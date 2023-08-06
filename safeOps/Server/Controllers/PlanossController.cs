using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    public class PlanossController
    {

        [ApiController]
        [Route("api/Planos")]
        public class Planoss : ControllerBase
        {
            private readonly DaBaContext context;

            public Planoss(DaBaContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Planos>>> Get()
            {
                return await context.Planoss.ToListAsync();
            }


            [HttpGet("{id:int}")]
            public async Task<ActionResult<Planos>> Get(int id)
            {
                var planos = await context.Planoss
                                             .Where(e => e.IdEmpresa == id)

                                             .FirstOrDefaultAsync();
                if (planos == null)
                {
                    return NotFound($"No existe los planos  con la  Id= {id}");
                }
                return planos;
            }





        }
    }
}
