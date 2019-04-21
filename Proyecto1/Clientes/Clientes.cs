using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.DataADO;
using static Proyecto1.Clases.Veloz;

namespace Proyecto1.Clientes
{
    public partial class Clientes : Form
    {
        private readonly DataADO.Proyecto1Entities db;
        estatus estatus;

        //public Proyecto1Entities Db => db;

        public Clientes()
        {
            InitializeComponent();
            db = new DataADO.Proyecto1Entities();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Limpiar()
        {
            lblId.Text = string.Empty;
            txtNOmbre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtcedula.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txtedad.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            
        }
        private void Crear()
        {
            if (txtNOmbre.Text == string.Empty)
            {               
                errorProvider1.SetError(txtNOmbre, "Ingrese un nombre");     
            }
            if (Clases.Veloz.ValidarEmail(txtcorreo.Text) == false)
            {
                errorProvider1.SetError(txtNOmbre, "Ingrese un correo valido");
            }
            else
            {
                var cliente = new DataADO.Clientes
                {
                    Nombre = txtNOmbre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Cedula = txtcedula.Text,
                    Celular = txtCelular.Text,
                    Edad = (txtedad.Text.Length == 0) ? 0 : Convert.ToInt32(txtedad.Text),
                    Correo = txtcorreo.Text,
                    Fecha_De_Registro = DateTime.Now
                };
                db.Clientes.Add(cliente);
                db.SaveChanges();


                estatus = estatus.Modificando;
                lblId.Text = cliente.Id.ToString();
                MensajeOk("Se inserto correctamente");
                Close();

                Clientes clientes = new Clientes
                {
                    ActiveControl = ActiveForm
                };
                ShowDialog();
            }
         
        }
        private void Actualizar(int id)
        {
            if (estatus == estatus.Modificando || estatus != estatus.Modificando)
            {
                if (txtNOmbre.Text == string.Empty)
                {
                    errorProvider1.SetError(txtNOmbre, "Ingrese un nombre");
                }
                if (Clases.Veloz.ValidarEmail(txtcorreo.Text) == false)
                {
                    errorProvider1.SetError(txtcorreo, "Ingrese un correo valido");
                }
                else
                {
                    var cliente = db.Clientes
                               .Single(x => x.Id == id);

                    cliente.Nombre = txtNOmbre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Cedula = txtcedula.Text;
                    cliente.Celular = txtCelular.Text;
                    cliente.Edad = (txtedad.Text.Length == 0) ? 0 : Convert.ToInt32(txtedad.Text);
                    cliente.Correo = txtcorreo.Text;
                    cliente.Fecha_De_Registro = dateTimePicker1.Value;

                    db.SaveChanges();
                    MensajeOk("Se actualizo de forma correcta");
                }
            }
            else { Crear(); }        
            

        }
        private void Cargar(int id)
        {
            var cliente = db.Clientes.Single(x => x.Id == id);

            txtNOmbre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDireccion.Text = cliente.Direccion;
            txtcedula.Text = cliente.Cedula;
            txtCelular.Text = cliente.Celular;
            txtedad.Text = cliente.Edad.ToString();
            txtcorreo.Text = cliente.Correo;


        }

        private void New_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
                Crear();
            else
                Actualizar(Convert.ToInt32(lblId.Text));
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if(estatus == estatus.Modificando) {
                lblId.Text = "";
            }
            if(lblId.Text.Length !=0){
                Cargar(Convert.ToInt32(lblId.Text));
            }
        }
    }
}
