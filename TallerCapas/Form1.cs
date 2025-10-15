using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace TallerCapas
{
    public partial class Form1 : Form
    {
        CNDashboard cnDashboard = new CNDashboard();

        public Form1()
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

        }


        bool datosCargados = false;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Obtener los grupos desde la base de datos
            DataTable dtGrupos = cnDashboard.ObtenerGrupos();

            // Crear una fila extra al inicio que diga "- Seleccionar grupo -"
            DataRow filaExtra = dtGrupos.NewRow();
            filaExtra["Grupo"] = "- Seleccionar grupo -";
            dtGrupos.Rows.InsertAt(filaExtra, 0);

            // Asignar al ComboBox
            comboGrupo.DataSource = dtGrupos;
            comboGrupo.DisplayMember = "Grupo";
            comboGrupo.ValueMember = "Grupo";

            // Llenar el DataGridView con todos los datos
            dgvDashboard.DataSource = cnDashboard.ObtenerDatosDashboard();
            dgvDashboard.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


            datosCargados = true;
        }


        private void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!datosCargados || comboGrupo.SelectedValue == null)
                return;

            string grupoSeleccionado = comboGrupo.SelectedValue.ToString();

            // Obtener todos los datos
            DataTable dt = cnDashboard.ObtenerDatosDashboard();
            DataView dv = dt.DefaultView;

            // Si el usuario escoge "- Seleccionar grupo -", mostramos todos
            if (grupoSeleccionado != "- Seleccionar grupo -")
            {
                dv.RowFilter = $"Grupo = '{grupoSeleccionado.Replace("'", "''")}'";
            }

            dgvDashboard.DataSource = dv;
        }

    }
}
