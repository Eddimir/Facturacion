using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Proveedores
{
    public partial class verProveedores : Form
    {
        private readonly DataADO.Proyecto1Entities db;
        public bool buscando;
        public int id;
        public verProveedores()
        {
            InitializeComponent();
            db = new DataADO.Proyecto1Entities();
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

            dgvProveedores.DataSource = query.OrderBy(x => x.Id).ToList();
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

            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
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

        private void VerProveedores_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            RefreSFill();
        }
        public void Botones()
        {
            var db = new DataADO.Proyecto1Entities();
            var query = db.Seguridad.Where(x => x.IdUsuario == Principal.veloz22.id && x.Modulos.NombreDeModulo == "proveedores")
                                    .Select(x => new { x.Ver, x.Editar }).FirstOrDefault();

            if (query.Editar == true)
            {
                btnNuevo.Enabled = true;
                btnSeleccionar.Enabled = true;
            }
            else
            {
                btnNuevo.Enabled = false;
                btnSeleccionar.Enabled = false;
            }
        }
        Proveedores proveedores = new Proveedores();
        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
           
            if (buscando)
            {
                id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value);
                Close();
            }
            else
            {
                proveedores.lblId.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                proveedores.ShowDialog();

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            proveedores.LimpiarCampos();
            proveedores.ShowDialog();
            RefreSFill();
        }
    }
}
