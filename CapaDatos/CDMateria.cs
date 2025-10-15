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
    }
}
