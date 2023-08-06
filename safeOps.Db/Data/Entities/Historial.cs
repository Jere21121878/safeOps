using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Historial


    {
    
        [Required]
        public int Id { get; set; }
        public string AccidentesPropios { get; set; }

        public string AccidentesMaquinaria { get; set; }

        public string AccidentesQuimicos { get; set; }

        public string AccidentesGeneral { get; set; }
        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }

    }
}
