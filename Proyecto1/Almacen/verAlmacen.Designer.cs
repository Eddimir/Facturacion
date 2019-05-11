namespace Proyecto1.Almacen
{
    partial class verAlmacen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btlseleccionar = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dtgvVer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 360);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 37);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btlseleccionar
            // 
            this.btlseleccionar.Location = new System.Drawing.Point(775, 360);
            this.btlseleccionar.Name = "btlseleccionar";
            this.btlseleccionar.Size = new System.Drawing.Size(89, 37);
            this.btlseleccionar.TabIndex = 13;
            this.btlseleccionar.Text = "Seleccionar";
            this.btlseleccionar.UseVisualStyleBackColor = true;
            this.btlseleccionar.Click += new System.EventHandler(this.Btlseleccionar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(111, 20);
            this.txtbusqueda.TabIndex = 12;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.Txtbusqueda_TextChanged);
            // 
            // dtgvVer
            // 
            this.dtgvVer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVer.Location = new System.Drawing.Point(12, 38);
            this.dtgvVer.Name = "dtgvVer";
            this.dtgvVer.Size = new System.Drawing.Size(852, 316);
            this.dtgvVer.TabIndex = 11;
            // 
            // verAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btlseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.dtgvVer);
            this.Name = "verAlmacen";
            this.Text = "verAlmacen";
            this.Load += new System.EventHandler(this.VerAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btlseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridView dtgvVer;
    }
}