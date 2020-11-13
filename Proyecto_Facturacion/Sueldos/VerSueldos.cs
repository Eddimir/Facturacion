using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Sueldos
{
    public partial class VerSueldos : Form
    {
        public VerSueldos()
        {
            InitializeComponent();
        }
        private void Refres()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var tipo = db.Sueldos
                    .Select(x => new
                    {
                        x.Id,
                        Usuario = x.Usuarios.Nombre + x.Usuarios.Apellido,
                        Puesto = x.Puestos.Puesto,
                        x.Sueldo,
                    });

                dtgvver.DataSource = tipo.ToList();
                AutoAjuste();
            }
        }

        private void AutoAjuste()
        {
            dtgvver.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvver.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvver.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtgvver.MultiSelect = true;
            dtgvver.AllowUserToOrderColumns = false;
            dtgvver.AllowUserToDeleteRows = false;
            dtgvver.BackgroundColor = Color.White;
            dtgvver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtgvver.Columns[0].Visible = false;

            dtgvver.Columns[1].ReadOnly = true;
            dtgvver.Columns[2].ReadOnly = true;
            dtgvver.Columns[3].ReadOnly = true;

            dtgvver.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Txtfiltro_TextChanged(object sender, EventArgs e)
        {

            using (var db = new DataADO.Proyecto1Entities())
            {
                var tipo = db.Sueldos
                    .Where(x=>x.Usuarios.Nombre.Contains(txtfiltro.Text) || x.Usuarios.Apellido.Contains(txtfiltro.Text) 
                    || x.Puestos.Puesto.Contains(txtfiltro.Text))
                    .Select(x => new
                    {
                        x.Id,
                        Usuario = x.Usuarios.Nombre + x.Usuarios.Apellido,
                        Puesto = x.Puestos.Puesto,
                        x.Sueldo,
                    });

                dtgvver.DataSource = tipo.ToList();
                AutoAjuste();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Sueldos sueldos = new Sueldos();
            sueldos.Limpiar();
            sueldos.ShowDialog();
            Refres();
        }

        private void VerSueldos_Load(object sender, EventArgs e)
        {
            Refres();
            CenterToScreen();
        }
    }
}
