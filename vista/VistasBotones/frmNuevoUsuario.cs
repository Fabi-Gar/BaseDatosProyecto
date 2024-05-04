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
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaUsuarios();
            dtUsuarios.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procedimientoSQL.AgregarUsuario(txtNumeroDPI.Text, txtApellidos.Text, txtNombreUsuario.Text, txtNumOficina.Text, "Tecnico");

            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaUsuarios();
            dtUsuarios.DataSource = dataTable;

            txtApellidos.Text = "";
            txtNombreUsuario.Text = "";
            txtNumeroDPI.Text = "";
            txtNumOficina.Text = "";
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            procedimientoSQL.AgregarUsuario(txtNumeroDPI.Text, txtApellidos.Text, txtNombreUsuario.Text, txtNumOficina.Text, "Cliente");

            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaUsuarios();
            dtUsuarios.DataSource = dataTable;

            txtApellidos.Text = "";
            txtNombreUsuario.Text = "";
            txtNumeroDPI.Text = "";
            txtNumOficina.Text = "";

        }
    }
}
