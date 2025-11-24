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
        string CadenaConexion = @"Server=LENOVOSOFIA\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

        public void InsertarCategoria(CECategoria c)
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                string query = "INSERT INTO categoria (id_categoria, codigo_materia, nombre_categoria, ponderacion) " +
                               "VALUES (@id, @codigo, @nombre, @ponderacion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", c.IdCategoria);
                cmd.Parameters.AddWithValue("@codigo", c.CodigoMateria);
                cmd.Parameters.AddWithValue("@nombre", c.NombreCategoria);
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
    }

}
