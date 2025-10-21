using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;


namespace CapasDatos
{
    public class CDMateria
    {
        string CadenaConexion = @"Server=ANGRYBIRDROJO\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

        // Obtener todas las materias
        public DataTable ObtenerMaterias()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT codigo_materia, nombre_materia FROM materia";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabla);
            }

            return tabla;
        }
        //crear materia
        public void Crear(CEMateria cE)
        {
            using SqlConnection cn = new SqlConnection(CadenaConexion);
            try
            {
                cn.Open();

                string query = @"INSERT INTO materia
                            (codigo_materia, nombre_materia, creditos, horas_teoricas, horas_practicas)
                            VALUES (@codigo_materia, @nombre_materia, @creditos, @horas_teoricas, @horas_practicas)";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.CommandTimeout = 20;
                    cmd.CommandType = CommandType.Text;

                    // Parámetros
                    cmd.Parameters.AddWithValue("@codigo_materia", cE.codigo_materia);
                    cmd.Parameters.AddWithValue("@nombre_materia", cE.nombre_materia);
                    cmd.Parameters.AddWithValue("@creditos", cE.Creditos);
                    cmd.Parameters.AddWithValue("@horas_teoricas", cE.horas_teoricas);
                    cmd.Parameters.AddWithValue("@horas_practicas", cE.horas_practicas);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("El registro ha sido creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el registro: " + ex.Message);
            }
        }
    }
}
