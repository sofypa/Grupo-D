using CapaEntidad;
using CapasDatos;
using CapaNegocio;
using System;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaMateria_Click(object sender, EventArgs e)
        {
            txtbCodigo.Clear();
            txtbNombre.Clear();
            numCreditos.Value = 0;
            numLabs.Value = 0;
            numClases.Value = 0;
        }

        private void txtbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbCreditos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbLabs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbClases_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEMateria cEMateria = new CEMateria();
            cEMateria.codigo_materia = txtbCodigo.Text;
            cEMateria.nombre_materia = txtbNombre.Text;
            cEMateria.Creditos = (int)numCreditos.Value;
            cEMateria.horas_teoricas = (int)numLabs.Value;
            cEMateria.horas_practicas = (int)numClases.Value;  
            
            CNMateria cNMateria = new CNMateria();

            cNMateria.CrearMateria(cEMateria);
            MessageBox.Show("Materia creada exitosamente.");
        }

        private void dgvPonderaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbPondeacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnVolverDashboard_Click(object sender, EventArgs e)
        {
            TallerCapas.DashBoard ventana = new TallerCapas.DashBoard();
            ventana.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void calificacion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double Nota = (double)numNota.Value;
            if (Nota < 0 || Nota >100)
            {
                MessageBox.Show("la nota tiene que ser de 0-100");
                e.Cancel = true;
            }
        }
    }
}
