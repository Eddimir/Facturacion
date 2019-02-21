namespace Proyecto1.Productos
{
    partial class Productos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtbeneficio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtFechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblMargenBeneficio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtitbs = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.lblITBS = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRegistro);
            this.groupBox1.Controls.Add(this.txtbeneficio);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.dtFechaDeRegistro);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblMargenBeneficio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtitbs);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.lblITBS);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(928, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(9, 219);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(133, 18);
            this.lblRegistro.TabIndex = 26;
            this.lblRegistro.Text = "Fecha de Registro:";
            // 
            // txtbeneficio
            // 
            this.txtbeneficio.Location = new System.Drawing.Point(800, 64);
            this.txtbeneficio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbeneficio.Name = "txtbeneficio";
            this.txtbeneficio.Size = new System.Drawing.Size(115, 24);
            this.txtbeneficio.TabIndex = 24;
            this.txtbeneficio.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(545, 42);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 18);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dtFechaDeRegistro
            // 
            this.dtFechaDeRegistro.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtFechaDeRegistro.Enabled = false;
            this.dtFechaDeRegistro.Location = new System.Drawing.Point(14, 241);
            this.dtFechaDeRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaDeRegistro.Name = "dtFechaDeRegistro";
            this.dtFechaDeRegistro.Size = new System.Drawing.Size(304, 24);
            this.dtFechaDeRegistro.TabIndex = 25;
            this.dtFechaDeRegistro.Value = new System.DateTime(2018, 9, 30, 0, 0, 0, 0);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(548, 64);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(115, 24);
            this.txtcantidad.TabIndex = 20;
            this.txtcantidad.Text = "0";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(14, 125);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(901, 88);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblMargenBeneficio
            // 
            this.lblMargenBeneficio.AutoSize = true;
            this.lblMargenBeneficio.Location = new System.Drawing.Point(810, 42);
            this.lblMargenBeneficio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMargenBeneficio.Name = "lblMargenBeneficio";
            this.lblMargenBeneficio.Size = new System.Drawing.Size(73, 18);
            this.lblMargenBeneficio.TabIndex = 22;
            this.lblMargenBeneficio.Text = "Beneficio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 102);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(322, 21);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 17;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtitbs
            // 
            this.txtitbs.Location = new System.Drawing.Point(674, 64);
            this.txtitbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtitbs.Name = "txtitbs";
            this.txtitbs.Size = new System.Drawing.Size(115, 24);
            this.txtitbs.TabIndex = 9;
            this.txtitbs.Text = "0";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(422, 64);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(115, 24);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.Text = "0";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(14, 64);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(397, 24);
            this.txtproducto.TabIndex = 6;
            // 
            // lblITBS
            // 
            this.lblITBS.AutoSize = true;
            this.lblITBS.Location = new System.Drawing.Point(671, 42);
            this.lblITBS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblITBS.Name = "lblITBS";
            this.lblITBS.Size = new System.Drawing.Size(44, 18);
            this.lblITBS.TabIndex = 3;
            this.lblITBS.Text = "ITBS:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(419, 42);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(8, 42);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(829, 303);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 43);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 356);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DateTimePicker dtFechaDeRegistro;
        private System.Windows.Forms.TextBox txtbeneficio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblMargenBeneficio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtitbs;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label lblITBS;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lblId;
    }
}