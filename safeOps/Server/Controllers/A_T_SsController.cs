using Microsoft.AspNetCore.Mvc;
using safeOps.Db.Data.Entities;
using safeOps.Db.Data;
using Microsoft.EntityFrameworkCore;

namespace safeOps.Server.Controllers
{
    public class A_T_SsController
    {

        [ApiController]
        [Route("api/A_T_S")]
        public class A_T_Ss: ControllerBase
        {
            private readonly DaBaContext context;

            public A_T_Ss(DaBaContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<A_T_S>>> Get()
            {
                return await context.A_T_Ss.ToListAsync();
            }


            [HttpGet("{id:int}")]
            public async Task<ActionResult<A_T_S>> Get(int id)
            {
                var ats = await context.A_T_Ss
                                             .Where(e => e.Id == id)

                                             .FirstOrDefaultAsync();
                if (ats == null)
                {
                    return NotFound($"No existe La A.T.S con la  Id= {id}");
                }
                return ats;
            }


            [HttpGet("ATS_PorResponsable/{Responsable}")]
            public async Task<ActionResult<A_T_S>> ATS_PorResponsable(string responsable)
            {
                var ats = await context.A_T_Ss
                                         .Where(e => e.Responsable == responsable)
                                         .FirstOrDefaultAsync();
                if (ats == null)
                {
                    return NotFound($"No existe la A.T.S que tenga al responsable ={responsable}");
                }
                return ats;
            }
            [HttpGet("ATS_PorArea/{Area}")]
            public async Task<ActionResult<A_T_S>> ATS_PorArea(string area)
            {
                var ats = await context.A_T_Ss
                                         .Where(e => e.Area == area)
                                         .FirstOrDefaultAsync();
                if (ats == null)
                {
                    return NotFound($"No existe la A.T.S que tenga la area ={area}");
                }
                return ats;
            }
            [HttpGet("ATS_PorTecnicoId/{Id_Tecnico}")]
            public async Task<ActionResult<A_T_S>> ATS_TecnicoId(int id_tecnico)
            {
                var ats = await context.A_T_Ss
                                         .Where(e => e.IdTecnico == id_tecnico)
                                         .FirstOrDefaultAsync();
                if (ats == null)
                {
                    return NotFound($"No existe la A.T.S que tenga la area ={id_tecnico}");
                }
                return ats;
            }

        }
    }
}
