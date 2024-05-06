using BaseDatosProyecto.vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatosProyecto.modelo
{
    internal class sqlModelos
    {
        public static class Miconexion
        {
            public static SqlConnection conexion;

            public static void abrir_conexion()
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ConnectionString;
                    conexion = new SqlConnection(connectionString);

                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open();
                    }
                    else { MessageBox.Show("error"); }
                }
                catch (Exception ex) { MessageBox.Show("error " + ex); }
            }

            public static ConnectionState ObtenerEstadoConexion()
            {
                return conexion.State;
            }

            public static string Log_in(string nombreUsuario, string contraseña)
            {
                string rolUsuario = "";

                try
                {
                    abrir_conexion();

                    SqlCommand cmd = new SqlCommand("ValidarUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        rolUsuario = reader["Roles"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }

                return rolUsuario;
            }


            public static string DpiUsuario(string nombreUsuario, string contraseña)
            {
                string dpiUsuario = "";

                try
                {
                    abrir_conexion();

                    SqlCommand cmd = new SqlCommand("ObtenerDPIUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dpiUsuario = reader.GetString(reader.GetOrdinal("DPI"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }

                return dpiUsuario;
            }


            public static string Usuario { get; set; }
            public static string Rol { get; set; }
            public static string dpi { get; set; }

        }
    }
}
