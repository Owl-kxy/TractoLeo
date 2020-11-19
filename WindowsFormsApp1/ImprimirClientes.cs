using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modulo;

namespace WindowsFormsApp1
{
    public partial class ImprimirClientes : Form
    {
        List<SP_ReporteClientes_Result> list;

        public ImprimirClientes(List<SP_ReporteClientes_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void ImprimirClientes_Load(object sender, EventArgs e)
        {
            ClientesReport1.SetDataSource(list);
            crystalReportViewer1.Refresh();
        }
    }
}
