using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using Microsoft.Reporting.NETCore;
using System.Data;
using System.Diagnostics;

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
            // Ocultar la columna id_nota, Nota y total_posible para que el usuario no la vea
            if (dgvNotas.Columns.Contains("id_nota"))
            {
                dgvNotas.Columns["id_nota"].Visible = false;
            }
            if (dgvNotas.Columns.Contains("Nota"))
                dgvNotas.Columns["Nota"].Visible = false;

            if (dgvNotas.Columns.Contains("total_posible"))
                dgvNotas.Columns["total_posible"].Visible = false;

            // Renombrar la columna NotaTexto (nota/total_posible) para que se vea como "Nota"
            if (dgvNotas.Columns.Contains("NotaTexto"))
                dgvNotas.Columns["NotaTexto"].HeaderText = "Nota";


        }

        private void Limpiar()
        {
            cbCategoriaG.SelectedIndex = -1;
            cmbMaterias.SelectedIndex = -1;
            numNota.Value = 0;
            numTotPosible.Value = 0;
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
                    total_posible = (int)numTotPosible.Value,
                    comentario = txtComentario.Text,
                    fecha_registro = DateTime.Now,
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
                total_posible = (int)numTotPosible.Value,
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

            cmbMaterias.SelectedIndex = cmbMaterias.FindStringExact(dgvNotas.Rows[e.RowIndex].Cells["Materia"].Value.ToString());
            cbCategoriaG.Text = dgvNotas.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
            numNota.Value = Convert.ToDecimal(dgvNotas.Rows[e.RowIndex].Cells["nota"].Value);
            numTotPosible.Value = Convert.ToInt32(dgvNotas.Rows[e.RowIndex].Cells["total_posible"].Value);
            txtComentario.Text = dgvNotas.Rows[e.RowIndex].Cells["comentario"].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Limpiar selección de filtros
            cmbFiltroMateria.SelectedIndex = -1;
            cmbFiltroCateg.SelectedIndex = -1;

            // Recargar todas las notas sin filtros
            CargarNotas("", "");

        }

        private void cmbFiltroMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoMateria = cmbFiltroMateria.SelectedValue?.ToString() ?? "";
            string idCategoria = cmbFiltroCateg.SelectedValue?.ToString() ?? "";

            // Filtrar notas en el DataGridView
            CargarNotas(codigoMateria, idCategoria);

            // Calcular promedio solo si hay materia seleccionada
            if (!string.IsNullOrEmpty(codigoMateria))
            {
                if (!string.IsNullOrEmpty(idCategoria))
                {
                    // Promedio de la categoría dentro de la materia
                    decimal promedio = cnNota.CalcularPromedioPorCategoria(codigoMateria, idCategoria, idUsuario);
                    lblPromedio.Text = $"Promedio de {cmbFiltroMateria.Text} ({cmbFiltroCateg.Text}): {promedio:0.00}";
                }
                else
                {
                    // Promedio general de la materia
                    decimal promedio = cnNota.CalcularPromedio(codigoMateria, idUsuario);
                    lblPromedio.Text = $"Promedio de {cmbFiltroMateria.Text}: {promedio:0.00}";
                }
                // PDF habilitado si hay datos
                btnPDFNotas.Enabled = dgvNotas.Rows.Count > 0;
            }
            else
            {
                // No hay materia → no se calcula promedio
                lblPromedio.Text = "Promedio calculado: -";
                // Si solo hay categoría → deshabilitar PDF
                if (!string.IsNullOrEmpty(idCategoria))
                    btnPDFNotas.Enabled = false;
                else
                    btnPDFNotas.Enabled = dgvNotas.Rows.Count > 0;

            }
        }

        private void cmbFiltroCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoMateria = cmbFiltroMateria.SelectedValue?.ToString() ?? "";
            string idCategoria = cmbFiltroCateg.SelectedValue?.ToString() ?? "";

            // Filtrar notas en el DataGridView
            CargarNotas(codigoMateria, idCategoria);

            // Calcular promedio solo si hay materia seleccionada
            if (!string.IsNullOrEmpty(codigoMateria))
            {
                if (!string.IsNullOrEmpty(idCategoria))
                {
                    // Promedio de la categoría dentro de la materia
                    decimal promedio = cnNota.CalcularPromedioPorCategoria(codigoMateria, idCategoria, idUsuario);
                    lblPromedio.Text = $"Promedio de {cmbFiltroMateria.Text} ({cmbFiltroCateg.Text}): {promedio:0.00}";
                }
                else
                {
                    // Promedio general de la materia
                    decimal promedio = cnNota.CalcularPromedio(codigoMateria, idUsuario);
                    lblPromedio.Text = $"Promedio de {cmbFiltroMateria.Text}: {promedio:0.00}";
                }
                // PDF habilitado si hay datos
                btnPDFNotas.Enabled = dgvNotas.Rows.Count > 0;
            }
            else
            {
                // Solo categoría o sin filtros → no se calcula promedio
                lblPromedio.Text = "Promedio calculado: -";
                // Si solo hay categoría → deshabilitar PDF
                if (!string.IsNullOrEmpty(idCategoria))
                    btnPDFNotas.Enabled = false;
                else
                    btnPDFNotas.Enabled = dgvNotas.Rows.Count > 0;

            }
        }
        private void btnPDFNotas_Click(object sender, EventArgs e)
        {
            string codigoMateria = cmbFiltroMateria.SelectedValue?.ToString() ?? "";
            string idCategoria = cmbFiltroCateg.SelectedValue?.ToString() ?? "";

            // Validación: debe haber materia seleccionada
            if (string.IsNullOrEmpty(codigoMateria))
            {
                MessageBox.Show("Debe seleccionar una materia para generar el reporte.");
                return;
            }

            // Obtener las notas filtradas directamente como DataTable
            DataTable dt = cnNota.ObtenerNotasVistaReportes(codigoMateria, idUsuario, idCategoria);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte.");
                return;
            }

            // Calcular el promedio según el escenario
            string promedioTexto = "-";
            if (!string.IsNullOrEmpty(codigoMateria))
            {
                if (!string.IsNullOrEmpty(idCategoria))
                {
                    decimal promedio = cnNota.CalcularPromedioPorCategoria(codigoMateria, idCategoria, idUsuario);
                    promedioTexto = promedio.ToString("0.00");
                }
                else
                {
                    decimal promedio = cnNota.CalcularPromedio(codigoMateria, idUsuario);
                    promedioTexto = promedio.ToString("0.00");
                }
            }

            try
            {
                LocalReport report = new LocalReport();
                string rutaRDLC = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportesNotas", "InformeNotas.rdlc");


                if (!File.Exists(rutaRDLC))
                {
                    MessageBox.Show("No se encontró el archivo RDLC en: " + rutaRDLC);
                    return;
                }

                report.ReportPath = rutaRDLC;
                report.DataSources.Add(new ReportDataSource("DataSet1", dt));

                // Parámetros del reporte
                string subtitulo = !string.IsNullOrEmpty(idCategoria)
                    ? $"Notas de {cmbFiltroMateria.Text} ({cmbFiltroCateg.Text})"
                    : $"Notas de {cmbFiltroMateria.Text}";

                ReportParameter[] parametros = new ReportParameter[]
                {
                    new ReportParameter("SubtituloReporte", subtitulo),
                    new ReportParameter("PromedioReporte", promedioTexto)
                };

                report.SetParameters(parametros);

                // Renderizar como PDF
                byte[] pdfBytes = report.Render("PDF");

                string rutaPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "InformeNotas.pdf");
                File.WriteAllBytes(rutaPDF, pdfBytes);

                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true
                });

                MessageBox.Show("PDF generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        private void btnVolverDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
