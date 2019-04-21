using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Reportes
{
    public partial class ReportesGenerales : Form
    {
        public ReportesGenerales()
        {
            //InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(468, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportesGenerales
            // 
            this.ClientSize = new System.Drawing.Size(468, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesGenerales";
            this.Load += new System.EventHandler(this.ReportesGenerales_Load);
            this.ResumeLayout(false);

        }

        private void ReportesGenerales_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
