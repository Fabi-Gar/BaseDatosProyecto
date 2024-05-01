using BaseDatosProyecto.modelo;
using BaseDatosProyecto.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaseDatosProyecto.modelo.sqlModelos.Miconexion;

namespace BaseDatosProyecto.controlador
{
    internal class manejoProgramaControl
    {
        frmInicioSesion VistaInicioSesion;
        frmAdministrador VistaAdministrador;
        frmTecnico VistaTecnico;
        frmCliente VistaCliente;
        Plantilla laPlantillaxD;

        obtenerDatosTablas modeloTablas;
        procedimientoSQL procedimientosAlmacenados;
        sqlModelos conexion;

        public manejoProgramaControl(frmInicioSesion vistaInicioSesion, 
            frmAdministrador vistaAdministrador, frmTecnico vistaTecnico, 
            frmCliente vistaCliente, Plantilla laPlantillaxD, obtenerDatosTablas modeloTablas, 
            procedimientoSQL procedimientosAlmacenados, sqlModelos conexion)
        {
            VistaInicioSesion = vistaInicioSesion;
            VistaAdministrador = vistaAdministrador;
            VistaTecnico = vistaTecnico;
            VistaCliente = vistaCliente;
            this.laPlantillaxD = laPlantillaxD;
            this.modeloTablas = modeloTablas;
            this.procedimientosAlmacenados = procedimientosAlmacenados;
            this.conexion = conexion;

            vistaInicioSesion.btnIniciarSesion.Click += clickBoton;
            vistaInicioSesion.btnCerrar.Click += clickBoton;
            vistaInicioSesion.ShowDialog();


     



        }

     
        private void clickBoton(object sender, EventArgs e)
        {
            if(sender == VistaInicioSesion.btnIniciarSesion)
            {
                sqlModelos.Miconexion.user = VistaInicioSesion.txtUsuario.Text;
                sqlModelos.Miconexion.pass = VistaInicioSesion.txtContraseña.Text;
                sqlModelos.Miconexion.abrir_conexion();

                System.Data.ConnectionState estadoCOnexion = sqlModelos.Miconexion.ObtenerEstadoConexion();

                if(estadoCOnexion == System.Data.ConnectionState.Open)
                {
                    VistaInicioSesion.Close();
                    VistaAdministrador.ShowDialog();    
                }

            }

            if(sender == VistaInicioSesion.btnCerrar)
            {
                VistaInicioSesion.Close();
                Application.Exit();
            }
        }
    }
}
