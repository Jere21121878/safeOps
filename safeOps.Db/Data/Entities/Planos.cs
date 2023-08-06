using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public  class Planos
    {
        [Required]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }

    }
}
