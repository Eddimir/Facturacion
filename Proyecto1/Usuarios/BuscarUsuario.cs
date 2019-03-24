using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Usuarios
{
    public partial class BuscarUsuario : Form
    {
        public BuscarUsuario()
        {
            InitializeComponent();
        }
        public  bool buscando;

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Fill();           
        }

        private void Fill()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var user = (from us in db.Usuarios
                            select new
                            {
                                us.Id,
                                us.Nombre,
                                us.Apellido,
                                us.Cedula,
                                us.Direccion,
                                us.Telefono
                            });


                dataGridView1.DataSource = user.OrderBy(x=>x.Id).ToList();
                autoajuste();
                
            }
            
        }
    
        public string Id;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Clientes.VerClientes fr = new Clientes.VerClientes();
            if (buscando)
            {
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Close();
            }
            else
            {
                //fr.lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //fr.ShowDialog();
            }
        }


        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            using (DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities())
            {
                var filtro = db.Usuarios.Where(x => x.Nombre.Contains(txtfiltro.Text) || x.Apellido.Contains(txtfiltro.Text))
                    .Select(x => new
                    {
                        x.Id,
                        x.Nombre,
                        x.Apellido,
                        x.Cedula,
                        x.Direccion,
                        x.Telefono
                    });

                dataGridView1.DataSource = filtro.OrderBy(x => x.Id).ToList();
                autoajuste();
            }
        }
        private void autoajuste()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.MultiSelect = true;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
        }
    }
}
