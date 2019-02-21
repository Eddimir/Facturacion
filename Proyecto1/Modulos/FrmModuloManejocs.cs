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
    public partial class FrmModuloManejocs : Form
    {
        public bool buscando;
        public FrmModuloManejocs()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities dbProyecto;
        
        private void fillModulos()
        {
            int idUser = AgsinarYModificar.idUser;

            using(dbProyecto = new DataADO.Proyecto1Entities())
            {
                var seguridad = dbProyecto.Seguridad
                               .Where(x=>x.IdUsuario == idUser)
                               .Select(x=>x.IdModulo);

                var modulos = dbProyecto.Modulos
                              .Where(x => x.Id == x.Id &&
                              !seguridad.Contains(x.Id))
                              .Select(x => new
                              {
                                  x.Id,
                                  x.NombreDeModulo
                              });

                if (modulos.Any())
                {
                    dataGridView1.DataSource = modulos.OrderBy(x => x.Id).ToList();
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                else
                {
                    var user = dbProyecto.Usuarios.Where(x => x.Id == idUser).Select(x => x.Nombre).Single();
                    MessageBox.Show($"El usuario: {user} no tiene modulos por agsinar.");
                                                                                                     Close();
                }
               

                    
            }
        }

        private void FrmModuloManejocs_Load(object sender, EventArgs e)
        {
            fillModulos();
            CenterToScreen();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var seguridad = new List<DataADO.Seguridad>();
                int iduser = AgsinarYModificar.idUser;
                using (dbProyecto = new DataADO.Proyecto1Entities())
                {
                    foreach(DataGridViewRow rows in dataGridView1.SelectedRows)
                    {
                        seguridad.Add(new DataADO.Seguridad()
                        {
                            IdModulo = Convert.ToInt32(rows.Cells[0].Value),
                            IdUsuario = iduser                                                    
                        });                   
                    }
                    dbProyecto.Seguridad.AddRange(seguridad);
                    dbProyecto.SaveChanges();
                }
                MessageBox.Show("Exitoso");
                Close();
            }
        }
    }
}
