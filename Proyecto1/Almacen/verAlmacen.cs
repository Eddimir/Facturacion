using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Almacen
{
    public partial class verAlmacen : Form
    {
        private DataADO.Proyecto1Entities db;
        public verAlmacen()
        {
            InitializeComponent();
            db = new DataADO.Proyecto1Entities();
        }
        public bool buscando;
        public string id;
       
        private void Llenar()
        {
            var Almacen = from al in db.Almacen
                          select new
                          {
                              al.Id,
                              al.Producto,
                              al.Precio,
                              al.ITBS,
                              al.Existencia,
                              al.Descripcion
                          };
            dtgvVer.DataSource = Almacen.OrderBy(x => x.Id).ToList();
            label1.Text = "Total de clientes:" + dtgvVer.Rows.Count.ToString();
            autosizes();
        }

        private void autosizes()
        {
           
            dtgvVer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvVer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtgvVer.Columns[0].Visible = false;

            dtgvVer.MultiSelect = true;
            dtgvVer.AllowUserToOrderColumns = false;
            dtgvVer.AllowUserToDeleteRows = false;
            dtgvVer.BackgroundColor = Color.White;
            dtgvVer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtgvVer.Columns[1].ReadOnly = true;
            dtgvVer.Columns[2].ReadOnly = true;
            dtgvVer.Columns[3].ReadOnly = true;
            dtgvVer.Columns[4].ReadOnly = true;
            dtgvVer.Columns[5].ReadOnly = true;

            dtgvVer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            var almacen = db.Almacen.Where(x => x.Producto.Contains(txtbusqueda.Text)
                         || x.Descripcion.Contains(txtbusqueda.Text))
                         .Select(x => new
                         {
                             x.Id,
                             x.Producto,
                             x.Precio,
                             x.ITBS,
                             x.Existencia,
                             x.Descripcion
                         });

            dtgvVer.DataSource = almacen.OrderBy(x => x.Id).ToList();
            autosizes();
            

        }

        Almacen almacen = new Almacen();
        private void Btlseleccionar_Click(object sender, EventArgs e)
        {
            if (buscando)
            {
                id = dtgvVer.CurrentRow.Cells[0].Value.ToString();
                Close();
            }
            else
            {          
                almacen.lblid.Text = dtgvVer.CurrentRow.Cells[0].Value.ToString();
                almacen.ShowDialog();
            }
        }
        private void Botones()
        {
            var query = db.Seguridad.Where(x => x.IdUsuario == Principal.veloz22.id && x.Modulos.NombreDeModulo == "Almacen")
                .Select(x => new { x.Ver, x.Editar }).FirstOrDefault();

            if (query.Editar == true)
            {
                btnNuevo.Enabled = true;
                btlseleccionar.Enabled = true;
            }
            else
            {
                btnNuevo.Enabled = false;
                btlseleccionar.Enabled = false;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            almacen.Limpiar();
            almacen.ShowDialog();
            Llenar();
        }

        private void VerAlmacen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Llenar();
            Botones();
        }
    }
}
