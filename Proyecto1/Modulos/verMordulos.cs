using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Modulos
{
    public partial class verMordulos : Form
    {
        public verMordulos()
        {
            InitializeComponent();
        }
       

        private IEnumerable<object> RefreshFill()
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                var query = from d in db.Modulos
                            select new
                            {
                                d.Id,
                                d.NombreDeModulo
                            };

                dtgvModulos.DataSource = query.OrderBy(x => x.Id).ToList();

                dtgvModulos.Columns[0].Visible = false;
                dtgvModulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                return query.ToArray();

                
            }
         
        }
    
         FrmCrearModulos frm = new FrmCrearModulos();
        private void BtnNew_Click(object sender, EventArgs e)
        {
           
            frm.Limpiar();
            frm.ShowDialog();
            RefreshFill();
        }
        
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            frm.lblid.Text = dtgvModulos.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            RefreshFill();
        }

        private void VerMordulos_Load(object sender, EventArgs e)
        {
            RefreshFill();
            CenterToScreen();
        }

        private void Txtfiltro_TextChanged(object sender, EventArgs e)
        {
            var db = new DataADO.Proyecto1Entities();

            var query = from d in db.Modulos
                        where d.NombreDeModulo.Contains(txtfiltro.Text)
                        select new
                        {
                            d.Id,
                            d.NombreDeModulo
                        };

            dtgvModulos.Columns[0].Visible = false;
            dtgvModulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvModulos.DataSource = query.OrderBy(x => x.Id).ToList();
        }
    }
}
