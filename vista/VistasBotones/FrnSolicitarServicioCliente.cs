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

namespace BaseDatosProyecto.vista.VistasBotones
{
    public partial class FrnSolicitarServicioCliente : Form
    {
        public FrnSolicitarServicioCliente()
        {
            InitializeComponent();
        }

        private void btnSolicitarServicio_Click(object sender, EventArgs e)
        {
            procedimientoSQL.SolicitarServicio(txtDescripcion.Text,sqlModelos.Miconexion.dpi,fechaSolicitud.Value);
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerServiciosSolicitadosPorUsuario(sqlModelos.Miconexion.dpi);
            dtServicios.DataSource = dataTable;
        }

        private void FrnSolicitarServicioCliente_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerServiciosSolicitadosPorUsuario(sqlModelos.Miconexion.dpi);
            dtServicios.DataSource = dataTable;
        }
    }
}
