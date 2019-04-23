using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Clases
{
    class ReportesPuntoVenta
    {
        public static void Facturacion(int? id)
        {
            try
            {
                using (var db = new DataADO.Proyecto1Entities())
                {
                    var configuracion = db.ConfiguracionEmpresa.ToList();

                    var facturacion = db.Facturacion
                                        .Where(x => x.Id == id)
                                        .FirstOrDefault();

                    var usuario = db.Usuarios.ToList();


                    Reportes.ReportesGenerales reportesGenerales = new Reportes.ReportesGenerales();

                    //reportesGenerales.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    //string ruta = Application.StartupPath.ToString() + @"\Reportes\ReporteFacturacion.rdlc";
                    //reportesGenerales.reportViewer1.LocalReport.ReportPath = ruta;

                    //reportesGenerales.reportViewer1.LocalReport.DataSources.Clear();
                    //reportesGenerales.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Facturacion", facturacion));
                    //reportesGenerales.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Configuraciones", configuracion));
                    //reportesGenerales.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Usuarios", usuario));
                    //reportesGenerales.reportViewer1.Refresh();

                    reportesGenerales.MdiParent = Principal.FrmReferencia.MdiParent;
                    reportesGenerales.Show();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
