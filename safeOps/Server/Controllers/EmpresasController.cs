using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    [ApiController]
    [Route("api/Empresas")]
    public class EmpresasController : ControllerBase
    {
        private readonly DaBaContext context;

        public EmpresasController(DaBaContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empresa>>> Get()
        {
            return await context.Empresas.ToListAsync();
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Empresa>> Get(int id)
        {
            var empresa = await context.Empresas
                                         .Where(e => e.Id == id)

                                         .FirstOrDefaultAsync();
            if (empresa == null)
            {
                return NotFound($"No existe la empresa con la  Id= {id}");
            }
            return empresa;
        }


        [HttpGet("EmpresaPorNombre/{nombre}")]
        public async Task<ActionResult<Empresa>> EmpresaPorNombre(string nombre)
        {
            var empresa = await context.Empresas
                                     .Where(e => e.Nombre == nombre)
                                     .FirstOrDefaultAsync();
            if (empresa == null)
            {
                return NotFound($"No existe la empresa de nombre ={nombre}");
            }
            return empresa;
        }


    }
}
