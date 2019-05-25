namespace Proyecto1.Facturas
{
    partial class Cotizacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtobs = new System.Windows.Forms.RichTextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.lbliduser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.lblRnc = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNOmbre = new System.Windows.Forms.TextBox();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgvCotizacion = new System.Windows.Forms.DataGridView();
            this.cmbtipodivisa = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbltipodivisa = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(838, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Sub Total:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(961, 464);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(62, 25);
            this.lbltotal.TabIndex = 81;
            this.lbltotal.Text = "Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtobs);
            this.groupBox3.Location = new System.Drawing.Point(13, 472);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(522, 65);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observacion:";
            // 
            // txtobs
            // 
            this.txtobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtobs.Location = new System.Drawing.Point(4, 17);
            this.txtobs.Margin = new System.Windows.Forms.Padding(4);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(514, 44);
            this.txtobs.TabIndex = 0;
            this.txtobs.Text = "";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(462, 141);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(73, 30);
            this.btnVer.TabIndex = 79;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 78;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(843, 490);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(115, 20);
            this.txtsubtotal.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Busqueda de Productos";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 147);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(362, 20);
            this.txtfiltro.TabIndex = 75;
            this.txtfiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtfiltro_KeyUp);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(966, 490);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(106, 20);
            this.txttotal.TabIndex = 74;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(843, 518);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(229, 35);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombreUser);
            this.groupBox2.Controls.Add(this.lbliduser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(223, 91);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(7, 43);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(203, 23);
            this.txtNombreUser.TabIndex = 6;
            // 
            // lbliduser
            // 
            this.lbliduser.AutoSize = true;
            this.lbliduser.Location = new System.Drawing.Point(137, 20);
            this.lbliduser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbliduser.Name = "lbliduser";
            this.lbliduser.Size = new System.Drawing.Size(13, 17);
            this.lbliduser.TabIndex = 35;
            this.lbliduser.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.lblRnc);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtNOmbre);
            this.groupBox1.Controls.Add(this.btnProveedor);
            this.groupBox1.Controls.Add(this.lblidcliente);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(830, 91);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.UseWaitCursor = true;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(414, 43);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(195, 23);
            this.txtcedula.TabIndex = 38;
            this.txtcedula.UseWaitCursor = true;
            // 
            // lblRnc
            // 
            this.lblRnc.AutoSize = true;
            this.lblRnc.Location = new System.Drawing.Point(411, 24);
            this.lblRnc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRnc.Name = "lblRnc";
            this.lblRnc.Size = new System.Drawing.Size(56, 17);
            this.lblRnc.TabIndex = 37;
            this.lblRnc.Text = "Cedula:";
            this.lblRnc.UseWaitCursor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(211, 43);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(195, 23);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.UseWaitCursor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(754, 40);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 29);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.UseWaitCursor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtNOmbre
            // 
            this.txtNOmbre.Location = new System.Drawing.Point(8, 43);
            this.txtNOmbre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNOmbre.Name = "txtNOmbre";
            this.txtNOmbre.Size = new System.Drawing.Size(195, 23);
            this.txtNOmbre.TabIndex = 6;
            this.txtNOmbre.UseWaitCursor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(616, 40);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(130, 30);
            this.btnProveedor.TabIndex = 24;
            this.btnProveedor.Text = "Buscar Cliente";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.UseWaitCursor = true;
            this.btnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(80, 20);
            this.lblidcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(0, 17);
            this.lblidcliente.TabIndex = 36;
            this.lblidcliente.UseWaitCursor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(208, 24);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.UseWaitCursor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 24);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseWaitCursor = true;
            // 
            // dtgvCotizacion
            // 
            this.dtgvCotizacion.AllowUserToAddRows = false;
            this.dtgvCotizacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Impuesto,
            this.Codigo,
            this.Productos,
            this.Cantidad,
            this.Precio,
            this.ITBS,
            this.Descuento,
            this.Total});
            this.dtgvCotizacion.Location = new System.Drawing.Point(13, 179);
            this.dtgvCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvCotizacion.Name = "dtgvCotizacion";
            this.dtgvCotizacion.Size = new System.Drawing.Size(1061, 281);
            this.dtgvCotizacion.TabIndex = 70;
            this.dtgvCotizacion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvCotizacion_CellEndEdit);
            this.dtgvCotizacion.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DtgvCotizacion_RowsAdded);
            // 
            // cmbtipodivisa
            // 
            this.cmbtipodivisa.FormattingEnabled = true;
            this.cmbtipodivisa.Location = new System.Drawing.Point(869, 127);
            this.cmbtipodivisa.Name = "cmbtipodivisa";
            this.cmbtipodivisa.Size = new System.Drawing.Size(135, 21);
            this.cmbtipodivisa.TabIndex = 84;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1010, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 86;
            this.checkBox1.Text = "ITBS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbltipodivisa
            // 
            this.lbltipodivisa.AutoSize = true;
            this.lbltipodivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipodivisa.Location = new System.Drawing.Point(870, 110);
            this.lbltipodivisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipodivisa.Name = "lbltipodivisa";
            this.lbltipodivisa.Size = new System.Drawing.Size(99, 16);
            this.lbltipodivisa.TabIndex = 85;
            this.lbltipodivisa.Text = "Tipo de Divisa:";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 56;
            // 
            // Descuento
            // 
            this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 84;
            // 
            // ITBS
            // 
            this.ITBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ITBS.HeaderText = "ITBS";
            this.ITBS.Name = "ITBS";
            this.ITBS.Width = 56;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 74;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Productos.HeaderText = "Producto";
            this.Productos.Name = "Productos";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 562);
            this.Controls.Add(this.cmbtipodivisa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbltipodivisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvCotizacion);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtobs;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label lbliduser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label lblRnc;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNOmbre;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgvCotizacion;
        private System.Windows.Forms.ComboBox cmbtipodivisa;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbltipodivisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}