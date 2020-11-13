using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.TipoDivisa
{
    public partial class verDivisas : Form
    {
        public verDivisas()
        {
            InitializeComponent();
        }
        public bool buscando;
        public int id;

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TipoDivisa.Divisas divisas = new Divisas();
            divisas.Limpiar();

            divisas.ShowDialog();
            Refres();
        }
        private void Refres()
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                var tipo = db.TipoDeDivisa
                    .Select(x => new
                    {
                        x.Id,
                        x.TipoDivisa,
                        x.Valor,
                        x.ITBS,
                        x.FechaActualizacion
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
            dtgvver.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtgvver.MultiSelect = true;
            dtgvver.AllowUserToOrderColumns = false;
            dtgvver.AllowUserToDeleteRows = false;
            dtgvver.BackgroundColor = Color.White;
            dtgvver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtgvver.Columns[0].Visible = false;

            dtgvver.Columns[1].ReadOnly = true;
            dtgvver.Columns[2].ReadOnly = true;
            dtgvver.Columns[3].ReadOnly = true;
            dtgvver.Columns[4].ReadOnly = true;

            dtgvver.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                var tipo = db.TipoDeDivisa
                             .Where(x => x.TipoDivisa.Contains(txtfiltro.Text))
                             .Select(x => new
                             {
                                 x.Id,
                                 x.TipoDivisa,
                                 x.Valor,
                                 x.ITBS,
                                 x.FechaActualizacion
                             });

                dtgvver.DataSource = tipo.ToList();
                AutoAjuste();
            }
        }

        private void VerDivisas_Load(object sender, EventArgs e)
        {
            Refres();
            CenterToScreen();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            TipoDivisa.Divisas divisas = new Divisas();
            divisas.lblid.Text = dtgvver.CurrentRow.Cells[0].Value.ToString();
            divisas.ShowDialog();
            Refres();            
        }
    }
}
