using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapasDatos
{
    public class CDNota
    {
        string CadenaConexion = @"Server=LENOVOSOFIA\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

        public void InsertarNota(Nota n)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "INSERT INTO nota (id_usuario, codigo_materia, id_categoria, calificacion, comentario) " +
                               "VALUES (@usuario, @materia, @categoria, @calificacion, @comentario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", n.IdUsuario);
                cmd.Parameters.AddWithValue("@materia", n.CodigoMateria);
                cmd.Parameters.AddWithValue("@categoria", n.IdCategoria);
                cmd.Parameters.AddWithValue("@calificacion", n.Calificacion);
                cmd.Parameters.AddWithValue("@comentario", n.Comentario ?? "");

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
