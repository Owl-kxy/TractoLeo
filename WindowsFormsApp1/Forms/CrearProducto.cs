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
                cbSeries.Enabled = true;

                con.conecta();

                string parametro = cbMarca.SelectedValue.ToString();
                int parametronum;
                Int32.TryParse(parametro, out parametronum);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("CargarSerie", con.cadenaSql);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@id_marca", SqlDbType.Int).Value = parametronum;
                da.SelectCommand.ExecuteNonQuery();

                da.Fill(dt);

                con.desconecta();

                cbSeries.DataSource = dt;
                cbSeries.DisplayMember = "nombre_serie";
                cbSeries.ValueMember = "id_serie";
            }
        }
    }
}
