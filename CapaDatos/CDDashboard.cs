using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapasDatos
{
    public class CDDashboard
    {
        string CadenaConexion = @"Server=POWELLSITO-PC\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

        // Obtener todos los registros de la vista_dashboard
        public DataTable ObtenerDatosDashboard()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM vista_dashboard";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabla);
            }

            return tabla;
        }

        // Obtener solo los grupos distintos para el ComboBox
        public DataTable ObtenerGrupos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT DISTINCT Grupo FROM vista_dashboard ORDER BY Grupo";

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

