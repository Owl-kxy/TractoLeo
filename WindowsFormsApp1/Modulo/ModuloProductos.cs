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

namespace WindowsFormsApp1.Modulo
{
    public partial class ModuloProductos : Form
    {
        Conexion con = new Conexion();

        public ModuloProductos()
        {
            InitializeComponent();
            cbxConsulta.Items.Add("Marca");
            cbxConsulta.Items.Add("Serie");
            cbxConsulta.Items.Add("Nombre");
        }

        private void btnVerTodoProd_Click(object sender, EventArgs e)
        {
            RellenarProductos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbxConsulta.SelectedIndex == -1)
                MessageBox.Show("Seleccione una de las opciones");
            else
            {
                string val_seleccionado = cbxConsulta.SelectedItem.ToString();

                if (val_seleccionado == "Marca")
                    BusquedaMarca();

                if (val_seleccionado == "Serie")
                    BusquedaSerie();

                if (val_seleccionado == "Nombre")
                    BusquedaNombre();
            }

        }

        private void gridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombreProd.Text = gridViewProductos.CurrentRow.Cells[1].Value.ToString();
            lblMarcaProd.Text = gridViewProductos.CurrentRow.Cells[2].Value.ToString();
            lblSerieProd.Text = gridViewProductos.CurrentRow.Cells[3].Value.ToString();
            lblPrecioProd.Text = gridViewProductos.CurrentRow.Cells[5].Value.ToString();
            lblStockProd.Text = gridViewProductos.CurrentRow.Cells[4].Value.ToString();
        }

        private void RellenarProductos()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_VerListaProductos", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewProductos.DataSource = dt;

            con.desconecta();
        }

        private void BusquedaMarca()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BusquedaMarca", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@marca", SqlDbType.VarChar, (50)).Value =txtBusquedaProd.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewProductos.DataSource = dt;

            con.desconecta();
        }

        private void BusquedaSerie()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BusquedaSerie", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@serie", SqlDbType.VarChar, (50)).Value = txtBusquedaProd.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewProductos.DataSource = dt;

            con.desconecta();
        }

        private void BusquedaNombre()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BusquedaNombreProducto", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nombreprod", SqlDbType.VarChar, (50)).Value = txtBusquedaProd.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewProductos.DataSource = dt;

            con.desconecta();
        }
    }
}
