using CapaNegocio;
using Proyecto;
using System.Text.RegularExpressions;


namespace CapaPresentacion
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botonSignup_Click(object sender, EventArgs e)
        {
            // Leer controles (ajusta los nombres si tus controles son distintos)
            string idUsuario = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(idUsuario))
            {
                MessageBox.Show("Ingrese la cédula / id de usuario.");
                txtCedula.Focus();
                return;
            }

            // Validación del formato del id segun tu CHECK (acepta 1-2 dígitos - 3-4 dígitos - 4 dígitos)
            // Ejemplos válidos: 8-123-4567  |  08-0998-2090  |  2-1234-5678
            var regexId = new System.Text.RegularExpressions.Regex(@"^\d{1,2}-\d{3,4}-\d{4}$");
            if (!regexId.IsMatch(idUsuario))
            {
                MessageBox.Show("Formato de cédula inválido. Debe ser, por ejemplo: 08-0998-2090 o 8-123-4567.");
                txtCedula.Focus();
                return;
            }

            // Email
            if (!EsEmailValido(email))
            {
                MessageBox.Show("Email inválido.");
                txtEmail.Focus();
                return;
            }

            // Password mínimo
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                MessageBox.Show("Contraseña demasiado corta (mínimo 6 caracteres).");
                txtPassword.Focus();
                return;
            }

            try
            {
                CNLogIn cn = new CNLogIn();

                // Llamada CORRECTA: id, nombre, correo, password
                bool creado = cn.CrearUsuario(idUsuario, nombre, email, password);

                if (creado)
                {
                    MessageBox.Show("Usuario creado con éxito.");

                }
                else
                {
                    MessageBox.Show("Error al crear usuario. Revisa los datos y vuelve a intentar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message);
            }
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }
    }
}
