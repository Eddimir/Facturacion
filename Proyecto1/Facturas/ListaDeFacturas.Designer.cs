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
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtobservaciones = new System.Windows.Forms.RichTextBox();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.txtrazonnula = new System.Windows.Forms.RichTextBox();
            this.lblrazonnula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMaestro
            // 
            this.dtgvMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaestro.Location = new System.Drawing.Point(12, 21);
            this.dtgvMaestro.Name = "dtgvMaestro";
            this.dtgvMaestro.Size = new System.Drawing.Size(827, 207);
            this.dtgvMaestro.TabIndex = 0;
            this.dtgvMaestro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMaestro_CellClick);
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.Location = new System.Drawing.Point(12, 249);
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.Size = new System.Drawing.Size(827, 236);
            this.dtgvDetalle.TabIndex = 0;
            // 
            // lbldetalles
            // 
            this.lbldetalles.AutoSize = true;
            this.lbldetalles.Location = new System.Drawing.Point(12, 231);
            this.lbldetalles.Name = "lbldetalles";
            this.lbldetalles.Size = new System.Drawing.Size(52, 15);
            this.lbldetalles.TabIndex = 1;
            this.lbldetalles.Text = "Detalles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(48, 491);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(845, 200);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(845, 39);
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(155, 155);
            this.txtobservaciones.TabIndex = 6;
            this.txtobservaciones.Text = "";
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.Location = new System.Drawing.Point(842, 21);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(88, 15);
            this.lblobservaciones.TabIndex = 7;
            this.lblobservaciones.Text = "Observaciones";
            // 
            // txtrazonnula
            // 
            this.txtrazonnula.Location = new System.Drawing.Point(842, 267);
            this.txtrazonnula.Name = "txtrazonnula";
            this.txtrazonnula.Size = new System.Drawing.Size(155, 218);
            this.txtrazonnula.TabIndex = 8;
            this.txtrazonnula.Text = "";
            // 
            // lblrazonnula
            // 
            this.lblrazonnula.AutoSize = true;
            this.lblrazonnula.Location = new System.Drawing.Point(842, 249);
            this.lblrazonnula.Name = "lblrazonnula";
            this.lblrazonnula.Size = new System.Drawing.Size(70, 15);
            this.lblrazonnula.TabIndex = 9;
            this.lblrazonnula.Text = "Razon nula";
            // 
            // ListaDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 522);
            this.Controls.Add(this.lblrazonnula);
            this.Controls.Add(this.txtrazonnula);
            this.Controls.Add(this.lblobservaciones);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.btnAnular);
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
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.RichTextBox txtobservaciones;
        private System.Windows.Forms.Label lblobservaciones;
        private System.Windows.Forms.RichTextBox txtrazonnula;
        private System.Windows.Forms.Label lblrazonnula;
    }
}