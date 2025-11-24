using CapaEntidad;
using CapasDatos;
using System.Data;

namespace CapasNegocio
{
    public class CNNota
    {
        private CDNota datos = new CDNota();

        public bool Validar(Nota n)
        {
            if (string.IsNullOrWhiteSpace(n.IdUsuario))
            {
                MessageBox.Show("El usuario es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(n.IdCategoria))
            {
                MessageBox.Show("La categoría es obligatoria.");
                return false;
            }
            if (n.Calificacion < 0 || n.Calificacion > 100)
            {
                MessageBox.Show("La calificación debe estar entre 0 y 100.");
                return false;
            }
            return true;
        }

        public void CrearNota(Nota n)
        {
            datos.InsertarNota(n);
        }

        public DataTable ObtenerNotasPorMateria(string codigoMateria)
        {
            return datos.ObtenerNotasPorMateria(codigoMateria);
        }
    }
}
