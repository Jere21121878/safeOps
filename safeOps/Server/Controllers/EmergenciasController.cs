using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    public class EmergenciasController
    {


        [ApiController]
        [Route("api/Emergencias")]
        public class Emergencias : ControllerBase
        {
            private readonly DaBaContext context;

            public Emergencias(DaBaContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Emergencia>>> Get()
            {
                return await context.Emergencias.ToListAsync();
            }


            [HttpGet("{id:int}")]
            public async Task<ActionResult<Emergencia>> Get(int id)
            {
                var emergencia = await context.Emergencias
                                             .Where(e => e.IdEmpresa == id)

                                             .FirstOrDefaultAsync();
                if (emergencia == null)
                {
                    return NotFound($"No existe la funcion emergencia con la  Id= {id}");
                }
                return emergencia;
            }





        }
    }
}
