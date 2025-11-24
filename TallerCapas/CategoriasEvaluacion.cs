using CapaEntidad;
using CapaNegocio;
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
        //  private string codigoMateria;

        public CategoriasEvaluacion()
        {
            InitializeComponent();
            // codigoMateria = codigoMateriaRecibido;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriasEvaluacion_Load(object sender, EventArgs e)
        {
            // Materias
            CNMateria logicaMateria = new CNMateria();
            DataTable materias = logicaMateria.ObtenerMaterias();
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "nombre_materia";
            cmbMateria.ValueMember = "codigo_materia";

            // Categorías (catálogo con id y nombre)
            CNCategoria logicaCategoria = new CNCategoria();
            DataTable catalogo = logicaCategoria.ObtenerCatalogoCategorias();

            cmbCat.DataSource = catalogo;
            cmbCat.DisplayMember = "nombre_categoria";  // lo que ves
            cmbCat.ValueMember = "id_categoria";        // el id real existente
            RefrescarCategorias();


        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (cmbCat.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una categoría válida.");
                return;
            }
            if (cmbMateria.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una materia válida.");
                return;
            }

            var nuevaCategoria = new CECategoria
            {
                IdCategoria = cmbCat.SelectedValue.ToString(),               // id existente desde BD
                CodigoMateria = cmbMateria.SelectedValue.ToString(),         // materia seleccionada
                NombreCategoria = ((DataRowView)cmbCat.SelectedItem)["nombre_categoria"].ToString(), // nombre mostrado
                Ponderacion = numPon.Value
            };

            CNCategoria logica = new CNCategoria();
            if (logica.Validar(nuevaCategoria))
            {
                if (logica.ExisteCategoria(nuevaCategoria.IdCategoria, nuevaCategoria.CodigoMateria))
                {
                    MessageBox.Show("Ya existe esta categoría para la materia seleccionada.");
                    return;
                }

                logica.CrearCategoria(nuevaCategoria);
                MessageBox.Show("Categoría añadida correctamente.");
                RefrescarCategorias();

                // Refrescar la grilla con la materia actual
                DataTable categorias = logica.ObtenerCategoriasPorMateria(nuevaCategoria.CodigoMateria);
                dgvCategorias.DataSource = categorias;

                // Mostrar solo nombre y ponderación
                if (dgvCategorias.Columns.Contains("id_categoria"))
                    dgvCategorias.Columns["id_categoria"].Visible = false;
                if (dgvCategorias.Columns.Contains("codigo_materia"))
                    dgvCategorias.Columns["codigo_materia"].Visible = false;

                dgvCategorias.Columns["nombre_categoria"].HeaderText = "Categoría";
                dgvCategorias.Columns["ponderacion"].HeaderText = "Ponderación";
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) return;

            string idCategoria = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            string codigoMateria = dgvCategorias.CurrentRow.Cells[1].Value.ToString();

            CNCategoria logica = new CNCategoria();
            logica.BorrarCategoria(idCategoria, codigoMateria);
            MessageBox.Show("Categoría eliminada.");
            RefrescarCategorias();

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
                RefrescarCategorias();
            }
            MessageBox.Show("Categoría actualizada.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) return;

            CECategoria c = new CECategoria
            {
                IdCategoria = dgvCategorias.CurrentRow.Cells["id_categoria"].Value.ToString(),   // id real
                CodigoMateria = cmbMateria.SelectedValue.ToString(),                             // materia
                NombreCategoria = cmbCat.Text,                                                   // nombre válido del catálogo
                Ponderacion = numPon.Value                                                       // ponderación
            };

            CNCategoria logica = new CNCategoria();
            if (logica.Validar(c))
            {
                logica.EditarCategoria(c);
                MessageBox.Show("Categoría actualizada.");
                RefrescarCategorias();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallerCapas.DashBoard ventana = new TallerCapas.DashBoard();
            ventana.Show();
            this.Hide();
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoMateria = cmbMateria.SelectedValue.ToString();

            CNCategoria logicaCategoria = new CNCategoria();
            DataTable categorias = logicaCategoria.ObtenerCategoriasPorMateria(codigoMateria);

            dgvCategorias.DataSource = categorias;

            // Ocultar columnas que no quieres mostrar
            if (dgvCategorias.Columns.Contains("id_categoria"))
                dgvCategorias.Columns["id_categoria"].Visible = false;

            if (dgvCategorias.Columns.Contains("codigo_materia"))
                dgvCategorias.Columns["codigo_materia"].Visible = false;

            // Renombrar encabezados si quieres
            dgvCategorias.Columns["nombre_categoria"].HeaderText = "Categoría";
            dgvCategorias.Columns["ponderacion"].HeaderText = "Ponderación";
        }
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null && !dgvCategorias.CurrentRow.IsNewRow)
            {
                // Selección del combo por texto o por id si lo tienes en la fila
                string nombre = dgvCategorias.CurrentRow.Cells["nombre_categoria"].Value?.ToString();
                decimal pon = 0;
                decimal.TryParse(dgvCategorias.CurrentRow.Cells["ponderacion"].Value?.ToString(), out pon);

                // Intentar encontrar por texto exacto
                int idx = cmbCat.FindStringExact(nombre ?? string.Empty);
                cmbCat.SelectedIndex = idx >= 0 ? idx : -1;

                numPon.Value = pon;
            }

        }
        private void RefrescarCategorias()
        {
            if (cmbMateria.SelectedValue == null) return;

            CNCategoria logica = new CNCategoria();
            DataTable categorias = logica.ObtenerCategoriasPorMateria(cmbMateria.SelectedValue.ToString());
            dgvCategorias.DataSource = categorias;

            // Ocultar columnas técnicas
            if (dgvCategorias.Columns.Contains("id_categoria"))
                dgvCategorias.Columns["id_categoria"].Visible = false;
            if (dgvCategorias.Columns.Contains("codigo_materia"))
                dgvCategorias.Columns["codigo_materia"].Visible = false;

            dgvCategorias.Columns["nombre_categoria"].HeaderText = "Categoría";
            dgvCategorias.Columns["ponderacion"].HeaderText = "Ponderación";
        }

    }
}
