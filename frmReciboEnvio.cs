using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace MoneyTransfer
{
    public partial class frmReciboEnvio : Form
    {
        public frmReciboEnvio()
        {
            InitializeComponent();
        }
       
        public void frmReporUsuario_Load(object sender, EventArgs e)
        {
            
            try
            {
                Datos.CConexion conex = new Datos.CConexion();

                DataTable tablaEnvio = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter
                    ("select * from  envio where numeroEnvio='" + Datos.CGlobal.numeroEnvio + "'", conex.establecerConexion());
                adapter.Fill(tablaEnvio);

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("DataSetEnvio", tablaEnvio);
                reportViewer1.LocalReport.DataSources.Add(rp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            this.reportViewer1.RefreshReport();
            
        }
    }
}
