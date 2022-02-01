
namespace Presentacion
{
    partial class FrmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtmBuscar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbCod_Name = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(74, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filtro";
            // 
            // BtmBuscar
            // 
            this.BtmBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtmBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtmBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtmBuscar.FlatAppearance.BorderSize = 0;
            this.BtmBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.BtmBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtmBuscar.ForeColor = System.Drawing.Color.White;
            this.BtmBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtmBuscar.Image")));
            this.BtmBuscar.Location = new System.Drawing.Point(742, 64);
            this.BtmBuscar.Name = "BtmBuscar";
            this.BtmBuscar.Size = new System.Drawing.Size(38, 38);
            this.BtmBuscar.TabIndex = 13;
            this.BtmBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtmBuscar.UseVisualStyleBackColor = false;
            this.BtmBuscar.Click += new System.EventHandler(this.BtmBuscar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.ColumnHeadersHeight = 30;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsulta.EnableHeadersVisualStyles = false;
            this.dgvConsulta.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvConsulta.Location = new System.Drawing.Point(27, 22);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsulta.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.dgvConsulta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsulta.RowTemplate.Height = 25;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(603, 377);
            this.dgvConsulta.TabIndex = 12;
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtConsulta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtConsulta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.TxtConsulta.Location = new System.Drawing.Point(415, 74);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(303, 25);
            this.TxtConsulta.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Proveedores",
            "Clientes"});
            this.cmbTipo.Location = new System.Drawing.Point(127, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(113, 25);
            this.cmbTipo.TabIndex = 15;
            // 
            // cmbCod_Name
            // 
            this.cmbCod_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbCod_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCod_Name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCod_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.cmbCod_Name.FormattingEnabled = true;
            this.cmbCod_Name.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cmbCod_Name.Location = new System.Drawing.Point(264, 74);
            this.cmbCod_Name.Name = "cmbCod_Name";
            this.cmbCod_Name.Size = new System.Drawing.Size(127, 25);
            this.cmbCod_Name.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvConsulta);
            this.groupBox1.Location = new System.Drawing.Point(127, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 405);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCod_Name);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtmBuscar);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtmBuscar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbCod_Name;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}