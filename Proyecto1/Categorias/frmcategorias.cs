using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Categorias
{
    public partial class frmcategorias : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmcategorias()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCategoriaBuscar, "Ingrese el Nombre de la Categoria;");
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar
        private void Limpiar()
        {
            txtcodigo.Text = "";
            txtdescricion.Text = "";
            txtCategoriaBuscar.Text = "";
        }
        //habilitar controles
        private void Habilitar(bool valor)
        {
            txtCategoriaBuscar.ReadOnly = !valor;//negacion
            txtdescricion.ReadOnly = !valor;
        }
        //habilitar botones
        private void Botones()
        {
            if (IsNuevo || IsEditar)
            {
                Habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        //Metodo para olcultar Columnas
        private void OlcultarColumna()
        {
            dtgvlistado.Columns[0].Visible = false;
        }
        //MOstrar Metodo
        private void Mostrar()
        {
            //aqui se despliega el contenido
            var db = new DataADO.Proyecto1Entities();
            var cat = from d in db.ProductosCategoria
                      select new
                      {
                          d.Id,
                          d.Categoria,
                          d.Descripcion
                      };

            dtgvlistado.DataSource = cat.ToList();
            this.OlcultarColumna();
            this.lblcantidad.Text = "Total de Registros:" + dtgvlistado.Rows.Count.ToString();            
        }
        private void BuscarCategoria()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var categorias = from cl in db.ProductosCategoria
                               where cl.Categoria.Contains(txtCategoriaBuscar.Text)
                               select new
                               {
                                   cl.Id,
                                   cl.Categoria,
                                   cl.Descripcion
                               };
                dtgvlistado.DataSource = categorias.OrderBy(x => x.Id).ToList();
                this.OlcultarColumna();
                this.lblcantidad.Text = "Total de Registros:" + dtgvlistado.Rows.Count.ToString();
                //autosize();

            }
        }
        private void frmcategorias_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Mostrar();
            Habilitar(false);
            Botones();           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void txtCategoriaBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarCategoria();
        }

        private void Crear()
        {
            try
            {
                if (txtnombrecategoria.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtnombrecategoria, "Ingrese un nombre");
                }
                else
                {
                    if (IsNuevo)
                    {
                        using(var db = new DataADO.Proyecto1Entities())
                        {
                            var categoria = new DataADO.ProductosCategoria
                            {
                                Categoria = txtnombrecategoria.Text,
                                Descripcion = txtdescricion.Text
                            };

                            db.ProductosCategoria.Add(categoria);
                            db.SaveChanges();
                            MensajeOk("Se inserto Correctamente");

                        }
                    }
                    else
                    {
                        Actualizar(Convert.ToInt32(txtcodigo.Text));
                        MensajeOk("Se actualizo de forma correcta");
                    }
                }
                IsNuevo = false;
                IsEditar = false;
                Botones();
                Limpiar();
                Mostrar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Actualizar(int? id)
        {
            if (id != null)
            {

                using (var db = new DataADO.Proyecto1Entities())
                {
                    var categoria = (from ct in db.ProductosCategoria
                                     where ct.Id == id
                                     select ct).First();

                    categoria.Categoria = txtnombrecategoria.Text;
                    categoria.Descripcion = txtdescricion.Text;

                    db.SaveChanges();
                }
            }
        }
       
        private void cargar(int id)
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                var categoria = (from ct in db.ProductosCategoria
                                where ct.Id == id
                                select ct).First();

                txtnombrecategoria.Text = categoria.Categoria;
                txtdescricion.Text = categoria.Descripcion;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            IsEditar = false;
            Botones();
            Limpiar();
            Habilitar(true);
            txtnombrecategoria.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void dtgvlistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtgvlistado.CurrentRow.Cells[1].Value.ToString();//#1 en este caso el id se agregara con un campo ya agregado en este caso eliminar

            if (txtcodigo.Text.Length != 0)
            {
                cargar(Convert.ToInt32(txtcodigo.Text));
            }
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtcodigo.Text.Equals(""))
            {
                IsEditar = true;
                Botones();
                Habilitar(true);
                Actualizar(Convert.ToInt32(txtcodigo.Text));

            }
            else
            {
                MensajeError("DebeSelecionar el registro a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IsNuevo = false;
            IsEditar = false;
            Botones();
            Limpiar();
            Habilitar(false);
        }

        private void ckbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEliminar.Checked)
            {
                dtgvlistado.Columns[0].Visible = true;
            }
            else
            {
                dtgvlistado.Columns[0].Visible = false;
            }
        }

        private void dtgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgvlistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ckeliminar = (DataGridViewCheckBoxCell)dtgvlistado.Rows[e.RowIndex].Cells["Eliminar"];
                ckeliminar.Value = !Convert.ToBoolean(ckeliminar.Value);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarC();
            }
            catch (Exception ex) { }            
        }
        private void EliminarC()
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea eliminar el registro", "Sitema de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                using (var db = new DataADO.Proyecto1Entities())
                {
                    foreach (DataGridViewRow row in dtgvlistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))//Si esta tachada la casilla
                        {
                            int id = Convert.ToInt32(row.Cells["Id"].Value);

                            var categorias = db.ProductosCategoria
                                               .Where(x => x.Id == id)
                                               .First();

                            db.ProductosCategoria.Remove(categorias);
                            db.SaveChanges();

                            if (categorias != null)
                            {
                                MensajeOk("El registro se elimino correctamente");
                            }
                            else
                            {
                                MensajeError("Error al eliminar");
                            }
                        }
                    }
                }
            }
        }
    }
}
