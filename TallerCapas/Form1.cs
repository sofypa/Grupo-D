using CapasNegocio;

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
            CNMateria cnMateria = new CNMateria();
            lbMaterias.DataSource = cnMateria.ObtenerMaterias();
            lbMaterias.DisplayMember = "nombre_materia";
            lbMaterias.ValueMember = "codigo_materia";
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
            txtbCodigo.Text = "";
            txtbNombre.Text = "";
            txtbCreditos.Text = "0";
            txtbClases.Text = "0";
            txtbLabs.Text = "0";
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
            if (dgvActivo == null || dgvActivo.CurrentRow == null) return;

            DataGridViewRow row = dgvActivo.CurrentRow;

            if (dgvActivo == dgvPonderacion)
            {
                row.Cells[2].Value = txtbCategoria.Text;
                row.Cells[3].Value = txtbPonderacion.Text;
            }
            else if (dgvActivo == dgvNotas)
            {
                row.Cells[2].Value = cbCategoria.SelectedValue.ToString();
                row.Cells[3].Value = txtbNota.Text;
                row.Cells[4].Value = "Comentario actualizado";
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (dgvActivo == null)
            {
                MessageBox.Show("Selecciona una tabla para añadir datos.");
                return;
            }

            if (dgvActivo == dgvPonderacion)
            {
                // Añadir categoría de evaluación
                dgvPonderacion.Rows.Add(
                    "C" + new Random().Next(1000, 9999).ToString(), // ID automático
                    lbMaterias.SelectedValue.ToString(),           // Código de materia
                    txtbCategoria.Text,                             // Nombre de categoría
                    txtbPonderacion.Text                            // Ponderación
                );
            }
            else if (dgvActivo == dgvNotas)
            {
                // Añadir nota
                dgvNotas.Rows.Add(
                    "08-0998-2090",                                 // ID de usuario (puedes usar ComboBox)
                    lbMaterias.SelectedValue.ToString(),           // Código de materia
                    cbCategoria.SelectedValue.ToString(),          // ID de categoría
                    txtbNota.Text,                                  // Calificación
                    "Comentario opcional"                           // Comentario
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvActivo == null || dgvActivo.CurrentRow == null) return;

            dgvActivo.Rows.Remove(dgvActivo.CurrentRow);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Materia m = new Materia
            {
                CodigoMateria = txtbCodigo.Text,
                NombreMateria = txtbNombre.Text,
                Creditos = int.Parse(txtbCreditos.Text),
                HorasTeoricas = int.Parse(txtbClases.Text),
                HorasPracticas = int.Parse(txtbLabs.Text)
            };

            CNMateria cnMateria = new CNMateria();
            if (!cnMateria.Validar(m)) return;
            cnMateria.CrearMateria(m);

            // Guardar categorías
            CNCategoria cnCategoria = new CNCategoria();
            foreach (DataGridViewRow row in dgvPonderacion.Rows)
            {
                if (row.IsNewRow) continue;

                Categoria c = new Categoria
                {
                    IdCategoria = row.Cells[0].Value.ToString(),
                    CodigoMateria = row.Cells[1].Value.ToString(),
                    NombreCategoria = row.Cells[2].Value.ToString(),
                    Ponderacion = Convert.ToDecimal(row.Cells[3].Value)
                };

                if (!cnCategoria.Validar(c)) continue;
                cnCategoria.CrearCategoria(c);
            }

            // Guardar notas
            CNNota cnNota = new CNNota();
            foreach (DataGridViewRow row in dgvNotas.Rows)
            {
                if (row.IsNewRow) continue;

                Nota n = new Nota
                {
                    IdUsuario = row.Cells[0].Value.ToString(),
                    CodigoMateria = row.Cells[1].Value.ToString(),
                    IdCategoria = row.Cells[2].Value.ToString(),
                    Calificacion = Convert.ToDecimal(row.Cells[3].Value),
                    Comentario = row.Cells[4].Value?.ToString()
                };

                if (!cnNota.Validar(n)) continue;
                cnNota.CrearNota(n);
            }

            MessageBox.Show("Todos los datos fueron guardados correctamente.");
        }
    }
}
