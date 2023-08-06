using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using safeOps.Db.Data;
using safeOps.Db.Data.Entities;

namespace safeOps.Server.Controllers
{
    [ApiController]
    [Route("api/Empleadors")]
    public class EmpleadorsController : ControllerBase
    {
        private readonly DaBaContext context;

        public EmpleadorsController(DaBaContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleador>>> Get() 
        {
         return await context.Empleadors.ToListAsync();
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Empleador>> Get(int id)
        {
            var empleador = await context.Empleadors
                                         .Where(e => e.Id == id)
                                         
                                         .FirstOrDefaultAsync();
            if (empleador == null)
            {
                return NotFound($"No existe el Empleador con la  Id= {id}");
            }
            return empleador;
        }


        [HttpGet("EmpleadorPorNombre/{nombre}")]
        public async Task<ActionResult<Empleador>> EmpleadorPorNombre(string nombre)
        {
            var empleador = await context.Empleadors
                                     .Where(e => e.Nombre == nombre)
                                     .FirstOrDefaultAsync();
            if (empleador == null)
            {
                return NotFound($"No existe el empleador de nombre ={nombre}");
            }
            return empleador;
        }


    }
}
