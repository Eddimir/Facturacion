using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Proyecto1.Clases.Veloz;

namespace Proyecto1.Almacen
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        estatus estatus;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Almacen_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (estatus == estatus.creando)
                lblid.Text = "";
            if (lblid.Text.Length != 0)
                Cargar(Convert.ToInt32(lblid.Text));
        }

        //private void txtfiltro_TextChanged(object sender, EventArgs e)
        //{
        //    var almacen = from d in db.Almacen
        //                  where d.Producto.Contains(txtfiltro.Text) || d.Descripcion.Contains(txtfiltro.Text)
        //                  select new
        //                  {
        //                      d.Id,
        //                      d.Producto,
        //                      d.Descripcion,
        //                      d.Precio,
        //                      d.Existencia,
        //                      d.ITBS
        //                  };
        //    dtgvAlmacen.DataSource = almacen.OrderBy(x => x.Id).ToList();
        //    Autosize();

        //    Filtro();

        //}

        //private void Filtro()
        //{
        //    lblid.Text = dtgvAlmacen.CurrentRow.Cells["Id"].Value.ToString();
        //    int? id = Convert.ToInt32(lblid.Text);
        //    Cargar(id);
        //}


        private void Cargar(int? id)
        {
            if (id != null)
            {
                var almacen = (from al in db.Almacen
                               where al.Id == id
                               select al).First();

                lblid.Text = almacen.Id.ToString();
                txtproducto.Text = almacen.Producto;
                txtprecio.Text = almacen.Precio.ToString();
                txtitbs.Text = almacen.ITBS.ToString();
                txtexistencia.Text = almacen.Existencia.ToString();
                txtdescripcion.Text = almacen.Descripcion;
            }
        }
     
        private void Crear()
        {
            if (txtproducto.Text == string.Empty)
            {
                errorProvider1.SetError(txtproducto, "Ingrese un nombre");
            }
            if (txtprecio.Text == "")
                errorProvider1.SetError(txtprecio, "Ingrese un precio del producto");
            else
            {
                DataADO.Almacen almacen = new DataADO.Almacen()
                {
                    Producto = txtproducto.Text,
                    Precio = Convert.ToDecimal(txtprecio.Text),
                    Existencia = Convert.ToDecimal(txtexistencia.Text),
                    Descripcion = txtdescripcion.Text,
                    ITBS = (txtitbs.Text.Length != 0) ? Convert.ToDecimal(txtitbs.Text) : 0
                };

                db.Almacen.Add(almacen);
                db.SaveChanges();

                estatus = estatus.creando;
                lblid.Text = almacen.Id.ToString();
            }
        }
        private void Actualizar(int id)
        {
            if (txtproducto.Text == "")
                errorProvider1.SetError(txtproducto, "Ingrese el nombre del producto");
            if (txtprecio.Text == "")
                errorProvider1.SetError(txtprecio, "Ingrese el precio del producto");
            else
            {

                if (estatus == estatus.Modificando)
                {
                    var almacen = (from al in db.Almacen
                                   where al.Id == id
                                   select al).First();

                    almacen.Id = Convert.ToInt32(lblid.Text);
                    almacen.Producto = txtproducto.Text;
                    almacen.Precio = Convert.ToDecimal(txtprecio.Text);
                    almacen.ITBS = Convert.ToDecimal(txtitbs.Text);
                    almacen.Existencia = Convert.ToDecimal(txtexistencia.Text);
                    almacen.Descripcion = txtdescripcion.Text;

                    db.SaveChanges();
                }
            }
        }
        private void btnGUardar_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Length == 0)
                Crear();
            else
            {
                Actualizar(Convert.ToInt32(lblid.Text));
                estatus = estatus.Modificando;
            }
        }

        private void dtgvAlmacen_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (lblid.Text.Length == 0)
                    {
                        MessageBox.Show("Para poder continuar con la accion antes debe de seleccionar el producto que desea  eliminar");
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que desea eliminar el producto esta accion no se podra deshacer?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            var almacen = db.Almacen.Find(Convert.ToInt32(lblid.Text));
                            db.Almacen.Remove(almacen);
                            db.SaveChanges();
                            MessageBox.Show("Registro eliminado correctamente");
                        }
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show("El registro del producto no puede ser eliminado debido a que este esta asociado a otros registros y dicha accion puede general problemas en los registros asociados.." + ex.Message); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            lblid.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtitbs.Text = "";
            txtexistencia.Text = "";
            txtdescripcion.Text = ""; 
        }

       
    }
}
