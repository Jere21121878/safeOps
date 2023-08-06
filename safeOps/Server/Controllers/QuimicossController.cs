using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    public class QuimicossController
    {

        [ApiController]
        [Route("api/ProductosQuimicos")]
        public class QumicossController : ControllerBase
        {
            private readonly DaBaContext context;

            public QumicossController(DaBaContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Quimicos>>> Get()
            {
                return await context.Quimicoss.ToListAsync();
            }
            [HttpGet("{NumeroOnu:int}")]
            public async Task<ActionResult<Quimicos>> Get(int numeroOnu)
            {
                var quimicos = await context.Quimicoss
                                             .Where(e => e.NumeroOnu == numeroOnu)

                                             .FirstOrDefaultAsync();
                if (quimicos == null)
                {
                    return NotFound($"No existe el producto con el numero de onu= {numeroOnu}");
                }
                return quimicos;
            }

            [HttpGet("{CAS:int}")]
            public async Task<ActionResult<Quimicos>> GetCas(int cas)
            {
                var quimicos = await context.Quimicoss
                                             .Where(e => e.CAS == cas)

                                             .FirstOrDefaultAsync();
                if (quimicos == null)
                {
                    return NotFound($"No existe el producto con la CAS= {cas}");
                }
                return quimicos;
            }


            [HttpGet("ProductosQuimicosPorNombre/{nombre}")]
            public async Task<ActionResult<Quimicos>> ProductosQuimicosPorNombre(string nombre)
            {
                var quimicos = await context.Quimicoss
                                         .Where(e => e.Nombre == nombre)
                                         .FirstOrDefaultAsync();
                if (quimicos == null)
                {
                    return NotFound($"No existe el producto quimico con el nombre ={nombre}");
                }
                return quimicos;
            }


        }

    }
}
