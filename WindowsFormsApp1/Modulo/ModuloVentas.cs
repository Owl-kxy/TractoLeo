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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


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
            AutocompletarCbxCliente();
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
            if (cbxSerieVenta.SelectedIndex != -1 && cbxMarcaVenta.SelectedIndex != -1)
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

                gridViewVerProds.Columns["Stock"].Visible = false;
            }

            if (string.IsNullOrEmpty(txtProdVenta.Text) == false)
            {
                con.conecta();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SP_BuscarProductoVender", con.cadenaSql);

                da.SelectCommand.Parameters.AddWithValue("@nombre", txtProdVenta.Text);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.ExecuteNonQuery();

                da.Fill(dt);
                gridViewVerProds.DataSource = dt;

                con.desconecta();
                gridViewVerProds.Columns["Stock"].Visible = false;
            }
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

                if (cantventa <= stockactual && cantventa > 0)
                {
                    AgregarProdsCompra();
                    AgregarDetalle();
                }

                else
                {
                    if (cantventa > stockactual)
                        MessageBox.Show("La cantidad no puede exceder el stock actual, ingrese otra cantidad");

                    if (cantventa <= 0)
                        MessageBox.Show("No puede ingresar una cantidad menor o igual a cero");
                }

            }

        }

        private void ValidarCantidadActualizada()
        {
            int cantventa;
            int stockactual;

            if (string.IsNullOrEmpty(txtQtyVenta.Text))
                MessageBox.Show("Ingrese la cantidad a vender");

            else
            {
                cantventa = Convert.ToInt32(txtQtyVenta.Text);
                stockactual = Convert.ToInt32(txtProdVentaStock.Text);

                if (cantventa <= stockactual && cantventa > 0)
                {
                    CambiarCantidadVenta();
                    ActualizarRegDetallePedido();
                }

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
            int pedido;
            int productoid;

            pedido = Convert.ToInt32(lblIdPedido.Text);
            productoid = Convert.ToInt32(idProdVenta.Text);
            preciounitario = Convert.ToDecimal(txtxPrecioUnitVenta.Text);
            cantidadventa = Convert.ToInt32(txtQtyVenta.Text);


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
            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void AgregarDetalle()
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
            cmd.CommandText = "SP_IngresarDetalleLog";
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = pedido;
            cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = productoid;
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

        private void gridviewVentas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idProdVenta.Text = gridviewVentas.CurrentRow.Cells[0].Value.ToString();
            txtProductVenta.Text = gridviewVentas.CurrentRow.Cells[1].Value.ToString();
            txtQtyVenta.Text = gridviewVentas.CurrentRow.Cells[2].Value.ToString();
            txtxPrecioUnitVenta.Text = gridviewVentas.CurrentRow.Cells[3].Value.ToString();
            txtProdVentaStock.Text = gridviewVentas.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            ValidarCantidadActualizada();
            VerVenta();
        }

        private void CambiarCantidadVenta()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarCantVentaDetalleLog";
            cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = idProdVenta.Text;
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = lblIdPedido.Text;
            cmd.Parameters.Add("@cantnueva", SqlDbType.Int).Value = txtQtyVenta.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void ActualizarRegDetallePedido()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarCantVenta";
            cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = idProdVenta.Text;
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = lblIdPedido.Text;
            cmd.Parameters.Add("@cantnueva", SqlDbType.Int).Value = txtQtyVenta.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            AperturaVenta();
            VerNumeroPedido();
        }

        private void AperturaVenta()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CrearPedido";
            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void VerNumeroPedido()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VerNumeroPedido";
            cmd.ExecuteNonQuery();

            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                lblIdPedido.Text = dr["id_pedido"].ToString();

                dr.Close();
            }

            con.desconecta();
        }

        private void btnTerminarVenta_Click(object sender, EventArgs e)
        {
            if (lblIdPedido.Text == "")
                MessageBox.Show("Antes de terminar cree una venta por favor");

            else
            {
                VerTotalPedido();
                ActualizarStockPostVenta();
                InformacionPedido();
                InformacionLogs();

                String idPedido = lblIdPedido.Text;
                String preciototal = lblTotalPedido.Text;

                RepFactura rpf = new RepFactura(idPedido,preciototal);
                rpf.Show();
            }
        }

        private void InformacionLogs()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarInformacionLogs";
            cmd.Parameters.Add("@idped", SqlDbType.Int).Value = lblIdPedido.Text;
            cmd.Parameters.Add("@idcli", SqlDbType.Int).Value = lblGetIdCliente.Text;
            cmd.Parameters.Add("@nomcli", SqlDbType.VarChar, (100)).Value = cbxCliente.Text;
            cmd.Parameters.Add(new SqlParameter("@prectotal", SqlDbType.Decimal) { Precision = 18, Scale = 2 }).Value = lblTotalPedido.Text;
            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void InformacionPedido()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarInformacionPedido";
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = lblIdPedido.Text;
            cmd.Parameters.Add("@idcliente", SqlDbType.Int).Value = lblGetIdCliente.Text;
            cmd.Parameters.Add("@nomcliente", SqlDbType.VarChar, (100)).Value = cbxCliente.Text;           
            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void VerTotalPedido()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_VentalTotalPedido";
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = lblIdPedido.Text;
            cmd.ExecuteNonQuery();

            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                lblTotalPedido.Text = dr["VentaTotal"].ToString();

                dr.Close();
            }

            con.desconecta();
        }

        private void ActualizarStockPostVenta()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarStockVenta";
            cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = lblIdPedido.Text;
            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void AutocompletarCbxCliente()
        {
            SqlCommand cmd = new SqlCommand("SP_AutocompletarNombreCliente", con.cadenaSql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            cbxCliente.DataSource = dt;
            cbxCliente.DisplayMember = "NombreCompleto";
            cbxCliente.ValueMember = "id_cliente";

            // Seccion de autocompletado
            AutoCompleteStringCollection listaClientes = new AutoCompleteStringCollection();

            foreach(DataRow dr in dt.Rows)
                listaClientes.Add(Convert.ToString(dr["NombreCompleto"]));

            cbxCliente.AutoCompleteCustomSource = listaClientes;
            cbxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        
        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGetIdCliente.Text = cbxCliente.SelectedValue.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
