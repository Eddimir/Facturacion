namespace Proyecto1.Facturas
{
    partial class Cotizaciones
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
            this.dtgvVer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVer
            // 
            this.dtgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVer.Location = new System.Drawing.Point(12, 60);
            this.dtgvVer.Name = "dtgvVer";
            this.dtgvVer.Size = new System.Drawing.Size(830, 378);
            this.dtgvVer.TabIndex = 0;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.dtgvVer);
            this.Name = "Cotizaciones";
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.Cotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVer;
    }
}