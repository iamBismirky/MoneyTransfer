namespace MoneyTransfer
{
    partial class frmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPago));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroEnvio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellidoRemitente = new System.Windows.Forms.TextBox();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoBeneficiario = new System.Windows.Forms.TextBox();
            this.txtNombreBeneficiario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCedulaBeneficiario = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagarEnvio = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtTipoMoneda = new System.Windows.Forms.TextBox();
            this.txtCodigoEnvio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarEnvio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO DE ENVIO";
            // 
            // txtNumeroEnvio
            // 
            this.txtNumeroEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroEnvio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEnvio.Location = new System.Drawing.Point(30, 56);
            this.txtNumeroEnvio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroEnvio.Name = "txtNumeroEnvio";
            this.txtNumeroEnvio.Size = new System.Drawing.Size(132, 27);
            this.txtNumeroEnvio.TabIndex = 0;
            this.txtNumeroEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroEnvio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOMBRE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellidoRemitente);
            this.groupBox1.Controls.Add(this.txtNombreRemitente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(323, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL REMITENTE";
            // 
            // txtApellidoRemitente
            // 
            this.txtApellidoRemitente.Enabled = false;
            this.txtApellidoRemitente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoRemitente.Location = new System.Drawing.Point(30, 91);
            this.txtApellidoRemitente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoRemitente.Name = "txtApellidoRemitente";
            this.txtApellidoRemitente.ReadOnly = true;
            this.txtApellidoRemitente.Size = new System.Drawing.Size(168, 23);
            this.txtApellidoRemitente.TabIndex = 1;
            this.txtApellidoRemitente.TabStop = false;
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.Enabled = false;
            this.txtNombreRemitente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRemitente.Location = new System.Drawing.Point(30, 43);
            this.txtNombreRemitente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.ReadOnly = true;
            this.txtNombreRemitente.Size = new System.Drawing.Size(168, 23);
            this.txtNombreRemitente.TabIndex = 1;
            this.txtNombreRemitente.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellidoBeneficiario);
            this.groupBox2.Controls.Add(this.txtNombreBeneficiario);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 314);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(323, 139);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL BENEFICIARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "APELLIDOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "NOMBRE";
            // 
            // txtApellidoBeneficiario
            // 
            this.txtApellidoBeneficiario.Enabled = false;
            this.txtApellidoBeneficiario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoBeneficiario.Location = new System.Drawing.Point(30, 96);
            this.txtApellidoBeneficiario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoBeneficiario.Name = "txtApellidoBeneficiario";
            this.txtApellidoBeneficiario.ReadOnly = true;
            this.txtApellidoBeneficiario.Size = new System.Drawing.Size(168, 23);
            this.txtApellidoBeneficiario.TabIndex = 1;
            this.txtApellidoBeneficiario.TabStop = false;
            // 
            // txtNombreBeneficiario
            // 
            this.txtNombreBeneficiario.Enabled = false;
            this.txtNombreBeneficiario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBeneficiario.Location = new System.Drawing.Point(30, 49);
            this.txtNombreBeneficiario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            this.txtNombreBeneficiario.ReadOnly = true;
            this.txtNombreBeneficiario.Size = new System.Drawing.Size(168, 23);
            this.txtNombreBeneficiario.TabIndex = 1;
            this.txtNombreBeneficiario.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 291);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "INGRESE CEDULA";
            // 
            // txtCedulaBeneficiario
            // 
            this.txtCedulaBeneficiario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaBeneficiario.Location = new System.Drawing.Point(221, 309);
            this.txtCedulaBeneficiario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedulaBeneficiario.Name = "txtCedulaBeneficiario";
            this.txtCedulaBeneficiario.Size = new System.Drawing.Size(161, 23);
            this.txtCedulaBeneficiario.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCedulaBeneficiario);
            this.groupBox3.Controls.Add(this.btnPagarEnvio);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtEstatus);
            this.groupBox3.Controls.Add(this.txtTotalPagar);
            this.groupBox3.Controls.Add(this.txtDestino);
            this.groupBox3.Controls.Add(this.txtOrigen);
            this.groupBox3.Controls.Add(this.txtTipoMoneda);
            this.groupBox3.Controls.Add(this.txtCodigoEnvio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(439, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(402, 424);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DEL ENVIO";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(178, 364);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 40);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPagarEnvio
            // 
            this.btnPagarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarEnvio.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarEnvio.Image = ((System.Drawing.Image)(resources.GetObject("btnPagarEnvio.Image")));
            this.btnPagarEnvio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarEnvio.Location = new System.Drawing.Point(230, 356);
            this.btnPagarEnvio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPagarEnvio.Name = "btnPagarEnvio";
            this.btnPagarEnvio.Size = new System.Drawing.Size(152, 48);
            this.btnPagarEnvio.TabIndex = 3;
            this.btnPagarEnvio.Text = "Pagar Envio";
            this.btnPagarEnvio.UseVisualStyleBackColor = true;
            this.btnPagarEnvio.Click += new System.EventHandler(this.btnPagarEnvio_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 180);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "DESTINO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "ORIGEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ESTATUS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "TOTAL A PAGAR";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(30, 254);
            this.txtEstatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(161, 23);
            this.txtEstatus.TabIndex = 1;
            this.txtEstatus.TabStop = false;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTotalPagar.Location = new System.Drawing.Point(221, 150);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(161, 34);
            this.txtTotalPagar.TabIndex = 1;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(30, 198);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(161, 23);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.TabStop = false;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Enabled = false;
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(30, 150);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(161, 23);
            this.txtOrigen.TabIndex = 1;
            this.txtOrigen.TabStop = false;
            // 
            // txtTipoMoneda
            // 
            this.txtTipoMoneda.Enabled = false;
            this.txtTipoMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMoneda.Location = new System.Drawing.Point(30, 97);
            this.txtTipoMoneda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipoMoneda.Name = "txtTipoMoneda";
            this.txtTipoMoneda.ReadOnly = true;
            this.txtTipoMoneda.Size = new System.Drawing.Size(161, 23);
            this.txtTipoMoneda.TabIndex = 1;
            this.txtTipoMoneda.TabStop = false;
            // 
            // txtCodigoEnvio
            // 
            this.txtCodigoEnvio.Enabled = false;
            this.txtCodigoEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEnvio.Location = new System.Drawing.Point(30, 49);
            this.txtCodigoEnvio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoEnvio.Name = "txtCodigoEnvio";
            this.txtCodigoEnvio.ReadOnly = true;
            this.txtCodigoEnvio.Size = new System.Drawing.Size(161, 23);
            this.txtCodigoEnvio.TabIndex = 1;
            this.txtCodigoEnvio.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "NUMERO DE ENVIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "MONEDA";
            // 
            // btnBuscarEnvio
            // 
            this.btnBuscarEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEnvio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEnvio.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEnvio.Image")));
            this.btnBuscarEnvio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEnvio.Location = new System.Drawing.Point(206, 56);
            this.btnBuscarEnvio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarEnvio.Name = "btnBuscarEnvio";
            this.btnBuscarEnvio.Size = new System.Drawing.Size(76, 27);
            this.btnBuscarEnvio.TabIndex = 1;
            this.btnBuscarEnvio.Text = "Buscar";
            this.btnBuscarEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEnvio.UseVisualStyleBackColor = true;
            this.btnBuscarEnvio.Click += new System.EventHandler(this.btnBuscarEnvio_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 45);
            this.panel1.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1159, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 38);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "PAGO DE ENVIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(917, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtNumeroEnvio);
            this.groupBox4.Controls.Add(this.btnBuscarEnvio);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 97);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IDENTIFICACION ENVIO";
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1208, 528);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago ";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroEnvio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellidoRemitente;
        private System.Windows.Forms.TextBox txtNombreRemitente;
        private System.Windows.Forms.TextBox txtCedulaBeneficiario;
        private System.Windows.Forms.TextBox txtNombreBeneficiario;
        private System.Windows.Forms.Button btnPagarEnvio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtTipoMoneda;
        private System.Windows.Forms.TextBox txtCodigoEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidoBeneficiario;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Button btnBuscarEnvio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}