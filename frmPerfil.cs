using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
            Datos.Cusuario objetoUsuario = new Datos.Cusuario();
            objetoUsuario.mostrarUsuario(dgvUsuarios);
        }

        private void btnconectardb_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Datos.Cusuario objetoUsuario = new Datos.Cusuario();
            objetoUsuario.guardarUsuario(txtNombre, txtApellido, txtNombreUsuario);
            objetoUsuario.mostrarUsuario(dgvUsuarios);
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Datos.Cusuario objetoUsuario = new Datos.Cusuario();
            objetoUsuario.seleccionarUsuario(dgvUsuarios, txtID, txtNombre, txtApellido, txtNombreUsuario);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Datos.Cusuario objetoUsuario = new Datos.Cusuario();
            objetoUsuario.modificarUsuario(txtID, txtNombre, txtApellido, txtNombreUsuario);
            objetoUsuario.mostrarUsuario(dgvUsuarios);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Datos.Cusuario objetoUsuario = new Datos.Cusuario();
            objetoUsuario.eliminarUsuario(txtID);
            objetoUsuario.mostrarUsuario(dgvUsuarios);
        }
    }
}
