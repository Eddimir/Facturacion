using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Almacen
{
    public partial class AlmacenMovimiento : Form
    {
        public AlmacenMovimiento()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        private void AlmacenMovimiento_Load(object sender, EventArgs e)
        {
            FillUserAndAgreggated();
            CenterToScreen();
        }

        private void FillUserAndAgreggated()
        {
            lbliduser.Text = Principal.veloz22.id.ToString();
            txtNombreUser.Text = Principal.veloz22.Nombre;
            txtApellidoUser.Text = Principal.veloz22.Apellido;

            /*User*/
            lbliduser.Enabled = false;
            txtNombreUser.Enabled = false;
            txtApellidoUser.Enabled = false;

            /*Customer*/
            lblidProveedor.Enabled = false;
            txtNOmbre.Enabled = false;
            txtApellido.Enabled = false;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Proveedores.Proveedores proveedores = new Proveedores.Proveedores();
            proveedores.buscando = true;
            proveedores.ShowDialog();

            if(proveedores.id != 0)
            {
                llenarproveedor(proveedores.id);
                proveedores = null;
            }
        }

        private void llenarproveedor(int id)
        {
            DataADO.Proveedores proveedores = db.Proveedores.Find(id);

            lblidProveedor.Text = proveedores.Id.ToString();
            txtNOmbre.Text = proveedores.Nombre;
            txtApellido.Text = proveedores.Apellido;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblidProveedor.Text = "";
            txtNOmbre.Text = "";
            txtApellido.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenar();            
        }
        private void llenar()
        {
            try
            {
                string Filtro = txtfiltro.Text;
                if (Filtro != null)
                {
                    llenarAlmacen(Filtro);
                    Filtro = null;
                }
            }
            catch { }
        }

        private void llenarAlmacen(string Filtro)
        {
            var Almacen = db.Almacen.Where(x => x.Producto == Filtro).FirstOrDefault();
            if(Almacen == null)
            {
                MessageBox.Show("Intentelo nuevo el producto no existe");
            }
            else
            {
                if(Almacen.Existencia >= 1)
                {
                    bool existe = false;
                    foreach(DataGridViewRow row in dtgvAlmacen.Rows)
                    {
                        if(Convert.ToInt32(row.Cells[0].Value) == Almacen.Id)
                        {
                            MessageBox.Show("El Producto ya fue insertado");
                            existe = true;                           
                        }
                    }
                    if(existe == false)
                    {
                        if(Almacen.Existencia <= 5)
                        {
                            MessageBox.Show($"El producto: {Almacen.Producto} se esta agotando solo quedan: {Almacen.Existencia} ");
                        }
                        dtgvAlmacen.Rows.Add(Almacen.Id, Almacen.Producto, 1, Almacen.Precio, Almacen.ITBS);
                        dtgvAlmacen.MultiSelect = true;
                    }
                    dtgvAlmacen.AllowUserToOrderColumns = false;
                    dtgvAlmacen.BackgroundColor = Color.White;
                    dtgvAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    ReadOnly();
                }
                else
                {
                    MessageBox.Show($"El producto:{Almacen.Producto} se ha agotado ");
                }
            }
                 
        }
        private void Calculo()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            try
            {
                foreach (DataGridViewRow row in dtgvAlmacen.Rows)
                {
                    decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    decimal ITBS = Convert.ToDecimal(row.Cells["ITBS"].Value);
                    decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    decimal Descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                    decimal MontoTotal = (cantidad * Precio) - Descuento + ITBS;

                    decimal result = (MontoTotal != 0) ? MontoTotal : ITBS;

                    row.Cells["Total"].Value = result;

                    if (result != 0)
                    {
                        Total += Convert.ToDecimal(row.Cells["Total"].Value);
                        SubTotal += cantidad * Precio;
                    }
                }
                txttotal.Text = Total.ToString();
                txtsubtotal.Text = SubTotal.ToString();
            }
            catch { }
        }
        private void ActualizarExistencia()
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                foreach (DataGridViewRow row in dtgvAlmacen.Rows)
                {
                    int id = (Int32)row.Cells["Id"].Value;
                    decimal Cantidad = (decimal)row.Cells["Cantidad"].Value;

                    var ProductoAL = (from AL in db.Almacen
                                      where AL.Id == id
                                      select AL).FirstOrDefault();

                    if (ProductoAL != null)
                    {
                        ProductoAL.Existencia += Cantidad;
                        db.SaveChanges();
                    }
                }
            }
        }
        private void Guardar()
        {
            if(dtgvAlmacen.Rows.Count == 0)
            {
                MessageBox.Show("Debe de agregar un producto para poder continuar de lo contrario no podra continuar con el proceso");
            }
            else if(lblidProveedor.Text.Length == 0)
            {
                MessageBox.Show("Antes se debe de agregar el proveedor  correpondiente para poder continuar con el proceso de almacenamiento, de lo contrario no podra proseguir");
            }
            else
            {
                DataADO.AlmacenMovimiento AlmacenMovimiento = new DataADO.AlmacenMovimiento()
                {
                    IdUsuarios = Convert.ToInt32(lbliduser.Text),
                    IdProveedor = Convert.ToInt32(lblidProveedor.Text),
                    Observacion = richTextBox1.Text,
                    Fecha = DateTime.Now,
                    Total = Convert.ToDecimal(txttotal.Text)
                };
                bool validacion = false;
                List<DataADO.AlmacenDetalle> AlmacenDetalle = new List<DataADO.AlmacenDetalle>();
                foreach(DataGridViewRow row in dtgvAlmacen.Rows)
                {
                    int id = (Int32)row.Cells[0].Value;
                    decimal cantidad = (decimal)row.Cells["Cantidad"].Value;

                    var query = (from pro in db.Almacen
                                 where pro.Id == id
                                 select pro).FirstOrDefault();


                    if(cantidad == 0)
                    {
                        MessageBox.Show($"Asegurese de agregar la cantidad del producto: {query.Producto} seleccionado esta debe de ser mayor o igual a 1 de lo contrario la accion no sera valida.");
                    }
                    else if(query.Existencia >= cantidad && query.Existencia != 0)
                    {
                        AlmacenDetalle.Add(new DataADO.AlmacenDetalle()
                        {
                            Idalmacen = (Int32)row.Cells[0].Value,
                            Cantidad = (decimal)row.Cells["Cantidad"].Value,
                            costo = (decimal)row.Cells["Descuento"].Value,
                            AlmacenMovimiento = AlmacenMovimiento
                        });
                        validacion = true;
                    }
                    else
                    {
                        MessageBox.Show($"NO es posible guardar una cantidad no exitente del producto: {query.Producto} solo quedan: {query.Existencia}.");
                        validacion = false;                        
                    }

                }
                if(validacion == true)
                {
                    Validacion(AlmacenDetalle, AlmacenMovimiento);
                }
            }
        }
        private void Validacion(List<DataADO.AlmacenDetalle> almacenDetalles ,DataADO.AlmacenMovimiento almacenMovimiento )
        {
            try
            {
                db.AlmacenDetalle.AddRange(almacenDetalles);
                db.AlmacenMovimiento.Add(almacenMovimiento);
                db.SaveChanges();
                ActualizarExistencia();

                AlmacenMovimiento fralmacen = new AlmacenMovimiento();
                fralmacen.MdiParent = Principal.GetForm;
                Close();
                fralmacen.Show();
            }
            catch { }
        }

        private void dtgvAlmacen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Calculo();
        }

        private void dtgvAlmacen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }

        private void dtgvAlmacen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Calculo();
        }

        private void dtgvAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Almacen fralmacen = new Almacen();
            fralmacen.Show();
        }

        private void btnCleam_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        private void ReadOnly()
        {
            dtgvAlmacen.Columns["ITBS"].ReadOnly = true;
            dtgvAlmacen.Columns["Precio"].ReadOnly = true;
            dtgvAlmacen.Columns["Total"].ReadOnly = true;
            dtgvAlmacen.Columns["Producto"].ReadOnly = true;
        }

        private void txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                llenar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
    
}
