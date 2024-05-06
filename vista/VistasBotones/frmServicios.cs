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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.VerTodosServiciosSolicitados();
            dtServicios.DataSource = dataTable;
        }
    }
}
