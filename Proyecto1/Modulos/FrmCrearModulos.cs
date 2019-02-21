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

namespace Proyecto1.Modulos
{
    public partial class FrmCrearModulos : Form
    {
        public FrmCrearModulos()
        {
            InitializeComponent();
        }
        private DataADO.Modulos dsModulos;
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        estatus estatus;

        private void FrmCrearModulos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dsModulos = new DataADO.Modulos();
            RefreshFill();
        }

        private IEnumerable<object> RefreshFill()
        {
            var query = from d in db.Modulos
                        select new
                        {
                            d.Id,
                            d.NombreDeModulo
                        };

            dtgvModulos.DataSource = query.OrderBy(x => x.Id).ToList();
            autoJuste();

            return query.ToList();
        }
        private void Crear()
        {
            using (db = new DataADO.Proyecto1Entities())
            {
                dsModulos = new DataADO.Modulos
                {
                    NombreDeModulo = txtNombreDeModulo.Text
                };

                db.Modulos.Add(dsModulos);
                db.SaveChanges();

                estatus = estatus.Modificando;
                lblid.Text = dsModulos.Id.ToString();
            }            
        }
        private void Actualizar(int id)
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                if (estatus == estatus.Modificando || estatus != estatus.Modificando)
                {
                    dsModulos = (from e in db.Modulos
                                 where e.Id == id
                                 select e).First();


                    dsModulos.NombreDeModulo = txtNombreDeModulo.Text;

                    db.SaveChanges();
                }
                RefreshFill();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(lblid.Text.Length == 0 && txtNombreDeModulo.Text.Length != 0)
            {
                Crear();
            }
            else
            {
                Actualizar(Convert.ToInt32(lblid.Text));
            }
        }
        private void cargar(int? id)
        {
            if(id != null)
            {
                dsModulos = (from m in db.Modulos
                             where m.Id == id
                             select m).First();

                lblid.Text = dsModulos.Id.ToString();
                txtNombreDeModulo.Text = dsModulos.NombreDeModulo;

            }
        }
        private void Limpiar()
        {
            lblid.Text = "";
            txtNombreDeModulo.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var modulos = from m in db.Modulos
                          where m.NombreDeModulo.Contains(txtfiltro.Text)
                          select new
                          {
                              m.Id,
                              m.NombreDeModulo
                          };

            dtgvModulos.DataSource = modulos.ToList();
            autoJuste();
            CargarFiltro();
        }

        private void autoJuste()
        {
            dtgvModulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvModulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CargarFiltro()
        {
            try
            {
                lblid.Text = dtgvModulos.CurrentRow.Cells["Id"].Value.ToString();

                int? id = Convert.ToInt32(lblid.Text);
                cargar(id);
            }
            catch { }
        }

        private void bTnnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarFiltro();
        }
    }
}
