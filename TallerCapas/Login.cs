using CapaNegocio;
using CapaPresentacion;
using System.Text.RegularExpressions;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            Sign_up frm = new Sign_up();               // crea el formulario de destino
            frm.FormClosed += (s, args) => this.Show(); // muestra Form1 cuando se cierre Sign_up
            frm.Show();                                 // abre la otra pantalla
            this.Hide();
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (!EsEmailValido(email))
            {
                MessageBox.Show("Ingrese un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            CNLogIn cnUsuario = new CNLogIn();
            bool ok = cnUsuario.ValidarCredenciales(email, password);

            if (!ok)
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login exitoso
            TallerCapas.DashBoard ventana = new TallerCapas.DashBoard();
            ventana.Show();
            this.Hide();
        }
        // Validación simple de formato de correo
        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }

        private void btnPruebaBCrypt_Click(object sender, EventArgs e)
        {
            string hashKevin = "$2a$11$Ahucl6moXDoGO0IZTDp3a.e6iHHQe9HwaWwWycM2SL87RGrOe3gqi";
            string pwdPrueba = "PRUEBA"; // escribe exactamente la contraseña
            try
            {
                bool ok = BCrypt.Net.BCrypt.Verify(pwdPrueba, hashKevin);
                MessageBox.Show($"Prueba BCrypt.Verify('{pwdPrueba}', hashKevin) = {ok}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción BCrypt: " + ex.Message);
            }
        }
    }
}


