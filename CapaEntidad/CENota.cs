using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CENota
    {
        public int IdNota { get; set; } // opcional si lo manejas como autoincremental
        public string IdUsuario { get; set; }
        public string CodigoMateria { get; set; }
        public string IdCategoria { get; set; }
        public decimal Calificacion { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public string Comentario { get; set; }
    }
}
