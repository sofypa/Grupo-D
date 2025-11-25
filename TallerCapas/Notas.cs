using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Notas : Form
    {
        CNNota cnNota = new CNNota();
        string idUsuario = "08-1234-5678"; // Usuario actual

        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            try
            {
                // ComboBox para agregar nota
                cmbMaterias.DataSource = cnNota.ObtenerMaterias();
                cmbMaterias.DisplayMember = "nombre_materia";
                cmbMaterias.ValueMember = "codigo_materia";
                cmbMaterias.SelectedIndex = -1;

                cbCategoriaG.DataSource = cnNota.ObtenerCategorias();
                cbCategoriaG.DisplayMember = "nombre_categoria";
                cbCategoriaG.ValueMember = "id_categoria";
                cbCategoriaG.SelectedIndex = -1;

                // ComboBox para filtrar
                cmbFiltroMateria.DataSource = cnNota.ObtenerMaterias();
                cmbFiltroMateria.DisplayMember = "nombre_materia";
                cmbFiltroMateria.ValueMember = "codigo_materia";
                cmbFiltroMateria.SelectedIndex = -1;

                cmbFiltroCateg.DataSource = cnNota.ObtenerCategorias();
                cmbFiltroCateg.DisplayMember = "nombre_categoria";
                cmbFiltroCateg.ValueMember = "id_categoria";
                cmbFiltroCateg.SelectedIndex = -1;

                // Cargar todas las notas inicialmente
                CargarNotas("", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void CargarNotas(string codigoMateria = "", string idCategoria = "")
        {
            // Llamar al método para obtener las notas filtradas
            dgvNotas.DataSource = cnNota.ObtenerNotasVista(codigoMateria, idUsuario, idCategoria);
            // Ocultar la columna id_nota para que el usuario no la vea
            if (dgvNotas.Columns.Contains("id_nota"))
            {
                dgvNotas.Columns["id_nota"].Visible = false;
            }

        }


        private void Limpiar()
        {
            cbCategoriaG.SelectedIndex = -1;
            cmbMaterias.SelectedIndex = -1;
            numNota.Value = 0;
            txtComentario.Text = "";
        }

        private void btnRegisMat_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que los campos no sean nulos ni vacíos
                if (cmbMaterias.SelectedValue == null || cbCategoriaG.SelectedValue == null || string.IsNullOrWhiteSpace(txtComentario.Text))
                {
                    MessageBox.Show("Seleccione materia, categoría y complete el comentario.");
                    return;
                }

                // Crear el objeto nota con los datos del formulario
                CENota nota = new CENota
                {
                    id_usuario = idUsuario,
                    codigo_materia = cmbMaterias.SelectedValue.ToString(),
                    id_categoria = cbCategoriaG.SelectedValue.ToString(),
                    calificacion = numNota.Value,
                    comentario = txtComentario.Text,
                    fecha_registro = DateTime.Now,
                    grupo = "A" // Asumí que esto está definido de alguna manera
                };

                // Llamar al método para agregar la nota
                bool result = cnNota.AgregarNota(nota);

                // Verificar si la inserción fue exitosa
                if (result)
                {
                    MessageBox.Show("Nota agregada correctamente.");
                    CargarNotas();  // Recargar las notas
                    Limpiar();  // Limpiar los campos
                }
                else
                {
                    MessageBox.Show("Error al agregar la nota.");
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier excepción y muestra el mensaje de error
                MessageBox.Show("Ocurrió un error al registrar la nota: " + ex.Message);
            }
        }

        private void btnEditMat_Click(object sender, EventArgs e)
        {
            if (dgvNotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una nota del listado.");
                return;
            }

            if (cbCategoriaG.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            int idNota = Convert.ToInt32(dgvNotas.CurrentRow.Cells["id_nota"].Value);

            CENota nota = new CENota
            {
                id_nota = idNota,
                id_categoria = cbCategoriaG.SelectedValue.ToString(),
                calificacion = numNota.Value,
                comentario = txtComentario.Text
            };

            if (cnNota.EditarNota(nota))
            {
                MessageBox.Show("Nota editada correctamente.");
                CargarNotas();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al editar la nota.");
            }
        }

        private void btnElimMat_Click(object sender, EventArgs e)
        {
            if (dgvNotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una nota para eliminar.");
                return;
            }

            int idNota = Convert.ToInt32(dgvNotas.CurrentRow.Cells["id_nota"].Value);

            if (cnNota.EliminarNota(idNota))
            {
                MessageBox.Show("Nota eliminada correctamente.");
                CargarNotas();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al eliminar la nota.");
            }
        }

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cbCategoriaG.Text = dgvNotas.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
            numNota.Value = Convert.ToDecimal(dgvNotas.Rows[e.RowIndex].Cells["nota"].Value);
            txtComentario.Text = dgvNotas.Rows[e.RowIndex].Cells["comentario"].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedValue == null) return;

            decimal promedio = cnNota.CalcularPromedio(cmbMaterias.SelectedValue.ToString(), idUsuario);
            MessageBox.Show("Promedio: " + promedio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados en los ComboBox de filtro
            string codigoMateria = cmbFiltroMateria.SelectedValue?.ToString() ?? "";
            string idCategoria = cmbFiltroCateg.SelectedValue?.ToString() ?? "";

            // Llamar al método para cargar las notas con los filtros
            CargarNotas(codigoMateria, idCategoria);
        }

        private void cmbFiltroMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoMateria = cmbFiltroMateria.SelectedValue?.ToString() ?? "";
            string idCategoria = cmbFiltroCateg.SelectedValue?.ToString() ?? "";
            CargarNotas(codigoMateria, idCategoria);
        }

        private void cmbFiltroCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoMateria = cmbFiltroMateria.SelectedValue?.ToString() ?? "";
            string idCategoria = cmbFiltroCateg.SelectedValue?.ToString() ?? "";
            CargarNotas(codigoMateria, idCategoria);
        }
    }
}
