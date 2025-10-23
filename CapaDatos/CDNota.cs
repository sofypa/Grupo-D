using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapasDatos
{
    public class CDNota
    {
        string CadenaConexion = "Server=POWELLSITO-PC\\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

        public void InsertarNota(CENota n)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "INSERT INTO nota (grupo, calificacion) " +
                               "VALUES (@grupo, @calificacion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@grupo", n.grupo);
                cmd.Parameters.AddWithValue("@calificacion", n.calificacion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerNotasPorMateria(string codigoMateria)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM nota WHERE codigo_materia = @codigo";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@codigo", codigoMateria);
                conn.Open();
                da.Fill(tabla);
            }

            return tabla;
        }

    }
}
