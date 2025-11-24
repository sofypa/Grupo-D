using CapaEntidad;
using CapasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CategoriasEvaluacion : Form
    {
        private string codigoMateria;

        public CategoriasEvaluacion()
        {
            InitializeComponent();
            codigoMateria = codigoMateriaRecibido;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriasEvaluacion_Load(object sender, EventArgs e)
        {
            txtIDMateria.Text = codigoMateria;

            dgvCategorias.Columns.Clear();
            dgvCategorias.Columns.Add("id_categoria", "ID Categoría");
            dgvCategorias.Columns.Add("codigo_materia", "ID Materia");
            dgvCategorias.Columns.Add("nombre_categoria", "Categoría");
            dgvCategorias.Columns.Add("ponderacion", "Ponderación");

            CNCategoria logica = new CNCategoria();
            dgvCategorias.DataSource = logica.ObtenerCategoriasPorMateria(codigoMateria);

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            dgvCategorias.Rows.Add(
                "C" + new Random().Next(1000, 9999).ToString(),
                txtIDMateria.Text,
                txtCat.Text,
                txtPon.Text
            );

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) return;

            string idCategoria = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            string codigoMateria = dgvCategorias.CurrentRow.Cells[1].Value.ToString();

            CNCategoria logica = new CNCategoria();
            logica.BorrarCategoria(idCategoria, codigoMateria);
            MessageBox.Show("Categoría eliminada.");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CNCategoria logica = new CNCategoria();

            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                if (row.IsNewRow) continue;

                CECategoria c = new CECategoria
                {
                    IdCategoria = row.Cells[0].Value.ToString(),
                    CodigoMateria = row.Cells[1].Value.ToString(),
                    NombreCategoria = row.Cells[2].Value.ToString(),
                    Ponderacion = Convert.ToDecimal(row.Cells[3].Value)
                };

                if (!logica.Validar(c)) continue;
                logica.CrearCategoria(c);
            }

            MessageBox.Show("Categorías guardadas correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) return;

            CECategoria c = new CECategoria
            {
                IdCategoria = dgvCategorias.CurrentRow.Cells[0].Value.ToString(),
                CodigoMateria = dgvCategorias.CurrentRow.Cells[1].Value.ToString(),
                NombreCategoria = txtCat.Text,
                Ponderacion = Convert.ToDecimal(txtPon.Text)
            };

            CNCategoria logica = new CNCategoria();
            logica.EditarCategoria(c);
            MessageBox.Show("Categoría actualizada.");

        }
    }
}
