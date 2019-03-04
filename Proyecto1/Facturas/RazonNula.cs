using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Facturas
{
    public partial class RazonNula : Form
    {
        public int? id;
        public RazonNula(int? id1)
        {            
            InitializeComponent();
            id = id1;
        }

        private void RazonNula_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private Proyecto1.DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();

        private void btnVlidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtxrazonnula.Text.Length == 0)
                {
                    MessageBox.Show($"{Principal.veloz22.Nombre} recuerde dar la razon de porque la factura sera anulada");
                }
                else if(txtxrazonnula.Text.Length <= 300)
                {
                    var act = (from d in db.Facturacion
                               where d.Id == id
                               select d).First();

                    act.RazonNula = txtxrazonnula.Text;
                    act.Nula = true;
                    act.FechaAnulacion = DateTime.Now;

                    db.SaveChanges();
                    MessageBox.Show("Anulacion de factura realizada exitosamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Lo siento ha alcanzando la longitud maxima de carecteres");
                }
            }
            catch { }
        }
    }
}
