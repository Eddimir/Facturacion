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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
            db  = new DataADO.Proyecto1Entities();
        }

        DataADO.Proyecto1Entities db;
        private DataADO.Facturacion facturacion;
        private List<DataADO.FacturacionDetalle> FacturacionDetalle;

        //private void llenar(string id)
        //{
        //    var cli = db.Clientes.Find(Convert.ToInt32(id));

        //    lblidcliente.Text = cli.Id.ToString();
        //    txtNOmbre.Text = cli.Nombre;
        //    txtApellido.Text = cli.Apellido;
        //}

        //private void btnBucarProducto_Click(object sender, EventArgs e)
        //{
        //    //Productos.BuscarProductos FrProduct = new Productos.BuscarProductos();
        //    //FrProduct.buscando = true;
        //    //FrProduct.ShowDialog();
            

        //    //if(FrProduct.IdProducto != null)
        //    //{
        //    //    LlenarPro(FrProduct.IdProducto);
        //    //    FrProduct.IdProducto = null;
        //    //}
        //}
        public String idfiltro;
        public string Productos;
        public Decimal Existencia;

        private void Llenarproducto()
        {
            try
            {             
                string filtro =  txtfiltro.Text;
                
                if (filtro != null)
                {
                    LlenarPro(filtro);
                    filtro = null;
                    txtfiltro.Text = "";
                }
            }
            catch { }
        }
        private decimal? partcantidad = 1;
        private void LlenarPro(string Filtro)
        {
            string[] parts = Filtro.ToString().Split('*');
            string valorParte1 = Clases.Veloz.VerificacionString(parts[0]); // primera parte

            if (parts.Length == 2)
            {
                partcantidad = Convert.ToDecimal(parts[1]); // Segunda parte               
            }         

            if (!string.IsNullOrEmpty(valorParte1) || Filtro != null)
            {
                //si es diferente de nulo el textbox entrara a la primera condicion de lo contrario entrara a la segunda
                var prod =(txtfiltro.Text.Length != 0)? db.Productos.Where(x => x.Codigo == valorParte1 || x.Producto.ToUpper() == valorParte1.ToUpper()).FirstOrDefault() 
                    : db.Productos.Find(Convert.ToInt32(Filtro));

                if (prod == null)
                {
                    MessageBox.Show("Porfavor intetelo de nuevo el producto no existe");
                }
                else
                {
                    if (prod.Cantidad_Existencia >= 1)
                    {
                        bool Existe = false;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == prod.Id)
                            {
                                MessageBox.Show($"El producto: {prod.Producto} ya fue insertado.");
                                Existe = true;
                            }
                        }
                        if (Existe == false)
                        {
                            if ( partcantidad <= prod.Cantidad_Existencia)
                            {
                                if (prod.Cantidad_Existencia <= 5)
                                {
                                    MessageBox.Show($"El producto: {prod.Producto} se esta agotanto la cantidad existente es de: {prod.Cantidad_Existencia}");
                                }
                                dataGridView1.Rows.Add(prod.Id,prod.Codigo, prod.Producto, partcantidad, prod.Precio,0,0);
                                dataGridView1.MultiSelect = true;
                                partcantidad = 1;
                            }
                            else
                            {
                                MessageBox.Show($"No puede agregar una cantidad no existente del producto: {prod.Producto}","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        dataGridView1.AllowUserToOrderColumns = false;
                        dataGridView1.BackgroundColor = Color.White;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                    else
                    {
                        MessageBox.Show($"El producto: {prod.Producto} esta agotado.");
                    }
                    ReadOnly();
                }
            }
            //Filtro = null;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes.VerClientes cli = new Clientes.VerClientes();
            cli.Buscando = true;
            cli.ShowDialog();

            if (cli.id != null)
            {
                llenarCli(cli.id);
                cli.id = null;
            }
        }
        private void llenarCli(string id)
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var cliente = db.Clientes.Find(Convert.ToInt32(id));

                lblidcliente.Text = cliente.Id.ToString();
                txtNOmbre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                textBox1.Text = cliente.Cedula;

                textBox1.Enabled = false;
            }
        }
        //private void llenarUser()
        //{
        //    lbliduser.Text =  Principal.veloz22.id.ToString();
        //    txtNombreUser.Text = Principal.veloz22.Nombre;
        //    txtApellidoUser.Text = Principal.veloz22.Apellido;
        //}
        private void Guardar()
        {
            int longitud = 300;
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe de agregar un producto para poder continuar de lo contrario no podra continuar con el proceso","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (lblidcliente.Text == "")
            {
                MessageBox.Show("Antes debe de agregar el cliente correpondiente de lo contrario no podra proseguir con la facturacion");
            }
            else if(txtdescripcionPago.TextLength <= longitud)
            {
                DateTime? valor = null;
                //Fecha vencimiento en caso de que sea igual a verdadero otendre el valor del datapaicker en caso de que sea falso sera igual a null
                facturacion = new DataADO.Facturacion()
                {
                    idCliente = Convert.ToInt32(lblidcliente.Text),
                    idUsario = Convert.ToInt32(lbliduser.Text),
                    IdTiPoDePago = Convert.ToInt32(cmbTipoDePago.SelectedValue),
                    Observaciones = richTextBox1.Text,
                    Fecha = DateTime.Now,
                    Total = Convert.ToDecimal(txttotal.Text),
                    DetalleTipoDepago = txtdescripcionPago.Text,
                    pagada = (ckbPagada.Checked == true) ? true : false,
                    FechaVencimiento =  (ckbPagada.Checked == false) ? Convert.ToDateTime(dtfechavencimiento.Value) : valor,
                    Contado = (ckbContado.Checked == true) ? true : false,
                    IdTipoDivisa = Convert.ToInt32(cmbtipodivisa.SelectedValue)
                };
                bool validacion = false;
                FacturacionDetalle = new List<DataADO.FacturacionDetalle>();               
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    int id = (int)rows.Cells["Id"].Value;
                    decimal Cantidad = Convert.ToDecimal(rows.Cells["Cantidad"].Value);

                    var Query = (from pro in db.Productos
                                 where pro.Id == id
                                 select pro).FirstOrDefault();

                    if (Cantidad == 0)
                    {
                        MessageBox.Show($"Asegurese de agregar la cantidad del producto: {Query.Producto} seleccionado esta debe de ser mayor o igual a 1 de lo contrario la accion no sera valida.");
                    }
                    else
                    {
                        if (Query.Cantidad_Existencia >= Cantidad && Query.Cantidad_Existencia != 0)
                        {
                            FacturacionDetalle.Add(new DataADO.FacturacionDetalle()
                            {
                                IdProducto = Convert.ToInt32(rows.Cells["Id"].Value),
                                Descuento = Convert.ToDecimal(rows.Cells["Descuento"].Value),
                                Cantidad = Convert.ToDecimal(rows.Cells["Cantidad"].Value),
                                ITBIS = Convert.ToDecimal(rows.Cells["ITBS"].Value),
                                Precio = Convert.ToDecimal(rows.Cells["Precio"].Value),                                
                                //Impuesto = Convert.ToDecimal(rows.Cells[3].Value),
                                Facturacion = facturacion
                            });
                            validacion = true;
                        }
                        else
                        {
                            MessageBox.Show($"NO es posible guardar una cantidad no exitente del producto: {Query.Producto} solo queda una cantidad de: {Query.Cantidad_Existencia}.");
                            validacion = false;
                        }
                    }                   
                }
                if (validacion == true)
                {
                    validacion1(FacturacionDetalle, facturacion);
                }               
            }
            else
            {
                MessageBox.Show("El detalle de tipo de pago supera la longitud maxima de carateres que es igual a: {0}",longitud.ToString());
            }
        }
        /// <summary>
        /// Inplementacion para guardar el encabezado y detalle de la factura
        /// </summary>
        /// <param name="resultado"></param>
        /// <param name="detalle"></param>
        /// <param name="facturacion1"></param>
        public void validacion1(List<DataADO.FacturacionDetalle> detalle, DataADO.Facturacion facturacion1)
        {
            try
            {
                db.FacturacionDetalle.AddRange(detalle);
                db.Facturacion.Add(facturacion1);
                db.SaveChanges();
                actualizaciondeexistencia();

                int? idFactura = db.Facturacion.Max(x => x.Id);             

                if(idFactura != null)
                {
                    Close();
                    Crear fr = new Crear();
                    fr.MdiParent = ActiveForm;
                    fr.Show();
                    //Clases.ReportesPuntoVenta.Facturacion(idFactura);
                }
                else { MessageBox.Show("Se guardara pero no se imprimira el recibo."); }              
            }
            catch { }
            
        }

        private void Calculo()
        {
            try
            {
                decimal TotalCalculo = 0, SubTotal = 0, cantidad, precio, Descuento, Total;
                decimal?  ITBS=0, tipodinero = 0;

                db = new DataADO.Proyecto1Entities();
                if (dataGridView1.Rows.Count >= 1)
                {
                    foreach (var tipo in db.TipoDeDivisa.Select(x => new { x.TipoDivisa, x.Valor, x.ITBS }).ToList())
                    {
                        if (cmbtipodivisa.Text.ToUpper() == tipo.TipoDivisa.ToUpper())
                        {
                            tipodinero = tipo.Valor;
                            if (ckbITBS.Checked)
                                ITBS = tipo.ITBS;
                            break;
                        }
                    }
                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                    {
                        cantidad = Convert.ToDecimal(rows.Cells["Cantidad"].Value);
                        precio = (cmbtipodivisa.Text != "Dominicano") ? Convert.ToDecimal(rows.Cells["Precio"].Value) / Convert.ToDecimal(tipodinero)
                            : Convert.ToDecimal(rows.Cells["Precio"].Value);

                        Descuento =  Convert.ToDecimal(rows.Cells["Descuento"].Value);
                       
                        Total = (precio * cantidad) - Descuento + (decimal)ITBS;
                        decimal result = (Total != 0) ? Total : (decimal)ITBS;

                        rows.Cells["Total"].Value = Convert.ToDecimal(((result * ITBS) + result)).ToString("N2");
                        rows.Cells["ITBS"].Value = Convert.ToDecimal(ITBS).ToString("N3");
                       

                        TotalCalculo += Convert.ToDecimal(rows.Cells["Total"].Value);
                        SubTotal += cantidad * precio;
                    }
  
                    txttotal.Text = TotalCalculo.ToString("N");
                    txtsubtotal.Text = SubTotal.ToString("N");                    
                    
                    if (txttotal.Text.Length != 0)
                    {
                        if (Convert.ToDecimal(txtefectivo.Text) >= TotalCalculo)
                        {
                            txtdevuelta.Text = (Convert.ToDecimal(txtefectivo.Text) - TotalCalculo).ToString("N");
                            errorProvider1.Clear();
                        }
                        else
                        {
                            txtefectivo.Text = string.Empty;
                            txtdevuelta.Text = string.Empty;
                            errorProvider1.SetError(txtefectivo, "El total entregado por el cliente debe de ser igual o mayor al total.");                         
                        }
                    }
                }
            }
            catch { }
        }
        private void ReadOnly()
        {
            //dataGridView1.Columns["Id"].ReadOnly = true;
            dataGridView1.Columns["ITBS"].ReadOnly = true;
            dataGridView1.Columns["Precio"].ReadOnly = true;
            dataGridView1.Columns["Total"].ReadOnly = true;
            dataGridView1.Columns["Producto"].ReadOnly = true;
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FillUserAndAgregatted();
            CargarFactura();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void FillUserAndAgregatted()
        {
            lbliduser.Text = Principal.veloz22.id.ToString();
            txtNombreUser.Text = Principal.veloz22.Nombre;
            txtApellidoUser.Text = Principal.veloz22.Apellido;

            /*User*/
            lbliduser.Enabled = false;
            txtNombreUser.Enabled = false;
            txtApellidoUser.Enabled = false;

            /*Customer*/
            lblidcliente.Enabled = false;
            txtNOmbre.Enabled = false;
            txtApellido.Enabled = false;
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            ////idfiltro = null;
           
            //if (string.IsNullOrEmpty(txtfiltro.Text))
            //{
            //    //refrescar();
            //}
            //else
            //{
            //    //using (var db = new DataADO.Proyecto1Entities())
            //    //{
            //    //    var q = from d in db.Productos
            //    //            where d.Producto.Contains(txtfiltro.Text) || d.Despcricion.Contains(txtfiltro.Text)
            //    //            select new
            //    //            {
            //    //                d.Id,
            //    //                d.Producto,
            //    //                d.Precio,
            //    //                d.ITBS,
            //    //                d.Despcricion,
            //    //                Exitencia = d.Cantidad_Existencia
            //    //            };

            //    //    if (q != null)
            //    //    {
            //    //        dtgvFiltro.DataSource = q.OrderBy(x => x.Id).ToList();
            //    //        dtgvFiltro.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    //        dtgvFiltro.MultiSelect = true;
            //    //    }
            //    //    //Llenarproducto();
            //    //}
            //}
        }

        private void dtgvFiltro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Llenarproducto();
        }

        private void dtgvFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Llenarproducto();
        }
        //private void refrescar()
        //{
        //    using (var db = new DataADO.Proyecto1Entities())
        //    {
        //        var q = from d in db.Productos
        //                select new
        //                {
        //                    d.Id,
        //                    d.Producto,
        //                    d.Precio,
        //                    d.ITBS,
        //                    d.Despcricion,
        //                    Cantidad = d.Cantidad_Existencia
        //                };


        //        dataGridView1.DataSource = q.OrderBy(x => x.Id).ToList();
        //        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //        dataGridView1.MultiSelect = true;               
        //    }
       
        private void actualizaciondeexistencia()
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                //List<DataADO.Productos> pro = new List<DataADO.Productos>();
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    int id = (Int32)row.Cells[0].Value;
                    var cantidad = Convert.ToDecimal(row.Cells[2].Value);

                    var query = (from h in db.Productos
                                 where h.Id == id
                                 select h).First();

                    if(query != null)
                    {
                        query.Cantidad_Existencia -= cantidad;
                        db.SaveChanges();
                    }
                }
            }
        }

        //private void dtgvFiltro_KeyDown(object sender, KeyEventArgs e)
        //{
        //  
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de que desea facturar?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guardar();
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llenarproducto();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Productos.VerProductos pro = new Productos.VerProductos();
            pro.Buscando = true;
            pro.ShowDialog();

            if(pro.Id != null)
            {
                LlenarPro(Convert.ToString(pro.Id));
                pro.Id = null;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }

        private void txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Llenarproducto();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtefectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (txttotal.Text.Length != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Calculo();
                }
            }
        }

        private void CargarFactura()
        {
            var Tipos = from t in db.TipoDePago
                        select new
                        {
                            t.Id,
                            t.TipoDePago1
                        };

            cmbTipoDePago.DataSource = Tipos.ToList();
            cmbTipoDePago.ValueMember = "Id";
            cmbTipoDePago.DisplayMember = "TipoDePago1";
            cmbTipoDePago.FlatStyle = FlatStyle.Flat;
            cmbTipoDePago.DropDownStyle = ComboBoxStyle.DropDownList;

            ///////////////////////////
            var tipodivisa = db.TipoDeDivisa
                               .Select(x => new
                               {
                                   x.Id,
                                   x.TipoDivisa
                               });                            

            cmbtipodivisa.DataSource = tipodivisa.ToList();
            cmbtipodivisa.ValueMember = "Id";
            cmbtipodivisa.DisplayMember = "TipoDivisa";
            cmbtipodivisa.FlatStyle = FlatStyle.Flat;
            cmbtipodivisa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipodivisa.SelectedIndex = 2;

            ///////////////////////
            var clientedefault = db.Clientes.Where(x => x.Nombre.ToLower() == "Efectivo".ToLower())
                .Select(x => new
                {
                    x.Id,
                    x.Nombre,
                    x.Apellido
                }).FirstOrDefault();

            lblidcliente.Text = clientedefault.Id.ToString();
            txtNOmbre.Text = clientedefault.Nombre;
            txtApellido.Text = clientedefault.Apellido;


            ///
            lblidcliente.Visible = false;
            lbliduser.Visible = false;
        }

        private void ckbPagada_Click(object sender, EventArgs e)
        {
            if(ckbPagada.Checked)
            {
                dtfechavencimiento.Visible = false;
                label4.Visible = false;
            }
            else
            {
                dtfechavencimiento.Visible = true;
                label4.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro de que desea cancelar la factura";
            string Eslogam = "Punto de venta en desarrollo";
            DialogResult =  MessageBox.Show(mensaje, Eslogam, MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Close();
                Crear fr = new Crear();
                fr.MdiParent = ActiveForm;
                fr.Show();
            }
        }

        private void cmbtipodivisa_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void CkbITBS_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1)
                Calculo();
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
