using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
     
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        //private Usuarios.BuscarUsuario first;

        //private void btnUser_Click(object sender, EventArgs e)
        //{
        //    Usuarios.BuscarUsuario dd = new Usuarios.BuscarUsuario();
           
        //    ////Usuarios.BuscarUsuario dd = new Usuarios.BuscarUsuario();
        //    ////dd.Controls.Add(this.first);

        //    //this.first = new Usuarios.BuscarUsuario();
        //    //this.SuspendLayout();

        //    ////this.first.BackColor = new System.Drawing.SystemColors;
        //    //this.first.Location = new System.Drawing.Point(98, 105);
        //    //this.first.Size = new System.Drawing.Size(75, 16);
            

        //}

        private void Login_Load(object sender, EventArgs e)            
        {

            ModificacionCtrs();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginUsuario();
            Validacion();
        }

        private void LoginUsuario()
        {
            if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtContrasenia.Text))
            {
                using (var db = new DataADO.Proyecto1Entities())
                {
                    var User = db.Usuarios.FirstOrDefault(x => x.Nombre == txtuser.Text &&
                                                          x.Contrasena == txtContrasenia.Text);
                    
                   
                    if (User == null)
                    {
                        MessageBox.Show("Porfavor digitar los datos correspondientes.");
                    }
                    else
                    {
                        Principal.veloz22 = new Clases.Veloz(User.Id, User.Nombre, User.Contrasena,User.Apellido);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Porfavor completar ambos campos para poder continuar con el proceso");
            }            
        }
        private void ModificacionCtrs()
        {
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.MaxLength = 20;
            txtContrasenia.CharacterCasing = CharacterCasing.Lower;
        }
        private void Validacion()
        {
            if (txtuser.Text == string.Empty)
            {
                errorProvider1.SetError(txtuser, "Introduzca el nobre del usuario.");
                txtuser.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
            //***//
            if (txtContrasenia.Text == string.Empty)
            {
                errorProvider2.SetError(txtContrasenia, "Introduzca la contrasenia.");
                //txtContrasenia.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }

        }

    }
}
