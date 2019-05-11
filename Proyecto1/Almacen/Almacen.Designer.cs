namespace Proyecto1.Almacen
{
    partial class Almacen
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtitbs = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblitbs = new System.Windows.Forms.Label();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.btnGUardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtitbs);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtexistencia);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.lbldescripcion);
            this.groupBox1.Controls.Add(this.lblprecio);
            this.groupBox1.Controls.Add(this.lblitbs);
            this.groupBox1.Controls.Add(this.lblexistencia);
            this.groupBox1.Controls.Add(this.lblproducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(284, 76);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 10;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(379, 32);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 9;
            this.txtprecio.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtitbs
            // 
            this.txtitbs.Location = new System.Drawing.Point(591, 32);
            this.txtitbs.Name = "txtitbs";
            this.txtitbs.Size = new System.Drawing.Size(100, 20);
            this.txtitbs.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(9, 101);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(684, 29);
            this.txtdescripcion.TabIndex = 7;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(485, 32);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(100, 20);
            this.txtexistencia.TabIndex = 6;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(9, 32);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(364, 20);
            this.txtproducto.TabIndex = 5;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(6, 76);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcion.TabIndex = 4;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(376, 16);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "Precio:";
            // 
            // lblitbs
            // 
            this.lblitbs.AutoSize = true;
            this.lblitbs.Location = new System.Drawing.Point(588, 16);
            this.lblitbs.Name = "lblitbs";
            this.lblitbs.Size = new System.Drawing.Size(34, 13);
            this.lblitbs.TabIndex = 2;
            this.lblitbs.Text = "ITBS:";
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Location = new System.Drawing.Point(482, 16);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(58, 13);
            this.lblexistencia.TabIndex = 1;
            this.lblexistencia.Text = "Existencia:";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(6, 16);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(53, 13);
            this.lblproducto.TabIndex = 0;
            this.lblproducto.Text = "Producto:";
            // 
            // btnGUardar
            // 
            this.btnGUardar.Location = new System.Drawing.Point(641, 170);
            this.btnGUardar.Name = "btnGUardar";
            this.btnGUardar.Size = new System.Drawing.Size(83, 33);
            this.btnGUardar.TabIndex = 12;
            this.btnGUardar.Text = "Guardar";
            this.btnGUardar.UseVisualStyleBackColor = true;
            this.btnGUardar.Click += new System.EventHandler(this.btnGUardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 170);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 33);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 212);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGUardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtitbs;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblitbs;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Button btnGUardar;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}