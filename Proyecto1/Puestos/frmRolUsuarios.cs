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

namespace Proyecto1.Puestos
{
    public partial class frmRolUsuarios : Form
    {
        public frmRolUsuarios()
        {
            InitializeComponent();
        }

        private DataADO.Proyecto1Entities dbproyecto;
        private DataADO.Puestos dspuestos;
        estatus estatus;

        private void crear()
        {
            using (dbproyecto = new DataADO.Proyecto1Entities())
            {
                dspuestos = new DataADO.Puestos
                {
                    Puesto = txtPuestos.Text
                };

                dbproyecto.Puestos.Add(dspuestos);
                dbproyecto.SaveChanges();
                MessageBox.Show("El Role se ha guardado exitosamente");

                estatus = estatus.Modificando;
                lblid.Text = dspuestos.Id.ToString();
            }

            
        }

        private void Actualizar(int id)
        {
            using (dbproyecto = new DataADO.Proyecto1Entities())
            {
                dspuestos = (from e in dbproyecto.Puestos
                             where e.Id == id
                             select e).First();

                dspuestos.Id = Convert.ToInt32(lblid.Text);
                dspuestos.Puesto = txtPuestos.Text;

                dbproyecto.SaveChanges();
            }
        }

        private void Cargar(int id)
        {
            var db = new DataADO.Proyecto1Entities();

            var rol = db.Puestos.Find(id);

            lblid.Text = rol.Id.ToString();
            txtPuestos.Text = rol.Puesto;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Length == 0)
                crear();
            else
                Actualizar(Convert.ToInt32(lblid.Text));
        }
        public void LImpiar()
        {
            lblid.Text = "";
            txtPuestos.Text = "";
        }

        private void FrmRolUsuarios_Load(object sender, EventArgs e)
        {
            if (estatus == estatus.Modificando)
                lblid.Text = string.Empty;

            if (lblid.Text.Length != 0)
                Cargar(Convert.ToInt32(lblid.Text));

            CenterToScreen();
        }
    }

  
}
