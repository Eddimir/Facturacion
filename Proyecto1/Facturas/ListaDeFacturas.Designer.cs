namespace Proyecto1.Facturas
{
    partial class ListaDeFacturas
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
            this.dtgvMaestro = new System.Windows.Forms.DataGridView();
            this.dtgvDetalle = new System.Windows.Forms.DataGridView();
            this.lbldetalles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMaestro
            // 
            this.dtgvMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaestro.Location = new System.Drawing.Point(12, 28);
            this.dtgvMaestro.Name = "dtgvMaestro";
            this.dtgvMaestro.Size = new System.Drawing.Size(827, 174);
            this.dtgvMaestro.TabIndex = 0;
            this.dtgvMaestro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMaestro_CellClick);
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.Location = new System.Drawing.Point(12, 237);
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.Size = new System.Drawing.Size(827, 226);
            this.dtgvDetalle.TabIndex = 0;
            // 
            // lbldetalles
            // 
            this.lbldetalles.AutoSize = true;
            this.lbldetalles.Location = new System.Drawing.Point(12, 221);
            this.lbldetalles.Name = "lbldetalles";
            this.lbldetalles.Size = new System.Drawing.Size(52, 15);
            this.lbldetalles.TabIndex = 1;
            this.lbldetalles.Text = "Detalles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(48, 472);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // ListaDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 508);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldetalles);
            this.Controls.Add(this.dtgvDetalle);
            this.Controls.Add(this.dtgvMaestro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListaDeFacturas";
            this.Text = "ListaDeFacturas";
            this.Load += new System.EventHandler(this.ListaDeFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMaestro;
        private System.Windows.Forms.DataGridView dtgvDetalle;
        private System.Windows.Forms.Label lbldetalles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblTotal;
    }
}