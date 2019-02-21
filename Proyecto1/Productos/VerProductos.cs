using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Productos
{
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();

        private void VerProductos_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            dtgvVer.BackgroundColor = Color.White;
            CenterToScreen();
        }

        private void RefreshGrid()
        {
            var query = from d in db.Productos
                        select new
                        {
                            d.Codigo,
                            d.Producto,
                            d.Precio,
                            d.ITBS,
                            Existencia = d.Cantidad_Existencia

                        };

            dtgvVer.DataSource = query.OrderBy(x => x.Producto).ToList();
            dtgvVer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;






        }

        
    }
   
}
