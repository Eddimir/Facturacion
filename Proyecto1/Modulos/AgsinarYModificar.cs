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
    public partial class AgsinarYModificar : Form
    {
        public AgsinarYModificar()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        private DataADO.Modulos dsmodulos;

        private void AgsinarYModificar_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dsmodulos = new DataADO.Modulos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios.verUsuario fr = new Usuarios.verUsuario();
            fr.buscando = true;
            fr.ShowDialog();
            if(fr.Id != null)
            {
                LlenarUsuario(fr.Id);
                fr.Id = null;
            }
        }
        public static int idUser;
        private void LlenarUsuario(string id)
        {
            var iduser = Convert.ToInt32(id);
            using (db = new DataADO.Proyecto1Entities())
            {
                var user = db.Usuarios.Find(iduser);

                lblid.Text = user.Id.ToString();
                txtxnombre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;                
            }
            RefreshFill();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblid.Text = string.Empty;
            txtxnombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtgvAsignarModulo.DataSource = null;
            dtgvAsignarModulo.Rows.Clear();
        }
        private void RefreshFill()
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                int iduser = Convert.ToInt32(lblid.Text);
                var fill = db.vsModulosUsuarios
                             .Where(x =>x.IdUsuario == iduser);

                dtgvAsignarModulo.DataSource = fill.OrderBy(x => x.id).ToList();
                dtgvAsignarModulo.Columns[1].Visible = false;
                dtgvAsignarModulo.Columns[0].Visible = false;
                dtgvAsignarModulo.Columns[3].Visible = false;
                dtgvAsignarModulo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgvAsignarModulo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgvAsignarModulo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dtgvAsignarModulo.Columns[4].ValueType = typeof(bool);
                dtgvAsignarModulo.Columns[5].ValueType = typeof(bool);
                //dtgvAsignarModulo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.a;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Length != 0)
            {
                idUser = Convert.ToInt32(lblid.Text);
                FrmModuloManejocs fr = new FrmModuloManejocs();
                fr.buscando = true;
                fr.ShowDialog();
                RefreshFill();
            }                
            else
                MessageBox.Show("Para poder continuar con el proceso antes se debe de agregar el usuario correpondiente");
        }

        private void dtgvAsignarModulo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show($"{Principal.veloz22.Nombre} esta completamente seguro de eliminar este modulo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in dtgvAsignarModulo.SelectedRows)
                    {
                        using (var db = new DataADO.Proyecto1Entities())
                        {                         
                            var seguridad = (from d in db.Seguridad
                                             where d.id == Convert.ToInt32(row.Cells["Id"].Value)
                                             select d).First();

                            //seguridad.Ver = false;
                            //seguridad.Editar = false;
                            db.Seguridad.Remove(seguridad);
                            db.SaveChanges();
                        }
                    }
                    RefreshFill();
                }
            }
        }
    }
}
