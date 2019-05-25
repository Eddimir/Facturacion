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
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                var cotizaciones = from ctc in db.Cotizacion
                                   select new
                                   {
                                       Fecha = ctc.Fecha,
                                       Cliente = ctc.Clientes.Nombre + ctc.Clientes.Apellido,
                                       Usuario = ctc.Usuarios.Nombre + ctc.Usuarios.Apellido,
                                       Detalle = ctc.CotizacionDetalle.Select(x => new
                                       {
                                           x.Productos.Producto,
                                           x.Cantidad,
                                           x.Precio,
                                           x.Descuento,
                                           x.ITBS

                                       }).ToList(),

                                      Total =  ctc.Total

                                   };

              
                dtgvVer.DataSource = cotizaciones.ToList();
            }
        }
        public class MyDataSource
        {
            DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();

            public  IQueryable<DataADO.Cotizacion> AllOrders
            {
                get { return db.Cotizacion; }
            }

            public  IQueryable<DataADO.CotizacionDetalle> OrderDetails
            {
                get
                {
                    return db.CotizacionDetalle;
                }
            }
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            FillGrid();
            CenterToScreen();
        }
    }
}
