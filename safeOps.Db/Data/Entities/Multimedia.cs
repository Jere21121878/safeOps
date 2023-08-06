using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Multimedia
    {
        [Required]
        public int Id { get; set; }

       
        public int IdTecnico { get; set; }

        public virtual Tecnico Tecnico { get; set; }
    }
}
