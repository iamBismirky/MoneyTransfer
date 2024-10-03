namespace MoneyTransfer
{
    partial class frmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCambiarContraseña = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(20, 11);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(60, 17);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // lblCambiarContraseña
            // 
            this.lblCambiarContraseña.AutoSize = true;
            this.lblCambiarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambiarContraseña.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContraseña.Location = new System.Drawing.Point(83, 105);
            this.lblCambiarContraseña.Name = "lblCambiarContraseña";
            this.lblCambiarContraseña.Size = new System.Drawing.Size(132, 17);
            this.lblCambiarContraseña.TabIndex = 0;
            this.lblCambiarContraseña.Text = "Cambiar contraseña";
            this.lblCambiarContraseña.Click += new System.EventHandler(this.lblCambiarContraseña_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(20, 43);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(327, 1);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(42, 34);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbCerrar.TabIndex = 1;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblCambiarContraseña);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(142, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 131);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.SystemColors.Window;
            this.btnCerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(259, 192);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(98, 23);
            this.btnCerrarAplicacion.TabIndex = 1;
            this.btnCerrarAplicacion.Text = "Cerrar Aplicacion";
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.btnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(142, 192);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(98, 23);
            this.btnCambiarUsuario.TabIndex = 1;
            this.btnCambiarUsuario.Text = "Cambiar Usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = false;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(370, 235);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Controls.Add(this.btnCerrarAplicacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptbCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblCambiarContraseña;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.Button btnCambiarUsuario;
    }
}