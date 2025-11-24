using CapaEntidad;
using CapasDatos;
using System.Data;
using System.Drawing.Drawing2D;

namespace CapasNegocio
{
    public class CNMateria
    {
        private CDMateria datos = new CDMateria();

        public bool Validar(Materia m)
        {
            if (string.IsNullOrWhiteSpace(m.CodigoMateria) || m.CodigoMateria.Length != 4)
            {
                MessageBox.Show("El código debe tener 4 dígitos.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(m.NombreMateria))
            {
                MessageBox.Show("El nombre de la materia es obligatorio.");
                return false;
            }
            if (m.Creditos <= 0)
            {
                MessageBox.Show("Los créditos deben ser mayores a 0.");
                return false;
            }
            return true;
        }

        public void CrearMateria(Materia m)
        {
            datos.InsertarMateria(m);
        }

        public DataTable ObtenerMaterias()
        {
            return datos.ObtenerMateriasCompleto();
        }
    }
}
