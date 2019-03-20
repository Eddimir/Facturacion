namespace Proyecto1.Modulos
{
    partial class AgsinarYModificar
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
            this.dtgvAsignarModulo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtxnombre = new System.Windows.Forms.TextBox();
            this.lblNOmbre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignarModulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvAsignarModulo
            // 
            this.dtgvAsignarModulo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvAsignarModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsignarModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAsignarModulo.Location = new System.Drawing.Point(3, 16);
            this.dtgvAsignarModulo.Name = "dtgvAsignarModulo";
            this.dtgvAsignarModulo.Size = new System.Drawing.Size(520, 411);
            this.dtgvAsignarModulo.TabIndex = 0;
            this.dtgvAsignarModulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvAsignarModulo_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtxnombre);
            this.groupBox1.Controls.Add(this.lblNOmbre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(276, 16);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 15);
            this.lblid.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(467, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 25);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Buscar Empleado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(174, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(162, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtxnombre
            // 
            this.txtxnombre.Location = new System.Drawing.Point(6, 38);
            this.txtxnombre.Name = "txtxnombre";
            this.txtxnombre.Size = new System.Drawing.Size(162, 20);
            this.txtxnombre.TabIndex = 3;
            // 
            // lblNOmbre
            // 
            this.lblNOmbre.AutoSize = true;
            this.lblNOmbre.Location = new System.Drawing.Point(3, 22);
            this.lblNOmbre.Name = "lblNOmbre";
            this.lblNOmbre.Size = new System.Drawing.Size(55, 15);
            this.lblNOmbre.TabIndex = 3;
            this.lblNOmbre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(171, 20);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvAsignarModulo);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 430);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modulos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Modulos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgsinarYModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AgsinarYModificar";
            this.Text = "AgsinarYModificar";
            this.Load += new System.EventHandler(this.AgsinarYModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignarModulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAsignarModulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtxnombre;
        private System.Windows.Forms.Label lblNOmbre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblid;
    }
}