
namespace Presentacion
{
    partial class FrmInicio
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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Deansgate Condensed", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(226, 188);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(214, 89);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "label3";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Deansgate Condensed", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFecha.Location = new System.Drawing.Point(184, 292);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 50);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "label1";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 566);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
    }
}