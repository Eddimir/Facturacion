namespace Proyecto1.Clientes
{
    partial class VerClientes
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
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btlseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVer
            // 
            this.dtgvVer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVer.Location = new System.Drawing.Point(12, 38);
            this.dtgvVer.Name = "dtgvVer";
            this.dtgvVer.Size = new System.Drawing.Size(852, 316);
            this.dtgvVer.TabIndex = 1;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(111, 20);
            this.txtbusqueda.TabIndex = 4;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // btlseleccionar
            // 
            this.btlseleccionar.Location = new System.Drawing.Point(775, 360);
            this.btlseleccionar.Name = "btlseleccionar";
            this.btlseleccionar.Size = new System.Drawing.Size(89, 37);
            this.btlseleccionar.TabIndex = 5;
            this.btlseleccionar.Text = "Seleccionar";
            this.btlseleccionar.UseVisualStyleBackColor = true;
            this.btlseleccionar.Click += new System.EventHandler(this.btlseleccionar_Click);
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 409);
            this.Controls.Add(this.btlseleccionar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.dtgvVer);
            this.Name = "VerClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVer;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btlseleccionar;
    }
}