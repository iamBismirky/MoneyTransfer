using MoneyTransfer.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmEnvioPaquete : Form
    {
        public frmEnvioPaquete()
        {
            InitializeComponent();
        }

        private void txtLibra_TextChanged(object sender, EventArgs e)
        {
            if (rbtnNormal.Checked == true)
            {
                try
                {
                    float libras;
                    float precioLibra;

                    libras = float.Parse(txtLibra.Text);


                    if (libras >= 1)
                    {
                        precioLibra = 190;
                        txtTarifaLibra.Text = precioLibra.ToString("n2");
                        txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                        Devuelta();
                    }
                    if (libras > 10)
                    {
                        precioLibra = 240;
                        txtTarifaLibra.Text = precioLibra.ToString("n2");
                        txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                        Devuelta();
                    }
                    if (libras > 20)
                    {
                        precioLibra = 250;
                        txtTarifaLibra.Text = precioLibra.ToString("n2");
                        txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                        Devuelta();
                    }
                    if (libras > 30)
                    {
                        precioLibra = 260;
                        txtTarifaLibra.Text = precioLibra.ToString("n2");
                        txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                        Devuelta();
                    }
                    if (libras > 50)
                    {
                        precioLibra = 300;
                        txtTarifaLibra.Text = precioLibra.ToString("n2");
                        txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                        Devuelta();
                    }
                }
                catch (Exception)
                {
                    txtLibra.Text = null;
                    txtTarifaLibra.Text = null;
                    txtMontoPagar.Text = null;
                    txtEfectivo.Text = null;
                    txtDevuelta.Text = null;

                }
            }
            if (rbtnExpress.Checked == true)
            {
                try
                {
                    float libras;
                    float tarifa;
                    float montoPagar;
                    float precioLibra;
                    float envioExpress = 0.3f;
                    //Pasar valores de textbox a variables
                    libras = float.Parse(txtLibra.Text);

                    //Calculos
                    if (libras >= 1)
                    {
                        precioLibra = 190;
                        tarifa = ((precioLibra * envioExpress) + precioLibra);
                        montoPagar = (tarifa * libras);
                        txtTarifaLibra.Text = tarifa.ToString("n2");
                        txtMontoPagar.Text = montoPagar.ToString("n2");
                        Devuelta();
                    }
                    if (libras > 10)
                    {
                        precioLibra = 240;
                        tarifa = ((precioLibra * envioExpress) + precioLibra);
                        montoPagar = (tarifa * libras);
                        txtTarifaLibra.Text = tarifa.ToString("n2");
                        txtMontoPagar.Text = montoPagar.ToString("n2");
                        Devuelta();
                    }
                    if (libras > 20)
                    {
                        precioLibra = 250;
                        tarifa = ((precioLibra * envioExpress) + precioLibra);
                        montoPagar = (tarifa * libras);
                        txtTarifaLibra.Text = tarifa.ToString("n2");
                        txtMontoPagar.Text = montoPagar.ToString("n2");
                        Devuelta();
                    }
                    if (libras > 30)
                    {
                        precioLibra = 260;
                        tarifa = ((precioLibra * envioExpress) + precioLibra);
                        montoPagar = (tarifa * libras);
                        txtTarifaLibra.Text = tarifa.ToString("n2");
                        txtMontoPagar.Text = montoPagar.ToString("n2");
                        Devuelta();
                    }
                    if (libras > 50)
                    {
                        precioLibra = 300;
                        tarifa = ((precioLibra * envioExpress) + precioLibra);
                        montoPagar = (tarifa * libras);
                        txtTarifaLibra.Text = tarifa.ToString("n2");
                        txtMontoPagar.Text = montoPagar.ToString("n2");
                        Devuelta();
                    }
                    Devuelta();
                }
                catch (Exception)
                {
                    txtLibra.Text = null;
                    txtTarifaLibra.Text = null;
                    txtMontoPagar.Text = null;
                    txtEfectivo.Text = null;
                    txtDevuelta.Text = null;
                }
            }

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            Devuelta();

        }

        private void rbtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float libras;

                //Pasar valores de textbox a variables
                libras = float.Parse(txtLibra.Text);

                //Calculos
                if (libras >= 1)
                {
                    float precioLibra = 190;
                    txtTarifaLibra.Text = precioLibra.ToString("n2");
                    txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                    Devuelta();
                }
                if (libras > 10)
                {
                    float precioLibra = 240;
                    txtTarifaLibra.Text = precioLibra.ToString("n2");
                    txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                    Devuelta();
                }
                if (libras > 20)
                {
                    float precioLibra = 250;
                    txtTarifaLibra.Text = precioLibra.ToString("n2");
                    txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                    Devuelta();
                }
                if (libras > 30)
                {
                    float precioLibra = 260;
                    txtTarifaLibra.Text = precioLibra.ToString("n2");
                    txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                    Devuelta();
                }
                if (libras > 50)
                {
                    float precioLibra = 300;
                    txtTarifaLibra.Text = precioLibra.ToString("n2");
                    txtMontoPagar.Text = (libras * precioLibra).ToString("n2");
                    Devuelta();
                }


            }
            catch (Exception)
            {
                txtLibra.Text = null;

            }
        }

        private void rbtnExpress_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float libras;
                float tarifa;
                float montoPagar;
                float precioLibra;
                float envioExpress = 0.3f;
                //Pasar valores de textbox a variables
                libras = float.Parse(txtLibra.Text);

                //Calculos
                if (libras >= 1)
                {
                    precioLibra = 190;
                    tarifa = ((precioLibra * envioExpress) + precioLibra);
                    montoPagar = (tarifa * libras);
                    txtTarifaLibra.Text = tarifa.ToString("n2");
                    txtMontoPagar.Text = montoPagar.ToString("n2");
                    Devuelta();
                }
                if (libras > 10)
                {
                    precioLibra = 240;
                    tarifa = ((precioLibra * envioExpress) + precioLibra);
                    montoPagar = (tarifa * libras);
                    txtTarifaLibra.Text = tarifa.ToString("n2");
                    txtMontoPagar.Text = montoPagar.ToString("n2");
                    Devuelta();
                }
                if (libras > 20)
                {
                    precioLibra = 250;
                    tarifa = ((precioLibra * envioExpress) + precioLibra);
                    montoPagar = (tarifa * libras);
                    txtTarifaLibra.Text = tarifa.ToString("n2");
                    txtMontoPagar.Text = montoPagar.ToString("n2");
                    Devuelta();
                }
                if (libras > 30)
                {
                    precioLibra = 260;
                    tarifa = ((precioLibra * envioExpress) + precioLibra);
                    montoPagar = (tarifa * libras);
                    txtTarifaLibra.Text = tarifa.ToString("n2");
                    txtMontoPagar.Text = montoPagar.ToString("n2");
                    Devuelta();
                }
                if (libras > 50)
                {
                    precioLibra = 300;
                    tarifa = ((precioLibra * envioExpress) + precioLibra);
                    montoPagar = (tarifa * libras);
                    txtTarifaLibra.Text = tarifa.ToString("n2");
                    txtMontoPagar.Text = montoPagar.ToString("n2");
                    Devuelta();
                }

            }
            catch (Exception)
            {

                txtLibra.Text = null;
                txtEfectivo.Text = null;
            }

        }

        private void registarEnvioPaquete()
        {
            if (!string.IsNullOrEmpty(cboOrigen.Text) &&
                !string.IsNullOrEmpty(cboDestino.Text) &&
                !string.IsNullOrEmpty(txtTipoPaquete.Text) &&
                !string.IsNullOrEmpty(txtLibra.Text) &&
                !string.IsNullOrEmpty(txtTarifaLibra.Text) &&
                !string.IsNullOrEmpty(txtMontoPagar.Text) &&
                !string.IsNullOrEmpty(txtNombreRemitente.Text) &&
                !string.IsNullOrEmpty(txtApellidoRemitente.Text) &&
                !string.IsNullOrEmpty(txtTelefonoRemitente.Text) &&
                !string.IsNullOrEmpty(txtCedulaRemitente.Text) &&
                !string.IsNullOrEmpty(txtNombreBeneficiario.Text) &&
                !string.IsNullOrEmpty(txtApellidoBeneficiario.Text))
            {
                if (MessageBox.Show("¿Estas seguro que desea realizar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        string origen = cboOrigen.Text;
                        string destino = cboDestino.Text;
                        string tipoPaquete = txtTipoPaquete.Text;

                        //Comprobar que tipo de envio es con en RADIOBUTTON
                        String tipoEnvio = "NORMAL";
                        if (rbtnExpress.Checked == true)
                        {
                            tipoEnvio = "EXPRESS";
                        }
                        float libras = float.Parse(txtLibra.Text);
                        float tarifaLibra = float.Parse(txtTarifaLibra.Text);
                        float montoPagar = float.Parse(txtMontoPagar.Text);

                        string nombreRemitente = txtNombreRemitente.Text;
                        string apellidoRemitente = txtApellidoRemitente.Text;
                        string telefonoRemitente = txtTelefonoRemitente.Text;
                        string cedulaRemitente = txtCedulaRemitente.Text;
                        string nombreBeneficiario = txtNombreBeneficiario.Text;
                        string apellidoBeneficiario = txtApellidoBeneficiario.Text;

                        //Generar un numero aleatorio para el numero de envio
                        Random codigo = new Random();
                        string numeroPaquete = "P" + Convert.ToString(codigo.Next(1000000, 9999999));

                        string fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                        string estatus = "DISPONIBLE";
                        // QUERY AND CONECTION

                        string query = $"INSERT INTO enviopaquete(fecha,numeroPaquete,estatus,origen,destino,tipoPaquete,tipoEnvio,nombreRemitente,apellidoRemitente,telefonoRemitente,cedulaRemitente,libra,tarifa,montoPagar,nombreBeneficiario,apellidoBeneficiario,userName)" +
                            $" values('{fecha}','{numeroPaquete}','{estatus}','{origen}','{destino}','{tipoPaquete}','{tipoEnvio}','{nombreRemitente}','{apellidoRemitente}','{telefonoRemitente}','{cedulaRemitente}','{libras}','{tarifaLibra}','{montoPagar}','{nombreBeneficiario}','{apellidoBeneficiario}','{Datos.CGlobal.userName}')";
                        CConexion conex = new CConexion();


                        MySqlCommand cmd = new MySqlCommand(query, conex.establecerConexion());
                        cmd.ExecuteNonQuery();
                        conex.cerrarConexion();
                        MessageBox.Show("Su transacción se ha completado\n NUMERO DE ENVIO: " + numeroPaquete.ToString(), "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormatoMoneda(float efectivo)
        {
            txtEfectivo.Text = efectivo.ToString("n2");
        }

        private void Devuelta()
        {
            try
            {
                float efectivo = float.Parse(txtEfectivo.Text);
                FormatoMoneda(float.Parse(txtEfectivo.Text));
                txtEfectivo.Select(txtEfectivo.Text.Length - 3, 0);
                float montoPagar = float.Parse(txtMontoPagar.Text);
                txtDevuelta.Text = (efectivo - montoPagar).ToString("n2");
            }
            catch (Exception)
            {
                txtEfectivo.Text = null;
                txtDevuelta.Text = null;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            registarEnvioPaquete();
        }
        private void Limpiar()
        {
            cboDestino.Text = null;
            cboOrigen.Text = null;
            txtLibra.Clear();
            txtTarifaLibra.Clear();
            txtMontoPagar.Clear();
            txtTipoPaquete.Clear();
            txtNombreRemitente.Clear();
            txtApellidoRemitente.Clear();
            txtApellidoBeneficiario.Clear();
            txtTelefonoRemitente.Clear();
            txtCedulaRemitente.Clear();
            txtNombreBeneficiario.Clear();
            txtApellidoBeneficiario.Clear();
            txtEfectivo.Clear();
            txtDevuelta.Clear();


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
