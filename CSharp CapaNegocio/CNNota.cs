using CapaEntidad;
using CapasDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CNNota
    {
        private CNNota cDNota = new CNNota();

        public bool validar(CENota Nota)
        {
            if (Nota.Calificacion == null)
            {
                MessageBox.Show("La nota es nula.");
                return false;
            }

            bool validado = true;

            if (string.IsNullOrWhiteSpace(Nota.IdUsuario))
            {
                MessageBox.Show("El campo IdUsuario es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(Nota.CodigoMateria))
            {
                MessageBox.Show("El campo CodigoMateria es obligatorio.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(Nota.IdCategoria))
            {
                MessageBox.Show("El campo IdCategoria es obligatorio.");
                validado = false;
            }

            // Ejemplo: validar rango válido para calificación
            if (Nota.Calificacion < 0m || Nota.Calificacion > 100m)
            {
                MessageBox.Show("La calificación debe estar entre 0 y 100.");
                validado = false;
            }

            return validado;
        }
    }
}