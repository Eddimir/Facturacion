namespace Proyecto1.Modulos
{
    partial class verMordulos
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
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dtgvModulos = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 20);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(107, 20);
            this.txtfiltro.TabIndex = 7;
            this.txtfiltro.TextChanged += new System.EventHandler(this.Txtfiltro_TextChanged);
            // 
            // dtgvModulos
            // 
            this.dtgvModulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvModulos.Location = new System.Drawing.Point(12, 50);
            this.dtgvModulos.Name = "dtgvModulos";
            this.dtgvModulos.Size = new System.Drawing.Size(326, 281);
            this.dtgvModulos.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 337);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(263, 337);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // verMordulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 372);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dtgvModulos);
            this.Name = "verMordulos";
            this.Text = "verMordulos";
            this.Load += new System.EventHandler(this.VerMordulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dtgvModulos;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSelect;
    }
}