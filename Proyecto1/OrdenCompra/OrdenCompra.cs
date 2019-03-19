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
        }

        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void llenarUserAndAgregatted()
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes.BuscarClientes frmclientes = new Clientes.BuscarClientes
            {
                buscandi = true
            };
            frmclientes.ShowDialog();

            if(frmclientes.id != null)
            {
                llenarCliente(frmclientes.id);
            }
        }

        private void llenarCliente(string id)
        {
            var cliente = db.Clientes.Find(Convert.ToInt32(id));

            lblidcliente.Text = cliente.Id.ToString();
            txtNOmbre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;           
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
                var producto = db.Productos.Where(x => x.Producto.Contains(filtro) || x.Codigo.Contains(filtro)).FirstOrDefault();

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
                        dtgvordencompra.Rows.Add(producto.Id, producto.Producto, producto.Cantidad_Existencia, producto.Precio, producto.ITBS);                  
                        dtgvordencompra.MultiSelect = false;
                    }
                    dtgvordencompra.AllowUserToOrderColumns = false;
                    dtgvordencompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }
        private void ReadOnly()
        {
            dtgvordencompra.Columns["ITBS"].ReadOnly = true;
            dtgvordencompra.Columns["Precio"].ReadOnly = true;
            dtgvordencompra.Columns["Total"].ReadOnly = true;
            dtgvordencompra.Columns["Producto"].ReadOnly = true;
        }

        private void ActualizarExistencia()
        {
            foreach(DataGridViewRow row in dtgvordencompra.Rows)
            {
                int id = (Int32)row.Cells[0].Value;
                decimal cantidad = Convert.ToDecimal(row.Cells[2].Value);

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
    }
}
