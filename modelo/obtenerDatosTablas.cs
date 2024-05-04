using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaseDatosProyecto.modelo.sqlModelos;
using System.Windows.Forms;

namespace BaseDatosProyecto.modelo
{
    internal class obtenerDatosTablas
    {
        public DataTable TablaUsuarios()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarUsuarios";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }

        public DataTable TablaEdificios()
        {
            DataTable tablaEdificios = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarEdificios";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaEdificios);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaEdificios;

        }

        public DataTable TablaOficinas()
        {
            DataTable tablaEdificios = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VerTodasOficinas";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaEdificios);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaEdificios;

        }

        public DataTable VerTodosServiciosSolicitados()
        {
            DataTable tablaCuentas = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VerTodosServiciosSolicitados";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaCuentas);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaCuentas;

        }
    }
}
