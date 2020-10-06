using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1.Modulo
{
    public partial class ModuloVentas : Form
    {
        Conexion con = new Conexion();
        int idmarca;
        int idserie;
        int idmarca2;

        public ModuloVentas()
        {
            InitializeComponent();
            RellenarcbxMarcaVenta();
        }

        private void RellenarcbxMarcaVenta()
        {
            con.conecta();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_RellenarCbxMarca";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.desconecta();

            cbxMarcaVenta.DataSource = dt;
            cbxMarcaVenta.DisplayMember = "nombre_marca";
            cbxMarcaVenta.ValueMember = "id_marca";
        }

        private void cbxMarcaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool conversion = Int32.TryParse(cbxMarcaVenta.SelectedValue.ToString(), out idmarca);
            RellenarcbxSerieVenta(idmarca);
        }

        private void RellenarcbxSerieVenta(int idmarca)
        {
            con.conecta();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_RellenarCbxSerie";
            cmd.Parameters.AddWithValue("@idmarca", idmarca);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            con.desconecta();

            cbxSerieVenta.DataSource = dt;
            cbxSerieVenta.DisplayMember = "nombre_serie";
            cbxSerieVenta.ValueMember = "id_serie";
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            bool eval2 = Int32.TryParse(cbxSerieVenta.SelectedValue.ToString(), out idserie);
            bool eval1 = Int32.TryParse(cbxMarcaVenta.SelectedValue.ToString(), out idmarca2);

            con.conecta();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarxMarcaxSerie", con.cadenaSql);

            da.SelectCommand.Parameters.AddWithValue("@idmarca", idmarca2);
            da.SelectCommand.Parameters.AddWithValue("@idserie", idserie);
            da.SelectCommand.Parameters.AddWithValue("@nombre", txtProdVenta.Text);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewVerProds.DataSource = dt;

            con.desconecta();
            MessageBox.Show("Cambios guardados");
        }
    }
}
