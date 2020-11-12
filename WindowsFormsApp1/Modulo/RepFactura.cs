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
    public partial class RepFactura : Form
    {
        Conexion con = new Conexion();

        public RepFactura()
        {
            InitializeComponent();
        }

        public RepFactura(String idPedido)
        {
            InitializeComponent();
            label1.Text = idPedido;
        }

        private void RepFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(label1.Text);

            using (FacturaEntiti fdb = new FacturaEntiti())
            {
                SP_ReporteFactura_ResultBindingSource.DataSource = fdb.SP_ReporteFactura(codigo).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("idpedido",label1.Text)
                };

                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }
        }
    }
}
