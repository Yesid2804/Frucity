
namespace Presentacion
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtCountVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumVentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountCotizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSumCotizacion = new System.Windows.Forms.TextBox();
            this.BtmBuscarReportes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.gbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportes";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Ventas",
            "Cotizaciones"});
            this.cmbFiltro.Location = new System.Drawing.Point(268, 65);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(185, 23);
            this.cmbFiltro.TabIndex = 2;
            // 
            // txtCountVenta
            // 
            this.txtCountVenta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCountVenta.Enabled = false;
            this.txtCountVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtCountVenta.Location = new System.Drawing.Point(42, 19);
            this.txtCountVenta.Name = "txtCountVenta";
            this.txtCountVenta.ReadOnly = true;
            this.txtCountVenta.Size = new System.Drawing.Size(112, 23);
            this.txtCountVenta.TabIndex = 5;
            this.txtCountVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(76, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(374, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Ventas";
            // 
            // txtSumVentas
            // 
            this.txtSumVentas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSumVentas.Enabled = false;
            this.txtSumVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtSumVentas.Location = new System.Drawing.Point(358, 19);
            this.txtSumVentas.Name = "txtSumVentas";
            this.txtSumVentas.ReadOnly = true;
            this.txtSumVentas.Size = new System.Drawing.Size(112, 23);
            this.txtSumVentas.TabIndex = 7;
            this.txtSumVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(216, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cotizaciones";
            // 
            // txtCountCotizacion
            // 
            this.txtCountCotizacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCountCotizacion.Enabled = false;
            this.txtCountCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtCountCotizacion.Location = new System.Drawing.Point(200, 19);
            this.txtCountCotizacion.Name = "txtCountCotizacion";
            this.txtCountCotizacion.ReadOnly = true;
            this.txtCountCotizacion.Size = new System.Drawing.Size(112, 23);
            this.txtCountCotizacion.TabIndex = 9;
            this.txtCountCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(522, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Cotizaciones";
            // 
            // txtSumCotizacion
            // 
            this.txtSumCotizacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSumCotizacion.Enabled = false;
            this.txtSumCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.txtSumCotizacion.Location = new System.Drawing.Point(516, 19);
            this.txtSumCotizacion.Name = "txtSumCotizacion";
            this.txtSumCotizacion.ReadOnly = true;
            this.txtSumCotizacion.Size = new System.Drawing.Size(112, 23);
            this.txtSumCotizacion.TabIndex = 11;
            this.txtSumCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtmBuscarReportes
            // 
            this.BtmBuscarReportes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtmBuscarReportes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtmBuscarReportes.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtmBuscarReportes.FlatAppearance.BorderSize = 0;
            this.BtmBuscarReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.BtmBuscarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmBuscarReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtmBuscarReportes.ForeColor = System.Drawing.Color.White;
            this.BtmBuscarReportes.Image = ((System.Drawing.Image)(resources.GetObject("BtmBuscarReportes.Image")));
            this.BtmBuscarReportes.Location = new System.Drawing.Point(722, 59);
            this.BtmBuscarReportes.Name = "BtmBuscarReportes";
            this.BtmBuscarReportes.Size = new System.Drawing.Size(38, 38);
            this.BtmBuscarReportes.TabIndex = 15;
            this.BtmBuscarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtmBuscarReportes.UseVisualStyleBackColor = false;
            this.BtmBuscarReportes.Click += new System.EventHandler(this.BtmBuscarReportes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(218, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReportes);
            this.groupBox1.Location = new System.Drawing.Point(99, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 329);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dgvReportes
            // 
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReportes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportes.ColumnHeadersHeight = 30;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportes.EnableHeadersVisualStyles = false;
            this.dgvReportes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReportes.Location = new System.Drawing.Point(25, 22);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReportes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportes.RowTemplate.Height = 25;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(630, 301);
            this.dgvReportes.TabIndex = 12;
            // 
            // gbTotales
            // 
            this.gbTotales.Controls.Add(this.label5);
            this.gbTotales.Controls.Add(this.txtSumCotizacion);
            this.gbTotales.Controls.Add(this.label4);
            this.gbTotales.Controls.Add(this.txtCountCotizacion);
            this.gbTotales.Controls.Add(this.label3);
            this.gbTotales.Controls.Add(this.txtSumVentas);
            this.gbTotales.Controls.Add(this.label2);
            this.gbTotales.Controls.Add(this.txtCountVenta);
            this.gbTotales.Location = new System.Drawing.Point(99, 445);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(661, 72);
            this.gbTotales.TabIndex = 19;
            this.gbTotales.TabStop = false;
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.dtpFechaReporte.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpFechaReporte.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(117)))));
            this.dtpFechaReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dtpFechaReporte.Location = new System.Drawing.Point(473, 65);
            this.dtpFechaReporte.MaxDate = new System.DateTime(3045, 1, 1, 0, 0, 0, 0);
            this.dtpFechaReporte.MinDate = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(230, 24);
            this.dtpFechaReporte.TabIndex = 20;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 566);
            this.Controls.Add(this.dtpFechaReporte);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtmBuscarReportes);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtCountVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountCotizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSumCotizacion;
        private System.Windows.Forms.Button BtmBuscarReportes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.GroupBox gbTotales;
        private System.Windows.Forms.DateTimePicker dtpFechaReporte;
    }
}