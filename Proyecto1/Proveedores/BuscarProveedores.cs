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

namespace Proyecto1.Proveedores
{
    public partial class BuscarProveedores : Form
    {
        public BuscarProveedores()
        {
            InitializeComponent();
        }
      
        private DataADO.Proyecto1Entities dbProyecto1;
        private DataADO.Proveedores dsProveedores;
        estatus estatus;

        private void BuscarProveedores_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            RefresFill();
        }
        
        //Proveedores FrmProveedores = new Proveedores();
        //private void btnSeleccionar_Click(object sender, EventArgs e)
        //{
        //    FrmProveedores.lblId.Text = dgvProveedores.CurrentRow.Cells["Id"].Value.ToString();
        //    FrmProveedores.ShowDialog();
        //    RefresFill();
        //}
        private IEnumerable<object> RefresFill()//como retorno lista generada... en consulta
        {
            using (dbProyecto1 = new DataADO.Proyecto1Entities())
            {
                var pro = dbProyecto1.Proveedores
                    .Select(x => new
                    {
                        x.Id,
                        x.Nombre,
                        x.Apellido,
                        x.Direccion,
                        x.Celular,
                        x.Cedula,
                        x.Provincia,
                        x.Empresa,
                        x.Telefono_Empresa

                    });

                dgvProveedores.DataSource = pro.OrderBy(x => x.Id).ToList();
                autosize();
                
                return pro.ToList();
                
            }
        }
        //public static List<T> CreateList<T>(params T[] elements)
        //{
        //    return new List<T>(elements);
        //}
        //private void ReadOnly()
        //{
        //    dgvProveedores.Columns[0].ReadOnly = true;
        //    dgvProveedores.Columns[1].ReadOnly = true;
        //    dgvProveedores.Columns[2].ReadOnly = true;
        //    dgvProveedores.Columns[3].ReadOnly = true;
        //    dgvProveedores.Columns[4].ReadOnly = true;
        //    dgvProveedores.Columns[5].ReadOnly = true;
        //    dgvProveedores.Columns[6].ReadOnly = true;
        //    dgvProveedores.Columns[7].ReadOnly = true;
        //    dgvProveedores.Columns[8].ReadOnly = true;
        //}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //FrmProveedores.ShowDialog();

            //RefresFill();
            Limpiar();
        }

        private void Limpiar()
        {
            lblId.Text = "";
            txtNOmbre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtcedula.Text = "";
            txtDireccion.Text = "";
            txtEmpresa.Text = "";
            txtTelefonoEmpresa.Text = "";
            txtProvincia.Text = "";
            
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            using (dbProyecto1 = new DataADO.Proyecto1Entities())
            {
                var pro = dbProyecto1.Proveedores
                     .Where(x=>x.Nombre.Contains(txtfiltro.Text) || x.Empresa.Contains(txtfiltro.Text))
                    .Select(x => new
                    {
                        x.Id,
                        x.Nombre,
                        x.Apellido,
                        x.Direccion,
                        x.Celular,
                        x.Cedula,
                        x.Provincia,
                        x.Empresa,
                        x.Telefono_Empresa

                    });

                dgvProveedores.DataSource = pro.OrderBy(x => x.Id).ToList();
                autosize();
              
                prueba();
            }
        }
        private void Cargar(int? Id)
        {
            if (Id != null)
            {
                using (var db = new DataADO.Proyecto1Entities())
                {
                    dsProveedores = (from h in db.Proveedores
                                     where h.Id == Id
                                     select h).Single();


                    lblId.Text = dsProveedores.Id.ToString();
                    txtNOmbre.Text = dsProveedores.Nombre;
                    txtApellido.Text = dsProveedores.Apellido;
                    txtTelefonoEmpresa.Text = dsProveedores.Cedula;
                    txtCelular.Text = dsProveedores.Celular;
                    txtEmpresa.Text = dsProveedores.Empresa;
                    txtProvincia.Text = dsProveedores.Provincia;
                    txtTelefonoEmpresa.Text = dsProveedores.Telefono_Empresa;
                }
            }
        }

        private void autosize()
        {
            dgvProveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedores.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedores.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
            {
                Crear();
            }
            else
            {
                Actualizar(Convert.ToInt32(lblId.Text));
            }
            dgvProveedores.DataSource = RefresFill();///Me devuleve una lista tal como lo defini en el metodo

        }


        private void Crear()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                dsProveedores = new DataADO.Proveedores
                {
                    Nombre = txtNOmbre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtcedula.Text,
                    Celular = txtCelular.Text,
                    Direccion = txtDireccion.Text,
                    Empresa = txtEmpresa.Text,
                    Provincia = txtProvincia.Text,
                    Telefono_Empresa = txtTelefonoEmpresa.Text
                };

                db.Proveedores.Add(dsProveedores);
                db.SaveChanges();

                estatus = estatus.Modificando;
                lblId.Text = dsProveedores.Id.ToString();
            }

        }
        private void Actualizar(int id)
        {
            if (estatus == estatus.Modificando || estatus != estatus.Modificando)
            {
                using (var db = new DataADO.Proyecto1Entities())
                {
                    var pro = db.Proveedores
                              .Where(x => x.Id == id)
                              .Single();

                    pro.Id = Convert.ToInt32(lblId.Text);
                    pro.Nombre = txtNOmbre.Text;
                    pro.Apellido = txtApellido.Text;
                    pro.Cedula = txtcedula.Text;
                    pro.Direccion = txtDireccion.Text;
                    pro.Empresa = txtEmpresa.Text;
                    pro.Provincia = txtProvincia.Text;
                    pro.Telefono_Empresa = txtTelefonoEmpresa.Text;
                    pro.Celular = txtCelular.Text;

                    db.SaveChanges();
                }
             
            }

        }

        private void dgvProveedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            prueba();

        }
        private void prueba()
        {
            try
            {
                
                    lblId.Text = dgvProveedores.CurrentRow.Cells["Id"].Value.ToString();

                    int? id = Convert.ToInt32(lblId.Text);
                    Cargar(id);
               

            }catch{ }
            
        }

        private void dgvProveedores_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (lblId.Text.Length == 0)
                    {
                        MessageBox.Show("Para poder continuar con la accion antes debe de seleccionar el proveedor que desea  eliminar");
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro que desea eliminar el proveedor esta accion no se podra deshacer?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            using (var db = new DataADO.Proyecto1Entities())
                            {
                                var proveedor = db.Proveedores.Find(Convert.ToInt32(lblId.Text));
                                db.Proveedores.Attach(proveedor);
                                db.Proveedores.Remove(proveedor);
                                db.SaveChanges();
                                MessageBox.Show("El registro fue eliminado correctamente");
                                RefresFill();
                            }
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show("El registro del proveedor no puede ser eliminado debido a que este esta asociado a otros registros y dicha accion puede general problemas en los registros asociados.." + ex.Message); }
        }
    }
}
