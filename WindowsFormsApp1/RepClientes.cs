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
    public partial class RepClientes : Form
    {
        List<SP_ReporteClientes_Result> listClientes;

        public RepClientes(List<SP_ReporteClientes_Result> listClientes)
        {
            InitializeComponent();
            this.listClientes = listClientes;
        }

        private void RepClientes_Load(object sender, EventArgs e)
        {
            SP_ReporteClientes_ResultBindingSource.DataSource = listClientes;
            this.reportViewer1.RefreshReport();
        }

        private void SP_ReporteClientes_ResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
