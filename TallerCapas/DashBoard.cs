using CapaEntidad;
using CapaNegocio;
using CapaPresentacion;
using System.Data;

namespace TallerCapas
{
    public partial class DashBoard : Form
    {
        CNDashboard cnDashboard = new CNDashboard();

        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Si quieres que Materia sea modal (no se puede interactuar con Dashboard mientras)
            this.Hide();
            using (var frm = new Materia())
            {
                frm.ShowDialog();
            }
            this.Show();
        }


        bool datosCargados = false;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Obtener los grupos desde la base de datos



            // Llenar el DataGridView con todos los datos
            dgvDashboard.DataSource = cnDashboard.ObtenerDatosDashboard();
            dgvDashboard.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


            datosCargados = true;
        }


        
        private void button5_Click(object sender, EventArgs e)
        {
            Proyecto.Form1 ventana = new Proyecto.Form1();
            ventana.Show();
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvDashboard.DataSource = cnDashboard.ObtenerDatosDashboard();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CategoriasEvaluacion ventana = new CategoriasEvaluacion();
            ventana.Show();
            this.Hide();
        }
    }
}

