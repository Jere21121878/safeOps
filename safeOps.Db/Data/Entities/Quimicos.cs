using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Quimicos
    {
        [Required]
       
        [Key]
        public int NumeroOnu { get; set; }
        public string Mantenimiento { get; set; }
        public int CAS { get; set; }
        public string Uso { get; set; }

        public string Aplicacion { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
