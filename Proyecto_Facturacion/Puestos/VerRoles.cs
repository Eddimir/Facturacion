using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Puestos
{
    public partial class VerRoles : Form
    {
        public VerRoles()
        {
            InitializeComponent();
            db = new DataADO.Proyecto1Entities();
        }

        private DataADO.Proyecto1Entities db;

        private void LLenar()
        {
            var Rol = from p in db.Puestos
                      select new
                      {
                          p.Puesto,
                          Usuario = p.Usuarios.Select(x => x.Nombre).ToList(),
                          Sueldo = p.Sueldos.Select(x => x.Sueldo).ToList()
                      };

            dataGridView1.DataSource = Rol.ToList();
        }

        private void VerRoles_Load(object sender, EventArgs e)
        {
            LLenar();
            CenterToScreen();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Proyecto1.Puestos.frmRolUsuarios frmRolUsuarios = new frmRolUsuarios();
            frmRolUsuarios.LImpiar();
            frmRolUsuarios.ShowDialog();
            LLenar();
        }
    }
}
