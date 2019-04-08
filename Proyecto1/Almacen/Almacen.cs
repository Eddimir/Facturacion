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

        private void RefreshAlmacen()
        {
            var almacen = from al in db.Almacen
                          select new
                          {
                              al.Id,
                              al.Producto,
                              al.Descripcion,
                              al.Precio,
                              al.Existencia,
                              al.ITBS
                          };

            dtgvAlmacen.DataSource = almacen.OrderBy(x => x.Id).ToList();
            Autosize();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            RefreshAlmacen();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            var almacen = from d in db.Almacen
                          where d.Producto.Contains(txtfiltro.Text) || d.Descripcion.Contains(txtfiltro.Text)
                          select new
                          {
                              d.Id,
                              d.Producto,
                              d.Descripcion,
                              d.Precio,
                              d.Existencia,
                              d.ITBS
                          };
            dtgvAlmacen.DataSource = almacen.OrderBy(x => x.Id).ToList();
            Autosize();

            Filtro();

        }

        private void Filtro()
        {
            lblid.Text = dtgvAlmacen.CurrentRow.Cells["Id"].Value.ToString();
            int? id = Convert.ToInt32(lblid.Text);
            Cargar(id);
        }


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
        private void Autosize()
        {
            dtgvAlmacen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvAlmacen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAlmacen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvAlmacen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvAlmacen.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtgvAlmacen.MultiSelect = true;
            dtgvAlmacen.AllowUserToOrderColumns = false;
            dtgvAlmacen.AllowUserToDeleteRows = false;
            dtgvAlmacen.BackgroundColor = Color.White;

            dtgvAlmacen.Columns[0].Visible = false;
            dtgvAlmacen.Columns[1].ReadOnly = true;
            dtgvAlmacen.Columns[2].ReadOnly = true;
            dtgvAlmacen.Columns[3].ReadOnly = true;
            dtgvAlmacen.Columns[4].ReadOnly = true;
            dtgvAlmacen.Columns[5].ReadOnly = true;
        }
        private void Crear()
        {
            DataADO.Almacen almacen = new DataADO.Almacen()
            {
                Producto = txtproducto.Text,
                Precio = Convert.ToDecimal(txtprecio.Text),
                Existencia = Convert.ToDecimal(txtexistencia.Text),
                Descripcion = txtdescripcion.Text,
                ITBS = Convert.ToDecimal(txtitbs.Text)
            };

            db.Almacen.Add(almacen);
            db.SaveChanges();

            estatus = estatus.Modificando;
            lblid.Text = almacen.Id.ToString();
        }
        private void Actualizar(int id)
        {
            if (estatus == estatus.Modificando || estatus != estatus.Modificando)
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
        private void btnGUardar_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Length == 0 && txtproducto.Text != null)
            {
                Crear();
            }
            else
            {
                Actualizar(Convert.ToInt32(lblid.Text));
            }
            RefreshAlmacen();
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
                            RefreshAlmacen();
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
        private void Limpiar()
        {
            lblid.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtitbs.Text = "";
            txtexistencia.Text = "";
            txtdescripcion.Text = "";            
        }

        private void dtgvAlmacen_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Filtro();
        }
    }
}
