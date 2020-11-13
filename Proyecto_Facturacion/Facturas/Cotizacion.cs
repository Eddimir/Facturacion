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
    public partial class Cotizacion : Form
    {
        private decimal partcantidad;

        public Cotizacion()
        {
            InitializeComponent();
        }

        private void FillControllers()
        {
            lbliduser.Text = Principal.veloz22.id.ToString();
            txtNombreUser.Text = Principal.veloz22.Nombre;

            //-->
            txtNombreUser.Enabled = false;
            txtNOmbre.Enabled = false;
            txtcedula.Enabled = false;
        }

        private void FillCustomers(int id)
        {
            var db = new DataADO.Proyecto1Entities();

            var cliente = db.Clientes.Find(id);
            lblidcliente.Text = cliente.Id.ToString();
            txtNOmbre.Text = cliente.Nombre;
            txtcedula.Text = cliente.Cedula;
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            Clientes.VerClientes verClientes = new Clientes.VerClientes();
            verClientes.Buscando = true;
            verClientes.ShowDialog();
            if(verClientes.id != null)
            {
                FillCustomers(Convert.ToInt32(verClientes.id));
            }
        }

        private void llenarProducto()
        {
            string Filtro = txtfiltro.Text;
            if (Filtro != null)
            {
                llenarProducto(Filtro);
                Filtro = null;
            }
        }

        private void llenarProducto(string filtro)
        {
            var db = new DataADO.Proyecto1Entities();

            string[] parts = filtro.ToString().Split('*');
            string valorParte1 = Clases.Veloz.VerificacionString(parts[0]); // primera parte

            if (parts.Length == 2)
            {
                partcantidad = Convert.ToDecimal(parts[1]); // Segunda parte}
            }
            if (!string.IsNullOrEmpty(valorParte1) || filtro != null)
            {
                //si es diferente de nulo el textbox entrara a la primera condicion de lo contrario entrara a la segunda
                var prod = (txtfiltro.Text.Length != 0) ? db.Productos.Where(x => x.Codigo == valorParte1 || x.Producto.ToUpper() == valorParte1.ToUpper()).FirstOrDefault()
                    : db.Productos.Find(Convert.ToInt32(filtro));

                if (prod == null)
                    MessageBox.Show("Porfavor intetelo de nuevo el producto no existe");
                else
                {
                    if (prod.Cantidad_Existencia >= 1)
                    {
                        bool Existe = false;
                        foreach (DataGridViewRow row in dtgvCotizacion.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == prod.Id)
                            {
                                MessageBox.Show($"El producto: {prod.Producto} ya fue insertado.");
                                Existe = true;
                            }
                        }
                        if (Existe == false)
                        {
                            if (partcantidad <= prod.Cantidad_Existencia)
                            {
                                if (prod.Cantidad_Existencia <= 5)
                                    MessageBox.Show($"El producto: {prod.Producto} se esta agotanto la cantidad existente es de: {prod.Cantidad_Existencia}");
                                
                                dtgvCotizacion.Rows.Add(prod.Id,null, prod.Codigo ?? "Sin codigo", prod.Producto, partcantidad, prod.Precio, 0, 0);
                                dtgvCotizacion.MultiSelect = true;
                                partcantidad = 1;
                            }
                            else
                            {
                                MessageBox.Show($"No puede agregar una cantidad no existente del producto: {prod.Producto}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        dtgvCotizacion.AllowUserToOrderColumns = false;
                        dtgvCotizacion.BackgroundColor = Color.White;
                        dtgvCotizacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                    else
                    {
                        MessageBox.Show($"El producto: {prod.Producto} esta agotado.");
                    }               
                }
            }
        }

        private void Guardar()
        {
            var db = new DataADO.Proyecto1Entities();
            if(dtgvCotizacion.Rows.Count == 0)
            {
                MessageBox.Show("Debe de agregar un producto para poder continuar de lo contrario no podra continuar con el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblidcliente.Text == "")
            {
                MessageBox.Show("Antes debe de agregar el cliente correpondiente de lo contrario no podra proseguir con la facturacion");
            }
            else
            {
                var Cotizacion = new DataADO.Cotizacion
                {
                    Fecha = DateTime.Now,
                    IdCliente = Convert.ToInt32(lblidcliente.Text),
                    IdUsuario = Convert.ToInt32(lbliduser.Text),
                    Observaciones = txtobs.Text,
                    Total = Convert.ToDecimal(txttotal.Text)
                };
                var cotizacionDetalle = new List<DataADO.CotizacionDetalle>();
                foreach(DataGridViewRow row in dtgvCotizacion.Rows)
                {
                    int id = (Int32)row.Cells[0].Value;
                    decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);

                    var query = (from i in db.Productos
                                 where i.Id == id
                                 select i).FirstOrDefault();

                    if(cantidad == 0)
                    {
                        MessageBox.Show($"Antecion, esta intentado una catidad igual a cero del producto: {query.Producto}, para poder continuar con el proceso,antes asegurece de modificar dicho producto con cantidad mayor o igual a 1.");
                    }
                    else if(query.Cantidad_Existencia >= cantidad && query.Cantidad_Existencia != 0)
                    {
                        cotizacionDetalle.Add(new DataADO.CotizacionDetalle
                        {
                            IdProducto = Convert.ToInt32(row.Cells["Id"].Value),
                            Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value),
                            Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value),
                            ITBS = Convert.ToDecimal(row.Cells["ITBS"].Value),
                            Precio = Convert.ToDecimal(row.Cells["Precio"].Value),
                            Cotizacion = Cotizacion                           
                        });
                    }
                }

                db.CotizacionDetalle.AddRange(cotizacionDetalle);
                db.Cotizacion.Add(Cotizacion);
                db.SaveChanges();

                Close();
                Facturas.Cotizacion fr = new Facturas.Cotizacion();              
                fr.Show();
            }
        }

        private void Calculo()
        {
            var db = new DataADO.Proyecto1Entities();
            decimal TotalCalculo = 0;
            decimal SubTotal = 0;
            decimal? Itbs = 0;

            foreach (DataGridViewRow row in dtgvCotizacion.Rows)
            {
                //Si tiene ITBS esta marcado en la celda el valor de itbs sera igual a :
                Itbs = Convert.ToBoolean(row.Cells["Impuesto"].Value) ? Itbs = db.TipoDeDivisa.Where(x => x.TipoDivisa.ToUpper() == "Dominicano".ToUpper()).FirstOrDefault().ITBS
                    : Itbs = 0;
                //if (Convert.ToBoolean(row.Cells["Impuesto"].Value))
                //{
                //    Itbs = db.TipoDeDivisa.Where(x => x.TipoDivisa.ToUpper() == "Dominicano".ToUpper()).FirstOrDefault().ITBS;
                //    //row.Cells["ITBS"].Value = Convert.ToDecimal(Itbs).ToString("N2");
                //}
                //else
                //{
                //    Itbs = 0;
                //    //row.Cells["ITBS"].Value = Itbs;
                //}

                decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                decimal Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                //Itbs = Convert.ToDecimal(row.Cells["ITBS"].Value);
                decimal Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);

                decimal Total = (Precio * Cantidad) - Descuento + (decimal)Itbs;
                //decimal result = (Total != 0) ? Total : Itbs;
                row.Cells["Total"].Value = Convert.ToDecimal((((Total != 0) ? Total : (decimal)Itbs)).ToString("N2"));

                TotalCalculo += Convert.ToDecimal(row.Cells["Total"].Value);
                SubTotal += Cantidad * Precio;
            }
            txttotal.Text = TotalCalculo.ToString("N");
            txtsubtotal.Text = SubTotal.ToString("N");
        }

        private void FillEfectivo()
        {
            var db = new DataADO.Proyecto1Entities();

            var cliente = db.Clientes.Where(c => c.Nombre.ToUpper() == "efectivo".ToUpper()).FirstOrDefault();

            lblidcliente.Text = cliente.Id.ToString();
            txtNOmbre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtcedula.Text = cliente.Cedula;
        }

        private void Txtfiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                llenarProducto();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            llenarProducto();
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            FillEfectivo();
            FillControllers();
            CenterToScreen();
        }

        private void DtgvCotizacion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculo();
        }

        private void DtgvCotizacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();         
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNOmbre.Text = "";
            txtApellido.Text = "";
            txtcedula.Text = "";
            lbliduser.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea facturar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guardar();
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Proyecto1.Productos.VerProductos fr = new Productos.VerProductos();
            fr.Buscando = true;
            fr.ShowDialog();

            if(fr.Id != null)
            {
                llenarProducto(Convert.ToString(fr.Id));
                fr.Id = null;
            }
        }

        private void DtgvCotizacion_CurrentCellChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void DtgvCotizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }
    }
}
