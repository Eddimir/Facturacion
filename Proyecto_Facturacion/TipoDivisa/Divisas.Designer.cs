namespace Proyecto1.TipoDivisa
{
    partial class Divisas
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtitbs = new System.Windows.Forms.TextBox();
            this.txttipodivisa = new System.Windows.Forms.TextBox();
            this.lblITBS = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblTipoDivisa = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.txtitbs);
            this.groupBox1.Controls.Add(this.txttipodivisa);
            this.groupBox1.Controls.Add(this.lblITBS);
            this.groupBox1.Controls.Add(this.lblvalor);
            this.groupBox1.Controls.Add(this.lblTipoDivisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(146, 42);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(134, 20);
            this.txtvalor.TabIndex = 2;
            // 
            // txtitbs
            // 
            this.txtitbs.Location = new System.Drawing.Point(286, 42);
            this.txtitbs.Name = "txtitbs";
            this.txtitbs.Size = new System.Drawing.Size(134, 20);
            this.txtitbs.TabIndex = 1;
            this.txtitbs.Text = "%";
            // 
            // txttipodivisa
            // 
            this.txttipodivisa.Location = new System.Drawing.Point(6, 42);
            this.txttipodivisa.Name = "txttipodivisa";
            this.txttipodivisa.Size = new System.Drawing.Size(134, 20);
            this.txttipodivisa.TabIndex = 3;
            // 
            // lblITBS
            // 
            this.lblITBS.AutoSize = true;
            this.lblITBS.Location = new System.Drawing.Point(283, 26);
            this.lblITBS.Name = "lblITBS";
            this.lblITBS.Size = new System.Drawing.Size(105, 13);
            this.lblITBS.TabIndex = 2;
            this.lblITBS.Text = "ITBS por porcentaja:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(143, 26);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(34, 13);
            this.lblvalor.TabIndex = 1;
            this.lblvalor.Text = "Valor:";
            // 
            // lblTipoDivisa
            // 
            this.lblTipoDivisa.AutoSize = true;
            this.lblTipoDivisa.Location = new System.Drawing.Point(3, 26);
            this.lblTipoDivisa.Name = "lblTipoDivisa";
            this.lblTipoDivisa.Size = new System.Drawing.Size(76, 13);
            this.lblTipoDivisa.TabIndex = 0;
            this.lblTipoDivisa.Text = "Tipo de divisa:";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(268, 107);
            this.New.Margin = new System.Windows.Forms.Padding(4);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(85, 30);
            this.New.TabIndex = 32;
            this.New.Text = "Nuevo";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(361, 107);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(123, 118);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 33;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Divisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 144);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.New);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Divisas";
            this.Text = "Divisas";
            this.Load += new System.EventHandler(this.Divisas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblITBS;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblTipoDivisa;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtitbs;
        private System.Windows.Forms.TextBox txttipodivisa;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label lblid;
    }
}