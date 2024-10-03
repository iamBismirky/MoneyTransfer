namespace MoneyTransfer
{
    partial class frmEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboEnvio = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnAparte = new System.Windows.Forms.RadioButton();
            this.rbtnIncluido = new System.Windows.Forms.RadioButton();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtDevuelta = new System.Windows.Forms.TextBox();
            this.txtMontoRecibir = new System.Windows.Forms.TextBox();
            this.txtMontoPrincipal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidoRemitente = new System.Windows.Forms.TextBox();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtApellidoBeneficiario = new System.Windows.Forms.TextBox();
            this.txtNombreBeneficiario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gboEnvio.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOrigen);
            this.groupBox1.Controls.Add(this.cboDestino);
            this.groupBox1.Controls.Add(this.cboMoneda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DESTINO";
            // 
            // cboOrigen
            // 
            this.cboOrigen.AutoCompleteCustomSource.AddRange(new string[] {
            "AZUA",
            "BAHORUCO",
            "BARAHONA",
            "DAJABON",
            "DISTRITO NACIONAL",
            "DUARTE",
            "EL SEYBO",
            "ELIAS PIÑA",
            "ESPAILLAT",
            "HATO MAYOR",
            "HERMANAS MIRABAL",
            "INDEPENDENCIA",
            "LA ALTAGRACIA",
            "LA ROMANA",
            "LA VEGA",
            "MARIA TRINIDAD SANCHEZ",
            "MONSEÑOR NOUEL",
            "MONTE PLATA",
            "MONTECRISTI",
            "PEDERNALES",
            "PERAVIA",
            "PUERTO PLATA",
            "SAMANA",
            "SAN CRISTOBAL",
            "SAN JOSE DE OCOA",
            "SAN JUAN",
            "SAN PEDRO DE MACORIS",
            "SANCHEZ RAMIREZ",
            "SANTIAGO",
            "SANTIAGO RODRIGUEZ",
            "SANTO DOMINGO",
            "VALVERDE"});
            this.cboOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrigen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "AZUA",
            "BAHORUCO",
            "BARAHONA",
            "DAJABON",
            "DISTRITO NACIONAL",
            "DUARTE",
            "EL SEYBO",
            "ELIAS PIÑA",
            "ESPAILLAT",
            "HATO MAYOR",
            "HERMANAS MIRABAL",
            "INDEPENDENCIA",
            "LA ALTAGRACIA",
            "LA ROMANA",
            "LA VEGA",
            "MARIA TRINIDAD SANCHEZ",
            "MONSEÑOR NOUEL",
            "MONTE PLATA",
            "MONTECRISTI",
            "PEDERNALES",
            "PERAVIA",
            "PUERTO PLATA",
            "SAMANA",
            "SAN CRISTOBAL",
            "SAN JOSE DE OCOA",
            "SAN JUAN",
            "SAN PEDRO DE MACORIS",
            "SANCHEZ RAMIREZ",
            "SANTIAGO",
            "SANTIAGO RODRIGUEZ",
            "SANTO DOMINGO",
            "VALVERDE"});
            this.cboOrigen.Location = new System.Drawing.Point(9, 114);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(161, 25);
            this.cboOrigen.TabIndex = 1;
            this.cboOrigen.Tag = "";
            this.cboOrigen.Text = "SANCHEZ RAMIREZ";
            // 
            // cboDestino
            // 
            this.cboDestino.AutoCompleteCustomSource.AddRange(new string[] {
            "AZUA",
            "BAHORUCO",
            "BARAHONA",
            "DAJABON",
            "DISTRITO NACIONAL",
            "DUARTE",
            "EL SEYBO",
            "ELIAS PIÑA",
            "ESPAILLAT",
            "HATO MAYOR",
            "HERMANAS MIRABAL",
            "INDEPENDENCIA",
            "LA ALTAGRACIA",
            "LA ROMANA",
            "LA VEGA",
            "MARIA TRINIDAD SANCHEZ",
            "MONSEÑOR NOUEL",
            "MONTE PLATA",
            "MONTECRISTI",
            "PEDERNALES",
            "PERAVIA",
            "PUERTO PLATA",
            "SAMANA",
            "SAN CRISTOBAL",
            "SAN JOSE DE OCOA",
            "SAN JUAN",
            "SAN PEDRO DE MACORIS",
            "SANCHEZ RAMIREZ",
            "SANTIAGO",
            "SANTIAGO RODRIGUEZ",
            "SANTO DOMINGO",
            "VALVERDE"});
            this.cboDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDestino.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Items.AddRange(new object[] {
            "AZUA",
            "BAHORUCO",
            "BARAHONA",
            "DAJABON",
            "DISTRITO NACIONAL",
            "DUARTE",
            "EL SEYBO",
            "ELIAS PIÑA",
            "ESPAILLAT",
            "HATO MAYOR",
            "HERMANAS MIRABAL",
            "INDEPENDENCIA",
            "LA ALTAGRACIA",
            "LA ROMANA",
            "LA VEGA",
            "MARIA TRINIDAD SANCHEZ",
            "MONSEÑOR NOUEL",
            "MONTE PLATA",
            "MONTECRISTI",
            "PEDERNALES",
            "PERAVIA",
            "PUERTO PLATA",
            "SAMANA",
            "SAN CRISTOBAL",
            "SAN JOSE DE OCOA",
            "SAN JUAN",
            "SAN PEDRO DE MACORIS",
            "SANCHEZ RAMIREZ",
            "SANTIAGO",
            "SANTIAGO RODRIGUEZ",
            "SANTO DOMINGO",
            "VALVERDE"});
            this.cboDestino.Location = new System.Drawing.Point(200, 114);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(173, 25);
            this.cboDestino.TabIndex = 2;
            this.cboDestino.Tag = "";
            // 
            // cboMoneda
            // 
            this.cboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMoneda.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Items.AddRange(new object[] {
            "Pesos Dominicanos"});
            this.cboMoneda.Location = new System.Drawing.Point(6, 52);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(194, 25);
            this.cboMoneda.TabIndex = 0;
            this.cboMoneda.Text = "Pesos Dominicanos";
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "MONEDA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(209, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "DESTINO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORIGEN\r\n";
            // 
            // gboEnvio
            // 
            this.gboEnvio.Controls.Add(this.label12);
            this.gboEnvio.Controls.Add(this.button1);
            this.gboEnvio.Controls.Add(this.rbtnAparte);
            this.gboEnvio.Controls.Add(this.rbtnIncluido);
            this.gboEnvio.Controls.Add(this.txtTotalPagar);
            this.gboEnvio.Controls.Add(this.txtTarifa);
            this.gboEnvio.Controls.Add(this.txtEfectivo);
            this.gboEnvio.Controls.Add(this.txtDevuelta);
            this.gboEnvio.Controls.Add(this.txtMontoRecibir);
            this.gboEnvio.Controls.Add(this.txtMontoPrincipal);
            this.gboEnvio.Controls.Add(this.label6);
            this.gboEnvio.Controls.Add(this.label13);
            this.gboEnvio.Controls.Add(this.label15);
            this.gboEnvio.Controls.Add(this.label5);
            this.gboEnvio.Controls.Add(this.label4);
            this.gboEnvio.Controls.Add(this.label3);
            this.gboEnvio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboEnvio.Location = new System.Drawing.Point(12, 221);
            this.gboEnvio.Name = "gboEnvio";
            this.gboEnvio.Size = new System.Drawing.Size(400, 295);
            this.gboEnvio.TabIndex = 1;
            this.gboEnvio.TabStop = false;
            this.gboEnvio.Text = "VALORES DE ENVIO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tarifa del 8%";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(747, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbtnAparte
            // 
            this.rbtnAparte.AutoSize = true;
            this.rbtnAparte.Checked = true;
            this.rbtnAparte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAparte.Location = new System.Drawing.Point(157, 47);
            this.rbtnAparte.Name = "rbtnAparte";
            this.rbtnAparte.Size = new System.Drawing.Size(104, 17);
            this.rbtnAparte.TabIndex = 0;
            this.rbtnAparte.TabStop = true;
            this.rbtnAparte.Text = "CARGO APARTE";
            this.rbtnAparte.UseVisualStyleBackColor = true;
            this.rbtnAparte.Click += new System.EventHandler(this.rbtnAparte_Click);
            // 
            // rbtnIncluido
            // 
            this.rbtnIncluido.AutoSize = true;
            this.rbtnIncluido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIncluido.Location = new System.Drawing.Point(280, 47);
            this.rbtnIncluido.Name = "rbtnIncluido";
            this.rbtnIncluido.Size = new System.Drawing.Size(117, 17);
            this.rbtnIncluido.TabIndex = 0;
            this.rbtnIncluido.Text = "CARGO INCLUIDO";
            this.rbtnIncluido.UseVisualStyleBackColor = true;
            this.rbtnIncluido.Click += new System.EventHandler(this.rbtnIncluido_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(11, 177);
            this.txtTotalPagar.MaxLength = 0;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(106, 29);
            this.txtTotalPagar.TabIndex = 0;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // txtTarifa
            // 
            this.txtTarifa.Enabled = false;
            this.txtTarifa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifa.Location = new System.Drawing.Point(11, 113);
            this.txtTarifa.MaxLength = 0;
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.ReadOnly = true;
            this.txtTarifa.Size = new System.Drawing.Size(106, 27);
            this.txtTarifa.TabIndex = 0;
            this.txtTarifa.TabStop = false;
            this.txtTarifa.TextChanged += new System.EventHandler(this.txtTarifa_TextChanged);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(64, 267);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(106, 27);
            this.txtEfectivo.TabIndex = 4;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // txtDevuelta
            // 
            this.txtDevuelta.Enabled = false;
            this.txtDevuelta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevuelta.Location = new System.Drawing.Point(187, 267);
            this.txtDevuelta.Name = "txtDevuelta";
            this.txtDevuelta.ReadOnly = true;
            this.txtDevuelta.Size = new System.Drawing.Size(106, 27);
            this.txtDevuelta.TabIndex = 0;
            // 
            // txtMontoRecibir
            // 
            this.txtMontoRecibir.Enabled = false;
            this.txtMontoRecibir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoRecibir.Location = new System.Drawing.Point(212, 177);
            this.txtMontoRecibir.MaxLength = 0;
            this.txtMontoRecibir.Name = "txtMontoRecibir";
            this.txtMontoRecibir.ReadOnly = true;
            this.txtMontoRecibir.Size = new System.Drawing.Size(159, 34);
            this.txtMontoRecibir.TabIndex = 0;
            this.txtMontoRecibir.TabStop = false;
            this.txtMontoRecibir.TextChanged += new System.EventHandler(this.txtMontoRecibir_TextChanged);
            // 
            // txtMontoPrincipal
            // 
            this.txtMontoPrincipal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMontoPrincipal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPrincipal.Location = new System.Drawing.Point(11, 52);
            this.txtMontoPrincipal.Name = "txtMontoPrincipal";
            this.txtMontoPrincipal.Size = new System.Drawing.Size(106, 27);
            this.txtMontoPrincipal.TabIndex = 3;
            this.txtMontoPrincipal.TextChanged += new System.EventHandler(this.txtMontoPrincipal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "TOTAL A PAGAR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "EFECTIVO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(209, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "DEVUELTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "MONTO A RECIBIR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "TARIFA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "MONTO A ENVIAR";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtCedula);
            this.groupBox3.Controls.Add(this.txtApellidoRemitente);
            this.groupBox3.Controls.Add(this.txtNombreRemitente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(484, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 230);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DEL REMITENTE";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(6, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 25);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(9, 109);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(168, 25);
            this.txtCedula.TabIndex = 7;
            // 
            // txtApellidoRemitente
            // 
            this.txtApellidoRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoRemitente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoRemitente.Location = new System.Drawing.Point(196, 52);
            this.txtApellidoRemitente.Name = "txtApellidoRemitente";
            this.txtApellidoRemitente.Size = new System.Drawing.Size(186, 25);
            this.txtApellidoRemitente.TabIndex = 6;
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreRemitente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRemitente.Location = new System.Drawing.Point(11, 52);
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.Size = new System.Drawing.Size(166, 25);
            this.txtNombreRemitente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "CEDULA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "APELLIDOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "NUMERO DE TELEFONO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "NOMBRE";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.txtApellidoBeneficiario);
            this.groupBox4.Controls.Add(this.txtNombreBeneficiario);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(484, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 104);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DATOS DEL BENEFICIARIO";
            // 
            // txtApellidoBeneficiario
            // 
            this.txtApellidoBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoBeneficiario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoBeneficiario.Location = new System.Drawing.Point(192, 52);
            this.txtApellidoBeneficiario.Name = "txtApellidoBeneficiario";
            this.txtApellidoBeneficiario.Size = new System.Drawing.Size(190, 25);
            this.txtApellidoBeneficiario.TabIndex = 10;
            // 
            // txtNombreBeneficiario
            // 
            this.txtNombreBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBeneficiario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBeneficiario.Location = new System.Drawing.Point(11, 52);
            this.txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            this.txtNombreBeneficiario.Size = new System.Drawing.Size(166, 25);
            this.txtNombreBeneficiario.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "APELLIDOS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "NOMBRE";
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(755, 439);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(146, 43);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 44);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1163, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 34);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "ENVIO DE DINERO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(928, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(704, 442);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1208, 528);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gboEnvio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENVIO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEnvio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboEnvio.ResumeLayout(false);
            this.gboEnvio.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboEnvio;
        private System.Windows.Forms.TextBox txtMontoPrincipal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnIncluido;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtMontoRecibir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidoRemitente;
        private System.Windows.Forms.TextBox txtNombreRemitente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombreBeneficiario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellidoBeneficiario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.RadioButton rbtnAparte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtDevuelta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}