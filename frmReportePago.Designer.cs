namespace MoneyTransfer
{
    partial class frmReportePago
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReporteFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvReportePago = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnReporteFecha);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFechaFinal);
            this.panel2.Controls.Add(this.dtpFechaInicio);
            this.panel2.Location = new System.Drawing.Point(12, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 100);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desde";
            // 
            // btnReporteFecha
            // 
            this.btnReporteFecha.Location = new System.Drawing.Point(343, 32);
            this.btnReporteFecha.Name = "btnReporteFecha";
            this.btnReporteFecha.Size = new System.Drawing.Size(75, 23);
            this.btnReporteFecha.TabIndex = 2;
            this.btnReporteFecha.Text = "Ver Reporte";
            this.btnReporteFecha.UseVisualStyleBackColor = true;
            this.btnReporteFecha.Click += new System.EventHandler(this.btnReporteFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar reportes por fechas";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(235, 60);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaFinal.TabIndex = 1;
            this.dtpFechaFinal.Value = new System.DateTime(2024, 3, 10, 22, 13, 24, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(235, 16);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 3, 10, 22, 13, 15, 0);
            // 
            // dgvReportePago
            // 
            this.dgvReportePago.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReportePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePago.Location = new System.Drawing.Point(12, 52);
            this.dgvReportePago.Name = "dgvReportePago";
            this.dgvReportePago.ReadOnly = true;
            this.dgvReportePago.Size = new System.Drawing.Size(1161, 240);
            this.dgvReportePago.TabIndex = 4;
            this.dgvReportePago.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 42);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPORTES DE PAGOS";
            // 
            // frmReportePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1180, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReportePago);
            this.Controls.Add(this.panel2);
            this.Name = "frmReportePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReporteFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgvReportePago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}