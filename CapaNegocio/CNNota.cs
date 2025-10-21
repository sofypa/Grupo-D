using CapaEntidad;
using CapasDatos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CNNota
    {

        public bool validar(CENota Nota)
        {
            bool validado = true;
            if (Nota.Calificacion < 0 || Nota.Calificacion > 100)
            {
                MessageBox.Show("La nota tiene que estar de 0 - 100 aaaaaaaa");
                validado = false;
            }
            
            

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

            return validado;
        }
    }
}