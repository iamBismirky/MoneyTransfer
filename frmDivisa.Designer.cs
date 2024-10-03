namespace MoneyTransfer
{
    partial class frmDivisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisa));
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoMoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtTotalPesos = new System.Windows.Forms.TextBox();
            this.btnRegistrarCambio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadDinero = new System.Windows.Forms.TextBox();
            this.gboCliente = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gboCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo De Dinero:";
            // 
            // cboTipoMoneda
            // 
            this.cboTipoMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMoneda.FormattingEnabled = true;
            this.cboTipoMoneda.Items.AddRange(new object[] {
            "DOLAR ESTADOUNIDENSE",
            "EURO",
            "DOLAR CANADIENSE",
            "FRANCOS SUIZOS",
            "LIBRAS ESTERLINAS"});
            this.cboTipoMoneda.Location = new System.Drawing.Point(169, 92);
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Size = new System.Drawing.Size(181, 23);
            this.cboTipoMoneda.TabIndex = 0;
            this.cboTipoMoneda.SelectedIndexChanged += new System.EventHandler(this.cboTipoMoneda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total en DOP:";
            // 
            // txtTasa
            // 
            this.txtTasa.Enabled = false;
            this.txtTasa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasa.Location = new System.Drawing.Point(183, 229);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 27);
            this.txtTasa.TabIndex = 2;
            this.txtTasa.TextChanged += new System.EventHandler(this.txtTasa_TextChanged);
            // 
            // txtTotalPesos
            // 
            this.txtTotalPesos.Enabled = false;
            this.txtTotalPesos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPesos.Location = new System.Drawing.Point(183, 302);
            this.txtTotalPesos.Name = "txtTotalPesos";
            this.txtTotalPesos.Size = new System.Drawing.Size(127, 34);
            this.txtTotalPesos.TabIndex = 2;
            this.txtTotalPesos.TextChanged += new System.EventHandler(this.txtTotalPesos_TextChanged);
            // 
            // btnRegistrarCambio
            // 
            this.btnRegistrarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCambio.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCambio.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCambio.Image")));
            this.btnRegistrarCambio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCambio.Location = new System.Drawing.Point(701, 385);
            this.btnRegistrarCambio.Name = "btnRegistrarCambio";
            this.btnRegistrarCambio.Size = new System.Drawing.Size(147, 44);
            this.btnRegistrarCambio.TabIndex = 7;
            this.btnRegistrarCambio.Text = "Cambiar";
            this.btnRegistrarCambio.UseVisualStyleBackColor = true;
            this.btnRegistrarCambio.Click += new System.EventHandler(this.btnRegistrarCambio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "DIVISAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad de Dinero:";
            // 
            // txtCantidadDinero
            // 
            this.txtCantidadDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDinero.Location = new System.Drawing.Point(183, 167);
            this.txtCantidadDinero.Name = "txtCantidadDinero";
            this.txtCantidadDinero.Size = new System.Drawing.Size(180, 23);
            this.txtCantidadDinero.TabIndex = 1;
            this.txtCantidadDinero.TextChanged += new System.EventHandler(this.txtCantidadDinero_TextChanged);
            this.txtCantidadDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDinero_KeyPress);
            // 
            // gboCliente
            // 
            this.gboCliente.Controls.Add(this.txtCedula);
            this.gboCliente.Controls.Add(this.label9);
            this.gboCliente.Controls.Add(this.label8);
            this.gboCliente.Controls.Add(this.txtTelefono);
            this.gboCliente.Controls.Add(this.label7);
            this.gboCliente.Controls.Add(this.label6);
            this.gboCliente.Controls.Add(this.txtApellido);
            this.gboCliente.Controls.Add(this.txtNombre);
            this.gboCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCliente.Location = new System.Drawing.Point(424, 81);
            this.gboCliente.Name = "gboCliente";
            this.gboCliente.Size = new System.Drawing.Size(424, 255);
            this.gboCliente.TabIndex = 6;
            this.gboCliente.TabStop = false;
            this.gboCliente.Text = "Datos Personales del Cliente";
            // 
            // txtCedula
            // 
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Location = new System.Drawing.Point(94, 158);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(147, 27);
            this.txtCedula.TabIndex = 6;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cedula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(94, 120);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 27);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(94, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(255, 27);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(94, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 27);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 50);
            this.panel1.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1116, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(52, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(941, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(647, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 35);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmDivisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1166, 509);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gboCliente);
            this.Controls.Add(this.txtCantidadDinero);
            this.Controls.Add(this.btnRegistrarCambio);
            this.Controls.Add(this.txtTotalPesos);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.cboTipoMoneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDivisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIO DE DINERO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDivisa_Load);
            this.gboCliente.ResumeLayout(false);
            this.gboCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtTotalPesos;
        private System.Windows.Forms.Button btnRegistrarCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadDinero;
        private System.Windows.Forms.GroupBox gboCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}