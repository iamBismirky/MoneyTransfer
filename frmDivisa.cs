using MoneyTransfer.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmDivisa : Form
    {
        public frmDivisa()
        {
            InitializeComponent();

        }
        Datos.CDivisas divisa = new Datos.CDivisas();

        private void frmDivisa_Load(object sender, EventArgs e)
        {

        }
        private void cboTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtCantidadDinero_TextChanged(object sender, EventArgs e)
        {

            try
            {
                divisa.Tipomoneda = cboTipoMoneda.Text;
                FormatoMoneda(float.Parse(txtCantidadDinero.Text));
                txtCantidadDinero.Select(txtCantidadDinero.Text.Length - 3, 0);
                if (cboTipoMoneda.Text == "DOLAR ESTADOUNIDENSE")
                {
                    divisa.Tasa = 58.75f;
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    divisa.Cantidad = float.Parse(txtCantidadDinero.Text);
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                    divisa.Tasa = 58.75f;
                    divisa.Totalpesos = (divisa.Cantidad * divisa.Tasa);
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                }
                if (cboTipoMoneda.Text == "EURO")
                {
                    divisa.Tasa = 63.50f;
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    divisa.Cantidad = float.Parse(txtCantidadDinero.Text);
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                    divisa.Totalpesos = (divisa.Cantidad * divisa.Tasa);
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                }
                if (cboTipoMoneda.Text == "DOLAR CANADIENSE")
                {
                    divisa.Tasa = 43.41f;
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    divisa.Cantidad = float.Parse(txtCantidadDinero.Text);
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                    divisa.Totalpesos = (divisa.Cantidad * divisa.Tasa);
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                }
                if (cboTipoMoneda.Text == "FRANCOS SUIZOS")
                {
                    divisa.Tasa = 66.84f;
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    divisa.Cantidad = float.Parse(txtCantidadDinero.Text);
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                    divisa.Totalpesos = (divisa.Cantidad * divisa.Tasa);
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                }
                if (cboTipoMoneda.Text == "LIBRAS ESTERLINAS")
                {
                    divisa.Tasa = 74.50f;
                    txtTasa.Text = divisa.Tasa.ToString("N2");
                    divisa.Cantidad = float.Parse(txtCantidadDinero.Text);
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                    divisa.Totalpesos = (divisa.Cantidad * divisa.Tasa);
                    txtTasa.Text = divisa.Tasa.ToString();
                    txtTotalPesos.Text = divisa.Totalpesos.ToString("N2");
                }
            }
            catch (Exception)
            {
                txtCantidadDinero.Text = null;

            }





        }
        private void txtTasa_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTotalPesos_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCantidadDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                btnRegistrarCambio.Focus();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {


        }
        private void btnRegistrarCambio_Click(object sender, EventArgs e)
        {
            InsertaDivisa();


        }
        private void Limpiar()
        {
            txtCantidadDinero.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTasa.Clear();
            txtTotalPesos.Clear();

        }
        private void InsertaDivisa()
        {
            if (!string.IsNullOrEmpty(cboTipoMoneda.Text) &&
                !string.IsNullOrEmpty(txtCantidadDinero.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtApellido.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtCedula.Text))

            {
                if (MessageBox.Show("¿Estas seguro que desea realizar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string nombreCliente = txtNombre.Text;
                        string apellidoCliente = txtApellido.Text;
                        string cedulaCliente = txtCedula.Text;
                        String telefono = txtTelefono.Text;
                        float tasa = float.Parse(txtTasa.Text);
                        float totalPesos = float.Parse(txtTotalPesos.Text);
                        float cantidad = float.Parse(txtCantidadDinero.Text);
                        string tipoMoneda = cboTipoMoneda.Text;
                        string fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                        // QUERY AND CONECTION

                        string query = $"INSERT INTO divisa(nombreCliente,apellidoCliente,cedulaCliente,telefono,tipoMoneda,cantidad,tasa,totalPesos,fecha,userName) " +
                            $"values('{nombreCliente}','{apellidoCliente}','{cedulaCliente}','{telefono}','{tipoMoneda}','{cantidad}','{tasa}','{totalPesos}','{fecha}','{Datos.CGlobal.userName}')";
                        CConexion conex = new CConexion();                     
                        MySqlCommand cmd = new MySqlCommand(query, conex.establecerConexion());
                        cmd.ExecuteNonQuery();
                        conex.cerrarConexion();
                        MessageBox.Show("Su transacción se ha completado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }

            }
            else
            {
                MessageBox.Show("Faltan Campos por llenar", "Campos vacios");
            }
        }
        private void FormatoMoneda(float cantidadDinero)
        {
            txtCantidadDinero.Text = cantidadDinero.ToString("F2");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea cancelar la transaccion?", "VALIDACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
