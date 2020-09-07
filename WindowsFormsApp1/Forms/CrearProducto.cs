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
using System.Configuration;

namespace WindowsFormsApp1.Forms
{

    public partial class CrearProducto : Form
    {
        Conexion con = new Conexion();

        public CrearProducto()
        {
            InitializeComponent();
            RellenarMarca();

            cbSeries.Enabled = false;
        }

        public void RellenarMarca()
        {
            con.conecta();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("RellenarMarca", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
             
            con.desconecta();

            cbMarca.DataSource = dt;
            cbMarca.DisplayMember = "nombre_marca";
            cbMarca.ValueMember = "id_marca";
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedValue.ToString() != null)
            {
                con.conecta();

                DataTable dt = new DataTable();
                DataRow dr = dt.NewRow();

                string SP = "SELECT nombre_serie " +
                            "FROM Tbl_Series AS series " +
                            "INNER JOIN " +
                                "Tbl_Marca AS marca ON " +
                                    "series.id_marca = marca.id_marca " +
                            "WHERE marca.id_marca = @idmarca";
                SqlCommand cmd = new SqlCommand(SP, con.cadenaSql);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //SqlDataAdapter da = new SqlDataAdapter("RellenaSerie", con.cadenaSql);
                //da.SelectCommand.Parameters.AddWithValue("@id_marca",cbMarca.SelectedValue.ToString());
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.Fill(dt);

                con.desconecta();

                cbSeries.DataSource = dt;
                cbSeries.DisplayMember = "nombre_serie";
                cbSeries.ValueMember = "id_serie";
            }
        }
    }
}
