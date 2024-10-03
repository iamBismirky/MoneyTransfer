namespace MoneyTransfer
{
    partial class frmCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCambiarClave = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmar Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nueva Contraseña";
            // 
            // txtCambiarClave
            // 
            this.txtCambiarClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambiarClave.Location = new System.Drawing.Point(178, 107);
            this.txtCambiarClave.Name = "txtCambiarClave";
            this.txtCambiarClave.PasswordChar = '*';
            this.txtCambiarClave.Size = new System.Drawing.Size(147, 23);
            this.txtCambiarClave.TabIndex = 0;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(178, 136);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(147, 23);
            this.txtConfirmarClave.TabIndex = 2;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.BackColor = System.Drawing.SystemColors.Window;
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarClave.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarClave.Location = new System.Drawing.Point(178, 192);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(147, 31);
            this.btnCambiarClave.TabIndex = 3;
            this.btnCambiarClave.Text = "Cambiar Contraseña";
            this.btnCambiarClave.UseVisualStyleBackColor = false;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(34, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 31);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(326, 12);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(32, 32);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbCerrar.TabIndex = 5;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(178, 52);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(147, 23);
            this.txtClave.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contraseña Actual";
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(370, 235);
            this.Controls.Add(this.ptbCerrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCambiarClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarContraseña";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCambiarClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
    }
}