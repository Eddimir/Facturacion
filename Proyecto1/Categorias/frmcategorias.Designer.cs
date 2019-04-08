namespace Proyecto1.Categorias
{
    partial class frmcategorias
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.ckbEliminar = new System.Windows.Forms.CheckBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCategoriaBuscar = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.dtgvlistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.txtdescricion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcategorianombre = new System.Windows.Forms.Label();
            this.lbldescricion = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblcantidad);
            this.tabPage1.Controls.Add(this.ckbEliminar);
            this.tabPage1.Controls.Add(this.btnimprimir);
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtCategoriaBuscar);
            this.tabPage1.Controls.Add(this.lblcategoria);
            this.tabPage1.Controls.Add(this.dtgvlistado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(329, 96);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 15;
            this.lblcantidad.Text = "Cantidad";
            // 
            // ckbEliminar
            // 
            this.ckbEliminar.AutoSize = true;
            this.ckbEliminar.Location = new System.Drawing.Point(6, 92);
            this.ckbEliminar.Name = "ckbEliminar";
            this.ckbEliminar.Size = new System.Drawing.Size(62, 17);
            this.ckbEliminar.TabIndex = 8;
            this.ckbEliminar.Text = "Eliminar";
            this.ckbEliminar.UseVisualStyleBackColor = true;
            this.ckbEliminar.CheckedChanged += new System.EventHandler(this.ckbEliminar_CheckedChanged);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(403, 35);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 13;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(322, 38);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(241, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCategoriaBuscar
            // 
            this.txtCategoriaBuscar.Location = new System.Drawing.Point(74, 35);
            this.txtCategoriaBuscar.Name = "txtCategoriaBuscar";
            this.txtCategoriaBuscar.Size = new System.Drawing.Size(159, 20);
            this.txtCategoriaBuscar.TabIndex = 10;
            this.txtCategoriaBuscar.TextChanged += new System.EventHandler(this.txtCategoriaBuscar_TextChanged);
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(24, 38);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(44, 13);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Nombre";
            // 
            // dtgvlistado
            // 
            this.dtgvlistado.AllowUserToAddRows = false;
            this.dtgvlistado.AllowUserToDeleteRows = false;
            this.dtgvlistado.AllowUserToOrderColumns = true;
            this.dtgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtgvlistado.Location = new System.Drawing.Point(6, 115);
            this.dtgvlistado.MultiSelect = false;
            this.dtgvlistado.Name = "dtgvlistado";
            this.dtgvlistado.ReadOnly = true;
            this.dtgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvlistado.Size = new System.Drawing.Size(492, 257);
            this.dtgvlistado.TabIndex = 14;
            this.dtgvlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvlistado_CellContentClick);
            this.dtgvlistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvlistado_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtnombrecategoria);
            this.groupBox1.Controls.Add(this.txtdescricion);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.lblcategorianombre);
            this.groupBox1.Controls.Add(this.lbldescricion);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Location = new System.Drawing.Point(23, 130);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(236, 20);
            this.txtnombrecategoria.TabIndex = 11;
            // 
            // txtdescricion
            // 
            this.txtdescricion.Location = new System.Drawing.Point(23, 183);
            this.txtdescricion.Multiline = true;
            this.txtdescricion.Name = "txtdescricion";
            this.txtdescricion.Size = new System.Drawing.Size(236, 40);
            this.txtdescricion.TabIndex = 10;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(23, 71);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(63, 20);
            this.txtcodigo.TabIndex = 9;
            // 
            // lblcategorianombre
            // 
            this.lblcategorianombre.AutoSize = true;
            this.lblcategorianombre.Location = new System.Drawing.Point(20, 105);
            this.lblcategorianombre.Name = "lblcategorianombre";
            this.lblcategorianombre.Size = new System.Drawing.Size(55, 13);
            this.lblcategorianombre.TabIndex = 8;
            this.lblcategorianombre.Text = "Categoria:";
            // 
            // lbldescricion
            // 
            this.lbldescricion.AutoSize = true;
            this.lbldescricion.Location = new System.Drawing.Point(20, 167);
            this.lbldescricion.Name = "lbldescricion";
            this.lbldescricion.Size = new System.Drawing.Size(66, 13);
            this.lbldescricion.TabIndex = 7;
            this.lbldescricion.Text = "Descripcion:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(20, 55);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 6;
            this.lblcodigo.Text = "Codigo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(108, 245);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(189, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(270, 245);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(351, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmcategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmcategorias";
            this.Text = "frmcategorias";
            this.Load += new System.EventHandler(this.frmcategorias_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.CheckBox ckbEliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCategoriaBuscar;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.DataGridView dtgvlistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.TextBox txtdescricion;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcategorianombre;
        private System.Windows.Forms.Label lbldescricion;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}