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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        public bool buscando;
        public int id;


        private void Proveedores_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            RefreSFill();
           
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (buscando)
            {
                id = (int)dgvProveedores.CurrentRow.Cells["Id"].Value;
                Close();
            }
        }
        private void RefreSFill()
        {
            var query = from pr in db.Proveedores
                        select new
                        {
                            pr.Id,
                            Proveedor = pr.Nombre + " " + pr.Apellido,
                            pr.Celular,
                            pr.Provincia,
                            pr.Empresa
                        };

            dgvProveedores.DataSource = query.OrderBy(x=>x.Id).ToList();
            AutoAjuste();

        }
        private void AutoAjuste()
        {
            dgvProveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProveedores.Columns[0].Visible = false;

            dgvProveedores.MultiSelect = true;
            dgvProveedores.AllowUserToOrderColumns = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvProveedores.Columns[1].ReadOnly = true;
            dgvProveedores.Columns[2].ReadOnly = true;
            dgvProveedores.Columns[3].ReadOnly = true;
            dgvProveedores.Columns[4].ReadOnly = true;
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                var proveedor = from pr in db.Proveedores
                                where pr.Nombre.Contains(txtfiltro.Text) || pr.Apellido.Contains(txtfiltro.Text)
                                || pr.Empresa.Contains(txtfiltro.Text)
                                select new
                                {
                                    pr.Id,
                                    Proveedor = pr.Nombre + " " + pr.Apellido,
                                    pr.Celular,
                                    pr.Provincia,
                                    pr.Empresa
                                };
                dgvProveedores.DataSource = proveedor.OrderBy(x => x.Id).ToList();

                AutoAjuste();
            }
        }

        //private void LimpiarCampos()
        //{
        //    lblId.Text = string.Empty;
        //    txtNOmbre.Text = string.Empty;
        //    txtApellido.Text = string.Empty;
        //    txtcedula.Text = string.Empty;
        //    txtDireccion.Text = string.Empty;
        //    txtTelefonoEmpresa.Text = string.Empty;
        //    txtCelular.Clear();
        //    txtProvincia.Text = string.Empty;
        //    txtDireccion.Text = string.Empty;
        //}

        //private void Crear()
        //{
        //    using(db = new DataADO.Proyecto1Entities())
        //    {
        //        dsProveedores = new DataADO.Proveedores
        //        { 
        //            Nombre = txtNOmbre.Text,
        //            Apellido = txtApellido.Text,
        //            Cedula = txtcedula.Text,
        //            Celular = txtCelular.Text,
        //            Direccion = txtDireccion.Text,
        //            Empresa = txtEmpresa.Text,
        //            Provincia = txtProvincia.Text,
        //            Telefono_Empresa = txtTelefonoEmpresa.Text
        //        };

        //        db.Proveedores.Add(dsProveedores);
        //        db.SaveChanges();

        //        estatus = estatus.Modificando;
        //        lblId.Text = dsProveedores.Id.ToString();
        //    }

        //}

        //private void Actualizar(int id)
        //{
        //    if(estatus == estatus.Modificando)
        //    {
        //        using (db = new DataADO.Proyecto1Entities())
        //        {
        //            var pro = db.Proveedores
        //                      .Where(x => x.Id == id)
        //                      .Single();

        //            pro.Id = Convert.ToInt32(lblId.Text);
        //            pro.Nombre = txtNOmbre.Text;
        //            txtApellido.Text = pro.Apellido;
        //            txtcedula.Text = pro.Cedula;
        //            txtDireccion.Text = pro.Direccion;
        //            txtEmpresa.Text = pro.Empresa;
        //            txtProvincia.Text = pro.Provincia;
        //            txtTelefonoEmpresa.Text = pro.Telefono_Empresa;
        //            txtCelular.Text = pro.Celular;
        //        }
        //    }

        //}

        //private void Cargar(int Id)
        //{
        //    using (db = new DataADO.Proyecto1Entities())
        //    {
        //        dsProveedores = (from h in db.Proveedores
        //                         where h.Id == Id
        //                         select h).Single();


        //        lblId.Text = dsProveedores.Id.ToString();
        //        txtNOmbre.Text = dsProveedores.Nombre;
        //        txtApellido.Text = dsProveedores.Apellido;
        //        txtTelefonoEmpresa.Text = dsProveedores.Cedula;
        //        txtCelular.Text = dsProveedores.Celular;
        //        txtEmpresa.Text = dsProveedores.Empresa;
        //        txtProvincia.Text = dsProveedores.Provincia;
        //        txtTelefonoEmpresa.Text = dsProveedores.Telefono_Empresa;
        //    }
        //}
        //private void Eliminar()
        //{
        //    using(db = new DataADO.Proyecto1Entities())
        //    {
        //        if(lblId.Text != null)
        //        {
        //            var prove = db.Proveedores
        //                        .Where(x => x.Id == Convert.ToInt32(lblId.Text))
        //                        .Single();

        //            db.Proveedores.Attach(prove);
        //            db.Proveedores.Remove(prove);
        //            db.SaveChanges();
        //            MessageBox.Show("El proveedor fue eliminado correctamente.");

        //            //var pr = dbproyecto1.Proveedores.Find(Convert.ToInt32(lblId.Text));

        //            //dbproyecto1.Proveedores.Attach(pr);
        //            //dbproyecto1.Proveedores.Remove(pr);



        //        }
        //    }
        //}


    }
}
