using Microsoft.Reporting.WinForms;
using MoneyTransfer.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace MoneyTransfer
{
    public partial class frmEnvio : Form
    {
        Datos.CEnvio envio = new Datos.CEnvio();

        public frmEnvio()
        {
            InitializeComponent();
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMontoPrincipal.Focus();
        }

        private void txtMontoPrincipal_TextChanged(object sender, EventArgs e)
        {   
            if(rbtnAparte.Checked == true)
            {
                try
                {
                    //Monto Principal
                    float montoPrincipal = float.Parse(txtMontoPrincipal.Text);
                    FormatoMoneda(float.Parse(txtMontoPrincipal.Text));
                    txtMontoPrincipal.Select(txtMontoPrincipal.Text.Length - 3, 0);
                    envio.Montoenviar = montoPrincipal;
                    //Tarifa
                    float porcientoTarifa = 0.08f;
                    float tarifa = (montoPrincipal * porcientoTarifa);
                    envio.Tarifa = tarifa;
                    txtTarifa.Text = (tarifa.ToString("n2"));
                    //Total a pagar
                    float totalPagar = (montoPrincipal * porcientoTarifa) + montoPrincipal;
                    envio.Totalpagar = totalPagar;
                    txtTotalPagar.Text = (totalPagar.ToString("n2"));
                    //Monto a recibir
                    txtMontoRecibir.Text = (montoPrincipal.ToString("n2"));
                    envio.Montorecibir = float.Parse(txtMontoRecibir.Text);
                    Devuelta();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Solo se permiten numeros, intente de nuevo");
                    txtMontoPrincipal.Text = null;
                    txtTarifa.Text = null;
                    txtTotalPagar.Text = null;
                    txtMontoRecibir.Text = null;
                }
            }
            if (rbtnIncluido.Checked == true)
            {
                try
                {
                    //Monto Principal
                    float montoprincipal = float.Parse(txtMontoPrincipal.Text);
                    envio.Montoenviar = montoprincipal;
                    //Tarifa
                    float porcientoTarifa = 1.08f;
                    float tarifa = montoprincipal - (montoprincipal / porcientoTarifa);
                    envio.Tarifa = tarifa;
                    txtTarifa.Text = tarifa.ToString("n2");
                    //Total a pagar
                    float totalpagar = montoprincipal;
                    envio.Totalpagar = totalpagar;
                    txtTotalPagar.Text = totalpagar.ToString("n2");
                    //Monto a recibir
                    txtMontoRecibir.Text = Convert.ToString(montoprincipal - tarifa);
                    //Devuelta
                    Devuelta();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Solo se permiten numeros, intente de nuevo");
                    txtMontoPrincipal.Text = null;
                    txtTarifa.Text = null;
                    txtTotalPagar.Text = null;
                    txtMontoRecibir.Text = null;

                }
            }
            

        }
        public void registarEnvio()
        {
            if (!string.IsNullOrEmpty(cboOrigen.Text) &&
                !string.IsNullOrEmpty(cboDestino.Text) &&
                !string.IsNullOrEmpty(cboMoneda.Text) &&
                !string.IsNullOrEmpty(txtMontoPrincipal.Text) &&
                !string.IsNullOrEmpty(txtNombreRemitente.Text) &&
                !string.IsNullOrEmpty(txtApellidoRemitente.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtCedula.Text) &&
                !string.IsNullOrEmpty(txtNombreBeneficiario.Text) &&
                !string.IsNullOrEmpty(txtApellidoBeneficiario.Text))
            {
                if (MessageBox.Show("¿Estas seguro que desea realizar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string origen = cboOrigen.Text;
                        string moneda = cboMoneda.Text;
                        string destino = cboDestino.Text;
                        float montoPrincipal = float.Parse(txtMontoPrincipal.Text);
                        float tarifa = float.Parse(txtTarifa.Text);
                        float montoTotal = float.Parse(txtTotalPagar.Text);
                        float montoRecibir = float.Parse(txtMontoRecibir.Text);
                        string nombreRemitente = txtNombreRemitente.Text;
                        string apellidoRemitente = txtApellidoRemitente.Text;
                        string telefono = txtTelefono.Text;
                        string cedulaRemitente = txtCedula.Text;
                        string nombreBeneficiario = txtNombreBeneficiario.Text;
                        string apellidoBeneficiario = txtApellidoBeneficiario.Text;

                        //Generar un numero aleatorio para el numero de envio
                        Random codigo = new Random();
                        string numeroEnvio = Convert.ToString(codigo.Next(1000000, 9999999));
                        Datos.CGlobal.numeroEnvio = numeroEnvio;
                        
                        string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string estatus = "DISPONIBLE";
                        // QUERY AND CONECTION

                        string query = $"INSERT INTO envio(fecha,numeroEnvio,estatus,moneda,origen,destino,nombreRemitente,apellidoRemitente,cedulaRemitente,telefono,montoPrincipal,tarifa,montoTotal,montoRecibir,nombreBeneficiario,apellidoBeneficiario,userName)" +
                            $" values('{fecha}','{numeroEnvio}','{estatus}','{moneda}','{origen}','{destino}','{nombreRemitente}','{apellidoRemitente}','{cedulaRemitente}','{telefono}','{montoPrincipal}','{tarifa}','{montoTotal}','{montoRecibir}','{nombreBeneficiario}','{apellidoBeneficiario}','{Datos.CGlobal.userName}')";
                        CConexion conex = new CConexion();
                        // QUERY AND CONECTION

                        MySqlCommand cmd = new MySqlCommand(query, conex.establecerConexion());
                        cmd.ExecuteNonQuery();
                        conex.cerrarConexion();
                        MessageBox.Show("Su transacción se ha completado\n NUMERO DE ENVIO: " + numeroEnvio.ToString(), "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmReciboEnvio frm = new frmReciboEnvio();
                        frm.Show();
                        Limpiar();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error al guardar los datos o conectar con la base de datos" + e.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan Campos por llenar", "Campos vacios");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            registarEnvio();

        }

        private void Limpiar()
        {
            cboDestino.Text = null;
            txtMontoPrincipal.Clear();
            txtTarifa.Clear();
            txtTotalPagar.Clear();
            txtMontoRecibir.Clear();
            txtNombreRemitente.Clear();
            txtApellidoRemitente.Clear();
            txtApellidoBeneficiario.Clear();
            txtTelefono.Clear();
            txtCedula.Clear();
            txtNombreBeneficiario.Clear();
            txtApellidoBeneficiario.Clear();
            txtEfectivo.Clear();
            txtDevuelta.Clear();


        }
        private void frmEnvio_Load(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {

                float efectivo = float.Parse(txtEfectivo.Text);
                float totalPagar = float.Parse(txtTotalPagar.Text);
                txtDevuelta.Text = Convert.ToString(efectivo - totalPagar);
            }
            catch (Exception)
            {
                txtEfectivo.Text = null;
                txtDevuelta.Text = null;

            }
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoRecibir_TextChanged(object sender, EventArgs e)
        {

        }
        private void rbtnIncluido_Click(object sender, EventArgs e)
        {
            try
            {
                //Monto Principal
                float montoprincipal = float.Parse(txtMontoPrincipal.Text);
                envio.Montoenviar = montoprincipal;
                //Tarifa
                float porcientoTarifa = 1.08f;
                float tarifa = montoprincipal - (montoprincipal / porcientoTarifa);
                envio.Tarifa = tarifa;
                txtTarifa.Text = tarifa.ToString("n2");
                //Total a pagar
                float totalpagar = montoprincipal;
                envio.Totalpagar = totalpagar;
                txtTotalPagar.Text = totalpagar.ToString("n2");
                //Monto a recibir
                txtMontoRecibir.Text = Convert.ToString(montoprincipal - tarifa);
                //Devuelta
                Devuelta();
            }
            catch (Exception)
            {
                //MessageBox.Show("Solo se permiten numeros, intente de nuevo");
                txtMontoPrincipal.Text = null;
                txtTarifa.Text = null;
                txtTotalPagar.Text = null;
                txtMontoRecibir.Text = null;

            }
        }

        private void rbtnAparte_Click(object sender, EventArgs e)
        {
            try
            {
                //Monto Principal
                float montoPrincipal = float.Parse(txtMontoPrincipal.Text);
                envio.Montoenviar = montoPrincipal;
                //Tarifa
                float porcientoTarifa = 0.08f;
                float tarifa = (montoPrincipal * porcientoTarifa);
                envio.Tarifa = tarifa;
                txtTarifa.Text = (tarifa.ToString("n2"));
                //Total a pagar
                float totalPagar = (montoPrincipal * porcientoTarifa) + montoPrincipal;
                envio.Totalpagar = totalPagar;
                txtTotalPagar.Text = (totalPagar.ToString("n2"));
                //Monto a recibir
                txtMontoRecibir.Text = (montoPrincipal.ToString("n2"));
                envio.Montorecibir = float.Parse(txtMontoRecibir.Text);
                //Devuelta
                Devuelta();
            }
            catch (Exception)
            {
                //MessageBox.Show("Solo se permiten numeros, intente de nuevo");
                txtMontoPrincipal.Text = null;
                txtTarifa.Text = null;
                txtTotalPagar.Text = null;
                txtMontoRecibir.Text = null;
            }
        }

        private void Devuelta()
        {
            try
            {
                float efectivo = float.Parse(txtEfectivo.Text);
                float totalPagar = float.Parse(txtTotalPagar.Text);
                txtDevuelta.Text = Convert.ToString(efectivo - totalPagar);
            }
            catch (Exception)
            {
                txtEfectivo.Text = null;
                txtDevuelta.Text = null;
            }
        }

        private void FormatoMoneda(float montoPrincipal)
        {
            txtMontoPrincipal.Text = montoPrincipal.ToString("n2");
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
