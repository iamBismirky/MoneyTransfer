using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmEditar : Form
    {

        public frmEditar()
        {
            InitializeComponent();

            lblNombreUsuario.Text = Datos.CGlobal.nombreUsuario;
            lblUserName.Text = Datos.CGlobal.userName;
        }

        private void lblCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña frm = new frmCambiarContraseña();
            frm.Show();
            this.Close();
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estas seguro que desea cambiar de usuario?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }


        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea salir de la aplicacion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
