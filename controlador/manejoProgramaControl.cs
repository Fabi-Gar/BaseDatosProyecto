using BaseDatosProyecto.modelo;
using BaseDatosProyecto.vista;
using BaseDatosProyecto.vista.VistasBotones;
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
        frmSolicitarServicio VistaSolicitarServicio;
        frmEstadoServicio VistaEstadoServicio;
        frmServicios VistaServicios;
        frmActualizarServicio VistaActualizarServicio;
        frmSoluciones VistaSoluciones;
        frmNuevoUsuario VistaUsuarioNuevo;
        frmAgregarEdificioOficina VistaEdificioOficina;
        
        Plantilla laPlantillaxD;


        obtenerDatosTablas modeloTablas;
        procedimientoSQL procedimientosAlmacenados;
        sqlModelos conexion;

        public manejoProgramaControl(frmAgregarEdificioOficina VistaEdificioOficina,frmInicioSesion vistaInicioSesion, frmAdministrador vistaAdministrador, frmTecnico vistaTecnico, frmCliente vistaCliente, frmSolicitarServicio vistaSolicitarServicio, frmEstadoServicio vistaEstadoServicio, frmServicios vistaServicios, frmActualizarServicio vistaActualizarServicio, frmSoluciones vistaSoluciones, frmNuevoUsuario vistaUsuarioNuevo, Plantilla laPlantillaxD, obtenerDatosTablas modeloTablas, procedimientoSQL procedimientosAlmacenados, sqlModelos conexion)
        {
            VistaInicioSesion = vistaInicioSesion;
            VistaAdministrador = vistaAdministrador;
            VistaTecnico = vistaTecnico;
            VistaCliente = vistaCliente;
            VistaSolicitarServicio = vistaSolicitarServicio;
            VistaEstadoServicio = vistaEstadoServicio;
            VistaServicios = vistaServicios;
            VistaActualizarServicio = vistaActualizarServicio;
            VistaSoluciones = vistaSoluciones;
            VistaUsuarioNuevo = vistaUsuarioNuevo;
           


            this.laPlantillaxD = laPlantillaxD;
            this.modeloTablas = modeloTablas;
            this.procedimientosAlmacenados = procedimientosAlmacenados;
            this.conexion = conexion;

            //Botones Vista Inicio Sesion
            vistaInicioSesion.btnIniciarSesion.Click += clickBoton;
            vistaInicioSesion.btnCerrar.Click += clickBoton;
            vistaInicioSesion.Show();

            //Botones Vista Administrador
            vistaAdministrador.btnSolicitarServicio.Click += clickBoton;
            vistaAdministrador.btnEstadoServicio.Click += clickBoton;
            vistaAdministrador.btnServicios.Click += clickBoton;
            vistaAdministrador.btnActualizar.Click += clickBoton;
            vistaAdministrador.btnSoluciones.Click += clickBoton;
            vistaAdministrador.btnNuevoUsuario.Click += clickBoton;
            vistaAdministrador.btnAgregarEdificio.Click += clickBoton;

            //Botones Vista Tecnico
            vistaTecnico.btnServicios.Click += clickBoton;
            vistaTecnico.btnActualizar.Click += clickBoton;
            vistaTecnico.btnSoluciones.Click += clickBoton;

            //Botones Vista Cliente
            vistaCliente.btnSolicitarServicio.Click += clickBoton;
            vistaCliente.btnEstadoServicio.Click += clickBoton;
        }

        private void AbrirForm(object formHeredado)
        {
            if (VistaAdministrador.PanelCentral.Controls.Count > 0) VistaAdministrador.PanelCentral.Controls.RemoveAt(0);
            Form fr = formHeredado as Form;
            fr.TopLevel = false;
            fr.Dock= DockStyle.Fill;
            VistaAdministrador.PanelCentral.Controls.Add(fr);
            VistaAdministrador.PanelCentral.Tag = fr;
            fr.Show(); 
        }


        private void clickBoton(object sender, EventArgs e)
        {
            // Vista Inicio sesión ya con sus respectivas funciones
            if (sender == VistaInicioSesion.btnIniciarSesion)
            {
                sqlModelos.Miconexion.user = VistaInicioSesion.txtUsuario.Text;
                sqlModelos.Miconexion.pass = VistaInicioSesion.txtContraseña.Text;
                sqlModelos.Miconexion.abrir_conexion();

                System.Data.ConnectionState estadoConexion = sqlModelos.Miconexion.ObtenerEstadoConexion();

                VistaInicioSesion.Hide();

                if (estadoConexion == System.Data.ConnectionState.Open)
                {
                    string rolUsuario = sqlModelos.Miconexion.ObtenerRol(VistaInicioSesion.txtUsuario.Text);

                    if (rolUsuario == "Cliente")
                    {
                        VistaCliente.ShowDialog();
                    }
                    else if (rolUsuario == "Tecnico")
                    {
                        VistaTecnico.ShowDialog();
                    }
                    else if (rolUsuario == "Administrador")
                    {
                        VistaAdministrador.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                    }
                }
                else
                {
                    Application.Exit();
                }






            }
            if (sender == VistaInicioSesion.btnCerrar)
            {
                Application.Exit();
            }

            //Vista Administrador Funciones
            if (sender == VistaAdministrador.btnNuevoUsuario)
            {
                AbrirForm(new frmNuevoUsuario());
            }

            if (sender == VistaAdministrador.btnSoluciones)
            { AbrirForm(new frmSoluciones()); }

            if (sender == VistaAdministrador.btnSoluciones)
            { AbrirForm(new frmSoluciones()); }

            if (sender == VistaAdministrador.btnActualizar)
            { AbrirForm(new frmActualizarServicio()); }

            if (sender == VistaAdministrador.btnServicios)
            { AbrirForm(new frmServicios()); }

            if (sender == VistaAdministrador.btnEstadoServicio)
            { AbrirForm(new frmEstadoServicio()); }

            if (sender == VistaAdministrador.btnSolicitarServicio) 
            { AbrirForm(new frmSolicitarServicio()); }

            if(sender == VistaAdministrador.btnAgregarEdificio) 
            { AbrirForm(new frmAgregarEdificioOficina()); }


        }
    }

}
