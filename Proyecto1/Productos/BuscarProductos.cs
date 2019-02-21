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
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        private DataADO.Productos dsproductos;
        public string IdProducto;
        public string Producto;

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            RefreFill();            
        }

        private IEnumerable<object> RefreFill()
        {
            using (var prdt = new DataADO.Proyecto1Entities())
            {
                var pro = (from d in prdt.Productos
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
        private void AutoAJuste()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReadOnly();
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
            
            decimal precio = Convert.ToDecimal(txtPrecio.Text) + Convert.ToDecimal(txtbeneficio.Text);
            dsproductos = new DataADO.Productos()
            {
                Codigo = GeneralCode(),
                Producto = txtproducto.Text,
                Despcricion = txtDescripcion.Text,
                Precio = precio,
                ITBS = Convert.ToDecimal(txtitbs.Text),
                Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text),
                Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text),
                Registro = DateTime.Now
            };

            db.Productos.Add(dsproductos);
            db.SaveChanges();

            estatus = estatus.Modificando;
            lblId.Text = dsproductos.Id.ToString();
        }

        private void actualizar(int id)
        {
            if (estatus == estatus.Modificando || estatus != estatus.Modificando)
            {
                //decimal precio = Convert.ToDecimal(txtPrecio.Text) + Convert.ToDecimal(txtbeneficio.Text);

                dsproductos = (from pro in db.Productos
                               where pro.Id == id
                               select pro).First();

                dsproductos.Producto = txtproducto.Text;
                dsproductos.Despcricion = txtDescripcion.Text;
                dsproductos.Precio = Convert.ToDecimal(txtPrecio.Text);
                dsproductos.ITBS = Convert.ToDecimal(txtitbs.Text);
                dsproductos.Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text);
                dsproductos.Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text);

                db.SaveChanges();
            }
            RefreFill();
        }
        private void Cargar(int? id)
        {
            if (id != null)
            {
                dsproductos = (from p in db.Productos
                               where p.Id == id
                               select p).First();

                lblId.Text = dsproductos.Id.ToString();
                txtproducto.Text = dsproductos.Producto;
                txtDescripcion.Text = dsproductos.Despcricion;
                txtPrecio.Text = dsproductos.Precio.ToString();
                txtitbs.Text = dsproductos.ITBS.ToString();
                txtbeneficio.Text = dsproductos.Margen_Beneficio.ToString();
                txtcantidad.Text = dsproductos.Cantidad_Existencia.ToString();
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
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
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
            CargaFiltro();

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
            CargaFiltro();
        }
    }
}
