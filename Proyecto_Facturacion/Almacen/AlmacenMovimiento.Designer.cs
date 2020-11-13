namespace Proyecto1.Almacen
{
    partial class AlmacenMovimiento
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
            this.btnVer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNOmbre = new System.Windows.Forms.TextBox();
            this.lblidProveedor = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.dtgvAlmacen = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.lblrnc = new System.Windows.Forms.Label();
            this.lbliduser = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlmacen)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(463, 151);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(73, 30);
            this.btnVer.TabIndex = 53;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 52;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 498);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Sub Total:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(827, 523);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(106, 23);
            this.txtsubtotal.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Busqueda de productos";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(13, 156);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(362, 20);
            this.txtfiltro.TabIndex = 48;
            this.txtfiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfiltro_KeyDown);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(936, 498);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(62, 25);
            this.lbltotal.TabIndex = 47;
            this.lbltotal.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(941, 523);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(102, 23);
            this.txttotal.TabIndex = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(827, 554);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(216, 35);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(260, 86);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(7, 43);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(245, 23);
            this.txtNombreUser.TabIndex = 6;
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
            this.groupBox1.Controls.Add(this.txtrnc);
            this.groupBox1.Controls.Add(this.lblrnc);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtNOmbre);
            this.groupBox1.Controls.Add(this.btnProveedor);
            this.groupBox1.Controls.Add(this.lblidProveedor);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(281, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(762, 86);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(182, 43);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 23);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNOmbre
            // 
            this.txtNOmbre.Location = new System.Drawing.Point(11, 43);
            this.txtNOmbre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNOmbre.Name = "txtNOmbre";
            this.txtNOmbre.Size = new System.Drawing.Size(163, 23);
            this.txtNOmbre.TabIndex = 6;
            // 
            // lblidProveedor
            // 
            this.lblidProveedor.AutoSize = true;
            this.lblidProveedor.Location = new System.Drawing.Point(83, 20);
            this.lblidProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidProveedor.Name = "lblidProveedor";
            this.lblidProveedor.Size = new System.Drawing.Size(0, 17);
            this.lblidProveedor.TabIndex = 36;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(179, 24);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 24);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(665, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 29);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(524, 40);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(133, 30);
            this.btnProveedor.TabIndex = 24;
            this.btnProveedor.Text = "Buscar proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // dtgvAlmacen
            // 
            this.dtgvAlmacen.AllowUserToAddRows = false;
            this.dtgvAlmacen.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.ITBS,
            this.Descuento,
            this.Total});
            this.dtgvAlmacen.Location = new System.Drawing.Point(13, 185);
            this.dtgvAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvAlmacen.Name = "dtgvAlmacen";
            this.dtgvAlmacen.Size = new System.Drawing.Size(1030, 307);
            this.dtgvAlmacen.TabIndex = 41;
            this.dtgvAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlmacen_CellContentClick);
            this.dtgvAlmacen.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlmacen_CellEndEdit);
            this.dtgvAlmacen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlmacen_CellValueChanged);
            this.dtgvAlmacen.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvAlmacen_RowsAdded);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 17);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 48);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(15, 500);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(531, 69);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observacion:";
            // 
            // txtrnc
            // 
            this.txtrnc.Location = new System.Drawing.Point(353, 43);
            this.txtrnc.Margin = new System.Windows.Forms.Padding(4);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.Size = new System.Drawing.Size(163, 23);
            this.txtrnc.TabIndex = 55;
            // 
            // lblrnc
            // 
            this.lblrnc.AutoSize = true;
            this.lblrnc.Location = new System.Drawing.Point(350, 24);
            this.lblrnc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrnc.Name = "lblrnc";
            this.lblrnc.Size = new System.Drawing.Size(41, 17);
            this.lblrnc.TabIndex = 54;
            this.lblrnc.Text = "RNC:";
            // 
            // lbliduser
            // 
            this.lbliduser.AutoSize = true;
            this.lbliduser.Location = new System.Drawing.Point(167, 20);
            this.lbliduser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbliduser.Name = "lbliduser";
            this.lbliduser.Size = new System.Drawing.Size(13, 17);
            this.lbliduser.TabIndex = 35;
            this.lbliduser.Text = "*";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Descripcion";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 74;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 62;
            // 
            // ITBS
            // 
            this.ITBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ITBS.HeaderText = "ITBS";
            this.ITBS.Name = "ITBS";
            this.ITBS.Width = 56;
            // 
            // Descuento
            // 
            this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 84;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 56;
            // 
            // AlmacenMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 602);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvAlmacen);
            this.Name = "AlmacenMovimiento";
            this.Text = "AlmacenMovimiento";
            this.Load += new System.EventHandler(this.AlmacenMovimiento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlmacen)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNOmbre;
        private System.Windows.Forms.Label lblidProveedor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.DataGridView dtgvAlmacen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbliduser;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.Label lblrnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}