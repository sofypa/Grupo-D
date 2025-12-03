using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapasDatos
{
    public class CDResumenAcadémico
    {
        string CadenaConexion = @"Server=tcp:hpa3calcnotas.database.windows.net,1433;Initial Catalog=ProyectoNotasBD;Persist Security Info=False;User ID=calcadmin;Password=Calculadora123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Método que devuelve el resumen por materia desde la vista_dashboard
        public List<CEResumenAcadémico> ObtenerResumenPorMateria()
        {
            var lista = new List<CEResumenAcadémico>();
            string query = "SELECT Materia, EvaluacionesRegistradas, NotaFinalPreliminar FROM vista_dashboard";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new CEResumenAcadémico
                    {
                        Materia = dr["Materia"].ToString(),
                        EvaluacionesRegistradas = Convert.ToInt32(dr["EvaluacionesRegistradas"]),
                        Promedio = Convert.ToDecimal(dr["NotaFinalPreliminar"])
                    });
                }
            }

            return lista;
        }
    }
}