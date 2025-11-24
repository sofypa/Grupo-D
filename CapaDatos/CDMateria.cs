using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;


namespace CapasDatos
{
    public class CDMateria
    {
        string CadenaConexion = @"Server=tcp:hpa3calcnotas.database.windows.net,1433;Initial Catalog=ProyectoNotasBD;Persist Security Info=False;User ID=calcadmin;Password=Calculadora123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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
        //crear materia
        public void Crear(CEMateria cE)
        {
            using SqlConnection cn = new SqlConnection(CadenaConexion);
            try
            {
                cn.Open();

                string query = @"INSERT INTO materia
                            (codigo_materia, nombre_materia, creditos, horas_teoricas, horas_practicas)
                            VALUES (@codigo_materia, @nombre_materia, @creditos, @horas_teoricas, @horas_practicas)";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.CommandTimeout = 20;
                    cmd.CommandType = CommandType.Text;

                    // Parámetros
                    cmd.Parameters.AddWithValue("@codigo_materia", cE.codigo_materia);
                    cmd.Parameters.AddWithValue("@nombre_materia", cE.nombre_materia);
                    cmd.Parameters.AddWithValue("@creditos", cE.Creditos);
                    cmd.Parameters.AddWithValue("@horas_teoricas", cE.horas_teoricas);
                    cmd.Parameters.AddWithValue("@horas_practicas", cE.horas_practicas);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("El registro ha sido creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el registro: " + ex.Message);
            }
        }
       
        // obetener lista de materias
        public DataTable ListarMateriasDataTable()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand("SELECT codigo_materia, nombre_materia, creditos, horas_teoricas, horas_practicas FROM materia ORDER BY nombre_materia", cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // Manejo simple de errores: puedes loguear en lugar de MessageBox en capas inferiores
                    System.Windows.Forms.MessageBox.Show("Error al obtener materias: " + ex.Message);
                    return null;
                }
            }

            return dt;
        }
        //Editar materia
        public bool EditarMateria(CEMateria materia)
        {
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    string query = @"UPDATE materia SET 
                                nombre_materia = @nombre,
                                creditos = @creditos,
                                horas_teoricas = @hte,
                                horas_practicas = @hpr
                             WHERE codigo_materia = @codigo";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@codigo", materia.codigo_materia);
                    cmd.Parameters.AddWithValue("@nombre", materia.nombre_materia);
                    cmd.Parameters.AddWithValue("@creditos", materia.Creditos);
                    cmd.Parameters.AddWithValue("@hte", materia.horas_teoricas);
                    cmd.Parameters.AddWithValue("@hpr", materia.horas_practicas);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        //Eliminar materia
        public bool EliminarMateria(string codigo)
        {
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    string query = "DELETE FROM materia WHERE codigo_materia = @codigo";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
