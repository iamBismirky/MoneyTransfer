using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmEntregaPaquete : Form
    {
        Datos.CConexion conex = new Datos.CConexion();

        public frmEntregaPaquete()
        {
            InitializeComponent();
        }

        private void btnBuscarEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select numeroPaquete,estatus,origen,destino,tipoPaquete,tipoEnvio,nombreRemitente,apellidoRemitente,nombreBeneficiario,apellidoBeneficiario,libra from enviopaquete where numeroPaquete='" + txtNumeroPaquete.Text + "';";
                MySqlCommand comando = new MySqlCommand(query, conex.establecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    txtTipoEnvio.Text = reader["tipoEnvio"].ToString();
                    txtTipoPaquete.Text = reader["tipoPaquete"].ToString();
                    txtLibra.Text = reader["libra"].ToString();
                    txtNombreRemitente.Text = reader["nombreRemitente"].ToString();
                    txtApellidoRemitente.Text = reader["apellidoRemitente"].ToString();
                    txtNombreBeneficiario.Text = reader["nombreBeneficiario"].ToString();
                    txtApellidoBeneficiario.Text = reader["apellidoBeneficiario"].ToString();
                    txtCodigoPaquete.Text = reader["numeroPaquete"].ToString();
                    txtEstatus.Text = reader["estatus"].ToString();
                    txtOrigen.Text = reader["origen"].ToString();
                    txtDestino.Text = reader["destino"].ToString();
                }
                conex.cerrarConexion();
                if (txtEstatus.Text == "ENTREGADO")
                {
                    MessageBox.Show("EL PAQUETE YA FUE ENTREGADO", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos ");

            }

        }

        private void btnPagarEnvio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumeroPaquete.Text) &&
               !string.IsNullOrEmpty(txtNombreRemitente.Text) &&
               !string.IsNullOrEmpty(txtApellidoRemitente.Text) &&
               !string.IsNullOrEmpty(txtNombreBeneficiario.Text) &&
               !string.IsNullOrEmpty(txtApellidoBeneficiario.Text) &&
               !string.IsNullOrEmpty(txtCedulaBeneficiario.Text) &&
               !string.IsNullOrEmpty(txtCodigoPaquete.Text) &&
               !string.IsNullOrEmpty(txtTipoEnvio.Text) &&
               !string.IsNullOrEmpty(txtTipoPaquete.Text) &&
               !string.IsNullOrEmpty(txtLibra.Text) &&
               !string.IsNullOrEmpty(txtEstatus.Text))
            {
                if (txtEstatus.Text == "DISPONIBLE")
                {
                    string numeroPaquete = txtCodigoPaquete.Text;
                    string nombreRemitente = txtNombreRemitente.Text;
                    string apellidoRemitente = txtApellidoRemitente.Text;
                    string nombreBeneficiario = txtNombreBeneficiario.Text;
                    string apellidoBeneficiario = txtApellidoBeneficiario.Text;
                    string cedulaBeneficiario = txtCedulaBeneficiario.Text;
                    string tipoEnvio = txtTipoEnvio.Text;
                    string tipoPaquete = txtTipoPaquete.Text;
                    float libra = float.Parse(txtLibra.Text);
                    string estatus = "ENTREGADO";
                    string origen = txtOrigen.Text;
                    string destino = txtDestino.Text;
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (MessageBox.Show("¿Estas seguro que desea realizar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Insertar datos en la tabla pago              
                        string query = $"insert into recibirpaquete(fechaEntrega,numeroPaquete,estatus,tipoEnvio,tipoPaquete,origen,destino,libra,nombreRemitente,apellidoRemitente,nombreBeneficiario,apellidoBeneficiario,cedulaBeneficiario,userName) " +
                            $"values('{fecha}','{numeroPaquete}','{estatus}','{tipoEnvio}','{tipoPaquete}','{origen}','{destino}','{libra}','{nombreRemitente}','{apellidoRemitente}','{nombreBeneficiario}','{apellidoBeneficiario}','{cedulaBeneficiario}','{Datos.CGlobal.userName}')";
                        MySqlCommand comando = new MySqlCommand(query, conex.establecerConexion());
                        comando.ExecuteNonQuery();

                        //Actualizar datos en la tabla envio
                        string queryEnvio = "update enviopaquete set estatus='" + estatus + "'where numeroPaquete='" + numeroPaquete + "';";
                        MySqlCommand comandoEnvio = new MySqlCommand(queryEnvio, conex.establecerConexion());
                        MySqlDataReader reader = comandoEnvio.ExecuteReader();
                        while (reader.Read())
                        {

                        }
                        MessageBox.Show("Su transacción se ha completado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        conex.cerrarConexion();
                    }

                }
                else
                {
                    MessageBox.Show("No es posible procesar la transaccion \n EL ENVIO YA FUE PAGADO", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Faltan Campos por llenar \n Ingrese cedula", "Campos vacios");
            }
        }
        private void Limpiar()
        {
            txtNumeroPaquete.Clear();
            txtNombreRemitente.Clear();
            txtApellidoRemitente.Clear();
            txtNombreBeneficiario.Clear();
            txtApellidoBeneficiario.Clear();
            txtCedulaBeneficiario.Clear();
            txtCodigoPaquete.Clear();
            txtTipoEnvio.Clear();
            txtTipoPaquete.Clear();
            txtLibra.Clear();
            txtEstatus.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            txtNumeroPaquete.Focus();

        }

        private void txtNumeroEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBuscarEnvio.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea cancelar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
