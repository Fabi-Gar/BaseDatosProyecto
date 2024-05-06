using BaseDatosProyecto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatosProyecto.vista
{
    public partial class frmSoluciones : Form
    {
        public frmSoluciones()
        {
            InitializeComponent();
        }



        private void frmSoluciones_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerServiciosSolicitadosPendientes();
            dtServiciosSolicitados.DataSource = dataTable;

            obtenerDatosTablas datos2 = new obtenerDatosTablas();
            DataTable dataTable2 = datos.VerServiciosPrestados();
            dtServiciosPrestados.DataSource = dataTable2;
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            procedimientoSQL.AgregarSolucion(txtCodServicio.Text, fechaSolicitud.Value, sqlModelos.Miconexion.dpi, txtSolucion.Text);
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerServiciosSolicitadosPendientes();
            dtServiciosSolicitados.DataSource = dataTable;

            obtenerDatosTablas datos2 = new obtenerDatosTablas();
            DataTable dataTable2 = datos.VerServiciosPrestados();
            dtServiciosPrestados.DataSource = dataTable2;
        }
    }
}
