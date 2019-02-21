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

namespace Proyecto1.Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        private  DataADO.Proyecto1Entities dbProyecto1;
        private  DataADO.Clientes dsClientes;
        public estatus estado;

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            if (estado == estatus.Modificando)
                lblId.Text = string.Empty;

            if (lblId.Text.Length != 0)
                Cargar(Convert.ToInt32(lblId.Text));

            if (lblId.Text.Length == 0)
                Limpiar();


            dsClientes = new DataADO.Clientes();
            dateTimePicker1.MinDate = DateTime.Today;
            dbProyecto1 = new DataADO.Proyecto1Entities();
        }

        private void Limpiar()
        {
            lblId.Text = string.Empty;
            txtNOmbre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtcedula.Text = string.Empty;
            txtedad.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void Cargar(int id)
        {
            using(dbProyecto1 = new DataADO.Proyecto1Entities())
            {
                dsClientes = (from d in dbProyecto1.Clientes
                              where d.Id == id
                              select d).Single();

                lblId.Text = dsClientes.Id.ToString();
                txtNOmbre.Text = dsClientes.Nombre;
                txtApellido.Text = dsClientes.Apellido;
                txtcedula.Text = dsClientes.Cedula;
                txtCelular.Text = dsClientes.Celular;
                txtedad.Text = dsClientes.Edad.ToString();
                txtDireccion.Text = dsClientes.Direccion;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
                Crear();
            else
                Actualizar(Convert.ToInt32(lblId.Text));
        }

        private void Actualizar(int id)
        {
            try
            {
                using (dbProyecto1 = new DataADO.Proyecto1Entities())
                {
                    if (estado == estatus.Modificando)
                    {

                        dsClientes = (from cl in dbProyecto1.Clientes
                                      where cl.Id == id
                                      select cl).First();

                        dsClientes.Id = Convert.ToInt32(lblId.Text);
                        dsClientes.Nombre = txtNOmbre.Text;
                        dsClientes.Apellido = txtApellido.Text;
                        dsClientes.Direccion = txtDireccion.Text;
                        dsClientes.Cedula = txtcedula.Text;
                        dsClientes.Celular = txtCelular.Text;
                        dsClientes.Edad = Convert.ToInt32(txtedad.Text);
                        dsClientes.Fecha_De_Registro = dateTimePicker1.Value;

                        dbProyecto1.SaveChanges();
                    }
                    else
                    {
                        Crear();
                    }
                }
            }
            catch {}           
        }

        private void Crear()
        {
            try
            {
                
                dsClientes = new DataADO.Clientes
                {                    
                    Nombre = txtNOmbre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Celular = txtCelular.Text,
                    Cedula = txtcedula.Text,
                    Edad = Convert.ToInt32(txtedad.Text),
                    Fecha_De_Registro = DateTime.Now,
                };

                dbProyecto1.Clientes.Add(dsClientes);
                dbProyecto1.SaveChanges();

                lblId.Text = dsClientes.Id.ToString();
                estado = estatus.Modificando;
            }
            catch { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          if (MessageBox.Show("Esta seguro que quiere eliminar el siguiente registro? " +
              ", la accion no se podra deshacer.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
          {
                try
                {
                    var Cli = (from H in dbProyecto1.Clientes
                               where H.Id == Convert.ToInt32(lblId.Text)
                               select H).Single();

                    dbProyecto1.Clientes.Attach(Cli);
                    dbProyecto1.Clientes.Remove(Cli);                 
                    dbProyecto1.SaveChanges();
                    MessageBox.Show("El cliente se ha eliminado exitosamente");
                }
                catch { MessageBox.Show("El registro no puede ser eliminado intentelo en otro momento","*", MessageBoxButtons.OK,MessageBoxIcon.Error); }

          }
                
        }
    }
}

