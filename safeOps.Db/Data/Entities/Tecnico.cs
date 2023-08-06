using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace safeOps.Db.Data.Entities
{
   
    public class Tecnico
    {
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int TCalzado { get; set; }

        public int TInferior { get; set; }

        public int TSuperior { get; set; }

       
        public int IdEmpleador { get; set; }

        public virtual Empleador Empleador { get; set; }




        public int IdLicenciado { get; set; }

        public virtual Licenciado Licenciado { get; set; }


        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }

        public List<A_T_S> A_T_S { get; set; }

        public List<Multimedia> Multimedia { get; set; }

        
    }
}
