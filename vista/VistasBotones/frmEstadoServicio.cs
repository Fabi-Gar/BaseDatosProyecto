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
    public partial class frmEstadoServicio : Form
    {
        public frmEstadoServicio()
        {
            InitializeComponent();
        }

        private void frmEstadoServicio_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerServiciosSolicitadosPorUsuario(sqlModelos.Miconexion.dpi);
            dtServicios.DataSource = dataTable;

        }
    }
}
