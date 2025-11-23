using CapaEntidad;
using CapaNegocio;
using CapasDatos;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbCodigo.Clear();
            txtbNombre.Clear();
            numCreditos.Value = 0;
            numLabs.Value = 0;
            numClases.Value = 0;
            cmbMaterias.SelectedIndex = -1;
        }

        private void btnRegisMat_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtbCodigo.Text))
            {
                MessageBox.Show("Ingrese el código de la materia.");
                txtbCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la materia.");
                txtbNombre.Focus();
                return;
            }

            CEMateria cEMateria = new CEMateria()
            {
                codigo_materia = txtbCodigo.Text.Trim(),
                nombre_materia = txtbNombre.Text.Trim(),
                Creditos = (int)numCreditos.Value,
                // Corregido: Clases -> horas_teoricas ; Labs -> horas_practicas
                horas_teoricas = (int)numClases.Value,
                horas_practicas = (int)numLabs.Value
            };

            CNMateria cNMateria = new CNMateria();
            try
            {
                cNMateria.CrearMateria(cEMateria);
                MessageBox.Show("Materia creada exitosamente.");
                // Opcional: refrescar combo para ver la nueva materia
                CargarMateriasEnComboDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear materia: " + ex.Message);
            }
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            CargarMateriasEnComboDataTable();
        }

        private void CargarMateriasEnComboDataTable()
        {
            CNMateria cNMateria = new CNMateria();
            var dt = cNMateria.ObtenerMateriasDataTable();
            if (dt == null || dt.Rows.Count == 0)
            {
                cmbMaterias.DataSource = null;
                return;
            }

            // Evitar que SelectedIndexChanged se dispare durante el DataSource assignment
            cmbMaterias.SelectedIndexChanged -= cmbMaterias_SelectedIndexChanged;

            cmbMaterias.DisplayMember = "nombre_materia";
            cmbMaterias.ValueMember = "codigo_materia";
            cmbMaterias.DataSource = dt;
            cmbMaterias.SelectedIndex = -1;

            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedValue != null)
            {
                string codigo = cmbMaterias.SelectedValue.ToString();
                MessageBox.Show("Código materia seleccionado: " + codigo);
            }
        }

        // Evento SelectedIndexChanged
        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Protecciones adicionales
            if (cmbMaterias.SelectedItem == null || cmbMaterias.SelectedIndex <= -1) return;

            DataRowView drv = cmbMaterias.SelectedItem as DataRowView;
            if (drv == null) return;

            txtbCodigo.Text = drv["codigo_materia"]?.ToString() ?? "";
            txtbNombre.Text = drv["nombre_materia"]?.ToString() ?? "";

            // creditos
            if (int.TryParse(drv["creditos"]?.ToString(), out int cred))
                numCreditos.Value = Math.Min(Math.Max(cred, (int)numCreditos.Minimum), (int)numCreditos.Maximum);
            else
                numCreditos.Value = numCreditos.Minimum;

            // horas_practicas => numLabs
            if (int.TryParse(drv["horas_practicas"]?.ToString(), out int hpr))
                numLabs.Value = Math.Min(Math.Max(hpr, (int)numLabs.Minimum), (int)numLabs.Maximum);
            else
                numLabs.Value = numLabs.Minimum;

            // horas_teoricas => numClases
            if (int.TryParse(drv["horas_teoricas"]?.ToString(), out int hte))
                numClases.Value = Math.Min(Math.Max(hte, (int)numClases.Minimum), (int)numClases.Maximum);
            else
                numClases.Value = numClases.Minimum;
        }

        private void btnElimMat_Click(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una materia para eliminar.");
                return;
            }

            string codigo = cmbMaterias.SelectedValue.ToString();

            var confirm = MessageBox.Show("¿Seguro que deseas eliminar esta materia?",
                                          "Confirmación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            CNMateria cn = new CNMateria();

            if (cn.EliminarMateria(codigo))
            {
                MessageBox.Show("Materia eliminada correctamente.");
                CargarMateriasEnComboDataTable();
                btnLimpiar_Click(null, null); // Limpia los campos
            }
            else
            {
                MessageBox.Show("Error al eliminar la materia.");
            }
        }

        private void btnEditMat_Click(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una materia primero.");
                return;
            }

            CEMateria materia = new CEMateria()
            {
                codigo_materia = txtbCodigo.Text,
                nombre_materia = txtbNombre.Text,
                Creditos = (int)numCreditos.Value,
                horas_teoricas = (int)numClases.Value,
                horas_practicas = (int)numLabs.Value
            };

            CNMateria cn = new CNMateria();

            if (cn.EditarMateria(materia))
            {
                MessageBox.Show("Materia editada correctamente.");
                CargarMateriasEnComboDataTable();
            }
            else
            {
                MessageBox.Show("Error al editar la materia.");
            }
        }

        private void btnVolverDashboard_Click(object sender, EventArgs e)
        {
            this.Close(); // esto hará que ShowDialog() termine y el Dashboard reaparezca

        }
    }
}
