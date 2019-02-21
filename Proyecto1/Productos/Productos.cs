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

namespace Proyecto1.Productos
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        DataADO.Proyecto1Entities dbproyecto1;
        DataADO.Productos dsproductos;
        estatus estatus;

        private void Productos_Load(object sender, EventArgs e)
        {
            CenterToScreen();          

            if (estatus == estatus.Modificando)
                lblId.Text = string.Empty;

            if (lblId.Text.Length != 0)
                Cargar(Convert.ToInt32(lblId.Text));

            //if (lblId.Text.Length != 0)
            //    Limpiar();

            dsproductos = new DataADO.Productos();


        }

        private void Limpiar()
        {
            lblId.Text = string.Empty;
            txtproducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtitbs.Text = string.Empty;
            txtbeneficio.Text = string.Empty;
        }

        private void Cargar(int IdPro)
        {
            try
            {
                using(dbproyecto1 = new DataADO.Proyecto1Entities())
                {
                    dsproductos = (from pro in dbproyecto1.Productos
                                   where pro.Id == IdPro
                                   select pro).Single();


                    lblId.Text = dsproductos.Id.ToString();
                    txtproducto.Text = dsproductos.Producto;
                    txtPrecio.Text = dsproductos.Precio.ToString();
                    txtitbs.Text = dsproductos.ITBS.ToString();
                    txtcantidad.Text = dsproductos.Cantidad_Existencia.ToString();
                    txtbeneficio.Text = dsproductos.Margen_Beneficio.ToString();
                    txtDescripcion.Text = txtDescripcion.Text;
                    dtFechaDeRegistro.Value = dsproductos.Registro.Value;
                }
                
            }
            catch { }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length == 0)
                Crear();
            else
                Actualizar(Convert.ToInt32(lblId.Text));
            //dsproductos.Facturacion.Select(x => x.Observaciones).ToList();
        }

        private void Actualizar(int Id)
        {
            try
            {
                if (estatus == estatus.Modificando)
                {
                    using (dbproyecto1 = new DataADO.Proyecto1Entities())
                    {
                        dsproductos = (from pro in dbproyecto1.Productos
                                       where pro.Id == Id
                                       select pro).Single();

                        dsproductos.Id = Convert.ToInt32(lblId.Text);
                        dsproductos.Producto = txtproducto.Text;
                        dsproductos.Despcricion = txtDescripcion.Text;
                        dsproductos.ITBS = Convert.ToDecimal(txtitbs.Text);
                        dsproductos.Precio = Convert.ToDecimal(txtPrecio.Text);
                        dsproductos.Registro = dtFechaDeRegistro.Value;
                        dsproductos.Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text);
                        dsproductos.Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text);

                        dbproyecto1.SaveChanges();
                    }
                }
                else
                {
                    Crear();
                }
            }
            catch { }         
                         
                           
        }

        private void Crear()
        {
            try
            {
                using (dbproyecto1 = new DataADO.Proyecto1Entities())
                {
                    dsproductos = new DataADO.Productos()
                    { 
                        Producto = txtproducto.Text,
                        Precio = Convert.ToDecimal(txtPrecio.Text),
                        Despcricion = txtDescripcion.Text,
                        ITBS = Convert.ToDecimal(txtitbs.Text),
                        Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text),
                        Registro = DateTime.Now,
                        Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text)
                    };

                    dbproyecto1.Productos.Add(dsproductos);
                    dbproyecto1.SaveChanges();

                    estatus = estatus.Modificando;
                    lblId.Text = dsproductos.Id.ToString();
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }

                         
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
