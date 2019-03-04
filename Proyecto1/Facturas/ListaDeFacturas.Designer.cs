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
            this.button1 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtobservaciones = new System.Windows.Forms.RichTextBox();
            this.grpObservaciones = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            this.grpObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMaestro
            // 
            this.dtgvMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMaestro.Location = new System.Drawing.Point(12, 21);
            this.dtgvMaestro.Name = "dtgvMaestro";
            this.dtgvMaestro.Size = new System.Drawing.Size(827, 188);
            this.dtgvMaestro.TabIndex = 0;
            this.dtgvMaestro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMaestro_CellClick);
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.Location = new System.Drawing.Point(12, 306);
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.Size = new System.Drawing.Size(827, 264);
            this.dtgvDetalle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(77, 582);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(9, 578);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(509, 248);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtobservaciones.Location = new System.Drawing.Point(3, 16);
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(485, 66);
            this.txtobservaciones.TabIndex = 6;
            this.txtobservaciones.Text = "";
            // 
            // grpObservaciones
            // 
            this.grpObservaciones.Controls.Add(this.txtobservaciones);
            this.grpObservaciones.Location = new System.Drawing.Point(12, 215);
            this.grpObservaciones.Name = "grpObservaciones";
            this.grpObservaciones.Size = new System.Drawing.Size(491, 85);
            this.grpObservaciones.TabIndex = 8;
            this.grpObservaciones.TabStop = false;
            this.grpObservaciones.Text = "Observaciones";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(509, 277);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // ListaDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 614);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grpObservaciones);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvDetalle);
            this.Controls.Add(this.dtgvMaestro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListaDeFacturas";
            this.Text = "ListaDeFacturas";
            this.Load += new System.EventHandler(this.ListaDeFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).EndInit();
            this.grpObservaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMaestro;
        private System.Windows.Forms.DataGridView dtgvDetalle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.RichTextBox txtobservaciones;
        private System.Windows.Forms.GroupBox grpObservaciones;
        private System.Windows.Forms.Button btnPagar;
    }
}