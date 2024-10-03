namespace MoneyTransfer
{
    partial class frmReciboEnvio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.envioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReporte = new MoneyTransfer.DataSetReporte();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.envioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // envioBindingSource
            // 
            this.envioBindingSource.DataMember = "envio";
            this.envioBindingSource.DataSource = this.dataSetReporte;
            // 
            // dataSetReporte
            // 
            this.dataSetReporte.DataSetName = "DataSetReporte";
            this.dataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEnvio";
            reportDataSource1.Value = this.envioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MoneyTransfer.Reportes.ReciboEnvio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(379, 681);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReciboEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 681);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReciboEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmReporUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.envioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource envioBindingSource;
        private DataSetReporte dataSetReporte;
    }
}