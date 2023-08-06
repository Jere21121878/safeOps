using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Calendario

    {
        [Required]
        public int Id { get; set; }

        
       

        public int Fecha { get; set; }

        public string Tarea { get; set; }

        public int LicenciadoId { get; set; }
        public virtual Licenciado Licenciados { get; set; }

    }
}
