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

namespace Proyecto1.Sueldos
{
    public partial class Sueldos : Form
    {
        estatus estatus;
        private DataADO.Proyecto1Entities db;
        public Sueldos()
        {
            InitializeComponent();
            db = new DataADO.Proyecto1Entities();
        }

        private void Sueldos_Load(object sender, EventArgs e)
        {
            Llenar();

            if (estatus == estatus.Modificando)
                lblid.Text = string.Empty;
                btnBuscar.Visible = true;

            if (lblid.Text.Length != 0)
                Cargar(Convert.ToInt32(lblid.Text));

            CenterToScreen();
            
        }

        private void Llenar()
        {
            var puestos = db.Puestos
                .Select(x => new

                {
                    x.Id,
                    x.Puesto
                });

            cmbPuestos.DataSource = puestos.ToList();
            cmbPuestos.DisplayMember = "Puesto";
            cmbPuestos.ValueMember = "Id";
            cmbPuestos.DropDownStyle = ComboBoxStyle.DropDownList;


            btnBuscar.Visible = false;
            txtnombre.ReadOnly = true;
            txtapell.ReadOnly = true;
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Cargar(int id)
        {
            var Sueldo = db.Sueldos
                           .Where(x => x.Id == id)
                           .FirstOrDefault();

            lblid.Text = Sueldo.Id.ToString();
            txtnombre.Text = Sueldo.Usuarios.Nombre;
            txtapell.Text = Sueldo.Usuarios.Apellido;
            cmbPuestos.Text = Sueldo.Puestos.Puesto;    
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Length == 0)
                Crear();
            else
                btnBuscar.Visible = true;
                Actualizar(Convert.ToInt32(lblid.Text));
        }

        private void Actualizar(int v)
        {
            var sueldo = (from sl in db.Sueldos
                          where sl.Id == v
                          select sl).FirstOrDefault();

            sueldo.IdUsuario = Convert.ToInt32(lbliduser.Text);
            sueldo.IdPuesto = Convert.ToInt32(Convert.ToInt32(cmbPuestos.SelectedValue));
            sueldo.Sueldo = (Convert.ToDecimal(txtsueldo) > 0) ? Convert.ToDecimal(txtsueldo.Text) : 0;

            db.SaveChanges();
            MensajeOk("Se actualizo de forma correcta");
        }

        private void Crear()
        {
            //if(txtnombre.Text.Length == 0)
            //{
            //    MensajeError("es de obligacion agregar un usuario.");
            //    errorProvider1.SetError(txtnombre, "No puede estar en blanco");
            //}
            var sueldo = new DataADO.Sueldos
            {
                IdUsuario = Convert.ToInt32(lbliduser.Text),
                ////IdPuesto = Convert.ToInt32(cmbPuestos.SelectedValue),
                Sueldo = (Convert.ToDecimal(txtsueldo.Text) > 0) ? Convert.ToDecimal(txtsueldo.Text) : 0
            };

            db.Sueldos.Add(sueldo);
            db.SaveChanges();

            estatus = estatus.Modificando;
            lblid.Text = sueldo.Id.ToString();
            MensajeOk("Se inserto correctamente");

            Close();
            Sueldos sueldos = new Sueldos();
            sueldos.ShowDialog();
        }
        public void Limpiar()
        {
            lblid.Text = "";
            lbliduser.Text = "";
            txtsueldo.Text = "";
            txtnombre.Text = "";
            txtapell.Text = "";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Usuarios.verUsuario verUsuario = new Usuarios.verUsuario();
            verUsuario.buscando = true;
            verUsuario.ShowDialog();

            if(verUsuario.Id != null)
            {
                CargarUser(Convert.ToInt32(verUsuario.Id));
                verUsuario.Id = null;
            }
        }

        private void CargarUser(int v)
        {
            var user = db.Usuarios.Find(v);

            lbliduser.Text = user.Id.ToString();
            txtnombre.Text = user.Nombre;
            txtapell.Text = user.Apellido;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
