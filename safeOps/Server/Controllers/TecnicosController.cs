using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    [ApiController]
    [Route("api/Tecnicos")]
    public class TecnicosController : ControllerBase
    {
        private readonly DaBaContext context;

        public TecnicosController(DaBaContext context)
        {
            this.context = context;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Tecnico>> Get(int id)
        {
            var tecnico = await context.Tecnicos
                                         .Where(e => e.Id == id)

                                         .FirstOrDefaultAsync();
            if (tecnico == null)
            {
                return NotFound($"No existe el tecnico con la  Id= {id}");
            }
            return tecnico;
        }
        [HttpGet("TecnicoPorNombre/{nombre}")]
        public async Task<ActionResult<Tecnico>> TecnicoPorNombre(string nombre)
        {
            var tecnico = await context.Tecnicos
                                     .Where(e => e.Nombre == nombre)
                                     .FirstOrDefaultAsync();
            if (tecnico == null)
            {
                return NotFound($"No existe el tecnico de nombre ={nombre}");
            }
            return tecnico;
        }
        [HttpGet("TecnicoPorApellido/{apellido}")]
        public async Task<ActionResult<Tecnico>> TecnicoPorApellido(string apellido)
        {
            var tecnico = await context.Tecnicos
                                     .Where(e => e.Apellido == apellido)
                                     .FirstOrDefaultAsync();
            if (tecnico == null)
            {
                return NotFound($"No existe el tecnico de apellido ={apellido}");
            }
            return tecnico;
        }
    }
}
