
namespace Presentacion
{
    partial class FrmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtmRegistrarProveedor = new System.Windows.Forms.Button();
            this.BtmCancelar = new System.Windows.Forms.Button();
            this.BtmFinlizar = new System.Windows.Forms.Button();
            this.BtmAñadirProducto = new System.Windows.Forms.Button();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtNITProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.rtxtPresentacion = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btmBuscarProveedor = new System.Windows.Forms.Button();
            this.eP_Proveedor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbProveedor.SuspendLayout();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_Proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 295);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // BtmRegistrarProveedor
            // 
            this.BtmRegistrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.BtmRegistrarProveedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtmRegistrarProveedor.FlatAppearance.BorderSize = 0;
            this.BtmRegistrarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.BtmRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmRegistrarProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtmRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.BtmRegistrarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("BtmRegistrarProveedor.Image")));
            this.BtmRegistrarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtmRegistrarProveedor.Location = new System.Drawing.Point(757, 51);
            this.BtmRegistrarProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmRegistrarProveedor.Name = "BtmRegistrarProveedor";
            this.BtmRegistrarProveedor.Size = new System.Drawing.Size(168, 53);
            this.BtmRegistrarProveedor.TabIndex = 32;
            this.BtmRegistrarProveedor.Text = "Registrar";
            this.BtmRegistrarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtmRegistrarProveedor.UseVisualStyleBackColor = false;
            this.BtmRegistrarProveedor.Click += new System.EventHandler(this.BtmRegistrarProveedor_Click);
            // 
            // BtmCancelar
            // 
            this.BtmCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.BtmCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtmCancelar.FlatAppearance.BorderSize = 0;
            this.BtmCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.BtmCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtmCancelar.ForeColor = System.Drawing.Color.White;
            this.BtmCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtmCancelar.Image")));
            this.BtmCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtmCancelar.Location = new System.Drawing.Point(855, 653);
            this.BtmCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmCancelar.Name = "BtmCancelar";
            this.BtmCancelar.Size = new System.Drawing.Size(115, 57);
            this.BtmCancelar.TabIndex = 33;
            this.BtmCancelar.Text = "Cancelar";
            this.BtmCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtmCancelar.UseVisualStyleBackColor = false;
            this.BtmCancelar.Click += new System.EventHandler(this.BtmCancelar_Click);
            // 
            // BtmFinlizar
            // 
            this.BtmFinlizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.BtmFinlizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtmFinlizar.FlatAppearance.BorderSize = 0;
            this.BtmFinlizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.BtmFinlizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmFinlizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtmFinlizar.ForeColor = System.Drawing.Color.White;
            this.BtmFinlizar.Image = ((System.Drawing.Image)(resources.GetObject("BtmFinlizar.Image")));
            this.BtmFinlizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtmFinlizar.Location = new System.Drawing.Point(727, 653);
            this.BtmFinlizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmFinlizar.Name = "BtmFinlizar";
            this.BtmFinlizar.Size = new System.Drawing.Size(121, 57);
            this.BtmFinlizar.TabIndex = 34;
            this.BtmFinlizar.Text = "Finalizar";
            this.BtmFinlizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtmFinlizar.UseVisualStyleBackColor = false;
            this.BtmFinlizar.Click += new System.EventHandler(this.BtmFinlizar_Click);
            // 
            // BtmAñadirProducto
            // 
            this.BtmAñadirProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.BtmAñadirProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtmAñadirProducto.FlatAppearance.BorderSize = 0;
            this.BtmAñadirProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.BtmAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmAñadirProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtmAñadirProducto.ForeColor = System.Drawing.Color.White;
            this.BtmAñadirProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtmAñadirProducto.Image")));
            this.BtmAñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtmAñadirProducto.Location = new System.Drawing.Point(757, 377);
            this.BtmAñadirProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtmAñadirProducto.Name = "BtmAñadirProducto";
            this.BtmAñadirProducto.Size = new System.Drawing.Size(168, 59);
            this.BtmAñadirProducto.TabIndex = 35;
            this.BtmAñadirProducto.Text = "Añadir producto";
            this.BtmAñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtmAñadirProducto.UseVisualStyleBackColor = false;
            this.BtmAñadirProducto.Click += new System.EventHandler(this.BtmAñadirProducto_Click);
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.txtDireccionProveedor);
            this.gbProveedor.Controls.Add(this.txtTelefonoProveedor);
            this.gbProveedor.Controls.Add(this.txtRazonSocialProveedor);
            this.gbProveedor.Controls.Add(this.txtNombreProveedor);
            this.gbProveedor.Controls.Add(this.txtNITProveedor);
            this.gbProveedor.Controls.Add(this.label6);
            this.gbProveedor.Controls.Add(this.label5);
            this.gbProveedor.Controls.Add(this.label4);
            this.gbProveedor.Controls.Add(this.label3);
            this.gbProveedor.Controls.Add(this.label1);
            this.gbProveedor.Controls.Add(this.label2);
            this.gbProveedor.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbProveedor.Location = new System.Drawing.Point(21, 28);
            this.gbProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProveedor.Size = new System.Drawing.Size(688, 259);
            this.gbProveedor.TabIndex = 38;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Proveedor";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDireccionProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccionProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtDireccionProveedor.Location = new System.Drawing.Point(486, 48);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(157, 27);
            this.txtDireccionProveedor.TabIndex = 23;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(168, 192);
            this.txtTelefonoProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(170, 27);
            this.txtTelefonoProveedor.TabIndex = 22;
            // 
            // txtRazonSocialProveedor
            // 
            this.txtRazonSocialProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRazonSocialProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazonSocialProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtRazonSocialProveedor.Location = new System.Drawing.Point(486, 112);
            this.txtRazonSocialProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazonSocialProveedor.Name = "txtRazonSocialProveedor";
            this.txtRazonSocialProveedor.Size = new System.Drawing.Size(157, 27);
            this.txtRazonSocialProveedor.TabIndex = 21;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtNombreProveedor.Location = new System.Drawing.Point(168, 116);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(170, 27);
            this.txtNombreProveedor.TabIndex = 20;
            // 
            // txtNITProveedor
            // 
            this.txtNITProveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNITProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNITProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtNITProveedor.Location = new System.Drawing.Point(168, 48);
            this.txtNITProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNITProveedor.Name = "txtNITProveedor";
            this.txtNITProveedor.Size = new System.Drawing.Size(170, 27);
            this.txtNITProveedor.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(393, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Razon Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(77, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(393, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(77, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "NIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(77, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Proveedor";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label7);
            this.gbProducto.Controls.Add(this.nudCantidad);
            this.gbProducto.Controls.Add(this.cmbCategoriaProducto);
            this.gbProducto.Controls.Add(this.rtxtPresentacion);
            this.gbProducto.Controls.Add(this.label13);
            this.gbProducto.Controls.Add(this.label14);
            this.gbProducto.Controls.Add(this.label11);
            this.gbProducto.Controls.Add(this.txtPrecioProducto);
            this.gbProducto.Controls.Add(this.label10);
            this.gbProducto.Controls.Add(this.txtCostoProducto);
            this.gbProducto.Controls.Add(this.label9);
            this.gbProducto.Controls.Add(this.txtNombreProducto);
            this.gbProducto.Controls.Add(this.label8);
            this.gbProducto.Location = new System.Drawing.Point(21, 359);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProducto.Size = new System.Drawing.Size(688, 380);
            this.gbProducto.TabIndex = 39;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "groupBox2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(391, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.nudCantidad.Location = new System.Drawing.Point(496, 195);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(158, 27);
            this.nudCantidad.TabIndex = 49;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.cmbCategoriaProducto.FormattingEnabled = true;
            this.cmbCategoriaProducto.Items.AddRange(new object[] {
            "Pulpa",
            "Zumo",
            "Nectar"});
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(178, 123);
            this.cmbCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            this.cmbCategoriaProducto.Size = new System.Drawing.Size(170, 28);
            this.cmbCategoriaProducto.TabIndex = 48;
            // 
            // rtxtPresentacion
            // 
            this.rtxtPresentacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxtPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.rtxtPresentacion.Location = new System.Drawing.Point(178, 205);
            this.rtxtPresentacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtPresentacion.Name = "rtxtPresentacion";
            this.rtxtPresentacion.Size = new System.Drawing.Size(170, 135);
            this.rtxtPresentacion.TabIndex = 47;
            this.rtxtPresentacion.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label13.Location = new System.Drawing.Point(10, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 30);
            this.label13.TabIndex = 46;
            this.label13.Text = "Regitro de Productos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label14.Location = new System.Drawing.Point(73, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Presentacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label11.Location = new System.Drawing.Point(73, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Categoria";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrecioProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtPrecioProducto.Location = new System.Drawing.Point(496, 123);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(157, 27);
            this.txtPrecioProducto.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label10.Location = new System.Drawing.Point(391, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Precio unitario";
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCostoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtCostoProducto.Location = new System.Drawing.Point(496, 51);
            this.txtCostoProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(157, 27);
            this.txtCostoProducto.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label9.Location = new System.Drawing.Point(391, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Costo";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(178, 51);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(170, 27);
            this.txtNombreProducto.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label8.Location = new System.Drawing.Point(73, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nombre";
            // 
            // btmBuscarProveedor
            // 
            this.btmBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.btmBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btmBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btmBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.btmBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmBuscarProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btmBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btmBuscarProveedor.Image")));
            this.btmBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBuscarProveedor.Location = new System.Drawing.Point(757, 152);
            this.btmBuscarProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btmBuscarProveedor.Name = "btmBuscarProveedor";
            this.btmBuscarProveedor.Size = new System.Drawing.Size(168, 53);
            this.btmBuscarProveedor.TabIndex = 40;
            this.btmBuscarProveedor.Text = "Consultar";
            this.btmBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmBuscarProveedor.UseVisualStyleBackColor = false;
            this.btmBuscarProveedor.Click += new System.EventHandler(this.btmBuscarProveedor_Click);
            // 
            // eP_Proveedor
            // 
            this.eP_Proveedor.ContainerControl = this;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 755);
            this.Controls.Add(this.btmBuscarProveedor);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbProveedor);
            this.Controls.Add(this.BtmAñadirProducto);
            this.Controls.Add(this.BtmFinlizar);
            this.Controls.Add(this.BtmCancelar);
            this.Controls.Add(this.BtmRegistrarProveedor);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP_Proveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtmRegistrarProveedor;
        private System.Windows.Forms.Button BtmCancelar;
        private System.Windows.Forms.Button BtmFinlizar;
        private System.Windows.Forms.Button BtmAñadirProducto;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtRazonSocialProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtNITProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbCategoriaProducto;
        private System.Windows.Forms.RichTextBox rtxtPresentacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btmBuscarProveedor;
        private System.Windows.Forms.ErrorProvider eP_Proveedor;
    }
}