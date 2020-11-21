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
    public partial class RepFacturaInfo : Form
    {
        Conexion con = new Conexion();

        public RepFacturaInfo()
        {
            InitializeComponent();
        }

        public RepFacturaInfo(String idPedidoF)
        {
            InitializeComponent();
            label1.Text = idPedidoF;
        }

        private void RepFacturaInfo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnFacturaCompleta_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label1.Text);

            using (FacturaInfoEntities fcdb = new FacturaInfoEntities())
            {
                SP_FacturaCompleta_ResultBindingSource.DataSource = fcdb.SP_FacturaCompleta(id).ToList();

                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("idped",label1.Text),
                };

                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }
        }
    }
}
