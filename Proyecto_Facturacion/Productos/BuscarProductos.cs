using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto1.Clases.Veloz;

namespace Proyecto1.Productos
{
    public partial class BuscarProductos : Form
    {
        public BuscarProductos()
        {
            InitializeComponent();
        }

        estatus estatus;
        private DataADO.Proyecto1Entities db;
        private DataADO.Productos Producto;
        public string IdProducto;

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            RefreshFill();            
        }

        private IEnumerable<object> RefreshFill()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var pro = (from d in db.Productos
                           select new
                           {
                               d.Id,
                               d.Producto,
                               d.Precio,
                               d.ITBS,
                               d.Despcricion,
                               d.Cantidad_Existencia
                           });

                dataGridView1.DataSource = pro.OrderBy(x => x.Id).ToList();
                AutoAJuste();

                return pro.ToList();
            }
        }
   
       

        //private void btnSeleccionar_Click(object sender, EventArgs e)
        //{
        //    if (buscando)
        //    {
        //        IdProducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //        //Producto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //        Close();
        //    }
        //    else
        //    {
        //        frpro.lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //        frpro.ShowDialog();
        //    }


        //}
        private void ReadOnly()
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            lblId.Text = "";
            txtbeneficio.Text = "";
            txtcantidad.Text = "";
            txtDescripcion.Text = "";
            txtitbs.Text = "";
            txtproducto.Text = "";
            txtPrecio.Text = "";
            ckbVencimiento.Checked = false;

        }
        private string GeneralCode()
        {
            var yearL = DateTime.Now.Year.ToString().Substring(1);
            var mes = DateTime.Now.Month; 
            var dia = DateTime.Now.Day;
            var hora = DateTime.Now.Hour;              
            var segundo = DateTime.Now.Second;

            var codigo = yearL +""+mes + "" + dia + "" + hora  + "" + segundo;
            

            return codigo;

        }

        private void Crear()
        {
            using (db = new DataADO.Proyecto1Entities())
            {

                decimal beneficio = (txtbeneficio.Text.Length == 0) ? 0 : Convert.ToDecimal(txtbeneficio.Text);
                decimal Precio = (txtPrecio.Text.Length == 0) ? 0 : Convert.ToDecimal(txtPrecio.Text);
                decimal precioTotal = ((Precio + beneficio) == 0.00m) ? 0 : Precio + beneficio;

                if (precioTotal == 0)
                {
                    MessageBox.Show("El precio  no  puede ser igual a 0, porfavor modificar el registro");
                }
                else if (precioTotal != 0)
                {
                   var  Producto = new DataADO.Productos
                   {
                        Codigo = GeneralCode(),
                        Producto = txtproducto.Text,
                        Despcricion = txtDescripcion.Text,
                        Precio = precioTotal,
                        ITBS = (txtitbs.Text.Length == 0) ? 0 : Convert.ToDecimal(txtitbs.Text),
                        Cantidad_Existencia = (txtcantidad.Text.Length == 0) ? 0 : Convert.ToDecimal(txtcantidad.Text),
                        Margen_Beneficio = beneficio,
                        Registro = DateTime.Now,
                        AvisarVencimiento = (ckbVencimiento.Checked == true) ? true : false
                    };

                    db.Productos.Add(Producto);
                    db.SaveChanges();

                    estatus = estatus.Modificando;
                    lblId.Text = Producto.Id.ToString();
                    RefreshFill();
                }
            }
        }

        private void actualizar(int id)
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                if (estatus == estatus.Modificando || estatus != estatus.Modificando)
                {
                    //decimal precio = Convert.ToDecimal(txtPrecio.Text) + Convert.ToDecimal(txtbeneficio.Text);

                    var Producto = (from pro in db.Productos
                                    where pro.Id == id
                                    select pro).First();

                    Producto.Producto = txtproducto.Text;
                    Producto.Despcricion = txtDescripcion.Text;
                    Producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                    Producto.ITBS = Convert.ToDecimal(txtitbs.Text);
                    Producto.Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text);
                    Producto.Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text);

                    db.SaveChanges();
                }
            }
            RefreshFill();
        }
        private void Cargar(int? id)
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                if (id != null)
                {
                    var Producto = (from p in db.Productos
                                    where p.Id == id
                                    select p).First();

                    lblId.Text = Producto.Id.ToString();
                    txtproducto.Text = Producto.Producto;
                    txtDescripcion.Text = Producto.Despcricion;
                    txtPrecio.Text = Producto.Precio.ToString();
                    txtitbs.Text = Producto.ITBS.ToString();
                    txtbeneficio.Text = Producto.Margen_Beneficio.ToString();
                    txtcantidad.Text = Producto.Cantidad_Existencia.ToString();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
            {
                Crear();
            }
            else
            {
                actualizar(Convert.ToInt32(lblId.Text));
            }
            RefreshFill();
           
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                var pro = (from d in db.Productos
                           where d.Producto.Contains(txtfiltro.Text) || d.Despcricion.Contains(txtfiltro.Text)
                           select new
                           {
                               d.Id,
                               d.Producto,
                               d.Precio,
                               d.ITBS,
                               d.Despcricion,
                               d.Cantidad_Existencia
                           });

                dataGridView1.DataSource = pro.ToList();
                AutoAJuste();
                
            }

        }
        private void CargaFiltro()
        {
            try
            {
                lblId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                int? id = Convert.ToInt32(lblId.Text);
                Cargar(id);

            }
            catch { }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void AutoAJuste()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.MultiSelect = true;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.Columns[0].Visible = false;
            ReadOnly();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CargaFiltro();
        }
    }
}
