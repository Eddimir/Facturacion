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

                    //db.Seguridad.Where(x => x.IdUsuario == User.Id).Select(s => new { s.Editar, s.Ver });
                   
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
