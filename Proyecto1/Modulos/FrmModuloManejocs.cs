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
        private DataADO.Proyecto1Entities db;
        
        private void fillModulos()
        {
            int idUser = AgsinarYModificar.idUser;

            using(db = new DataADO.Proyecto1Entities())
            {
                var seguridad = db.Seguridad
                               .Where(x=>x.IdUsuario == idUser)
                               .Select(x=>x.IdModulo);

                var modulos = db.Modulos
                              .Where(x => x.Id == x.Id &&
                              !seguridad.Contains(x.Id))
                              .Select(x => new
                              {
                                  x.Id,
                                  Modulo = x.NombreDeModulo
                              });

                if (modulos.Any())
                {
                    dataGridView1.DataSource = modulos.OrderBy(x => x.Id).ToList();
                    dataGridView1.Columns[2].Visible = false;
                    //dataGridView1.SortedColumn.
                    dataGridView1.Columns["Modulo"].DisplayIndex = 0;
                    dataGridView1.Columns["Editar"].DisplayIndex = 1;
                    dataGridView1.Columns["Ver"].DisplayIndex = 2;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                else
                {
                    var user = db.Usuarios.Where(x => x.Id == idUser).Select(x => x.Nombre).Single();
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
        //public List<int?> IdsSubRoles = new List<int?>();
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var seguridad = new List<DataADO.Seguridad>();
                int iduser = AgsinarYModificar.idUser;
                using (db = new DataADO.Proyecto1Entities())
                {

                    foreach (DataGridViewRow rows in dataGridView1.SelectedRows)
                    {
                        var Editar = Convert.ToBoolean(rows.Cells["Editar"].Value);                    
                        var Ver = Convert.ToBoolean(rows.Cells["Ver"].Value);

                        if(Editar == true && Ver == false)
                        {
                            Ver = true;
                        }
                        seguridad.Add(new DataADO.Seguridad()
                        {
                            IdModulo = Convert.ToInt32(rows.Cells["Id"].Value),
                            IdUsuario = iduser,
                            Editar = (bool)Editar,
                            Ver = (bool)Ver
                        });                                                
                    }
                    db.Seguridad.AddRange(seguridad);
                    db.SaveChanges();
                }
                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    MessageBox.Show("Exitoso");
                    Close();
                }
                else
                {
                    MessageBox.Show("No realizo ningun cambio");
                    Close();
                }
            }
        }     

    }
}