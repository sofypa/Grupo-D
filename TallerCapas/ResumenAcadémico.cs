using CapaEntidad;
using CapaNegocio;
using CapaPresentacion;
using System.Data;

namespace TallerCapas
{
    public partial class ResumenAcadémico : Form
    {
        CNResumenAcadémico cnDashboard = new CNResumenAcadémico();

        private readonly string _nombreUsuario; // campo para guardar el nombre

        // Constructor que recibe el nombre del usuario
        public ResumenAcadémico(string nombreUsuario)
        {
            InitializeComponent();
            _nombreUsuario = nombreUsuario;
        }
        private void ResumenAcadémico_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido(a), {(_nombreUsuario ?? "Estudiante")}";
            CargarResumenAcademico();
        }

        private void CargarResumenAcademico()
        {
            var listaResumen = cnDashboard.ObtenerResumenPorMateria();
            dgvDashboard.DataSource = listaResumen;
            dgvDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDashboard.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDashboard.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDashboard.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDashboard.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formato de columna Promedio
            if (dgvDashboard.Columns.Contains("Promedio"))
                dgvDashboard.Columns["Promedio"].DefaultCellStyle.Format = "N2";
            if (dgvDashboard.Columns.Contains("EvaluacionesRegistradas"))
                dgvDashboard.Columns["EvaluacionesRegistradas"].HeaderText = "Cant. Notas";

            // Advertencia
            var materiasBajas = listaResumen
                .Where(r => r.Promedio < 61.0m)
                .Select(r => r.Materia)
                .ToList();

            lblAdvertencia.Visible = materiasBajas.Any();
            lblAdvertencia.Text = materiasBajas.Any()
                ? "⚠️ Promedio bajo en:\n" + string.Join(", ", materiasBajas)
                : "";


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



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Proyecto.Form1 ventana = new Proyecto.Form1();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new Notas())
            {
                frm.ShowDialog();
            }
            this.Show();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new CategoriasEvaluacion(_nombreUsuario))
            {
                frm.ShowDialog();
            }
            this.Show();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CargarResumenAcademico(); // tu método que llena el DGV
        }
    }
}

