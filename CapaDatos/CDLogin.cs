// CDLogin.cs (fragmento corregido)
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace CapaDatos
{
    public class CDLogin
    {
        private readonly string CadenaConexion = @"Server=POWELLSITO-PC\SQLEXPRESS;Database=ProyectoNotasBD;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool ValidarCredenciales(string email, string passwordPlana)
        {
            // Validaciones rápidas
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(passwordPlana))
                return false;

            string correoNormalized = email.Trim().ToLowerInvariant();
            const string sql = "SELECT clave_hash FROM usuario WHERE LOWER(correo_usuario) = @correo";

            try
            {
                using (SqlConnection cn = new SqlConnection(CadenaConexion))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // Parámetro con tipo/tamaño explícito
                    cmd.Parameters.Add("@correo", SqlDbType.NVarChar, 255).Value = correoNormalized;

                    cn.Open();

                    var result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return false; // correo no existe

                    // Normalizar el hash (quitar saltos de línea o espacios extra)
                    string dbHashRaw = result.ToString();
                    string dbHash = dbHashRaw.Replace("\r", "").Replace("\n", "").Trim();

                    // Verificar con BCrypt
                    bool verifica = BCrypt.Net.BCrypt.Verify(passwordPlana, dbHash);
                    return verifica;
                }
            }
            catch (Exception ex)
            {
                // Log del error (Trace) — evita mostrar MessageBox en la capa de datos
                Trace.TraceError($"Error en ValidarCredenciales: {ex}");
                return false;
            }
        }

        // Método auxiliar para crear usuario con password hasheada (ej. Sign_up)
        public bool CrearUsuario(string idUsuario, string nombreUsuario, string correo, string passwordPlana)
        {
            try
            {
                // Genera hash BCrypt (asegúrate de tener BCrypt.Net-Next instalado)
                string hash = BCrypt.Net.BCrypt.HashPassword(passwordPlana);

                const string sql = @"INSERT INTO usuario (id_usuario, nombre_usuario, correo_usuario, clave_hash)
                                     VALUES (@id, @nombre, @correo, @hash)";

                using (SqlConnection cn = new SqlConnection(CadenaConexion))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario.Trim());
                    cmd.Parameters.AddWithValue("@nombre", nombreUsuario.Trim());
                    cmd.Parameters.AddWithValue("@correo", correo.Trim());
                    cmd.Parameters.AddWithValue("@hash", hash);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // Mostrar mensaje para debug; en producción usa logger
                System.Windows.Forms.MessageBox.Show("Error SQL al crear usuario: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al crear usuario: " + ex.Message);
                return false;
            }
        }

    }
}
