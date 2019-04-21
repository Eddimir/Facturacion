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


                return query.ToArray();
            }
         
        }
        private void blabla()
        {
            var db = new DataADO.Proyecto1Entities();

            var query = from d in db.Modulos
                        where d.NombreDeModulo.Contains(txtfiltro.Text)
                        select new
                        {
                            d.Id,
                            d.NombreDeModulo
                        };

            dtgvModulos.DataSource = query.OrderBy(x => x.Id).ToList();


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
            
        }
    }
}
