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

namespace Proyecto1.TipoDivisa
{
    public partial class Divisas : Form
    {
        public Divisas()
        {
            InitializeComponent();
        }
        estatus estatus;
        private void Divisas_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (estatus == estatus.Modificando)
                lblid.Text = string.Empty;

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
        private void cargar(int id)
        {
            using (var db = new DataADO.Proyecto1Entities())
            {
                var tipo = (from pro in db.TipoDeDivisa
                            where pro.Id == id
                            select pro).First();

                lblid.Text = tipo.Id.ToString();
                //Convirtiendo de decimales equivalente a pesos extrajero para facilitar la conversion de ITBs en las divisas
                txtitbs.Text = (tipo.TipoDivisa != "Dominicano") ? (tipo.ITBS * 100 * tipo.Valor).Value.ToString("N2") + "%" : (tipo.ITBS * 100).Value.ToString("N2") + "%";
                txttipodivisa.Text = tipo.TipoDivisa;
                txtvalor.Text = tipo.Valor.ToString();
            }
        }

        public void Limpiar()
        {
            lblid.Text = "";
            txtitbs.Text = "";
            txttipodivisa.Text = "";
            txtvalor.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (lblid.Text.Length == 0)
                crear();
            else
                Actualizar(Convert.ToInt32(lblid.Text));
        }

        private void Actualizar(int Id)
        {
            if (txtvalor.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
                errorProvider1.SetError(txtvalor, "este campo es de obligacion");
            }
            if (txttipodivisa.Text == "")
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
                errorProvider1.SetError(txttipodivisa, "este campo es requerido");
            }
            using (var db = new DataADO.Proyecto1Entities())
            {
                var tipo = db.TipoDeDivisa
                             .Where(x => x.Id == Id)
                             .First();

                tipo.TipoDivisa = txttipodivisa.Text;
                tipo.Valor = (txtvalor.Text != "") ? Convert.ToDecimal(txtvalor.Text) : 0;
                tipo.ITBS = (txtvalor.Text.Length != 0 && txtvalor.Text.Length != 0) ? CalcularITBS(txtvalor, txtitbs) : 0;
                tipo.FechaActualizacion = DateTime.Now;

                db.SaveChanges();
                MensajeOk("Se actualizo de forma correcta");
            }

        }

        private void crear()
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                if (txtvalor.Text == string.Empty )
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorProvider1.SetError(txtvalor, "este campo es de obligacion.");                    
                }
                if(txttipodivisa.Text == "")
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorProvider1.SetError(txttipodivisa, "este campo es requerido");
                }


                 var tipoDivisa = new DataADO.TipoDeDivisa
                 {
                     TipoDivisa = txttipodivisa.Text,
                     ITBS = (txtvalor.Text.Length != 0 && txtvalor.Text.Length != 0) ? CalcularITBS(txtvalor, txtitbs) : 0,
                     Valor = Convert.ToDecimal(txtvalor.Text),
                     FechaActualizacion = DateTime.Now
                 };

                 db.TipoDeDivisa.Add(tipoDivisa);
                 db.SaveChanges();

                 estatus = estatus.Modificando;
                 lblid.Text = tipoDivisa.Id.ToString();
                 MensajeOk("Se inserto correctamente");

                 Close();
                 Divisas divisas = new Divisas();
                 divisas.ShowDialog();
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private decimal CalcularITBS(TextBox ValorDivisa, TextBox ITBSXPorcentaje)
        {
            if(txtitbs.Text.Length != 0 && txtvalor.Text.Length != 0)
            {
                if(MessageBox.Show($"Esta seguro de que el valor de ITBS en su region es igual a: {txtitbs.Text}%","Sistemas de ventas",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Obteniendo la primera parte y ignorando el signo de procentaje...
                    string[] valor = ITBSXPorcentaje.Text.Split('%');

                    try
                    {
                        if (txttipodivisa.Text != "Dominicano")
                        {
                            var ValorDivi = Convert.ToDecimal(ValorDivisa.Text);
                            //var dd = ITBSXPorcentaje.Text;                          

                            var ValorITBS = Convert.ToDecimal(valor[0]);
                            return ValorITBS / 100 / ValorDivi;
                        }

                        else
                        {
                            return Convert.ToDecimal(valor[0]) /  100;
                        }
                    }
                    catch { }
                }
            }
            return 0;      

        }
    }
}
