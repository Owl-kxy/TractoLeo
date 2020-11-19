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
    public partial class FacturaVenta : Form
    {
        public FacturaVenta()
        {
            InitializeComponent();
        }

        public FacturaVenta(String idPedido)
        {
            label1.Text = "el id del pedido es: " + idPedido;
        }
    }
}
