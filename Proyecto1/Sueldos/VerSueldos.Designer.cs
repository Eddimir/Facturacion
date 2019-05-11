namespace Proyecto1.Sueldos
{
    partial class VerSueldos
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dtgvver = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(597, 267);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(95, 33);
            this.btnSelecionar.TabIndex = 14;
            this.btnSelecionar.Text = "Seleccionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 267);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 33);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 12);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 20);
            this.txtfiltro.TabIndex = 12;
            this.txtfiltro.TextChanged += new System.EventHandler(this.Txtfiltro_TextChanged);
            // 
            // dtgvver
            // 
            this.dtgvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvver.Location = new System.Drawing.Point(12, 38);
            this.dtgvver.Name = "dtgvver";
            this.dtgvver.Size = new System.Drawing.Size(680, 223);
            this.dtgvver.TabIndex = 11;
            // 
            // VerSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 317);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgvver);
            this.Name = "VerSueldos";
            this.Text = "VerSueldos";
            this.Load += new System.EventHandler(this.VerSueldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSelecionar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dtgvver;
    }
}