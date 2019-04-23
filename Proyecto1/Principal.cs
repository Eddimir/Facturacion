using Proyecto1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Principal : Form
    {
        public static Form FrmReferencia;
        public Principal()
        {
            GetForm = new Form();
            GetForm = MdiParent;
            InitializeComponent();
        }

        public static Veloz veloz22;
        public string nombre;
        public string contrasenia;
        public static Form GetForm;
        

       

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void Principal_Load(object sender, EventArgs e)
        {
          
            //timer1.Start();
            timer1.Enabled = true;
            Agreggated();
            hidden();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var pro = new Proveedores.BuscarProveedores();
            //pro.MdiParent = this;
            //pro.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var productos = new Productos.BuscarProductos();
            //productos.MdiParent = this;
            //productos.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        
        
        private void Principal_Shown(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.ShowDialog();

            if (veloz22 != null)
            {
                nombre = veloz22.Nombre;
                contrasenia = veloz22.Contrasenia;
                validacion();
                label1.Visible = true;

                label1.Text = $"Usuario: {veloz22.Nombre} {veloz22.Apellido}";
            }
            else
            {
                Application.Exit();
            }
    
        }

        private void validacion()
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
                validacion(menuItem, null);
        }

        private void validacion(dynamic menuItem, string id)
        {
            using(var db = new DataADO.Proyecto1Entities())
            {
                var query = (from ep in db.Seguridad
                             where ep.IdUsuario == veloz22.id
                             select new
                             {
                                 ep.IdModulo,
                                 ep.Modulos.NombreDeModulo

                             }).ToList();

                var padre = string.IsNullOrEmpty(id) ? null : $"{id}";

                menuItem.Visible = false;

                foreach(var permisoUsers in query)
                {
                    if (string.Equals(permisoUsers.NombreDeModulo.ToString(), menuItem.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        padre = permisoUsers.IdModulo.ToString();
                        menuItem.Visible = true;
                    }
                }
                if (menuItem.GetType() != typeof(MenuStrip))
                    return;

                foreach (var item in menuItem.menuItem.Items)
                    validacion(item, id);
            }
            label1.Text = $"Usuario: {veloz22.Nombre}";
        }

        private DataADO.Proyecto1Entities db = new DataADO.Proyecto1Entities();
        private void mostrandovencimientodefacturas()
        {

          
            var factura = (from d in db.Facturacion
                           where DbFunctions.TruncateTime(d.FechaVencimiento) == DbFunctions.TruncateTime(DateTime.Today.Date)
                           && d.pagada == false || d.pagada == null
                           select d).ToList();


            if (factura.Count >= 1)
            {
                MessageBox.Show("Atencion por favor dirigirse al modulo de facturacion hay facturas que hoy se vencen", "Antencion");
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void agregarYModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void seleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Proveedores.Proveedores fr = new Proveedores.Proveedores
            //{
            //    MdiParent = this
            //};
            //fr.Show();

        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.verProveedores fr = new Proveedores.verProveedores
            {
                MdiParent = this
            };

            fr.Show();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas.ListaDeFacturas fa = new Facturas.ListaDeFacturas();
            fa.MdiParent = this;
            fa.Show();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Facturas.Crear frcrear = new Facturas.Crear();
            frcrear.MdiParent = this;
            frcrear.Show();
        }
        private void hidden()
        {
            try
            {
                var db = new DataADO.Proyecto1Entities();
                var query = db.Seguridad.Where(x => x.IdUsuario == Principal.veloz22.id && x.Modulos.NombreDeModulo == "Facturas").Select(x => new { x.Ver, x.Editar }).FirstOrDefault();

                if (query.Editar == true)
                {
                    facturasToolStripMenuItem1.Visible = true;
                }
                else
                {
                    facturasToolStripMenuItem1.Visible = false;
                }
            }
            catch { }


        }

        private void movimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.AlmacenMovimiento fralmacen = new Almacen.AlmacenMovimiento();
            fralmacen.MdiParent = this;
            fralmacen.Show();          
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.Almacen fralmacen = new Almacen.Almacen();
            fralmacen.MdiParent = this;
            fralmacen.Show();
        }

        /// <summary>
        /// cada 5 minutos mensaje de alerta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrandovencimientodefacturas();
            
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrdenCompra.ListarOrdenCompra listarOrdenCompra = new OrdenCompra.ListarOrdenCompra()
            {
                MdiParent = this
            };
            listarOrdenCompra.Show();
        }

        private void darEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenCompra.OrdenCompra ordenCompra = new OrdenCompra.OrdenCompra()
            {
                MdiParent = this
            };
            ordenCompra.Show();
        }
        private void Agreggated()
        {
            this.WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-Do");

            MdiClient mdiClient;
            foreach(Control ctl in this.Controls)
            {
                try
                {
                    mdiClient = (MdiClient)ctl;
                    mdiClient.BackColor = Color.White;
                }
                catch { }
            }

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        
            olcultando();
            
        }
        private void olcultando() {
            usuarioToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;
            proveedoresToolStripMenuItem.Visible = false;
            productosToolStripMenuItem.Visible = false;
            facturasToolStripMenuItem.Visible = false;
            modulosToolStripMenuItem.Visible = false;
            almacenToolStripMenuItem.Visible = false;
            ordenDeCompraToolStripMenuItem.Visible = false;
            ajustesToolStripMenuItem.Visible = false;
            label1.Visible = false;
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Productos.VerProductos buscarProductos = new Productos.VerProductos
            {
                MdiParent = this
            };

            buscarProductos.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Usuarios.verUsuario usuario = new Usuarios.verUsuario
            {
                MdiParent = this
            };
            usuario.Show();
        }

        private void mantenimientoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Clientes.VerClientes fr = new Clientes.VerClientes();
            fr.MdiParent = this;
            fr.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.FrmCrearModulos fr = new Modulos.FrmCrearModulos
            {
                MdiParent = this
            };
            fr.Show();
        }

        private void agregarYModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.AgsinarYModificar fr = new Modulos.AgsinarYModificar
            {
                MdiParent = this
            };
            fr.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias.frmcategorias fr = new Categorias.frmcategorias();
            fr.MdiParent = this;
            fr.Show();
        }

        private void CambiarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            olcultando();
            Login fr = new Login();
            fr.ShowDialog();

            if (veloz22 != null)
            {
                nombre = veloz22.Nombre;
                contrasenia = veloz22.Contrasenia;
                validacion();

                label1.Visible = true;

                label1.Text = $"Usuario: {veloz22.Nombre}";
            }
            else
            {
                Application.Exit();
            }
            hidden();
        }
    }
}
