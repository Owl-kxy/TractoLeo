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

        private void ModuloReportes_Load(object sender, EventArgs e)
        {
            using (ReportClientesEntities db = new ReportClientesEntities())
                sPReporteClientesResultBindingSource.DataSource = db.SP_ReporteClientes().ToList();
        }
    }
}
