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
        }

        DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        private DataADO.Facturacion facturacion;
        private List<DataADO.FacturacionDetalle> FacturacionDetalle;

        private void llenar(string id)
        {
            var cli = db.Clientes.Find(Convert.ToInt32(id));

            lblidcliente.Text = cli.Id.ToString();
            txtNOmbre.Text = cli.Nombre;
            txtApellido.Text = cli.Apellido;
        }

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
        public string idfiltro;
        public string Productos;
        public decimal Existencia;

        private void Llenarproducto()
        {
            try
            {
                //idfiltro = dtgvFiltro.CurrentRow.Cells[0].Value.ToString();
                //Productos = dtgvFiltro.CurrentRow.Cells[1].Value.ToString();
                //Existencia = Convert.ToDecimal(dtgvFiltro.CurrentRow.Cells[5].Value.ToString());                
                
                string Filtro = txtfiltro.Text;
                
                if (Filtro != null)
                {
                    LlenarPro(Filtro);
                    Filtro = null;
                }
            }
            catch { }
        }
        private decimal? partcantidad = 1;
        private void LlenarPro(string Filtro)
        {
            string[] parts = Filtro.Split('*');
            string valorParte1 =  Clases.Veloz.VerificacionString(parts[0]); // primera parte
            if (parts.Length == 2)
            {
                partcantidad = Convert.ToDecimal(parts[1]); // Segunda parte
            }
            if (!string.IsNullOrEmpty(valorParte1))
            {
                var prod = db.Productos.Where(x => x.Codigo == valorParte1 || x.Producto == valorParte1).FirstOrDefault();


                if (prod == null)
                {
                    MessageBox.Show("Porfavor intetelo de nuevo el producto no existe");
                }
                else
                {
                    //var pro = db.Productos.Find(Convert.ToInt32(prod.Id));
                    if (prod.Cantidad_Existencia >= 1)
                    {
                        bool Existe = false;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == prod.Id)
                            {
                                MessageBox.Show($"El producto:{prod.Producto} ya fue insertado.");
                                Existe = true;
                            }
                        }
                        if (Existe == false)
                        {
                            if (prod.Cantidad_Existencia <= 5)
                            {
                                MessageBox.Show($"El producto: {Productos} se esta agotanto solo quedan: {prod.Cantidad_Existencia}");
                            }
                            dataGridView1.Rows.Add(prod.Id, prod.Producto, partcantidad, prod.Precio, prod.ITBS);
                            dataGridView1.MultiSelect = true;
                            partcantidad = 1;
                        }

                        dataGridView1.AllowUserToOrderColumns = false;
                        dataGridView1.BackgroundColor = Color.White;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                    else
                    {
                        MessageBox.Show($"El producto: {Productos} esta agotado.");
                    }
                    ReadOnly();
                }
            }
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes.BuscarClientes cli = new Clientes.BuscarClientes();
            cli.buscandi = true;
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
                MessageBox.Show("Debe de agregar un producto para poder continuar de lo contrario no podra continuar con el proceso");
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
                    Contado = (ckbContado.Checked == true) ? true : false                    
                };
                bool validacion = false;
                FacturacionDetalle = new List<DataADO.FacturacionDetalle>();               
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    int id = (int)rows.Cells["Id"].Value;
                    decimal Cantidad = Convert.ToDecimal( rows.Cells["Cantidad"].Value);

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
                                IdProducto = Convert.ToInt32(rows.Cells[0].Value),
                                Descuento = Convert.ToDecimal(rows.Cells[5].Value),
                                Cantidad = Convert.ToDecimal(rows.Cells[2].Value),
                                ITBIS = Convert.ToDecimal(rows.Cells[4].Value),
                                Precio = Convert.ToDecimal(rows.Cells[3].Value),     
                                //Impuesto = Convert.ToDecimal(rows.Cells[3].Value) * 0.18m,
                                Facturacion = facturacion
                            });
                            validacion = true;
                        }
                        else
                        {
                            MessageBox.Show($"NO es posible guardar una cantidad no exitente del producto: {Query.Producto} solo queda un acnatidad de: {Query.Cantidad_Existencia}.");
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
        /// Inplementacion para guardar el ecabezado y detalle de la factura
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

                Crear fr = new Crear();
                fr.MdiParent = Principal.GetForm;
                Close();
                fr.Show();
            }
            catch { }
            
        }
        private void Calculo()
        {
            decimal TotalCalculo = 0;
            decimal SubTotal = 0;
            decimal TotalDevuelta = 0;
            try
            {
                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    decimal cantidad = Convert.ToDecimal(rows.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(rows.Cells["Precio"].Value);
                    decimal Descuento = Convert.ToDecimal(rows.Cells["Descuento"].Value);
                    decimal ITBS = Convert.ToDecimal(rows.Cells["ITBS"].Value);
                    decimal Total =  (precio * cantidad) - Descuento + ITBS;
                    //si es diferente de cero en caso de que no itbs
                    decimal result = (Total != 0) ? Total : ITBS;

                    rows.Cells["Total"].Value = result;

                    if (cantidad != 0)
                    {
                        TotalCalculo += Convert.ToDecimal(rows.Cells["Total"].Value);
                        SubTotal += cantidad * precio;
                    }
                }
                txttotal.Text = TotalCalculo.ToString("N");
                txtsubtotal.Text = SubTotal.ToString("N");

                //Devolucion Calculo
                if (txttotal.Text.Length != 0)
                {                    
                    if (Convert.ToDecimal(txtefectivo.Text) >= TotalCalculo)
                    {
                        TotalDevuelta = Convert.ToDecimal(txtefectivo.Text) - TotalCalculo;
                        txtdevuelta.Text = TotalDevuelta.ToString("N");
                    }
                    else
                    {
                        txtefectivo.Text = string.Empty;
                        txtdevuelta.Text = string.Empty;
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
            TiposDePago();
            //ReadOnly();
            //refrescar();
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
            //richTextBox1.Text = string.Empty;
            //richTextBox1.Text = "";
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
            //idfiltro = null;
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

                    query.Cantidad_Existencia -= cantidad;
                    //pro.Add(query);
                    db.SaveChanges();
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
            pro.Show();
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

        private void TiposDePago()
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
        }

        private void ckbPagada_Click(object sender, EventArgs e)
        {
            if(ckbPagada.Checked == true)
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
    }
}
