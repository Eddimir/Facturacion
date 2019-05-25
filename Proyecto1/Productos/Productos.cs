using Proyecto1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        DataADO.Proyecto1Entities db;
        DataADO.Productos dsproductos;
        estatus estatus;

        private void Productos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            CategoriaProducto();

            if (estatus == estatus.Modificando)
                lblId.Text = string.Empty;

            if (lblId.Text.Length != 0)
                Cargar(Convert.ToInt32(lblId.Text));

            AvisarVencimiento();
            dsproductos = new DataADO.Productos();


          
        }
        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Limpiar()
        {
            lblId.Text = string.Empty;
            txtproducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            ckbitbs.Checked = false;
            txtbeneficio.Text = string.Empty;
            PtImagen.Image = null;
            dtvencimiento.Value = DateTime.Now;
            cmbcategoriaproducto.SelectedIndex = -1;
            txtdiasparaavisar.Text = "";
            ckbavisarvencimiento.Checked = false;
            textBox1.Text = "";

            ///Value by default
            //txtitbs.Text = "0.00";
            //txtPrecio.Text = "";
        }

        private void Cargar(int IdPro)
        {
            try
            {
                using(db = new DataADO.Proyecto1Entities())
                {
                    dsproductos = (from pro in db.Productos
                                   where pro.Id == IdPro
                                   select pro).Single();


                    if (dsproductos.Codigo != null)
                        ckbgeneralcode.Visible = false;
                    else
                        ckbgeneralcode.Visible = true;

                    lblId.Text = dsproductos.Id.ToString();
                    txtproducto.Text = dsproductos.Producto;
                    txtPrecio.Text = dsproductos.Precio.ToString();
                    ckbitbs.Checked = (dsproductos.ITBS != null) ? true : false;
                    txtcantidad.Text = dsproductos.Cantidad_Existencia.ToString();
                    txtbeneficio.Text = dsproductos.Margen_Beneficio.ToString();
                    txtDescripcion.Text = dsproductos.Despcricion;
                    cmbcategoriaproducto.SelectedValue = dsproductos.IdCategoria.ToString();
                    ckbavisarvencimiento.Checked = (bool)dsproductos.AvisarVencimiento; /*Convert.ToBoolean(dsproductos.AvisarVencimiento);*/
                    txtdiasparaavisar.Text = dsproductos.DiasParaAvisar.ToString();
                    PtImagen.Image = Veloz.byteArrayToImage(dsproductos.Imagen);
                    dtvencimiento.Value = (dsproductos.FechaVencimiento.Value == null) ? DateTime.Today: dsproductos.FechaVencimiento.Value;
                    //}
                    dtvencimiento.Value = dsproductos.FechaVencimiento.Value;
                    if (dsproductos.Imagen != null)
                    {
                        PtImagen.Image = Veloz.byteArrayToImage(dsproductos.Imagen);
                    }
                    else
                    {
                        PtImagen.Image = null;
                    }
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
                if (estatus == estatus.Modificando || estatus  != estatus.Modificando)
                {
                    if (txtproducto.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar algunos datos, seran remarcados");
                        errorProvider1.SetError(txtproducto, "Ingrese un nombre");
                    }
                    if(cmbcategoriaproducto.SelectedValue == null)
                    {
                        MensajeError("Falta ingresar algunos datos, seran remarcados");
                        errorProvider1.SetError(cmbcategoriaproducto, "elija una categoria");
                    }
                    using (db = new DataADO.Proyecto1Entities())
                    {
                        dsproductos = (from pro in db.Productos
                                       where pro.Id == Id
                                       select pro).Single();

                        dsproductos.Codigo = (ckbgeneralcode.Checked) ? GeneralCode() : null;
                        dsproductos.Producto = txtproducto.Text;
                        dsproductos.Despcricion = txtDescripcion.Text;
                        dsproductos.ITBS = (ckbitbs.Checked == true) ? Itbs(db) : 0;
                        dsproductos.Precio = Convert.ToDecimal(txtPrecio.Text);
                       
                        dsproductos.Registro = DateTime.Today;
                        dsproductos.Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text);
                        dsproductos.Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text);
                        dsproductos.IdCategoria = Convert.ToInt32(cmbcategoriaproducto.SelectedValue);
                        dsproductos.DiasParaAvisar = txtdiasparaavisar.Text.Length == 0 ? 0: Convert.ToInt32(txtdiasparaavisar.Text);
                        dsproductos.AvisarVencimiento = (ckbavisarvencimiento.Checked == true) ? true : false;
                        dsproductos.FechaVencimiento = ckbavisarvencimiento.Checked ? dtvencimiento.Value : Convert.ToDateTime(null) ;

                        /// convercion de byte to img...
                        //var img = byteArrayToImage(dsproductos.Imagen);

                        if(PtImagen.Image != null)
                        dsproductos.Imagen = imageToByteArray(PtImagen.Image);

                        AvisarVencimiento();

                        db.SaveChanges();
                        MensajeOk("Se actualizo de forma correcta");
                    }
                }
                else
                {
                    Crear();
                }
            }
            catch { }         
                         
                           
        }

        //private void Crear()
        //{
        //    try
        //    {
        //        using (dbproyecto1 = new DataADO.Proyecto1Entities())
        //        {
        //            dsproductos = new DataADO.Productos()
        //            { 
        //                Producto = txtproducto.Text,
        //                Precio = Convert.ToDecimal(txtPrecio.Text),
        //                Despcricion = txtDescripcion.Text,
        //                ITBS = Convert.ToDecimal(txtitbs.Text),
        //                Margen_Beneficio = Convert.ToDecimal(txtbeneficio.Text),
        //                Registro = DateTime.Now,
        //                Cantidad_Existencia = Convert.ToDecimal(txtcantidad.Text)
        //            };

        //            dbproyecto1.Productos.Add(dsproductos);
        //            dbproyecto1.SaveChanges();

        //            estatus = estatus.Modificando;
        //            lblId.Text = dsproductos.Id.ToString();
        //        }
        //    }
        //    catch (Exception ex){ MessageBox.Show(ex.Message); }


        //}

        
      
        private void Crear()
        {
            using (var db = new DataADO.Proyecto1Entities())
            {

                decimal beneficio = (txtbeneficio.Text.Length == 0) ? 0 : Convert.ToDecimal(txtbeneficio.Text);
                decimal Precio = (txtPrecio.Text.Length == 0) ? 0 : Convert.ToDecimal(txtPrecio.Text);
                decimal precioTotal = ((Precio + beneficio) == 0.00m) ? 0 : Precio + beneficio;

                if(txtproducto.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorProvider1.SetError(txtproducto, "Ingrese un nombre");
                }

                if (precioTotal == 0)
                {
                    MensajeError("El precio  no  puede ser igual a 0, porfavor modificar el registro");
                    errorProvider1.SetError(txtPrecio, "modificar el precio");
                }
                else if (precioTotal != 0)
                {
                    var Producto = new DataADO.Productos
                    {
                        Codigo = (ckbgeneralcode.Checked) ?  GeneralCode() : null,
                        Producto = txtproducto.Text,
                        Despcricion = txtDescripcion.Text,
                        Precio = precioTotal,
                        ITBS = (ckbitbs.Checked == true) ? Itbs(db) : 0,
                        Cantidad_Existencia = (txtcantidad.Text.Length == 0) ? 0 : Convert.ToDecimal(txtcantidad.Text),
                        Margen_Beneficio = beneficio,
                        Registro = DateTime.Now,
                        AvisarVencimiento = (ckbavisarvencimiento.Checked == true) ? true : false,
                        DiasParaAvisar = (txtdiasparaavisar.Text.Length == 0) ? 0 : Convert.ToInt32(txtdiasparaavisar.Text),
                        Imagen = (PtImagen.Image != null) ? Veloz.imageToByteArray(PtImagen.Image) : null,
                        FechaVencimiento = (ckbavisarvencimiento.Checked) ? dtvencimiento.Value : Convert.ToDateTime(null),
                        IdCategoria = Convert.ToInt32(cmbcategoriaproducto.SelectedValue)                        
                    };

                    db.Productos.Add(Producto);
                    db.SaveChanges();

                    estatus = estatus.Modificando;
                    lblId.Text = Producto.Id.ToString();
                    MensajeOk("Se inserto Correctamente");
                    Close();
                    Productos productos = new Productos();                 
                    productos.ShowDialog();
                    //RefreshFill();
                }
            }
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
        private string GeneralCode()
        {
            var yearL = DateTime.Now.Year.ToString().Substring(1);
            var mes = DateTime.Now.Month;
            var dia = DateTime.Now.Day;
            var hora = DateTime.Now.Hour;
            var segundo = DateTime.Now.Second;

            var codigo = yearL +  mes + dia  + hora  + segundo;
        

            return codigo;

        }

        private void New_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                //PtImagen.Image;
                var image = new Bitmap(open.FileName);
                var imagePerfect = new Bitmap(image, 201, 185);
                PtImagen.Image = imagePerfect;
                // image file path  
                PtImagen.Text = open.FileName;
                textBox1.Text = open.FileName;

            }

        }

        private void CategoriaProducto()
        {
            db = new DataADO.Proyecto1Entities(); 
            var categoria = db.ProductosCategoria.SqlQuery("Select * from ProductosCategoria")
                               .Select(x => new
                               {
                                   x.Id,
                                   x.Categoria
                               });

            cmbcategoriaproducto.DataSource = categoria.ToList();
            cmbcategoriaproducto.DisplayMember = "Categoria";
            cmbcategoriaproducto.ValueMember = "Id";
            
            cmbcategoriaproducto.FlatStyle = FlatStyle.Flat;
            cmbcategoriaproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private decimal? Itbs(DataADO.Proyecto1Entities db)
        {
            var itbs = db.TipoDeDivisa.Where(x => x.TipoDivisa == "Dominicano").FirstOrDefault().ITBS;
            return itbs;
        }

        private void Ckbavisarvencimiento_CheckedChanged(object sender, EventArgs e)
        {
            AvisarVencimiento();
        }
        private void AvisarVencimiento()
        {
            if (ckbavisarvencimiento.Checked)
            {
                lbldiasparavisar.Visible = true;
                lblvencimiento.Visible = true;
                dtvencimiento.Visible = true;
                txtdiasparaavisar.Visible = true;
            }
            else
            {
                lbldiasparavisar.Visible = false;
                lblvencimiento.Visible = false;
                dtvencimiento.Visible = false;
                txtdiasparaavisar.Visible = false;
            }

            textBox1.ReadOnly = true;
        }
    }
}
