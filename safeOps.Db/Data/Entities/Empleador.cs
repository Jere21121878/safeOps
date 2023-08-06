using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeOps.Db.Data.Entities
{
    public class Empleador
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public virtual List<Empresa> Empresas { get; set; }

        public virtual List<Tecnico> Tecnicos { get; set; }
        public virtual List<Licenciado> Licenciados { get; set; }

       
    }
}
