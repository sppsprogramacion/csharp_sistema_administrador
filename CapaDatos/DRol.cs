using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRol
    {
        public string id_rol { get; set; }
        public string rol { get; set; }

        public string sistema_id { get; set; }
        public DSistema sistema { get; set; }
    }
}
