using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;


namespace CapasDatos
{
    public class CDMateria
    {
        string CadenaConexion = @"Server=LENOVOSOFIA\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

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

        public void InsertarMateria(Materia m)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "INSERT INTO materia (codigo_materia, nombre_materia, creditos, horas_teoricas, horas_practicas) " +
                               "VALUES (@codigo, @nombre, @creditos, @teoricas, @practicas)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", m.CodigoMateria);
                cmd.Parameters.AddWithValue("@nombre", m.NombreMateria);
                cmd.Parameters.AddWithValue("@creditos", m.Creditos);
                cmd.Parameters.AddWithValue("@teoricas", m.HorasTeoricas);
                cmd.Parameters.AddWithValue("@practicas", m.HorasPracticas);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerMateriasCompleto()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM materia";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabla);
            }

            return tabla;
        }

    }
}
