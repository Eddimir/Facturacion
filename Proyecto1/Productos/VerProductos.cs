using Proyecto1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Productos
{
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db;
        public bool Buscando;
        public int Id;
        //private DataTable productos;
        //private bool buton;
        private void VerProductos_Load(object sender, EventArgs e)
        {
            //productos = new DataTable();
           db = new DataADO.Proyecto1Entities();
            RefreshGrid();
            CenterToScreen();
            AutoAjuste();
            Botones();
        }
        //private DataRow row = null;

        private void RefreshGrid()
        {
            var query = from d in db.Productos
                        select new
                        {
                            d.Id,
                            d.Codigo,
                            d.Producto,
                            d.Precio,
                            d.ITBS,
                            Existencia = d.Cantidad_Existencia
                        };

            dtgvVer.DataSource = query.OrderBy(x => x.Producto).ToList();

            label1.Text = "Total de Registros:" + dtgvVer.Rows.Count.ToString();

            //foreach (var item in query.AsEnumerable())
            //{
            //    productos = new DataTable();
            //    productos.Columns.Add("Prueba",GetType(String));

            //    productos.Rows.Add(item.Id, item.Codigo, item.Producto, item.Precio, item.ITBS, item.Existencia);
            //}


        }
        private void AutoAjuste()
        {
            dtgvVer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvVer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtgvVer.MultiSelect = true;
            dtgvVer.AllowUserToOrderColumns = false;
            dtgvVer.AllowUserToDeleteRows = false;
            dtgvVer.BackgroundColor = Color.White;
            dtgvVer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtgvVer.Columns[1].ReadOnly = true;
            dtgvVer.Columns[2].ReadOnly = true;
            dtgvVer.Columns[3].ReadOnly = true;
            dtgvVer.Columns[4].ReadOnly = true;
            dtgvVer.Columns[0].Visible = false;

            avisarvencimiento();
        }
        

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

            //var quey = from pro in productos.AsEnumerable()
            //           where pro.Field<string>("Codigo").Contains(txtbusqueda.Text) || pro.Field<string>("Producto").Contains(txtbusqueda.Text)
            //           select new
            //           {
            //               Id = pro.Field<int>("Id"),
            //               Codigo = pro.Field<string>("Codigo"),
            //               Producto = pro.Field<string>("Producto"),
            //               Precio = pro.Field<decimal>("Precio"),
            //               Descripcion = pro.Field<string>("Descripcion"),
            //               Existencia = pro.Field<decimal>("Cantidad_Existencia")
            //           };
            var query = from d in db.Productos
                        where d.Producto.Contains(txtbusqueda.Text) || d.Codigo.Contains(txtbusqueda.Text)
                        select new
                        {
                            d.Id,
                            d.Codigo,
                            d.Producto,
                            d.Precio,
                            d.ITBS,
                            Existencia = d.Cantidad_Existencia
                        };

            dtgvVer.DataSource = query.OrderBy(x => x.Producto).ToList();
        }

        private Productos frpro = new Productos();
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            if (Buscando)
            {
                Id = (int)dtgvVer.CurrentRow.Cells[0].Value;
                Close();
            }
            else
            {
                frpro.lblId.Text = dtgvVer.CurrentRow.Cells[0].Value.ToString();
                frpro.ShowDialog();
            }
            RefreshGrid();

        }
        private void ReadOnly()
        {
            dtgvVer.Columns[0].ReadOnly = true;
            dtgvVer.Columns[1].ReadOnly = true;
            dtgvVer.Columns[2].ReadOnly = true;
            dtgvVer.Columns[3].ReadOnly = true;
            dtgvVer.Columns[4].ReadOnly = true;
            dtgvVer.Columns[5].ReadOnly = true;
        }
        //habilitar controles
        //private void Habilitar(bool valor)
        //{
        //    txtCategoriaBuscar.ReadOnly = !valor;//negacion
        //    txtdescricion.ReadOnly = !valor;
        //}
        //habilitar botones
        public void Botones()
        {
            var db = new DataADO.Proyecto1Entities();
            var query = db.Seguridad.Where(x => x.IdUsuario == Principal.veloz22.id && x.Modulos.NombreDeModulo == "Productos").Select(x => new { x.Ver, x.Editar }).FirstOrDefault();

            if(query.Editar == true)
            {
                btnNuevo.Enabled = true;
                btnSelecionar.Enabled = true;
            }
            else
            {
                btnNuevo.Enabled = false;
                btnSelecionar.Enabled = false;
            }
        }
        private void productosss()
        {

        }

        private List<string> ProductoDiaDeVencimiento;
        private List<string> ProductosFaltandoDiasParaVencimiento;
  
        private void avisarvencimiento()
        {
            string Verificacion, cantidad, result, result2;
            bool banderin = false, banderin2 = false; 
            
            var vencimiento = from pro in db.Productos
                              select pro;

            int count = 0;
            //TimeSpan TotalDiasEntreFechas;
            foreach(var item in vencimiento)
            {
                int? dias = (item.DiasParaAvisar == null)? 0 : item.DiasParaAvisar;
                var fecha = Convert.ToDateTime(item.FechaVencimiento);

                TimeSpan TotalDiasEntreFechas = fecha.Subtract(DateTime.Today); /*DateTime.Today.Subtract(fecha);*/
                //TimeSpan DiasParavencer = 

                //var totaldias = fecha.AddDays(Convert.ToDouble(dias));                
                //var fecha1 = totaldias.ToString("dd/MM/yyyy");
                //var fecha2 = DateTime.Today.ToString("dd/MM/yyyy");

                if (fecha.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy"))
                {
                    //MessageBox.Show($"El producto: {item.Producto}, de codigo: {item.Codigo} esta vencido");
                    count++;
                    ProductoDiaDeVencimiento = new List<string>();
                    ProductoDiaDeVencimiento.Add(item.Producto);
                    banderin = true;
                    //codigos.Add(item.Codigo);
                } 
                else if(TotalDiasEntreFechas.Days <= dias && TotalDiasEntreFechas.Days > dias)
                {
                    count++;
                    ProductosFaltandoDiasParaVencimiento = new List<string>();
                    ProductosFaltandoDiasParaVencimiento.Add(item.Producto);
                    banderin2 = true;
                }
            }

            if (count >= 1)
            {

                if (banderin == true)
                {
                    result = Funciones.ToString(ProductoDiaDeVencimiento);
                    Verificacion = (count == 1 && count != 0) ? "El producto:" : "Los productos:";
                    cantidad = (count == 1 && count != 0) ? " esta vencido." : " estan vencidos.";
                    MessageBox.Show($"{Verificacion} {result}{cantidad}");
                }
                else if(banderin2 == true)
                {

                    result2 = Funciones.ToString(ProductosFaltandoDiasParaVencimiento);
                    Verificacion = (count == 1 && count != 0) ? "El producto:" : "Los productos:";
                    cantidad = (count == 1 && count != 0) ? " esta proximos a vencer." : " estan proximos a vencer.";
                    MessageBox.Show($"{Verificacion} {result2}{cantidad}");
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Limpiar();
            productos.ShowDialog();
            RefreshGrid();
        }
    }   
}
