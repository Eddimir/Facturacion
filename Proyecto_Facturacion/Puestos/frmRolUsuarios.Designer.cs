namespace Proyecto1.Puestos
{
    partial class frmRolUsuarios
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtPuestos = new System.Windows.Forms.TextBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.txtPuestos);
            this.groupBox1.Controls.Add(this.lblRoles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(165, 16);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(11, 13);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "*";
            // 
            // txtPuestos
            // 
            this.txtPuestos.Location = new System.Drawing.Point(6, 38);
            this.txtPuestos.Name = "txtPuestos";
            this.txtPuestos.Size = new System.Drawing.Size(230, 20);
            this.txtPuestos.TabIndex = 3;
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(3, 22);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(40, 13);
            this.lblRoles.TabIndex = 1;
            this.lblRoles.Text = "Puesto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(181, 99);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmRolUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 132);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRolUsuarios";
            this.Text = "frmRolUsuarios";
            this.Load += new System.EventHandler(this.FrmRolUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtPuestos;
        private System.Windows.Forms.Button btnGuardar;
    }
}