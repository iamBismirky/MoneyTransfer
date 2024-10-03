namespace MoneyTransfer
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pbar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbar.AnimationSpeed = 500;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbar.InnerColor = System.Drawing.Color.White;
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(63, 21);
            this.pbar.MarqueeAnimationSpeed = 1000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.Transparent;
            this.pbar.OuterMargin = 0;
            this.pbar.OuterWidth = 0;
            this.pbar.ProgressColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbar.ProgressWidth = 4;
            this.pbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbar.Size = new System.Drawing.Size(252, 223);
            this.pbar.StartAngle = 270;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = ".23";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "°C";
            this.pbar.TabIndex = 1;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}