namespace MoneyTransfer
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDivisa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.btnRecibirPaquete = new System.Windows.Forms.Button();
            this.btnEnvioPaquete = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money Transfer and Package";
            // 
            // btnDivisa
            // 
            this.btnDivisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivisa.BackColor = System.Drawing.Color.DarkGray;
            this.btnDivisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDivisa.Image = ((System.Drawing.Image)(resources.GetObject("btnDivisa.Image")));
            this.btnDivisa.Location = new System.Drawing.Point(258, 16);
            this.btnDivisa.Name = "btnDivisa";
            this.btnDivisa.Size = new System.Drawing.Size(117, 113);
            this.btnDivisa.TabIndex = 2;
            this.btnDivisa.Text = "Divisas";
            this.btnDivisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDivisa.UseVisualStyleBackColor = false;
            this.btnDivisa.Click += new System.EventHandler(this.btnDivisa_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(135, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 113);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pago Dinero";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnvio
            // 
            this.btnEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnvio.BackColor = System.Drawing.Color.Teal;
            this.btnEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvio.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEnvio.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvio.Image")));
            this.btnEnvio.Location = new System.Drawing.Point(13, 16);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(116, 113);
            this.btnEnvio.TabIndex = 0;
            this.btnEnvio.Text = "Enviar Dinero";
            this.btnEnvio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnvio.UseVisualStyleBackColor = false;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // btnRecibirPaquete
            // 
            this.btnRecibirPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecibirPaquete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRecibirPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecibirPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibirPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirPaquete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibirPaquete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecibirPaquete.Image = ((System.Drawing.Image)(resources.GetObject("btnRecibirPaquete.Image")));
            this.btnRecibirPaquete.Location = new System.Drawing.Point(135, 12);
            this.btnRecibirPaquete.Name = "btnRecibirPaquete";
            this.btnRecibirPaquete.Size = new System.Drawing.Size(116, 113);
            this.btnRecibirPaquete.TabIndex = 1;
            this.btnRecibirPaquete.Text = "Recibir";
            this.btnRecibirPaquete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecibirPaquete.UseVisualStyleBackColor = false;
            this.btnRecibirPaquete.Click += new System.EventHandler(this.btnRecibirPaquete_Click);
            // 
            // btnEnvioPaquete
            // 
            this.btnEnvioPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnvioPaquete.BackColor = System.Drawing.Color.Gold;
            this.btnEnvioPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvioPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvioPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvioPaquete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvioPaquete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnvioPaquete.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvioPaquete.Image")));
            this.btnEnvioPaquete.Location = new System.Drawing.Point(13, 12);
            this.btnEnvioPaquete.Name = "btnEnvioPaquete";
            this.btnEnvioPaquete.Size = new System.Drawing.Size(116, 113);
            this.btnEnvioPaquete.TabIndex = 0;
            this.btnEnvioPaquete.Text = "Enviar ";
            this.btnEnvioPaquete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnvioPaquete.UseVisualStyleBackColor = false;
            this.btnEnvioPaquete.Click += new System.EventHandler(this.btnEnvioPaquete_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(222, 2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(39, 33);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(837, 115);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(115, 111);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 30.3F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblHora.Location = new System.Drawing.Point(261, 24);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(112, 55);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFecha.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblFecha.Location = new System.Drawing.Point(213, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 37);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoEllipsis = true;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(3, 12);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(116, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MONEY TRANSFER";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnDivisa);
            this.panel1.Controls.Add(this.btnEnvio);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnRecibirPaquete);
            this.panel2.Controls.Add(this.btnEnvioPaquete);
            this.panel2.Location = new System.Drawing.Point(12, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 137);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Location = new System.Drawing.Point(566, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 119);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(440, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 144);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 48);
            this.panel5.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DINERO";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(21, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "PAQUETES";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.btnInfo);
            this.panel6.Controls.Add(this.btnPerfil);
            this.panel6.Controls.Add(this.lblNombreUsuario);
            this.panel6.Controls.Add(this.lblUserName);
            this.panel6.Location = new System.Drawing.Point(645, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 36);
            this.panel6.TabIndex = 4;
            this.panel6.TabStop = true;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(267, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 30);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(964, 455);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.Button btnDivisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnvioPaquete;
        private System.Windows.Forms.Button btnRecibirPaquete;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInfo;
    }
}

