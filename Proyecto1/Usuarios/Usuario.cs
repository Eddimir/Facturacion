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


        private void Usuario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        private DataADO.Usuarios dsUsuarios = new DataADO.Usuarios();
        estatus estatus;

        private void Crear()
        {
            dsUsuarios = new DataADO.Usuarios()
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

            db.Usuarios.Add(dsUsuarios);
            db.SaveChanges();

            lblId.Text = dsUsuarios.Id.ToString();
            estatus = estatus.Modificando;

            Close();
            Usuario fr = new Usuario();
            fr.MdiParent = ActiveForm;
            fr.Show();
        }
        private void Actualizar(int id)
        {
            if (estatus == estatus.Modificando || estatus != estatus.Modificando)
            {
                using (db = new DataADO.Proyecto1Entities())
                {
                    dsUsuarios = db.Usuarios
                                .Where(x => x.Id == id)
                                .First();

                    dsUsuarios.Nombre = txtNOmbre.Text;
                    dsUsuarios.Apellido = txtApellido.Text;
                    dsUsuarios.Direccion = txtDireccion.Text;
                    dsUsuarios.Celular = txtCelular.Text;
                    dsUsuarios.Cedula = txtCedula.Text;
                    dsUsuarios.Telefono = txtTelefono.Text;
                    dsUsuarios.NombreUsuario = txtNOmbreUser.Text;
                    dsUsuarios.Contrasena = txtconntrasenia.Text;
                    dsUsuarios.Activo_estado = ckbActivo.Checked;

                    db.SaveChanges();                   
                }
            }
        }

        private void Cargar(int? id)
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                dsUsuarios = (from e in db.Usuarios
                              where e.Id == id
                              select e).First();

                lblId.Text = dsUsuarios.Id.ToString();
                //lblPuesto.Text = dsUsuarios.IdPuesto.ToString();
                txtNOmbre.Text = dsUsuarios.Nombre;
                txtApellido.Text = dsUsuarios.Apellido;
                txtCedula.Text = dsUsuarios.Cedula;
                txtCelular.Text = dsUsuarios.Celular;
                txtDireccion.Text = dsUsuarios.Direccion;
                txtTelefono.Text = dsUsuarios.Telefono;
                txtNOmbreUser.Text = dsUsuarios.NombreUsuario;
                txtconntrasenia.Text = dsUsuarios.Contrasena;
                ckbActivo.Checked = Convert.ToBoolean(dsUsuarios.Activo_estado);
               
                //cmbPuestos.Text = dsUsuarios.IdPuesto.ToString();
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
                Crear();
            else
                Actualizar(Convert.ToInt32(lblId.Text));
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
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
            FillFiltro();
            autoajuste();
           
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

            dataGridView1.DataSource = filtro.ToList();
            autoajuste();
            return filtro.ToList();
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

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (lblId.Text.Length == 0)
                    {
                        MessageBox.Show("Para poder continuar con la accion antes debe de seleccionar el proveedor al eliminar");
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que desea eliminar el proveedor esta accion no se podra deshacer?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
    }
}
