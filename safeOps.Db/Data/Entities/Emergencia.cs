using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Emergencia
    {
        [Required]
        public int Id { get; set; }

        public string Rol { get; set; }

        public int NumEmergencia { get; set; }

        public string Instrucciones { get; set; }
        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }


    }


}

