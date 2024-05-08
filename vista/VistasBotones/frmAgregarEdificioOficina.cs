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
    public partial class frmAgregarEdificioOficina : Form
    {
        public frmAgregarEdificioOficina()
        {
            InitializeComponent();
        }

        private void frmAgregarEdificioOficina_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaEdificios();
            dtEdificios.DataSource = dataTable;

            obtenerDatosTablas datos2 = new obtenerDatosTablas();
            DataTable dataTable2 = datos.TablaOficinas();
            dtOficinas.DataSource = dataTable2;




        }

        private void btnAgregarEdificios_Click(object sender, EventArgs e)
        {
            procedimientoSQL.AgregarEdificios(txtAgregarEdificio.Text);
            txtAgregarEdificio.Text = "";
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaEdificios();
            dtEdificios.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procedimientoSQL.AgregarOficina(txtOficina.Text, txtNombreOficina.Text, txtNombreEdificio.Text);
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaOficinas();
            dtOficinas.DataSource = dataTable;

            txtOficina.Text = "";
            txtNombreOficina.Text = "";
            txtNombreEdificio.Text = "";
        }
    }
}
