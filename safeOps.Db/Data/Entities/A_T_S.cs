using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class A_T_S
    {
        [Required]
        public int Id { get; set; }

        public string Responsable { get; set; }

        public string Tarea { get; set;}

        public string Area { get; set; }

        public string Peligros { get; set; }

        public string Herramientas { get; set; }

        public string Proteccion { get; set; }

        public string Personal   { get; set; }

      
        public int IdTecnico { get; set; }

        public virtual Tecnico Tecnico { get; set; }
    }
}
