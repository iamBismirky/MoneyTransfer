using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Datos.CGlobal.userName.ToString();
            lblNombreUsuario.Text = Datos.CGlobal.nombreUsuario.ToString();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            frmEnvio llama = new frmEnvio();
            llama.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPago llama = new frmPago();
            llama.Show();
        }

        private void btnDivisa_Click(object sender, EventArgs e)
        {
            frmDivisa llama = new frmDivisa();
            llama.Show();
        }

        private void btnEnvioPaquete_Click(object sender, EventArgs e)
        {
            frmEnvioPaquete llama = new frmEnvioPaquete();
            llama.Show();
        }

        private void btnRecibirPaquete_Click(object sender, EventArgs e)
        {
            frmEntregaPaquete llama = new frmEntregaPaquete();
            llama.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte llama = new frmReporte();
            llama.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmEditar llama = new frmEditar();
            llama.Show();

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.Show();
        }
    }
}
