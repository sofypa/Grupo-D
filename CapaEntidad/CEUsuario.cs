using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuario
    {
        public string id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string clave_hash { get; set; }
    }
}

