using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaseDatosProyecto.modelo.sqlModelos;

namespace BaseDatosProyecto.modelo
{
    internal class procedimientoSQL
    {
        public static void AgregarUsuario(string numDPI, string Apellidos, string Nombre, String NumeroOficina, string Rol)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearUsuario"; 
                cmd.Connection = Miconexion.conexion;

                // Los parámetros para CrearUsuario
                cmd.Parameters.Add(new SqlParameter("@NumeroDPI", numDPI)); 
                cmd.Parameters.Add(new SqlParameter("@Apellidos", Apellidos));
                cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                cmd.Parameters.Add(new SqlParameter("@NumeroOficina", NumeroOficina)); 
                cmd.Parameters.Add(new SqlParameter("@Roles", Rol)); 

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado Exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal " + ex.Message);
            }
        }

        public static void AgregarEdificios(string nomEdificios)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearUsuario";
                cmd.Connection = Miconexion.conexion;

            
                cmd.Parameters.Add(new SqlParameter("@NombreEdificio", nomEdificios));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edificio Agregado Exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal " + ex.Message);
            }
        }

        public static void AgregarOficina(string numOficina,string nomOficina, string nomEdificio)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AgregarOficina";
                cmd.Connection = Miconexion.conexion;

                
                cmd.Parameters.Add(new SqlParameter("@NumeroOficina", nomOficina));
                cmd.Parameters.Add(new SqlParameter("@NombreOficina", nomOficina));
                cmd.Parameters.Add(new SqlParameter("@NombreEdificio", nomEdificio));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oficina Agregada Exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal " + ex.Message);
            }
        }

        public static void SolicitarServicio(string Descripcion, string SolicitanteDpi, DateTime fecha )
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SolicitarServicio";
                cmd.Connection = Miconexion.conexion;


                cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                cmd.Parameters.Add(new SqlParameter("@SolicitanteDPI", SolicitanteDpi));
                cmd.Parameters.Add(new SqlParameter("@FechaSolicitud", fecha));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Servicio Agregado Exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal " + ex.Message);
            }
        }
    }
}
