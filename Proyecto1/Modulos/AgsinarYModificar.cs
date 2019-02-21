﻿using System;
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
        private DataADO.Proyecto1Entities db;
        private DataADO.Modulos dsmodulos;

        private void AgsinarYModificar_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dsmodulos = new DataADO.Modulos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios.BuscarUsuario fr = new Usuarios.BuscarUsuario();
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
                dtgvAsignarModulo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgvAsignarModulo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
    }
}