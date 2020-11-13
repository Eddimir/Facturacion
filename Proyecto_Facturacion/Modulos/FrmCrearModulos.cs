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
        private DataADO.Modulos modulo;
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        estatus estatus;

        private void FrmCrearModulos_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (estatus == estatus.Modificando)
                lblid.Text = "";

            if (lblid.Text.Length != 0)
                cargar(Convert.ToInt32(lblid.Text));
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

     
   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(lblid.Text.Length == 0)
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
            using(var db= new DataADO.Proyecto1Entities())
            {
                var modulo = (from m in db.Modulos
                             where m.Id == id
                             select m).First();

                lblid.Text = modulo.Id.ToString();
                txtNombreDeModulo.Text = modulo.NombreDeModulo;
            }            
        }
        public void Limpiar()
        {
            lblid.Text = "";
            txtNombreDeModulo.Text = "";
        }
        private void Crear()
        {
            if (txtNombreDeModulo.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
                errorProvider1.SetError(txtNombreDeModulo, "Ingrese un nombre");
            }
            else
            {
                using (db = new DataADO.Proyecto1Entities())
                {
                    var  modulo = new DataADO.Modulos
                    {
                        NombreDeModulo = txtNombreDeModulo.Text
                    };

                    db.Modulos.Add(modulo);
                    db.SaveChanges();

                    estatus = estatus.Modificando;
                    lblid.Text = modulo.Id.ToString();

                    MensajeOk("Se inserto Correctamente");
                    Close();
                    Modulos.FrmCrearModulos frmCrearModulos = new FrmCrearModulos();
                    //frmCrearModulos.MdiChildren = ActiveForm;
                    frmCrearModulos.ShowDialog();
                }
            }
           
        }
        private void Actualizar(int id)
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                if (estatus == estatus.Modificando || estatus != estatus.Modificando)
                {
                    modulo = (from e in db.Modulos
                              where e.Id == id
                              select e).First();


                    modulo.NombreDeModulo = txtNombreDeModulo.Text;

                    db.SaveChanges();
                    MensajeOk("Se actualizo de forma correcta");
                }
                else
                {
                    Crear();
                }
            }

        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    var modulos = from m in db.Modulos
        //                  where m.NombreDeModulo.Contains(txtfiltro.Text)
        //                  select new
        //                  {
        //                      m.Id,
        //                      m.NombreDeModulo
        //                  };

        //    dtgvModulos.DataSource = modulos.ToList();
        //    autoJuste();
        //    CargarFiltro();
        //}

        //private void autoJuste()
        //{
        //    dtgvModulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    dtgvModulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //}
        //private void CargarFiltro()
        //{
        //    try
        //    {
        //        lblid.Text = dtgvModulos.CurrentRow.Cells["Id"].Value.ToString();

        //        int? id = Convert.ToInt32(lblid.Text);
        //        cargar(id);
        //    }
        //    catch { }
        //}

        private void bTnnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //private void dtgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CargarFiltro();
        //}
    }
}
