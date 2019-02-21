using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Facturas
{
    public partial class ListaDeFacturas : Form
    {
        public ListaDeFacturas()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();

        private void RefreshMaestro()
        {
            var maestro = from m in db.Facturacion
                          select new
                          {
                              m.Id,
                              Cliente = m.Clientes.Nombre + " " + m.Clientes.Apellido,
                              Usuario = m.Usuarios.Nombre + " " + m.Usuarios.Apellido,
                              m.Fecha,
                              m.Observaciones,
                              m.total
                          };

            dtgvMaestro.DataSource = maestro.OrderBy(x=>x.Fecha).ToList();
            SumalTotal();
            if (dtgvMaestro.Rows.Count == 1)
            {
                button1.Visible = false;
            }
        }
        //private void refreshDetalle()
        //{
        //    var Detalle = from de in db.FacturacionDetalle
        //                  select new
        //                  {
        //                      de.Facturacion.Fecha,
        //                      de.Productos.Producto,
        //                      de.Cantidad,
        //                      de.ITBIS,
        //                      de.Descuento
        //                  };

        //    dtgvDetalle.DataSource = Detalle.OrderBy(x => x.Fecha).ToList();
        //    dtgvDetalle.Columns[0].Visible = false;
        //}
        private void CargaFiltro()
        {
            try
            {
                string id = dtgvMaestro.CurrentRow.Cells["Id"].Value.ToString();

                int? id4 = Convert.ToInt32(id);
                Cargar(id4);

            }
            catch { }
        }

        private void Cargar(int? IdMaestro)
        {
            //var deta = db.FacturacionDetalle.Find(IdMaestro);
            var detalle = from de in db.FacturacionDetalle
                          where de.IdFacturacion == IdMaestro
                          select new
                          {
                              de.Facturacion.Fecha,
                              de.Productos.Producto,
                              de.Cantidad,
                              de.ITBIS,
                              de.Descuento
                          };

            dtgvDetalle.DataSource = detalle.OrderBy(x => x.Fecha).ToList();
            dtgvDetalle.Columns[0].Visible = false;

        }

        private void ListaDeFacturas_Load(object sender, EventArgs e)
        {
            agreggated();
        }
        private void agreggated()
        {
            CenterToScreen();
            RefreshMaestro();

        }

        private bool butonclik;
        private void dtgvMaestro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaFiltro();
           
            SumalTotal();
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            var detalle = from de in db.FacturacionDetalle
                          select new
                          {
                              de.Facturacion.Fecha,
                              de.Productos.Producto,
                              de.Cantidad,
                              de.ITBIS,
                              de.Descuento
                          };

            dtgvDetalle.DataSource = detalle.OrderBy(x => x.Fecha).ToList();
            dtgvDetalle.Columns[0].Visible = false;

            butonclik = true;
            SumalTotal();
        }
        private void SumalTotal()
        {
            decimal Total = 0;
            //decimal subtotal = 0;
            if(butonclik == true)
            {
                foreach (DataGridViewRow row in dtgvMaestro.Rows)
                {
                    Total += Convert.ToDecimal(row.Cells["total"].Value);
                }                
            }
            else
            {
                foreach (DataGridViewRow row in dtgvMaestro.SelectedRows)
                {
                    Total += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }
            
            //foreach (DataGridViewRow rows in dtgvDetalle.Rows)
            //{
            //    decimal cantidad = (decimal)rows.Cells["Cantidad"].Value;
            //    //decimal precio = (decimal)rows.Cells["Precio"].Value;
            //    decimal descuento = (decimal)rows.Cells["Descuento"].Value;
            //    decimal total = cantidad - descuento;
            //    subtotal += total;
            //}
            
            //txtsubtotal.Text = subtotal.ToString();
            txttotal.Text = Total.ToString();
        }
    }
}
