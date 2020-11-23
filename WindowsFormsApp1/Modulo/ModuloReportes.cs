using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Modulo
{
    public partial class ModuloReportes : Form
    {
        public ModuloReportes()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<SP_ReporteClientes_Result> list = sPReporteClientesResultBindingSource.DataSource as List<SP_ReporteClientes_Result>;
            if (list!=null)
            {
                using (ImprimirClientes fic = new ImprimirClientes(list))
                {
                    fic.ShowDialog();
                }
            }
        }

        private void btnPedidosReport_Click(object sender, EventArgs e)
        {
            List<SP_ReportePedidos_Result> listpedidos = sPReportePedidosResultBindingSource.DataSource as List<SP_ReportePedidos_Result>;
            if (listpedidos !=null)
            {
                using (RepPedidos frp = new RepPedidos(listpedidos))
                { 
                    frp.ShowDialog(); 
                }
                    
            }
        }

        private void btnProductosReporte_Click(object sender, EventArgs e)
        {
            List<SP_ReporteProductos_Result> list = sPReporteProductosResultBindingSource.DataSource as List<SP_ReporteProductos_Result>;
            if (list != null)
            {
                using (RepProductos form = new RepProductos(list))
                {
                    form.ShowDialog();
                }
            }
        }

        private void btnClientesReporte_Click(object sender, EventArgs e)
        {
            List<SP_ReporteClientes_Result> listClientes = sPReporteClientesResultBindingSource.DataSource as List<SP_ReporteClientes_Result>;
            if (listClientes != null)
            {
                using (RepClientes formCli = new RepClientes(listClientes))
                {
                    formCli.ShowDialog();
                }
            }
        }


        private void ModuloReportes_Load(object sender, EventArgs e)
        {
            using (ReportClientesEntities db = new ReportClientesEntities())
                sPReporteClientesResultBindingSource.DataSource = db.SP_ReporteClientes().ToList();

            using (ProductosEntities dprod = new ProductosEntities())
                sPReporteProductosResultBindingSource.DataSource = dprod.SP_ReporteProductos().ToList();

            using (ReportClientesEntities dcli = new ReportClientesEntities())
                sPReporteClientesResultBindingSource.DataSource = dcli.SP_ReporteClientes().ToList();

            using (PedidosEntities dped = new PedidosEntities())
                sPReportePedidosResultBindingSource.DataSource = dped.SP_ReportePedidos().ToList();
            this.reportViewer1.RefreshReport();
        }

        private void btnCargarReportexFecha_Click(object sender, EventArgs e)
        {
            using (PxFEntities fechaPed = new PxFEntities())
            {
                double x = -1;

                SP_ReportePedidosxFecha_ResultBindingSource.DataSource = fechaPed.SP_ReportePedidosxFecha(dpFechaIni.Value, dpFechaFin.Value).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] parametros = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("FechaIni",dpFechaIni.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("FechaFin",dpFechaFin.Value.Date.ToShortDateString())
                };

                reportViewer1.LocalReport.SetParameters(parametros);
                reportViewer1.RefreshReport();
            }
        }
    }
}
