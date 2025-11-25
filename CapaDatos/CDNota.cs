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
                    int result = cmd.ExecuteNonQuery();  // Ejecutar la consulta

                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se insertó ninguna fila en la base de datos.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en InsertarNota: " + ex.Message);  // Mostrar el error específico
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
        public List<CENotaVista> ObtenerNotasVista(string codigoMateria, string idUsuario, string idCategoria)
        {
            List<CENotaVista> lista = new List<CENotaVista>();

            string sql = @"SELECT id_nota, Materia, Categoria, Nota, Comentario
               FROM vista_notas
               WHERE id_usuario = @usuario";

            if (!string.IsNullOrEmpty(codigoMateria))
                sql += " AND codigo_materia = @materia";   // ahora sí existe
            if (!string.IsNullOrEmpty(idCategoria))
                sql += " AND id_categoria = @categoria";   // ahora sí existe


            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                if (!string.IsNullOrEmpty(codigoMateria))
                    cmd.Parameters.AddWithValue("@materia", codigoMateria);
                if (!string.IsNullOrEmpty(idCategoria))
                    cmd.Parameters.AddWithValue("@categoria", idCategoria);

                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new CENotaVista
                        {
                            id_nota = Convert.ToInt32(dr["id_nota"]),
                            materia = dr["Materia"].ToString(),
                            categoria = dr["Categoria"].ToString(),
                            Nota = Convert.ToDecimal(dr["Nota"]),
                            comentario = dr["Comentario"].ToString()
                        });
                    }
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
