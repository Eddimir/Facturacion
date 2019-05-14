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
        estatus estatus;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void LimpiarCampos()
        {
            lblId.Text = string.Empty;
            txtNOmbre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtcedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonoEmpresa.Text = string.Empty;
            txtCelular.Clear();
            txtProvincia.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtrnc.Text = "";
            txtemail.Text = "";
        }

        private void Crear()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                if (txtNOmbre.Text.Length == 0)
                    errorProvider1.SetError(txtNOmbre, "Ingresar el nombre del proveedor");
                if (txtEmpresa.Text == "")
                    errorProvider1.SetError(txtEmpresa, "Ingrese el nombre de la empresa perteneciente");
                if (Clases.Veloz.ValidarEmail(txtemail.Text) == false)
                    errorProvider1.SetError(txtemail, "Ingrese un correo valido");
                else {
                    var dsProveedores = new DataADO.Proveedores
                    {
                        Nombre = txtNOmbre.Text,
                        Apellido = txtApellido.Text,
                        Cedula = txtcedula.Text,
                        Celular = txtCelular.Text,
                        Direccion = txtDireccion.Text,
                        Empresa = txtEmpresa.Text,
                        Provincia = txtProvincia.Text,
                        Telefono_Empresa = txtTelefonoEmpresa.Text,
                        razonsocial = txtrnc.Text,
                        email = Clases.Veloz.ValidarEmail(txtemail.Text) == true ? txtemail.Text : null
                    };

                    db.Proveedores.Add(dsProveedores);
                    db.SaveChanges();

                    estatus = estatus.creando;
                    lblId.Text = dsProveedores.Id.ToString();


                    MensajeOk("Se inserto Correctamente");
                    Close();
                    Proveedores pro = new Proveedores();                
                    pro.ShowDialog();
                }
            }

        }

        private void Actualizar(int id)
        {
            if (estatus == estatus.Modificando)
            {
                if(txtNOmbre.Text.Length == 0)
                    errorProvider1.SetError(txtNOmbre, "Ingresar el nombre del proveedor");
                if (txtEmpresa.Text == "")
                    errorProvider1.SetError(txtEmpresa, "Ingrese el nombre de la empresa perteneciente");
                if (Clases.Veloz.ValidarEmail(txtemail.Text) == false)
                    errorProvider1.SetError(txtemail, "Ingrese un correo valido");
                else
                {
                    using (var db = new DataADO.Proyecto1Entities())
                    {
                        var pro = db.Proveedores
                                  .Where(x => x.Id == id)
                                  .Single();

                        pro.Id = Convert.ToInt32(lblId.Text);
                        pro.Nombre = txtNOmbre.Text;
                        pro.Apellido = txtApellido.Text;
                        pro.Celular = txtCelular.Text;
                        pro.Cedula = txtcedula.Text;
                        pro.Direccion = txtDireccion.Text;
                        pro.Provincia = txtProvincia.Text;
                        pro.Telefono_Empresa = txtTelefonoEmpresa.Text;
                        pro.Empresa = txtEmpresa.Text;
                        pro.email = txtemail.Text;

                        db.SaveChanges();
                        MensajeOk("Se actualizo de forma correcta");
                    }
                }
            }

        }

        private void Cargar(int Id)
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var dsProveedores = (from h in db.Proveedores
                                 where h.Id == Id
                                 select h).Single();


                lblId.Text = dsProveedores.Id.ToString();
                txtNOmbre.Text = dsProveedores.Nombre;
                txtApellido.Text = dsProveedores.Apellido;
                txtTelefonoEmpresa.Text = dsProveedores.Telefono_Empresa;
                txtCelular.Text = dsProveedores.Celular;
                txtEmpresa.Text = dsProveedores.Empresa;
                txtProvincia.Text = dsProveedores.Provincia;
                txtTelefonoEmpresa.Text = dsProveedores.Telefono_Empresa;
                txtrnc.Text = dsProveedores.razonsocial;
                txtemail.Text = dsProveedores.email;
                txtcedula.Text = dsProveedores.Cedula;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (estatus == estatus.Modificando)
            {
                lblId.Text = "";
            }
            if (lblId.Text.Length != 0)
                Cargar(Convert.ToInt32(lblId.Text));
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
                Crear();
            else
            {
                estatus = estatus.Modificando;
                Actualizar(Convert.ToInt32(lblId.Text));           
            }
        }
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
