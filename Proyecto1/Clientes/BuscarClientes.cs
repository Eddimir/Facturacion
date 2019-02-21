using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Clientes
{
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        public bool buscandi;
        public string id;
        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            RefresFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes d = new Clientes();
            d.estado = Clases.Veloz.estatus.creando;
            d.ShowDialog();
        }
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
                                d.Direccion
                            }).OrderBy(x => x.Id).ToList();

                dataGridView1.DataSource = fill;
                autosize();

            }

        }

        Clientes fr = new Clientes();
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (buscandi)
            {
                id = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                Close();
            }
            else
            {
                fr.lblId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Id"].Value);
                fr.ShowDialog();
            }
            RefresFill();
           
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
                                d.Direccion
                            }).OrderBy(x => x.Id).ToList();

                dataGridView1.DataSource = fill;
                autosize();
               

            }
            
        }
        private void autosize()
        {
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
