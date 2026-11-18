using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuarioRol
    {

        public int id_usuario_rol { get; set; }
        public int usuario_id { get; set; }
        public DUsuario usuario { get; set; }
        public string rol_id { get; set; }
        public DRol rol { get; set; }
        public string observaciones { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime? fecha_baja { get; set; }
        public bool activo { get; set; }

    }
}
