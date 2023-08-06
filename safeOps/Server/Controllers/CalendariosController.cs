using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    public class CalendariosController
    {
        [ApiController]
        [Route("api/Calendario")]
        public class Calendarios : ControllerBase
        {
            private readonly DaBaContext context;

            public Calendarios(DaBaContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Calendario>>> Get()
            {
                return await context.Calendarios.ToListAsync();
            }


            [HttpGet("{id:int}")]
            public async Task<ActionResult<Calendario>> Get(int id)
            {
                var calendario = await context.Calendarios
                                             .Where(e => e.LicenciadoId == id)

                                             .FirstOrDefaultAsync();
                if (calendario == null)
                {
                    return NotFound($"No existe el calendario con la  Id= {id}");
                }
                return calendario;
            }


            

    }

    }
}
