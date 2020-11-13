using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.OrdenCompra
{
    public partial class ListarOrdenCompra : Form
    {
        public ListarOrdenCompra()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();

        private void RefreshOrdenM()
        {
            var maestro = from or in db.OrdenCompra
                          select new
                          {
                              or.Id,
                              proveedor = or.Proveedores.Nombre +" "+ or.Proveedores.Apellido,
                              Usuario = or.Usuarios.Nombre +" "+or.Proveedores.Apellido,
                              or.Fecha,
                              or.Total
                          };

            dtgvMaestro.DataSource = maestro.ToList();
            AutoSizem();
        }
        private void AutoSizem()
        {
            dtgvMaestro.BackgroundColor = Color.White;
            //dtgvDetalle.BackgroundColor = Color.White;

            dtgvMaestro.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvMaestro.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvMaestro.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvMaestro.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvMaestro.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void CargarFiltro()
        {
            string id = dtgvMaestro.CurrentRow.Cells[0].Value.ToString();
            int? id1 = Convert.ToInt32(id);
            if(id1 != null)
            {
                cargar(id1);
                id1 = null;
            }
        }

        private void cargar(int? id1)
        {
            var detalle = from de in db.OrdenCompraDetalle
                          where de.Id == id1
                          select new
                          {
                              de.OrdenCompra.Fecha,
                              de.Productos.Producto,                              
                              de.Cantidad,
                              de.ITBS,
                              de.Precio,
                              de.Descuento
                          };

            txtobservaciones.Text = db.OrdenCompra.Where(x => x.Id == id1).Select(x => x.Observaciones).First();
            dtgvDetalle.DataSource = detalle.OrderByDescending(x => x.Fecha).ToList();

            dtgvDetalle.Columns[0].Visible = false;
            AutoSizeDetalle();
            
        }

        private void AutoSizeDetalle()
        {
            dtgvDetalle.BackgroundColor = Color.White;

            dtgvDetalle.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvDetalle.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvDetalle.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvDetalle.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvDetalle.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void SumaToTal()
        {
            decimal Total = 0;
            if(dtgvMaestro.SelectedRows.Count >= 1)
            {
                foreach(DataGridViewRow row in dtgvMaestro.SelectedRows)
                {
                    Total += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dtgvMaestro.Rows)
                {
                    Total += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }

            txttotal.Text = Total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var detalle = from de in db.OrdenCompraDetalle
                          select new
                          {
                              de.OrdenCompra.Fecha,
                              de.Productos.Producto,
                              de.Cantidad,
                              de.ITBS,
                              de.Precio,
                              de.Descuento
                          };

            dtgvDetalle.DataSource = detalle.OrderByDescending(x => x.Fecha).ToList();
            dtgvDetalle.Columns[0].Visible = false;
            txtobservaciones.Text = string.Empty;
            //deseleccionando las filas
            dtgvMaestro.ClearSelection();
            dtgvDetalle.ClearSelection();
            SumaToTal();
            AutoSizeDetalle();
        }

        private void dtgvMaestro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SumaToTal();
            CargarFiltro();
        }

        private void ListarOrdenCompra_Load(object sender, EventArgs e)
        {
            RefreshOrdenM();
        }
    }
    
}
