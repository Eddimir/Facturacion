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
                              m.Nula,
                              m.pagada,
                              m.Total,
                              
                          };

            dtgvMaestro.DataSource = maestro.OrderByDescending(x=>x.Fecha).ToList();            
            if (dtgvMaestro.Rows.Count == 1)
            {
                button1.Visible = false;
            }
            SumalTotal();
            autosize();
        }
        public void Botones()
        {
            var db = new DataADO.Proyecto1Entities();
            var query = db.Seguridad.Where(x => x.IdUsuario == Principal.veloz22.id && x.Modulos.NombreDeModulo == "Facturas").Select(x => new { x.Ver, x.Editar }).FirstOrDefault();

            if (query.Editar == true)
            {
                btnAnular.Enabled = true;
                btnPagar.Enabled = true;
                txtobservaciones.ReadOnly = true;
                dtgvMaestro.ReadOnly = false;
                dtgvDetalle.ReadOnly = false;

            }
            else
            {
                btnAnular.Enabled = false;
                btnPagar.Enabled = false;
                txtobservaciones.ReadOnly = true;
                dtgvMaestro.ReadOnly = true;
                dtgvDetalle.ReadOnly = true;
            }
        }
        private void autosize()
        {
            dtgvMaestro.BackgroundColor = Color.White;
            dtgvDetalle.BackgroundColor = Color.White;

            dtgvMaestro.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvMaestro.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvMaestro.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvMaestro.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvMaestro.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                if (id4 != null)
                {
                    Cargar(id4);
                    id4 = null;
                }

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
                              de.Precio,
                              de.Descuento
                          };

            txtobservaciones.Text = db.Facturacion.Where(x => x.Id == IdMaestro).Select(x => x.Observaciones).First().ToString();
            dtgvDetalle.DataSource = detalle.OrderByDescending(x => x.Fecha).ToList();
            
            dtgvDetalle.Columns[0].Visible = false;
            AutoSizeDetalle();

        }

        private void ListaDeFacturas_Load(object sender, EventArgs e)
        {
            agreggated();           
        }
        private void agreggated()
        {
            CenterToScreen();
            RefreshMaestro();
            Botones();
        }

        //private bool butonclik;
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
                              de.Precio,
                              de.Descuento
                          };

            dtgvDetalle.DataSource = detalle.OrderByDescending(x => x.Fecha).ToList();
            dtgvDetalle.Columns[0].Visible = false;
            txtobservaciones.Text = string.Empty;
            //deseleccionando las filas
            dtgvMaestro.ClearSelection();
            dtgvDetalle.ClearSelection();
            SumalTotal();
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
        private void SumalTotal()
        {
            decimal Total = 0;
            //decimal subtotal = 0;
            if(dtgvMaestro.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow row in dtgvMaestro.SelectedRows)
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
        private bool repuesta = false;
        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                repuesta = false;             
                int? id = Convert.ToInt32(dtgvMaestro.CurrentRow.Cells["Id"].Value);
                if (dtgvMaestro.SelectedRows.Count == 1 && dtgvDetalle.Rows.Count >= 1 && repuesta == false)
                {                    
                    var cliente = db.Facturacion.Where(x => x.Id == id)
                                    .Select(x => new { x.Clientes.Nombre,x.Clientes.Apellido, x.Fecha }).First();
                    var Maestro = db.Facturacion.Find(id);
                    ///
                    var FechaFacturacion = cliente.Fecha.Value.DayOfYear;
                    var FechaActual = DateTime.Now.DayOfYear;              
                    int TotalFecha = FechaActual - FechaFacturacion;

                    if (Maestro.Nula == false || Maestro.Nula == null)
                    {
                        if (TotalFecha <= 2)
                        {
                            if (MessageBox.Show($"Esta seguro de que desea anular la factura del cliente: {cliente.Nombre} {cliente.Apellido}?", "", MessageBoxButtons.YesNo) == DialogResult.Yes && id != null)
                            {
                                repuesta = true;
                            }
                        }
                        else if (TotalFecha >= 3)
                        {
                            MessageBox.Show($"Lo siento la factura no puede ser anulada, el cliente tiene un limite de dos dias para poder anular en este caso la diferencia es de {TotalFecha} dias");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La factura ya fue anulada");
                        //repuesta = false;
                    }                   
                                 
                }
                else if(dtgvMaestro.SelectedRows.Count == 0 & dtgvDetalle.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Para poder poder continuar con el processo de anulacion antes se debe de selecionar la factura que desea eliminar, de lo contrario la accion no sera valida");
                }
                comprobacion(id, repuesta);
            }
            catch {  }
        }
        private void comprobacion(int? id, bool repuesta)
        {
            if (repuesta == true && dtgvMaestro.SelectedRows.Count >= 1)
            {
                if (id != null)
                {
                    //llamando otro formulario para validar la razon nula en caso de que se desee anular la fatura
                    RazonNula frraxon = new RazonNula(id);
                    frraxon.ShowDialog();
                    repuesta = false;
                    RefreshMaestro();                    
                }
                else
                {
                    MessageBox.Show("No es posible eliminar las factura porfavor intentelo nuevamnete");
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dtgvMaestro.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dtgvMaestro.CurrentRow.Cells[0].Value);
                var cliente = db.Facturacion.Where(x => x.Id == id).Select(x => new { x.Clientes.Nombre, x.Clientes.Apellido }).First();
                var factura = (from d in db.Facturacion
                               where d.Id == id  /*&& d.Nula == false || d.Nula == null*/
                               select d).First();

                if (factura.pagada == true)
                {
                    MessageBox.Show("La factura ya fue pagada");
                }
                else
                {
                    if (factura.Nula == true)
                    {
                        MessageBox.Show("Lo siento no es posible realizar el pago de una  factura que fue anulada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (factura != null)
                    {
                        if (MessageBox.Show($"Esta seguro de que desea dar por pagada la factura del cliente {cliente.Nombre} {cliente.Apellido} ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            factura.pagada = true;
                            db.SaveChanges();
                            RefreshMaestro();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Antes se debe de selecionar un resgitros de lo contrario no sera valida la accion");
            }
        }
        //private void Actualizacion(int? id)
        //{
        //    try
        //    {
        //        var act = (from d in db.Facturacion
        //                   where d.Id == id
        //                   select d).First();


        //        act.RazonNula = txtrazonnula.Text;
        //        act.Nula = true;
        //        act.FechaAnulacion = DateTime.Now;
        //        ////
        //        repuesta = false;

        //        //db.FacturacionDetalle.RemoveRange(Detalle);
        //        //db.Facturacion.Remove(Maestro);
        //        db.SaveChanges();
        //        MessageBox.Show("Anulacion de factura realizada exitosamente");
        //        RefreshMaestro();
        //    }
        //    catch { }
        //}
    }
}
