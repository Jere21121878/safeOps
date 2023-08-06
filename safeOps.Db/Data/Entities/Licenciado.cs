using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Licenciado
    {
        [Required]
       
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int TCalzado { get; set; }

        public int TInferior { get; set; }

        public int TSuperior { get; set; }

        
        public int IdEmpleador { get; set; }

        public virtual Empleador Empleadors { get; set; }


        public virtual List<Tecnico> Tecnicos { get; set; }
        public virtual Calendario Calendarios { get; set; }

    }
}
