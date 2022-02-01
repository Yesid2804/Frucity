namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtmIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtmMinimizar = new System.Windows.Forms.PictureBox();
            this.BtmSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LinkLblContraseña = new System.Windows.Forms.LinkLabel();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtmMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtmSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // BtmIngresar
            // 
            this.BtmIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.BtmIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmIngresar.FlatAppearance.BorderSize = 0;
            this.BtmIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtmIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtmIngresar.ForeColor = System.Drawing.Color.White;
            this.BtmIngresar.Location = new System.Drawing.Point(66, 297);
            this.BtmIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmIngresar.Name = "BtmIngresar";
            this.BtmIngresar.Size = new System.Drawing.Size(202, 39);
            this.BtmIngresar.TabIndex = 0;
            this.BtmIngresar.Text = "Iniciar Sesión";
            this.BtmIngresar.UseVisualStyleBackColor = false;
            this.BtmIngresar.Click += new System.EventHandler(this.BtmIngresar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsuario.Location = new System.Drawing.Point(66, 199);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(202, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtContraseña.Location = new System.Drawing.Point(66, 249);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(202, 20);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtmMinimizar
            // 
            this.BtmMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtmMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtmMinimizar.Image")));
            this.BtmMinimizar.Location = new System.Drawing.Point(423, 16);
            this.BtmMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmMinimizar.Name = "BtmMinimizar";
            this.BtmMinimizar.Size = new System.Drawing.Size(37, 24);
            this.BtmMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtmMinimizar.TabIndex = 4;
            this.BtmMinimizar.TabStop = false;
            this.BtmMinimizar.Click += new System.EventHandler(this.BtmMinimizar_Click);
            // 
            // BtmSalir
            // 
            this.BtmSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtmSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtmSalir.Image")));
            this.BtmSalir.Location = new System.Drawing.Point(455, 16);
            this.BtmSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmSalir.Name = "BtmSalir";
            this.BtmSalir.Size = new System.Drawing.Size(37, 24);
            this.BtmSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtmSalir.TabIndex = 5;
            this.BtmSalir.TabStop = false;
            this.BtmSalir.Click += new System.EventHandler(this.BtmSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LinkLblContraseña);
            this.panel1.Controls.Add(this.BtmIngresar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(77, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 411);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(51, 265);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 13);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 215);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 13);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // LinkLblContraseña
            // 
            this.LinkLblContraseña.AutoSize = true;
            this.LinkLblContraseña.Location = new System.Drawing.Point(91, 352);
            this.LinkLblContraseña.Name = "LinkLblContraseña";
            this.LinkLblContraseña.Size = new System.Drawing.Size(178, 20);
            this.LinkLblContraseña.TabIndex = 4;
            this.LinkLblContraseña.TabStop = true;
            this.LinkLblContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(505, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtmSalir);
            this.Controls.Add(this.BtmMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtmMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtmSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtmIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtmMinimizar;
        private System.Windows.Forms.PictureBox BtmSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LinkLblContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
    }
}