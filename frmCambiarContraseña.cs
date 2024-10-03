using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmCambiarContraseña : Form
    {
        Datos.CConexion conex = new Datos.CConexion();
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            string clave = txtCambiarClave.Text;
            string confirmarClave = txtConfirmarClave.Text;

            if (txtClave.Text == Datos.CGlobal.contraseña)
            {
                if (!string.IsNullOrEmpty(txtCambiarClave.Text) && !string.IsNullOrEmpty(txtConfirmarClave.Text))
                {
                    if (clave == confirmarClave)
                    {
                        try
                        {
                            //Actualizacion de contraseña en la base de datos
                            string query = "update usuario set clave='" + txtConfirmarClave.Text + "' where userName='" + Datos.CGlobal.userName + "';";
                            MySqlCommand comando = new MySqlCommand(query, conex.establecerConexion());
                            MySqlDataReader reader = comando.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            MessageBox.Show("Contraseña cambiada", "Estatus de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Datos.CGlobal.contraseña = txtConfirmarClave.Text;
                            Limpiar();
                            conex.cerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "No se modifico la contraseña");

                        }

                    }
                    else
                    {
                        MessageBox.Show("La contraseña no coinciden, intente de nuevo", "Contraseña no coincide");
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nueva contraseña", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Su contraseña actual no es la correcta", "Estatus de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtCambiarClave.Clear();
            txtConfirmarClave.Clear();
        }
    }
}
