namespace Proyecto1.Facturas
{
    partial class Crear
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtApellidoUser = new System.Windows.Forms.TextBox();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.lbliduser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblefectivo = new System.Windows.Forms.Label();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdevuelta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNOmbre = new System.Windows.Forms.TextBox();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.ckbPagada = new System.Windows.Forms.CheckBox();
            this.dtfechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescripcionTipoDepago = new System.Windows.Forms.Label();
            this.txtdescripcionPago = new System.Windows.Forms.RichTextBox();
            this.cmbTipoDePago = new System.Windows.Forms.ComboBox();
            this.ckbContado = new System.Windows.Forms.CheckBox();
            this.cmbtipodivisa = new System.Windows.Forms.ComboBox();
            this.lbltipodivisa = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbITBS = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(1072, 475);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(62, 25);
            this.lbltotal.TabIndex = 31;
            this.lbltotal.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(1077, 504);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(106, 21);
            this.txttotal.TabIndex = 30;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(958, 533);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 35);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 483);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(438, 117);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observacion:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 23);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(430, 90);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtApellidoUser);
            this.groupBox2.Controls.Add(this.txtNombreUser);
            this.groupBox2.Controls.Add(this.lbliduser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(331, 77);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // txtApellidoUser
            // 
            this.txtApellidoUser.Location = new System.Drawing.Point(175, 43);
            this.txtApellidoUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoUser.Name = "txtApellidoUser";
            this.txtApellidoUser.Size = new System.Drawing.Size(143, 23);
            this.txtApellidoUser.TabIndex = 7;
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(7, 43);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(160, 23);
            this.txtNombreUser.TabIndex = 6;
            // 
            // lbliduser
            // 
            this.lbliduser.AutoSize = true;
            this.lbliduser.Location = new System.Drawing.Point(140, 20);
            this.lbliduser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbliduser.Name = "lbliduser";
            this.lbliduser.Size = new System.Drawing.Size(13, 17);
            this.lbliduser.TabIndex = 35;
            this.lbliduser.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Usuario:";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 59;
            // 
            // Descuento
            // 
            this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 91;
            // 
            // ITBS
            // 
            this.ITBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ITBS.HeaderText = "ITBS";
            this.ITBS.Name = "ITBS";
            this.ITBS.Width = 58;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 67;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 81;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.ITBS,
            this.Descuento,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(14, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1169, 306);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(13, 123);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(362, 21);
            this.txtfiltro.TabIndex = 1;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            this.txtfiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfiltro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Busqueda de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sub Total:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(958, 504);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(111, 21);
            this.txtsubtotal.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(463, 117);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(73, 31);
            this.btnVer.TabIndex = 40;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblefectivo
            // 
            this.lblefectivo.AutoSize = true;
            this.lblefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblefectivo.Location = new System.Drawing.Point(715, 475);
            this.lblefectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblefectivo.Name = "lblefectivo";
            this.lblefectivo.Size = new System.Drawing.Size(87, 25);
            this.lblefectivo.TabIndex = 42;
            this.lblefectivo.Text = "Efectivo:";
            // 
            // txtefectivo
            // 
            this.txtefectivo.Location = new System.Drawing.Point(720, 504);
            this.txtefectivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(111, 21);
            this.txtefectivo.TabIndex = 41;
            this.txtefectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtefectivo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 475);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Devuelta:";
            // 
            // txtdevuelta
            // 
            this.txtdevuelta.Location = new System.Drawing.Point(839, 504);
            this.txtdevuelta.Margin = new System.Windows.Forms.Padding(4);
            this.txtdevuelta.Name = "txtdevuelta";
            this.txtdevuelta.Size = new System.Drawing.Size(111, 21);
            this.txtdevuelta.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNOmbre);
            this.groupBox1.Controls.Add(this.lblidcliente);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(353, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(688, 77);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(260, 44);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(207, 23);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNOmbre
            // 
            this.txtNOmbre.Location = new System.Drawing.Point(8, 44);
            this.txtNOmbre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNOmbre.Name = "txtNOmbre";
            this.txtNOmbre.Size = new System.Drawing.Size(244, 23);
            this.txtNOmbre.TabIndex = 6;
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(83, 20);
            this.lblidcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(0, 17);
            this.lblidcliente.TabIndex = 36;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(257, 22);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Cliente:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(485, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 29);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(563, 41);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(114, 30);
            this.btnCliente.TabIndex = 24;
            this.btnCliente.Text = "Buscar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // ckbPagada
            // 
            this.ckbPagada.AutoSize = true;
            this.ckbPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPagada.Location = new System.Drawing.Point(857, 119);
            this.ckbPagada.Name = "ckbPagada";
            this.ckbPagada.Size = new System.Drawing.Size(83, 24);
            this.ckbPagada.TabIndex = 49;
            this.ckbPagada.Text = "Pagada";
            this.ckbPagada.UseVisualStyleBackColor = true;
            this.ckbPagada.Click += new System.EventHandler(this.ckbPagada_Click);
            // 
            // dtfechavencimiento
            // 
            this.dtfechavencimiento.Location = new System.Drawing.Point(951, 122);
            this.dtfechavencimiento.Name = "dtfechavencimiento";
            this.dtfechavencimiento.Size = new System.Drawing.Size(232, 21);
            this.dtfechavencimiento.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(947, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // lblDescripcionTipoDepago
            // 
            this.lblDescripcionTipoDepago.AutoSize = true;
            this.lblDescripcionTipoDepago.Location = new System.Drawing.Point(7, 46);
            this.lblDescripcionTipoDepago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionTipoDepago.Name = "lblDescripcionTipoDepago";
            this.lblDescripcionTipoDepago.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcionTipoDepago.TabIndex = 51;
            this.lblDescripcionTipoDepago.Text = "Descripcion:";
            // 
            // txtdescripcionPago
            // 
            this.txtdescripcionPago.Location = new System.Drawing.Point(6, 64);
            this.txtdescripcionPago.Name = "txtdescripcionPago";
            this.txtdescripcionPago.Size = new System.Drawing.Size(226, 47);
            this.txtdescripcionPago.TabIndex = 50;
            this.txtdescripcionPago.Text = "";
            // 
            // cmbTipoDePago
            // 
            this.cmbTipoDePago.FormattingEnabled = true;
            this.cmbTipoDePago.Location = new System.Drawing.Point(6, 20);
            this.cmbTipoDePago.Name = "cmbTipoDePago";
            this.cmbTipoDePago.Size = new System.Drawing.Size(226, 23);
            this.cmbTipoDePago.TabIndex = 49;
            // 
            // ckbContado
            // 
            this.ckbContado.AutoSize = true;
            this.ckbContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbContado.Location = new System.Drawing.Point(762, 119);
            this.ckbContado.Name = "ckbContado";
            this.ckbContado.Size = new System.Drawing.Size(89, 24);
            this.ckbContado.TabIndex = 53;
            this.ckbContado.Text = "Contado";
            this.ckbContado.UseVisualStyleBackColor = true;
            // 
            // cmbtipodivisa
            // 
            this.cmbtipodivisa.FormattingEnabled = true;
            this.cmbtipodivisa.Location = new System.Drawing.Point(1048, 67);
            this.cmbtipodivisa.Name = "cmbtipodivisa";
            this.cmbtipodivisa.Size = new System.Drawing.Size(135, 23);
            this.cmbtipodivisa.TabIndex = 54;
            this.cmbtipodivisa.SelectedValueChanged += new System.EventHandler(this.cmbtipodivisa_SelectedValueChanged);
            // 
            // lbltipodivisa
            // 
            this.lbltipodivisa.AutoSize = true;
            this.lbltipodivisa.Location = new System.Drawing.Point(1049, 49);
            this.lbltipodivisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipodivisa.Name = "lbltipodivisa";
            this.lbltipodivisa.Size = new System.Drawing.Size(87, 15);
            this.lbltipodivisa.TabIndex = 55;
            this.lbltipodivisa.Text = "Tipo de Divisa:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTipoDePago);
            this.groupBox4.Controls.Add(this.lblDescripcionTipoDepago);
            this.groupBox4.Controls.Add(this.txtdescripcionPago);
            this.groupBox4.Location = new System.Drawing.Point(459, 483);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 117);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Pago:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(720, 533);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 35);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbITBS
            // 
            this.ckbITBS.AutoSize = true;
            this.ckbITBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbITBS.Location = new System.Drawing.Point(692, 119);
            this.ckbITBS.Name = "ckbITBS";
            this.ckbITBS.Size = new System.Drawing.Size(64, 24);
            this.ckbITBS.TabIndex = 58;
            this.ckbITBS.Text = "ITBS";
            this.ckbITBS.UseVisualStyleBackColor = true;
            this.ckbITBS.CheckedChanged += new System.EventHandler(this.CkbITBS_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 611);
            this.Controls.Add(this.ckbITBS);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbltipodivisa);
            this.Controls.Add(this.cmbtipodivisa);
            this.Controls.Add(this.ckbContado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtfechavencimiento);
            this.Controls.Add(this.ckbPagada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdevuelta);
            this.Controls.Add(this.lblefectivo);
            this.Controls.Add(this.txtefectivo);
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
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Crear";
            this.Text = "Crear";
            this.Load += new System.EventHandler(this.Crear_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtApellidoUser;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbliduser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblefectivo;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdevuelta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNOmbre;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.CheckBox ckbPagada;
        private System.Windows.Forms.DateTimePicker dtfechavencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescripcionTipoDepago;
        private System.Windows.Forms.RichTextBox txtdescripcionPago;
        private System.Windows.Forms.ComboBox cmbTipoDePago;
        private System.Windows.Forms.CheckBox ckbContado;
        private System.Windows.Forms.ComboBox cmbtipodivisa;
        private System.Windows.Forms.Label lbltipodivisa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbITBS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}