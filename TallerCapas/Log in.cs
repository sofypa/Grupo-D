using CapaPresentacion;

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

    }
}

