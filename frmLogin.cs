using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmLogin : Form
    {
        //Clases
        Datos.Cusuario usuario = new Datos.Cusuario();  //Instancia de la clase usuario
        Datos.CConexion conex = new Datos.CConexion();  //Instancia a conexxion a base de datos

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void TxtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAcceder.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {


        }
        private void Login()
        {
            //Inicio de session desde la base de datos 
            try
            {

                string query = "select * from usuario where userName='" + txtUsuario.Text + "'and clave='" + TxtClave.Text + "';";
                MySqlCommand comando = new MySqlCommand(query, conex.establecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    //Guardar datos del usuario en variable global
                    Datos.CGlobal.userName = reader["userName"].ToString();
                    Datos.CGlobal.nombreUsuario = reader["nombreUsuario"].ToString() + " " + reader["apellidoUsuario"].ToString();
                    Datos.CGlobal.contraseña = reader["clave"].ToString();
                    //Cerrar conexion
                    conex.cerrarConexion();
                    frmPrincipal frm = new frmPrincipal();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Datos incorrectos");
                    txtUsuario.Clear();
                    TxtClave.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtClave.Focus();
            }
        }
    }
}
