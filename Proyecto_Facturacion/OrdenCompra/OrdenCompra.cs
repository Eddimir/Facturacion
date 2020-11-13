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
    public partial class OrdenCompra : Form
    {
        public OrdenCompra()
        {
            InitializeComponent();
            db = new DataADO.Proyecto1Entities();
        }

        private DataADO.Proyecto1Entities db;
        private DataADO.OrdenCompra OrdenCompra1;
        private List<DataADO.OrdenCompraDetalle> OrdenCompraDetalle;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void llenarUserAndAgregatted()
        {
            lbliduser.Text = Principal.veloz22.id.ToString();
            txtNombreUser.Text = Principal.veloz22.Nombre +" "+ Principal.veloz22.Apellido;
            

            /*User*/
            lbliduser.Enabled = false;
            txtNombreUser.Enabled = false;
            txtrnc.Enabled = false;

            /*Customer*/
            lblidproveedor.Enabled = false;
            txtNOmbre.Enabled = false;
            txtApellido.Enabled = false;

            LlenarEfectivo();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Clientes.BuscarClientes frmclientes = new Clientes.BuscarClientes
            //{
            //    buscandi = true
            //};
            //frmclientes.ShowDialog();

            //if(frmclientes.id != null)
            //{
            //    //llenarCliente(frmclientes.id);
            //}
        }
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            Proveedores.verProveedores proveedores = new Proveedores.verProveedores();
            proveedores.buscando = true;
            proveedores.ShowDialog();

            if (proveedores.id != 0)
                llenarproveedor(proveedores.id);
        }
        private void llenarproveedor(int id)
        {
            var proveedor = db.Proveedores.Find(id);

            lblidproveedor.Text = proveedor.Id.ToString();
            txtNOmbre.Text = proveedor.Nombre;
            txtApellido.Text = proveedor.Apellido;
            txtrnc.Text = proveedor.razonsocial;
        }
        private void Producto()
        {
            string filtro = txtfiltro.Text;
            if(filtro!= null)
            {
                LlenarPro(filtro);
                filtro = null;
            }
        }

        private void LlenarPro(string filtro)
        {
            if (!string.IsNullOrEmpty(filtro))
            {
                var producto = (txtfiltro.Text.Length != 0) ? db.Productos.Where(x => x.Producto.Contains(filtro) || x.Codigo.Contains(filtro)).FirstOrDefault()
                    : db.Productos.Find(Convert.ToInt32(filtro));

                if (producto == null)
                {
                    MessageBox.Show("Porfavor intetelo de nuevo el producto no existe");
                }
                else
                {
                    bool existe = false;
                    foreach(DataGridViewRow row in dtgvordencompra.Rows)
                    {
                        if(Convert.ToInt32(row.Cells[0].Value) == producto.Id)
                        {
                            MessageBox.Show($"El producto: {producto.Producto} ya fue insertado.");
                            existe = true;
                        }
                    }
                    if(existe == false)
                    {
                        dtgvordencompra.Rows.Add(producto.Id,((producto.Codigo != null) ? producto.Codigo : "NO codigo") , producto.Producto, producto.Cantidad_Existencia, producto.Precio, producto.ITBS,0,0);                  
                        dtgvordencompra.MultiSelect = false;
                    }
                    dtgvordencompra.AllowUserToOrderColumns = false;
                    dtgvordencompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            
        }
       
        private void ActualizarExistencia()
        {
            foreach(DataGridViewRow row in dtgvordencompra.Rows)
            {
                int id = (Int32)row.Cells[0].Value;
                decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);

                var pro = (from pr in db.Productos
                          where pr.Id == id
                          select pr).First();

                if(pro != null)
                {
                    pro.Cantidad_Existencia += cantidad;
                    db.SaveChanges();
                }
            }
        }
        private void Guardar()
        {
            if (dtgvordencompra.Rows.Count == 0)
            {
                MessageBox.Show("Debe de agregar un producto para poder continuar de lo contrario no podra continuar con el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lblidproveedor.Text == "")
            {
                MessageBox.Show("Antes debe de agregar el cliente correpondiente de lo contrario no podra proseguir con la facturacion");
            }
            else
            {
                OrdenCompra1 = new DataADO.OrdenCompra()
                {
                    IdUsuario = Convert.ToInt32(lbliduser.Text),
                    IdProveedor = Convert.ToInt32(lblidproveedor.Text),
                    Fecha = DateTime.Now,
                    Observaciones = txtobs.Text,
                    Total = Convert.ToDecimal(txttotal.Text)                    
                };
                OrdenCompraDetalle = new List<DataADO.OrdenCompraDetalle>();
                foreach(DataGridViewRow row in dtgvordencompra.Rows)
                {
                    OrdenCompraDetalle.Add(new DataADO.OrdenCompraDetalle()
                    {
                        IdProducto = Convert.ToInt32(row.Cells["Id"].Value),
                        Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value),
                      
                        Precio = Convert.ToDecimal(row.Cells["Precio"].Value),
                        Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value),
                        ITBS = Convert.ToDecimal(row.Cells["ITBS"].Value),    
                        OrdenCompra = OrdenCompra1
                    });
                }

                db.OrdenCompra.Add(OrdenCompra1);
                db.OrdenCompraDetalle.AddRange(OrdenCompraDetalle);
                db.SaveChanges();
                ActualizarExistencia();

                Close();
                OrdenCompra ordenCompra = new OrdenCompra();
                ordenCompra.MdiParent = ActiveForm;
                ordenCompra.Show();              
            }            
        }
        private void Calculo()
        {
            decimal TotalCalculo = 0;
            decimal SubTotal = 0;

            foreach(DataGridViewRow row in dtgvordencompra.Rows)
            {
                decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                decimal Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                decimal Itbs = Convert.ToDecimal(row.Cells["ITBS"].Value);
                decimal Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);

                decimal Total = (Precio * Cantidad) - Descuento + Itbs;
                decimal result = (Total != 0) ? Total : Itbs;

                row.Cells["Total"].Value = Convert.ToDecimal(((result)).ToString("N2"));

                TotalCalculo += Convert.ToDecimal(row.Cells["Total"].Value);
                SubTotal += Cantidad * Precio;
            }
            txttotal.Text = TotalCalculo.ToString("N");
            txtsubtotal.Text = SubTotal.ToString("N");

        }

        private void dtgvordencompra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculo();
        }

        private void dtgvordencompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }

        private void dtgvordencompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea facturar la orden de compra?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guardar();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Productos.VerProductos pro = new Productos.VerProductos();
            pro.Buscando = true;
            pro.ShowDialog();
            if (pro.Id != null)
            {
                LlenarPro(Convert.ToString(pro.Id));
                pro.Id = null;
            }

           
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Producto();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Producto();
        }

     

        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            llenarUserAndAgregatted();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
        private void LlenarEfectivo()
        {
            var db = new DataADO.Proyecto1Entities();

            var pro = db.Proveedores.Where(x => x.Nombre.ToUpper() == "Efectivo".ToUpper()).FirstOrDefault();

            lblidproveedor.Text = pro.Id.ToString();
            txtNOmbre.Text = pro.Nombre;
            txtApellido.Text = pro.Apellido;
            txtrnc.Text = pro.razonsocial;
        }
    }
}
