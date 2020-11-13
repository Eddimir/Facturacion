namespace Proyecto1.TipoDivisa
{
    partial class verDivisas
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
            this.dtgvver = new System.Windows.Forms.DataGridView();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvver)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvver
            // 
            this.dtgvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvver.Location = new System.Drawing.Point(12, 43);
            this.dtgvver.Name = "dtgvver";
            this.dtgvver.Size = new System.Drawing.Size(680, 223);
            this.dtgvver.TabIndex = 0;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 17);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 20);
            this.txtfiltro.TabIndex = 1;
            this.txtfiltro.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 272);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 33);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(597, 272);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(95, 33);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Seleccionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // verDivisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 318);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgvver);
            this.Name = "verDivisas";
            this.Text = "Divisas";
            this.Load += new System.EventHandler(this.VerDivisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvver;
        private System.Windows.Forms.TextBox txtfiltro;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnSelecionar;
    }
}