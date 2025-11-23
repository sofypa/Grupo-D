using CapaDatos;

namespace CapaNegocio
{
    public class CNLogIn
    {
        private readonly CDLogin cd = new CDLogin();

        public bool ValidarCredenciales(string email, string password)
        {
            return cd.ValidarCredenciales(email, password);
        }

        // Firma corregida: recibimos idUsuario (cédula), nombre, correo y contraseña
        public bool CrearUsuario(string idUsuario, string nombre, string correo, string password)
        {
            return cd.CrearUsuario(idUsuario, nombre, correo, password);
        }
    }
}
