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
    public partial class FormIngresarProducto : Form
    {
        Conexion con = new Conexion();

        public FormIngresarProducto()
        {
            InitializeComponent();
            Cargar_CbxMarca();
            cbxSerieProducto.Enabled = false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Crear_Marca();
        }

        private void btnAgregarSerie_Click(object sender, EventArgs e)
        {
            Crear_Serie();
        }

        private void cbxMarcaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string parametro = cbxMarcaProducto.SelectedValue.ToString();

            if (parametro != null)
            {
                cbxSerieProducto.Enabled = true;

                con.conecta();
                int parametronum;
                Int32.TryParse(parametro, out parametronum);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SP_CargarSerie", con.cadenaSql);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("@id_marca", SqlDbType.Int).Value = parametronum;
                da.SelectCommand.ExecuteNonQuery();

                da.Fill(dt);

                con.desconecta();

                cbxSerieProducto.DataSource = dt;
                cbxSerieProducto.DisplayMember = "nombre_serie";
                cbxSerieProducto.ValueMember = "id_serie";
            }

            else
            {
                //cbxSerieProducto.Enabled = false;
            }
        }

        private void Crear_Marca()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CrearMarca";
            cmd.Parameters.Add("@nombre_marca", SqlDbType.VarChar, (50)).Value = txtNombreMarca.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void Crear_Serie()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CrearSerie";
            cmd.Parameters.Add("@nombre_serie", SqlDbType.VarChar, (50)).Value = txtNombreSerie.Text;
            cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = cbxMarcaSerie.SelectedValue;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void Cargar_CbxMarca()
        {
            con.conecta();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SP_CargarMarca", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            con.desconecta();

            cbxMarcaProducto.DataSource = dt;
            cbxMarcaProducto.DisplayMember = "nombre_marca";
            cbxMarcaProducto.ValueMember = "id_marca";
        }
    }
}
