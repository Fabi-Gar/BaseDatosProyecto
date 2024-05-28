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
        frmSoluciones VistaSoluciones;
        frmNuevoUsuario VistaUsuarioNuevo;
        frmAgregarEdificioOficina VistaEdificioOficina;
        
        Plantilla laPlantillaxD;


        obtenerDatosTablas modeloTablas;
        procedimientoSQL procedimientosAlmacenados;
        sqlModelos conexion;

        public manejoProgramaControl(frmAgregarEdificioOficina VistaEdificioOficina,frmInicioSesion vistaInicioSesion, frmAdministrador vistaAdministrador, frmTecnico vistaTecnico, frmCliente vistaCliente, frmSolicitarServicio vistaSolicitarServicio, frmEstadoServicio vistaEstadoServicio, frmServicios vistaServicios, frmSoluciones vistaSoluciones, frmNuevoUsuario vistaUsuarioNuevo, Plantilla laPlantillaxD, obtenerDatosTablas modeloTablas, procedimientoSQL procedimientosAlmacenados, sqlModelos conexion)
        {
            VistaInicioSesion = vistaInicioSesion;
            VistaAdministrador = vistaAdministrador;
            VistaTecnico = vistaTecnico;
            VistaCliente = vistaCliente;
            VistaSolicitarServicio = vistaSolicitarServicio;
            VistaEstadoServicio = vistaEstadoServicio;
            VistaServicios = vistaServicios;
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
       
            vistaAdministrador.btnSoluciones.Click += clickBoton;
            vistaAdministrador.btnNuevoUsuario.Click += clickBoton;
            vistaAdministrador.btnAgregarEdificio.Click += clickBoton;

            //Botones Vista Tecnico
            vistaTecnico.btnServicios.Click += clickBoton;
           
            vistaTecnico.btnSoluciones.Click += clickBoton;

            //Botones Vista Cliente
            vistaCliente.btnSolicitarServicio.Click += clickBoton;
            vistaCliente.btnEstadoServicio.Click += clickBoton;

        }

        private void AbrirFormAdmin(object formHeredado)
        {
            if (VistaAdministrador.PanelCentral.Controls.Count > 0) VistaAdministrador.PanelCentral.Controls.RemoveAt(0);
            Form fr = formHeredado as Form;
            fr.TopLevel = false;
            fr.Dock= DockStyle.Fill;
            VistaAdministrador.PanelCentral.Controls.Add(fr);
            VistaAdministrador.PanelCentral.Tag = fr;
            fr.Show(); 
        }

        private void AbrirFormUsuario(object formHeredado)
        {
            if (VistaCliente.PanelCentral.Controls.Count > 0) VistaCliente.PanelCentral.Controls.RemoveAt(0);
            Form fr = formHeredado as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            VistaCliente.PanelCentral.Controls.Add(fr);
            VistaCliente.PanelCentral.Tag = fr;
            fr.Show();
        }

        private void AbrirFormTecnico(object formHeredado)
        {
            if (VistaTecnico.PanelCentral.Controls.Count > 0) VistaTecnico.PanelCentral.Controls.RemoveAt(0);
            Form fr = formHeredado as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            VistaTecnico.PanelCentral.Controls.Add(fr);
            VistaTecnico.PanelCentral.Tag = fr;
            fr.Show();
        }




        private void clickBoton(object sender, EventArgs e)
        {
            // Vista Inicio sesión ya con sus respectivas funciones
            if (sender == VistaInicioSesion.btnIniciarSesion)
            {

                sqlModelos.Miconexion.abrir_conexion();

                System.Data.ConnectionState estadoConexion = sqlModelos.Miconexion.ObtenerEstadoConexion();

                sqlModelos.Miconexion.Rol = sqlModelos.Miconexion.Log_in(VistaInicioSesion.txtUsuario.Text, VistaInicioSesion.txtContraseña.Text);

                sqlModelos.Miconexion.dpi = sqlModelos.Miconexion.DpiUsuario(VistaInicioSesion.txtUsuario.Text, VistaInicioSesion.txtContraseña.Text);

                sqlModelos.Miconexion.Usuario = VistaInicioSesion.txtUsuario.Text;

                VistaInicioSesion.Hide();

                if (estadoConexion == System.Data.ConnectionState.Open)
                {


                    if (sqlModelos.Miconexion.Rol == "Cliente")
                    {
                        VistaCliente.ShowDialog();
                    }
                    else if (sqlModelos.Miconexion.Rol == "Tecnico")
                    {
                        VistaTecnico.ShowDialog();
                    }
                    else if (sqlModelos.Miconexion.Rol == "Administrador")
                    {
                        VistaAdministrador.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                        Application.Exit();
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
            { AbrirFormAdmin(new frmNuevoUsuario()); }

            if (sender == VistaAdministrador.btnSoluciones)
            { AbrirFormAdmin(new frmSoluciones()); }

            if (sender == VistaAdministrador.btnSoluciones)
            { AbrirFormAdmin(new frmSoluciones()); }

            if (sender == VistaAdministrador.btnServicios)
            { AbrirFormAdmin(new frmServicios()); }

            if (sender == VistaAdministrador.btnEstadoServicio)
            { AbrirFormAdmin(new frmEstadoServicio()); }

            if (sender == VistaAdministrador.btnSolicitarServicio)
            { AbrirFormAdmin(new frmSolicitarServicio()); }

            if (sender == VistaAdministrador.btnAgregarEdificio)
            { AbrirFormAdmin(new frmAgregarEdificioOficina()); }

            //Vista Cliente

            if (sender == VistaCliente.btnSolicitarServicio)
            { AbrirFormUsuario(new FrnSolicitarServicioCliente()); }

            if (sender == VistaCliente.btnEstadoServicio) 
            { AbrirFormUsuario(new frmEstadoServicio()); }

            //VistaTecnico

            if (sender == VistaTecnico.btnServicios)
            { AbrirFormTecnico(new frmServicios()); }

            

            if (sender == VistaTecnico.btnSoluciones)
            { AbrirFormTecnico(new frmSoluciones()); }


        }
    }

}
