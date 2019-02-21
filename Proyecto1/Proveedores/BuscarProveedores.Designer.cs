namespace Proyecto1.Proveedores
{
    partial class BuscarProveedores
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoEmpresa = new System.Windows.Forms.TextBox();
            this.lblTelefonoempresa = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDirecion = new System.Windows.Forms.Label();
            this.lblceudla = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNOmbre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 233);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(739, 260);
            this.dgvProveedores.TabIndex = 1;
            this.dgvProveedores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellEnter);
            this.dgvProveedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProveedores_KeyDown);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 499);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 32);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 207);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(118, 20);
            this.txtfiltro.TabIndex = 4;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefonoEmpresa);
            this.groupBox1.Controls.Add(this.lblTelefonoempresa);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDirecion);
            this.groupBox1.Controls.Add(this.lblceudla);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.txtProvincia);
            this.groupBox1.Controls.Add(this.lblCelular);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNOmbre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefonoEmpresa
            // 
            this.txtTelefonoEmpresa.Location = new System.Drawing.Point(472, 125);
            this.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
            this.txtTelefonoEmpresa.Size = new System.Drawing.Size(253, 20);
            this.txtTelefonoEmpresa.TabIndex = 43;
            // 
            // lblTelefonoempresa
            // 
            this.lblTelefonoempresa.AutoSize = true;
            this.lblTelefonoempresa.Location = new System.Drawing.Point(469, 109);
            this.lblTelefonoempresa.Name = "lblTelefonoempresa";
            this.lblTelefonoempresa.Size = new System.Drawing.Size(95, 13);
            this.lblTelefonoempresa.TabIndex = 41;
            this.lblTelefonoempresa.Text = "Telefono empresa:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 125);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(460, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // lblDirecion
            // 
            this.lblDirecion.AutoSize = true;
            this.lblDirecion.Location = new System.Drawing.Point(3, 109);
            this.lblDirecion.Name = "lblDirecion";
            this.lblDirecion.Size = new System.Drawing.Size(55, 13);
            this.lblDirecion.TabIndex = 40;
            this.lblDirecion.Text = "Direccion:";
            // 
            // lblceudla
            // 
            this.lblceudla.AutoSize = true;
            this.lblceudla.Location = new System.Drawing.Point(3, 65);
            this.lblceudla.Name = "lblceudla";
            this.lblceudla.Size = new System.Drawing.Size(43, 13);
            this.lblceudla.TabIndex = 39;
            this.lblceudla.Text = "Cedula:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(6, 81);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(227, 20);
            this.txtcedula.TabIndex = 38;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(472, 81);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(253, 20);
            this.txtEmpresa.TabIndex = 32;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(469, 65);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 29;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(239, 81);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(227, 20);
            this.txtProvincia.TabIndex = 37;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(469, 15);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 34;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(472, 31);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(253, 20);
            this.txtCelular.TabIndex = 35;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(237, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Provincia:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(118, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 33;
            this.lblId.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(239, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(227, 20);
            this.txtApellido.TabIndex = 31;
            // 
            // txtNOmbre
            // 
            this.txtNOmbre.Location = new System.Drawing.Point(6, 31);
            this.txtNOmbre.Name = "txtNOmbre";
            this.txtNOmbre.Size = new System.Drawing.Size(227, 20);
            this.txtNOmbre.TabIndex = 30;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(237, 15);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 28;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(656, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BuscarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 543);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProveedores);
            this.Name = "BuscarProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.BuscarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefonoEmpresa;
        private System.Windows.Forms.Label lblTelefonoempresa;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDirecion;
        private System.Windows.Forms.Label lblceudla;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNOmbre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}