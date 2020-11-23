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
    public partial class RepPedidos : Form
    {
        List<SP_ReportePedidos_Result> listpedidos;
        
        public RepPedidos(List<SP_ReportePedidos_Result> listpedidos)
        {
            InitializeComponent();
            this.listpedidos = listpedidos;
        }

        private void RepPedidos_Load(object sender, EventArgs e)
        {
            SP_ReportePedidos_ResultBindingSource.DataSource = listpedidos;
            this.reportViewer1.RefreshReport();
        }
    }
}
