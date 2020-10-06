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
        }

        private void gridViewVerProds_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            idProdVenta.Text = gridViewVerProds.CurrentRow.Cells[0].Value.ToString();
            txtProductVenta.Text = gridViewVerProds.CurrentRow.Cells[1].Value.ToString();
            txtProdVentaStock.Text = gridViewVerProds.CurrentRow.Cells[2].Value.ToString();
            txtxPrecioUnitVenta.Text = gridViewVerProds.CurrentRow.Cells[3].Value.ToString();
        }

        private void ValidarCantidad()
        {
            int cantventa;
            int stockactual;

            if (string.IsNullOrEmpty(txtQtyVenta.Text))
                MessageBox.Show("Ingrese la cantidad a vender");

            else 
            {
                cantventa = Convert.ToInt32(txtQtyVenta.Text);
                stockactual = Convert.ToInt32(txtProdVentaStock.Text);

                if (cantventa <= stockactual && cantventa>0)
                    AgregarProdsCompra();

                else
                {
                    if (cantventa > stockactual)
                        MessageBox.Show("La cantidad no puede exceder el stock actual, ingrese otra cantidad");

                    if (cantventa <= 0)
                        MessageBox.Show("No puede ingresar una cantidad menor o igual a cero");
                }
                    
            }

        }

        private void AgregarProdsCompra()
        {

            decimal preciounitario;
            int cantidadventa;
            decimal preciosubtotal;
            int pedido;
            int productoid;

            pedido = Convert.ToInt32(lblIdPedido.Text);
            productoid = Convert.ToInt32(idProdVenta.Text);
            preciounitario = Convert.ToDecimal(txtxPrecioUnitVenta.Text);
            cantidadventa = Convert.ToInt32(txtQtyVenta.Text);

            preciosubtotal = preciounitario * cantidadventa;

            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_IngresarDetallePedido";
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = pedido;
            cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = productoid;
            cmd.Parameters.Add("@nombreproducto", SqlDbType.VarChar, (100)).Value = txtProductVenta.Text;
            cmd.Parameters.Add("@cantidadventa", SqlDbType.Int).Value = cantidadventa;
            cmd.Parameters.Add(new SqlParameter("@preciounit", SqlDbType.Decimal) { Precision = 18, Scale = 2 }).Value = txtxPrecioUnitVenta.Text;
            cmd.Parameters.Add(new SqlParameter("@preciosubtotal", SqlDbType.Decimal) { Precision = 18, Scale = 2 }).Value = preciosubtotal;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void VerVenta()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_VerVenta", con.cadenaSql);
            da.SelectCommand.Parameters.AddWithValue("@idpedido", lblIdPedido.Text);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridviewVentas.DataSource = dt;

            con.desconecta();
        }

        private void btnAgregarProds_Click(object sender, EventArgs e)
        {
            ValidarCantidad();
            VerVenta();
        }
    }
}
