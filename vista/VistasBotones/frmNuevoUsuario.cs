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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            procedimientoSQL.AgregarUsuario(txtNumeroDPI.Text, txtApellidos.Text, txtNombreUsuario.Text, txtNumOficina.Text, "Tecnico", txtContraseña.Text);

            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaUsuarios();
            dtUsuarios.DataSource = dataTable;



            txtApellidos.Text = "";
            txtNombreUsuario.Text = "";
            txtNumeroDPI.Text = "";
            txtNumOficina.Text = "";
            txtContraseña.Text = "";
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            procedimientoSQL.AgregarUsuario(txtNumeroDPI.Text, txtApellidos.Text, txtNombreUsuario.Text, txtNumOficina.Text, "Cliente",txtContraseña.Text);

            obtenerDatosTablas datos = new obtenerDatosTablas();
            DataTable dataTable = datos.TablaUsuarios();
            dtUsuarios.DataSource = dataTable;

            txtApellidos.Text = "";
            txtNombreUsuario.Text = "";
            txtNumeroDPI.Text = "";
            txtNumOficina.Text = "";
            txtContraseña.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dtUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreUsuario.Text = (string)dtUsuarios.Rows[e.RowIndex].Cells[2].Value;
            txtApellidos.Text = (string)dtUsuarios.Rows[e.RowIndex].Cells[1].Value;
            txtContraseña.Text = (string)dtUsuarios.Rows[e.RowIndex].Cells[5].Value;
            txtNumeroDPI.Text = (string)dtUsuarios.Rows[e.RowIndex].Cells[0].Value;
            txtNumOficina.Text = (string)dtUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
