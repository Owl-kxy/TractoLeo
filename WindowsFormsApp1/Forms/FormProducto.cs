using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormProducto : Form
    {
        Conexion con = new Conexion();

        public FormProducto()
        {
            InitializeComponent();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            VerProductos();
        }

        private void VerProductos()
        {
            con.conecta();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("VerTodosProductos", con.cadenaSql);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            DataGridProductos.DataSource = dt;

            con.desconecta();
        }
    }
}
