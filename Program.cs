using BaseDatosProyecto.controlador;
using BaseDatosProyecto.modelo;
using BaseDatosProyecto.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatosProyecto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmInicioSesion vistaInicioSesion = new frmInicioSesion();
            frmAdministrador vistaAdministrador = new frmAdministrador();
            frmTecnico vistaTecnico = new frmTecnico();
            frmCliente vistaCliente = new frmCliente();
            Plantilla plantilla = new Plantilla();

            sqlModelos Conexiones = new sqlModelos();
            procedimientoSQL procedimientoSQL = new procedimientoSQL();
            obtenerDatosTablas tablasSql = new obtenerDatosTablas();

            manejoProgramaControl controlador = new manejoProgramaControl(vistaInicioSesion, vistaAdministrador, vistaTecnico, vistaCliente, plantilla, tablasSql, procedimientoSQL, Conexiones);




            Application.Run();
        }
    }
}
