using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDCategoria
    {
        string CadenaConexion = @"Server=tcp:hpa3calcnotas.database.windows.net,1433;Initial Catalog=ProyectoNotasBD;Persist Security Info=False;User ID=calcadmin;Password=Calculadora123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public void InsertarCategoria(CECategoria c)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "INSERT INTO categoria (id_categoria, codigo_materia, nombre_categoria, ponderacion) " +
                               "VALUES (@id_categoria, @codigo_materia, @nombre_categoria, @ponderacion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_categoria", c.IdCategoria);
                cmd.Parameters.AddWithValue("@codigo_materia", c.CodigoMateria);
                cmd.Parameters.AddWithValue("@nombre_categoria", c.NombreCategoria);
                cmd.Parameters.AddWithValue("@ponderacion", c.Ponderacion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerCategoriasPorMateria(string codigoMateria)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM categoria WHERE codigo_materia = @codigo";

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

        public void ActualizarCategoria(CECategoria c)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "UPDATE categoria SET nombre_categoria=@nombre, ponderacion=@ponderacion " +
                               "WHERE id_categoria=@id AND codigo_materia=@codigo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", c.IdCategoria);
                cmd.Parameters.AddWithValue("@codigo", c.CodigoMateria);
                cmd.Parameters.AddWithValue("@nombre", c.NombreCategoria);
                cmd.Parameters.AddWithValue("@ponderacion", c.Ponderacion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCategoria(string idCategoria, string codigoMateria)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "DELETE FROM categoria WHERE id_categoria=@id AND codigo_materia=@codigo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCategoria);
                cmd.Parameters.AddWithValue("@codigo", codigoMateria);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<string> ObtenerNombresCategoriasUnicos()
        {
            List<string> nombres = new List<string>();
            string query = "SELECT DISTINCT nombre_categoria FROM categoria";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombres.Add(reader["nombre_categoria"].ToString());
                    }
                }
            }

            return nombres;
        }
        public DataTable ObtenerCatalogoCategorias()
        {
            var tabla = new DataTable();
            const string query = "SELECT DISTINCT id_categoria, nombre_categoria FROM categoria";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabla);
            }
            return tabla;
        }
        public bool ExisteCategoria(string idCategoria, string codigoMateria)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "SELECT COUNT(*) FROM categoria WHERE id_categoria=@id AND codigo_materia=@codigo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCategoria);
                cmd.Parameters.AddWithValue("@codigo", codigoMateria);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

}