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
    public partial class frmSolicitarServicio : Form
    {
        public frmSolicitarServicio()
        {
            InitializeComponent();
        }

        private void frmSolicitarServicio_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerTodosServiciosSolicitados();
            dtServicios.DataSource = dataTable;
        }

        private void btnSolicitarServicio_Click(object sender, EventArgs e)
        {
            procedimientoSQL.SolicitarServicio(txtDescripcion.Text,txtDPI.Text,fechaSolicitud.Value);
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerTodosServiciosSolicitados();
            dtServicios.DataSource = dataTable;
        }
    }
}
