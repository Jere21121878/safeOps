using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace safeOps.Db.Data.Entities
{
    public class Empresa
    {


        [Required]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public virtual List<Tecnico> Tecnicos { get; set; }

        
        public virtual Planos Planos { get; set; }
     
        public virtual Historial Historials { get; set; }
        
      
        public virtual Legal Legals { get; set; }
    
        public virtual Quimicos Quimicoss { get; set; }

        public virtual Maquinaria Maquinarias { get; set; }

        public virtual Emergencia Emergencias { get; set; }
        public int IdEmpleador { get; set; }

        public virtual Empleador Empleadors { get; set; }

        
    }
}


