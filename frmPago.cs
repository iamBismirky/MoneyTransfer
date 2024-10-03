using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmPago : Form
    {
        Datos.CConexion conex = new Datos.CConexion();

        public frmPago()
        {
            InitializeComponent();
        }

        private void btnBuscarEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select moneda,montoRecibir,nombreRemitente,apellidoRemitente,nombreBeneficiario,apellidoBeneficiario,numeroEnvio,estatus,origen,destino from envio where numeroEnvio='" + txtNumeroEnvio.Text + "';";
                MySqlCommand comando = new MySqlCommand(query, conex.establecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    txtTipoMoneda.Text = reader["moneda"].ToString();
                    txtTotalPagar.Text = reader["montoRecibir"].ToString();
                    txtNombreRemitente.Text = reader["nombreRemitente"].ToString();
                    txtApellidoRemitente.Text = reader["apellidoRemitente"].ToString();
                    txtNombreBeneficiario.Text = reader["nombreBeneficiario"].ToString();
                    txtApellidoBeneficiario.Text = reader["apellidoBeneficiario"].ToString();
                    txtCodigoEnvio.Text = reader["numeroEnvio"].ToString();
                    txtEstatus.Text = reader["estatus"].ToString();
                    txtOrigen.Text = reader["origen"].ToString();
                    txtDestino.Text = reader["destino"].ToString();
                }
                conex.cerrarConexion();
                if (txtEstatus.Text == "PAGADO")
                {
                    MessageBox.Show("EL ENVIO YA FUE PAGADO", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos ");

            }

        }

        private void btnPagarEnvio_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumeroEnvio.Text) &&
               !string.IsNullOrEmpty(txtNombreRemitente.Text) &&
               !string.IsNullOrEmpty(txtApellidoRemitente.Text) &&
               !string.IsNullOrEmpty(txtNombreBeneficiario.Text) &&
               !string.IsNullOrEmpty(txtApellidoBeneficiario.Text) &&
               !string.IsNullOrEmpty(txtCedulaBeneficiario.Text) &&
               !string.IsNullOrEmpty(txtCodigoEnvio.Text) &&
               !string.IsNullOrEmpty(txtTipoMoneda.Text) &&
               !string.IsNullOrEmpty(txtTotalPagar.Text) &&
               !string.IsNullOrEmpty(txtEstatus.Text))
            {
                if (txtEstatus.Text == "DISPONIBLE")
                {
                    string numeroEnvio = txtCodigoEnvio.Text;
                    string nombreRemitente = txtNombreRemitente.Text;
                    string apellidoRemitente = txtApellidoRemitente.Text;
                    string nombreBeneficiario = txtNombreBeneficiario.Text;
                    string apellidoBeneficiario = txtApellidoBeneficiario.Text;
                    string cedulaBeneficiario = txtCedulaBeneficiario.Text;
                    string moneda = txtTipoMoneda.Text;
                    float montoPagado = float.Parse(txtTotalPagar.Text);
                    string estatus = "PAGADO";
                    string origen = txtOrigen.Text;
                    string destino = txtDestino.Text;
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (MessageBox.Show("¿Estas seguro que desea realizar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Insertar datos en la tabla pago              
                        string query = $"insert into pagoDinero(fecha,numeroEnvio,estatus,origen,destino,nombreRemitente,apellidoRemitente,nombreBeneficiario,apellidoBeneficiario,cedulaBeneficiario,moneda,montoPagado,userName) " +
                            $"values('{fecha}','{numeroEnvio}','{estatus}','{origen}','{destino}','{nombreRemitente}','{apellidoRemitente}','{nombreBeneficiario}','{apellidoBeneficiario}','{cedulaBeneficiario}','{moneda}','{montoPagado}','{Datos.CGlobal.userName}')";
                        MySqlCommand comando = new MySqlCommand(query, conex.establecerConexion());
                        comando.ExecuteNonQuery();

                        //Actualizar datos en la tabla envio
                        string queryEnvio = "update envio set estatus='" + estatus + "'where numeroEnvio='" + numeroEnvio + "';";
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
            txtNumeroEnvio.Clear();
            txtNombreRemitente.Clear();
            txtApellidoRemitente.Clear();
            txtNombreBeneficiario.Clear();
            txtApellidoBeneficiario.Clear();
            txtCedulaBeneficiario.Clear();
            txtCodigoEnvio.Clear();
            txtTipoMoneda.Clear();
            txtTotalPagar.Clear();
            txtEstatus.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            txtNumeroEnvio.Focus();

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
