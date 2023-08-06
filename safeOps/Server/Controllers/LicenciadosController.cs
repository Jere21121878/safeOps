using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using safeOps.Db.Data;
using safeOps.Db.Data.Entities;

namespace safeOps.Server.Controllers
{

    [ApiController]
    [Route("api/Licenciados")]
    public class LicenciadosController : ControllerBase
    {
        private readonly DaBaContext context;

        public LicenciadosController(DaBaContext context)
        {
            this.context = context;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Licenciado>> Get(int id)
        {
            var licenciado = await context.Licenciados
                                         .Where(e => e.Id == id)

                                         .FirstOrDefaultAsync();
            if (licenciado == null)
            {
                return NotFound($"No existe el Licenciado con la  Id= {id}");
            }
            return licenciado;
        }
        [HttpGet("LicenciadoPorNombre/{nombre}")]
        public async Task<ActionResult<Licenciado>> LicenciadoPorNombre(string nombre)
        {
            var licenciado = await context.Licenciados
                                     .Where(e => e.Nombre == nombre)
                                     .FirstOrDefaultAsync();
            if (licenciado == null)
            {
                return NotFound($"No existe el licenciado de nombre ={nombre}");
            }
            return licenciado;
        }
        [HttpGet("LicenciadoPorApellido/{apellido}")]
        public async Task<ActionResult<Licenciado>> LicenciadoPorApellido(string apellido)
        {
            var licenciado = await context.Licenciados
                                     .Where(e => e.Apellido == apellido)
                                     .FirstOrDefaultAsync();
            if (licenciado == null)
            {
                return NotFound($"No existe el licenciado de apellido ={apellido}");
            }
            return licenciado;
        }
    }
}
