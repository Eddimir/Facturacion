using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Proyecto1.Clases.Veloz;

namespace Proyecto1
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private DataADO.Proyecto1Entities db;
        estatus estatus;
        private void Usuario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            RefreshFill();
        }
     

        private void Crear()
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                var user = new DataADO.Usuarios()
                {
                    Nombre = txtNOmbre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Celular = txtCelular.Text,
                    Telefono = txtTelefono.Text,
                    Activo_estado = true,
                    Direccion = txtDireccion.Text,
                    Contrasena = txtconntrasenia.Text,
                    NombreUsuario = txtNOmbreUser.Text
                };

                db.Usuarios.Add(user);
                db.SaveChanges();

                lblId.Text = user.Id.ToString();
                estatus = estatus.Modificando;
            }
        }
        private void Actualizar(int id)
        {
            if (estatus == estatus.Modificando || estatus != estatus.Modificando)
            {
                using (db = new DataADO.Proyecto1Entities())
                {
                    var user = db.Usuarios
                                .Where(x => x.Id == id)
                                .First();

                    user.Nombre = txtNOmbre.Text;
                    user.Direccion = txtDireccion.Text;
                    user.Celular = txtCelular.Text;
                    user.Cedula = txtCedula.Text;
                    user.Telefono = txtTelefono.Text;
                    user.NombreUsuario = txtNOmbreUser.Text;
                    user.Contrasena = txtconntrasenia.Text;
                    user.Activo_estado = ckbActivo.Checked;

                    db.SaveChanges();                   
                }
            }
        }

        private void Cargar(int? id)
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                var user = (from e in db.Usuarios
                              where e.Id == id
                              select e).First();

                lblId.Text = user.Id.ToString();
                //lblPuesto.Text = dsUsuarios.IdPuesto.ToString();
                txtNOmbre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;
                txtCedula.Text = user.Cedula;
                txtCelular.Text = user.Celular;
                txtDireccion.Text = user.Direccion;
                txtTelefono.Text = user.Telefono;
                txtNOmbreUser.Text = user.NombreUsuario;
                txtconntrasenia.Text = user.Contrasena;
                ckbActivo.Checked = Convert.ToBoolean(user.Activo_estado);
               
                //cmbPuestos.Text = dsUsuarios.IdPuesto.ToString();
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
                Crear();
            else
                Actualizar(Convert.ToInt32(lblId.Text));

            RefreshFill();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (db = new DataADO.Proyecto1Entities())
                {
                    var filtro = db.Usuarios.Where(x => x.Nombre.Contains(txtfiltro.Text) || x.Apellido.Contains(txtfiltro.Text))
                            .Select(x => new
                            {
                                x.Id,
                                x.Nombre,
                                x.Apellido,
                                x.Cedula,
                                x.Direccion,
                                x.Telefono,
                                x.Celular,
                                x.Activo_estado
                            });

                    dataGridView1.DataSource = filtro.OrderBy(x => x.Id).ToList();
                    autoajuste();
                }
            }
            catch { }
           
        }
        private void FillFiltro()
        {
            lblId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

            int? id = Convert.ToInt32(lblId.Text);
            Cargar(id);
        }
        private void autoajuste()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.MultiSelect = true;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
        }

        private IEnumerable<object> RefreshFill()
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                var filtro = db.Usuarios
                        .Select(x => new
                        {
                            x.Id,
                            x.Nombre,
                            x.Apellido,
                            x.Cedula,
                            x.Direccion,
                            x.Telefono,
                            x.Celular,
                            x.Activo_estado
                        });

                dataGridView1.DataSource = filtro.OrderBy(x => x.Id).ToList();
                autoajuste();
                return filtro.ToList();
            }
        }
        private void Limpiar()
        {
            lblId.Text = "";
            txtNOmbre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtNOmbreUser.Text = "";
            txtconntrasenia.Text = "";
            txtTelefono.Text = "";
            ckbActivo.Checked = false;

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                using (db = new DataADO.Proyecto1Entities())
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        if (lblId.Text.Length == 0)
                        {
                            MessageBox.Show("Para poder continuar con la accion antes debe de seleccionar el proveedor al eliminar");
                        }
                        else
                        {
                            if (MessageBox.Show("Seguro que desea eliminar el Usuario esta accion no se podra deshacer?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                var User = db.Usuarios.Find(Convert.ToInt32(lblId.Text));
                                db.Usuarios.Attach(User);
                                db.Usuarios.Remove(User);
                                db.SaveChanges();
                                MessageBox.Show("El registro fue eliminado correctamente.");
                                RefreshFill();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("El registro del proveedor no puede ser eliminado debido a que este esta asociado a otros registros y dicha accion puede general problemas en los registros asociados.." + ex.Message); }
        }
        private void FillPuestos()
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                var puestos = from h in db.Puestos
                              select new
                              {
                                  h.Id,
                                  h.Puesto
                              };

                cmbPuestos.DataSource = puestos.ToList();
                cmbPuestos.DisplayMember = "Puesto";
                cmbPuestos.ValueMember = "Id";

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillFiltro();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
