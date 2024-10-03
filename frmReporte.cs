using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void btnReportesEnvios_Click(object sender, EventArgs e)
        {

            frmReporteEnvio reporteEnvio = new frmReporteEnvio();
            reporteEnvio.Show();
            this.Close();

        }

        private void btnDivisa_Click(object sender, EventArgs e)
        {
            frmReporteDivisa ReporteDivisa = new frmReporteDivisa();
            ReporteDivisa.Show();
            this.Close();
        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {
            frmReportePago frmReportePago = new frmReportePago();
            frmReportePago.Show();
            this.Close();
        }
    }
}
