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
            AutoAjuste();
        }
        private void AutoAjuste()
        {
            dtgvVer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvVer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtgvVer.MultiSelect = true;
            dtgvVer.AllowUserToOrderColumns = false;
            dtgvVer.AllowUserToDeleteRows = false;
            dtgvVer.BackgroundColor = Color.White;
            dtgvVer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtgvVer.Columns[1].ReadOnly = true;
            dtgvVer.Columns[2].ReadOnly = true;
            dtgvVer.Columns[3].ReadOnly = true;
            dtgvVer.Columns[4].ReadOnly = true;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                var productos = from pr in db.Productos
                                where pr.Codigo.Contains(txtbusqueda.Text) || pr.Producto.Contains(txtbusqueda.Text)
                                select new
                                {
                                    pr.Codigo,
                                    pr.Producto,
                                    pr.Precio,
                                    Existencia = pr.Cantidad_Existencia
                                };

                dtgvVer.DataSource = productos.OrderBy(x => x.Producto).ToList();
                AutoAjuste();
            }
        }
    }
   
}
