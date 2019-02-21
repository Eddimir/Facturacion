namespace Proyecto1.OrdenCompra
{
    partial class ListarOrdenCompra
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbldetalles = new System.Windows.Forms.Label();
            this.dtgvDetalle = new System.Windows.Forms.DataGridView();
            this.dtgvMaestro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 459);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(48, 456);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ver Todo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbldetalles
            // 
            this.lbldetalles.AutoSize = true;
            this.lbldetalles.Location = new System.Drawing.Point(12, 205);
            this.lbldetalles.Name = "lbldetalles";
            this.lbldetalles.Size = new System.Drawing.Size(45, 13);
            this.lbldetalles.TabIndex = 7;
            this.lbldetalles.Text = "Detalles";
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.Location = new System.Drawing.Point(12, 221);
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.Size = new System.Drawing.Size(827, 226);
            this.dtgvDetalle.TabIndex = 5;
            // 
            // dtgvMaestro
            // 
            this.dtgvMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaestro.Location = new System.Drawing.Point(12, 12);
            this.dtgvMaestro.Name = "dtgvMaestro";
            this.dtgvMaestro.Size = new System.Drawing.Size(827, 174);
            this.dtgvMaestro.TabIndex = 6;
            // 
            // ListarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 489);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldetalles);
            this.Controls.Add(this.dtgvDetalle);
            this.Controls.Add(this.dtgvMaestro);
            this.Name = "ListarOrdenCompra";
            this.Text = "ListarOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldetalles;
        private System.Windows.Forms.DataGridView dtgvDetalle;
        private System.Windows.Forms.DataGridView dtgvMaestro;
    }
}