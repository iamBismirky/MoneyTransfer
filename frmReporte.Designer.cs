namespace MoneyTransfer
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.btnReportesEnvios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDivisa = new System.Windows.Forms.Button();
            this.btnReportePagos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportesEnvios
            // 
            this.btnReportesEnvios.BackColor = System.Drawing.Color.Teal;
            this.btnReportesEnvios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportesEnvios.BackgroundImage")));
            this.btnReportesEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportesEnvios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportesEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesEnvios.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesEnvios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReportesEnvios.Location = new System.Drawing.Point(13, 10);
            this.btnReportesEnvios.Name = "btnReportesEnvios";
            this.btnReportesEnvios.Size = new System.Drawing.Size(116, 113);
            this.btnReportesEnvios.TabIndex = 1;
            this.btnReportesEnvios.UseVisualStyleBackColor = false;
            this.btnReportesEnvios.Click += new System.EventHandler(this.btnReportesEnvios_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 41);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTES";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnDivisa);
            this.panel2.Controls.Add(this.btnReportePagos);
            this.panel2.Controls.Add(this.btnReportesEnvios);
            this.panel2.Location = new System.Drawing.Point(13, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 137);
            this.panel2.TabIndex = 7;
            // 
            // btnDivisa
            // 
            this.btnDivisa.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDivisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivisa.BackgroundImage")));
            this.btnDivisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDivisa.Location = new System.Drawing.Point(257, 11);
            this.btnDivisa.Name = "btnDivisa";
            this.btnDivisa.Size = new System.Drawing.Size(117, 113);
            this.btnDivisa.TabIndex = 3;
            this.btnDivisa.UseVisualStyleBackColor = false;
            this.btnDivisa.Click += new System.EventHandler(this.btnDivisa_Click);
            // 
            // btnReportePagos
            // 
            this.btnReportePagos.BackColor = System.Drawing.Color.Red;
            this.btnReportePagos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportePagos.BackgroundImage")));
            this.btnReportePagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportePagos.Location = new System.Drawing.Point(135, 10);
            this.btnReportePagos.Name = "btnReportePagos";
            this.btnReportePagos.Size = new System.Drawing.Size(116, 113);
            this.btnReportePagos.TabIndex = 2;
            this.btnReportePagos.UseVisualStyleBackColor = false;
            this.btnReportePagos.Click += new System.EventHandler(this.btnReportePagos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(26, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 113);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnReportesEnvios_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(148, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 113);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnReportesEnvios_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReportesEnvios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        //private System.Windows.Forms.Button btnReporteDivisa;
        private System.Windows.Forms.Button btnDivisa;
        private System.Windows.Forms.Button btnReportePagos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}