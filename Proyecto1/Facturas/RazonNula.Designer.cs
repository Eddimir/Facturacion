namespace Proyecto1.Facturas
{
    partial class RazonNula
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
            this.txtxrazonnula = new System.Windows.Forms.RichTextBox();
            this.lblRazonNula = new System.Windows.Forms.Label();
            this.btnVlidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtxrazonnula
            // 
            this.txtxrazonnula.Location = new System.Drawing.Point(12, 46);
            this.txtxrazonnula.Name = "txtxrazonnula";
            this.txtxrazonnula.Size = new System.Drawing.Size(244, 135);
            this.txtxrazonnula.TabIndex = 0;
            this.txtxrazonnula.Text = "";
            // 
            // lblRazonNula
            // 
            this.lblRazonNula.AutoSize = true;
            this.lblRazonNula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonNula.Location = new System.Drawing.Point(75, 17);
            this.lblRazonNula.Name = "lblRazonNula";
            this.lblRazonNula.Size = new System.Drawing.Size(122, 26);
            this.lblRazonNula.TabIndex = 1;
            this.lblRazonNula.Text = "Razon nula";
            // 
            // btnVlidar
            // 
            this.btnVlidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVlidar.Location = new System.Drawing.Point(181, 187);
            this.btnVlidar.Name = "btnVlidar";
            this.btnVlidar.Size = new System.Drawing.Size(75, 28);
            this.btnVlidar.TabIndex = 2;
            this.btnVlidar.Text = "Validar";
            this.btnVlidar.UseVisualStyleBackColor = true;
            this.btnVlidar.Click += new System.EventHandler(this.btnVlidar_Click);
            // 
            // RazonNula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 225);
            this.Controls.Add(this.btnVlidar);
            this.Controls.Add(this.lblRazonNula);
            this.Controls.Add(this.txtxrazonnula);
            this.Name = "RazonNula";
            this.Load += new System.EventHandler(this.RazonNula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtxrazonnula;
        private System.Windows.Forms.Label lblRazonNula;
        private System.Windows.Forms.Button btnVlidar;
    }
}