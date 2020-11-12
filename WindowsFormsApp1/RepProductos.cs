using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RepProductos : Form
    {
        List<SP_ReporteProductos_Result> list;

        public RepProductos(List<SP_ReporteProductos_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void RepProductos_Load(object sender, EventArgs e)
        {
            SP_ReporteProductos_ResultBindingSource.DataSource = list;
            this.reportViewer1.RefreshReport();
        }
    }
}
