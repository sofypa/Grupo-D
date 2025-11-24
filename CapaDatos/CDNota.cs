using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CDNota
    {
        private readonly string CadenaConexion =
            @"Server=tcp:hpa3calcnotas.database.windows.net,1433;
                        Initial Catalog=ProyectoNotasBD;Persist Security Info=False;
                        User ID=calcadmin;
                        Password=Calculadora123;
                        MultipleActiveResultSets=False;Encrypt=True;
                        TrustServerCertificate=False;Connection Timeout=30;";

        // -------------------------------------------------------------
        // INSERTAR NOTA
        // -------------------------------------------------------------
        public bool InsertarNota(CENota n)
        {
            const string sql = @"
                INSERT INTO nota (id_usuario, codigo_materia, id_categoria, calificacion, comentario, fecha_registro, grupo)
                VALUES (@usuario, @materia, @categoria, @calificacion, @comentario, @fecha, @grupo)";

            try
            {
                using (SqlConnection cn = new SqlConnection(CadenaConexion))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", n.id_usuario);
                    cmd.Parameters.AddWithValue("@materia", n.codigo_materia);
                    cmd.Parameters.AddWithValue("@categoria", n.id_categoria);
                    cmd.Parameters.AddWithValue("@calificacion", n.calificacion);
                    cmd.Parameters.AddWithValue("@comentario", n.comentario ?? "");
                    cmd.Parameters.AddWithValue("@fecha", n.fecha_registro);
                    cmd.Parameters.AddWithValue("@grupo", n.grupo);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // -------------------------------------------------------------
        // EDITAR NOTA
        // -------------------------------------------------------------
        public bool EditarNota(CENota n)
        {
            const string sql = @"
                UPDATE nota SET
                    id_categoria = @categoria,
                    calificacion = @calificacion,
                    comentario = @comentario
                WHERE id_nota = @idNota";

            try
            {
                using (SqlConnection cn = new SqlConnection(CadenaConexion))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idNota", n.id_nota);
                    cmd.Parameters.AddWithValue("@categoria", n.id_categoria);
                    cmd.Parameters.AddWithValue("@calificacion", n.calificacion);
                    cmd.Parameters.AddWithValue("@comentario", n.comentario ?? "");

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // -------------------------------------------------------------
        // ELIMINAR NOTA
        // -------------------------------------------------------------
        public bool EliminarNota(int idNota)
        {
            const string sql = "DELETE FROM nota WHERE id_nota = @id";

            try
            {
                using (SqlConnection cn = new SqlConnection(CadenaConexion))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idNota);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }


        // -------------------------------------------------------------
        // OBTENER LISTA DE VISTA (CENotaVista)
        // -------------------------------------------------------------
        public List<CENotaVista> ObtenerNotasVista(string codigoMateria, string idUsuario)
        {
            List<CENotaVista> lista = new List<CENotaVista>();

            string sql = @"
                SELECT 
                    c.nombre_categoria AS Categoria,
                    n.calificacion AS Nota,
                    n.comentario AS Comentario
                FROM nota n
                INNER JOIN categoria c ON n.id_categoria = c.id_categoria
                WHERE n.codigo_materia = @materia AND n.id_usuario = @usuario
                ORDER BY c.nombre_categoria";

            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@materia", codigoMateria);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);

                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CENotaVista
                            {
                                categoria = dr["Categoria"].ToString(),
                                Nota = Convert.ToDecimal(dr["Nota"]),
                                comentario = dr["Comentario"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }

            return lista;
        }
        // -------------------------------------------------------------
        // PROMEDIO PONDERADO REAL
        // -------------------------------------------------------------
        public decimal ObtenerPromedioMateria(string codigoMateria, string idUsuario)
        {
            const string sql = @"
                SELECT 
                    SUM(n.calificacion * c.ponderacion / 100.0)
                FROM nota n
                JOIN categoria c 
                    ON n.id_categoria = c.id_categoria
                    AND n.codigo_materia = c.codigo_materia
                WHERE n.codigo_materia = @materia
                  AND n.id_usuario = @usuario";

            try
            {
                using SqlConnection cn = new SqlConnection(CadenaConexion);
                using SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@materia", codigoMateria);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);

                cn.Open();
                object result = cmd.ExecuteScalar();

                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
            catch
            {
                return 0;
            }
        }
    }
}
