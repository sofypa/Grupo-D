using Proyecto;


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
            TallerCapas.DashBoard ventana = new TallerCapas.DashBoard();
            ventana.Show();
            this.Hide();
        }
    }
}
