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
        public static ReportesGenerales Current { get; private set; }
        public ReportesGenerales()
        {
            InitializeComponent();
            Current = this;
        }       

        //private void ReportesGenerales_Load(object sender, EventArgs e)
        //{
        //    CenterToScreen();
        //    //this.reportViewer1.RefreshReport();
          
        //}

        private void ReportesGenerales_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            CenterToScreen();
        }
    }
}
