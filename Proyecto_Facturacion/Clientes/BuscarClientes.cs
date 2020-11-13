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
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        //public bool buscandi;
        //public string id;
        private DataADO.Proyecto1Entities db;
        estatus estatus;
        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            RefresFill();
        }
        

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Clientes d = new Clientes();
        //    d.estado = Clases.Veloz.estatus.creando;
        //    d.ShowDialog();
        //}
        private void RefresFill()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var fill = (from d in db.Clientes
                            select new
                            {
                                d.Id,
                                d.Nombre,
                                d.Apellido,
                                d.Cedula,
                                d.Celular,
                                d.Edad,
                                d.Direccion,
                                d.Correo
                                
                            }).OrderBy(x => x.Id).ToList();

                dataGridView1.DataSource = fill;
                autosize();
            }
        }

        VerClientes fr = new VerClientes();
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void ReadOnly()
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)//Se ejecuta cada vez que se entran valores en el texbox
        {

            using (var db = new DataADO.Proyecto1Entities())
            {
                var fill = (from d in db.Clientes
                            where d.Nombre.Contains(txtbusqueda.Text) || d.Apellido.Contains(txtbusqueda.Text)//Filtro 
                            select new
                            {
                                d.Id,
                                d.Nombre,
                                d.Apellido,
                                d.Cedula,
                                d.Celular,
                                d.Edad,
                                d.Direccion,
                                d.Correo

                            }).OrderBy(x => x.Id).ToList();

                dataGridView1.DataSource = fill;
                autosize();
            }
        }
        private void Limpiar()
        {
            lblId.Text = "";
            txtNOmbre.Text = "";
            txtApellido.Text = "";
            txtcedula.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtedad.Text = "";
            txtcorreo.Text = "";
           
        }
        private void autosize()
        {
            dataGridView1.BackgroundColor = Color.White;

           
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dataGridView1.MultiSelect = true;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void btnGua(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CambioDeCliente();
        }

        private void CambioDeCliente()
        {
            lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int? id = Convert.ToInt32(lblId.Text);
            cargar(id);
        }

        private void cargar(int? id)
        {
            if(id != null)
            {
                using(db = new DataADO.Proyecto1Entities())
                {
                    var Cliente = (from p in db.Clientes
                                    where p.Id == id
                                    select p).First();

                    lblId.Text = Cliente.Id.ToString();
                    txtNOmbre.Text = Cliente.Nombre;
                    txtApellido.Text = Cliente.Apellido;
                    txtcedula.Text = Cliente.Cedula;
                    txtCelular.Text = Cliente.Celular;
                    txtcorreo.Text = Cliente.Correo;
                    txtedad.Text = Cliente.Edad.ToString();
                    txtDireccion.Text = Cliente.Direccion;
                }
            }
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
                RefresFill();
            
        }

        private void Actualizar(int id)
        {
            if(estatus == estatus.Modificando || estatus != estatus.Modificando)
            {
                using(db = new DataADO.Proyecto1Entities())
                {
                    var cliente = (from cli in db.Clientes
                                  where cli.Id == id
                                  select cli).First();

                    cliente.Id = Convert.ToInt32(lblId.Text);
                    cliente.Nombre = txtNOmbre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Cedula = txtcedula.Text;
                    cliente.Celular = txtCelular.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Edad = Convert.ToInt32(txtedad.Text);
                    cliente.Correo = txtcorreo.Text;

                    db.SaveChanges();
                }
            }
            else
            {
                Crear();
            }
        }

        private void Crear()
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                var Cliente = new DataADO.Clientes()
                {
                    Nombre = txtNOmbre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Cedula = txtcedula.Text,
                    Celular = txtCelular.Text,
                    Correo = txtcorreo.Text,
                    Edad = (txtedad.Text.Length != 0) ? Convert.ToInt32(txtedad.Text) : 0,
                    Fecha_De_Registro = DateTime.Today
                };

                db.Clientes.Add(Cliente);
                db.SaveChanges();

                estatus = estatus.Modificando;
                lblId.Text = Cliente.Id.ToString();
         
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Esta seguro que quiere eliminar el siguiente registro? " +
                 ", la accion no se podra deshacer.", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (db = new DataADO.Proyecto1Entities())
                        {
                            var Cli = db.Clientes.Find(Convert.ToInt32(lblId.Text));

                            db.Clientes.Attach(Cli);
                            db.Clientes.Remove(Cli);
                            db.SaveChanges();
                            MessageBox.Show("El cliente se ha eliminado exitosamente");
                            RefresFill();
                        }
                    }
                    catch { MessageBox.Show("El registro no puede ser eliminado debido a que este tiene Historias", "*", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
            }
        }
    }
}
