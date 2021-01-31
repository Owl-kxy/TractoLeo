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
using System.Drawing.Imaging;

namespace WindowsFormsApp1.Modulo
{
    public partial class ModuloProductos : Form
    {
        Conexion con = new Conexion();
        string route = "";
        int idmarca;
        int idmarca2;
        int idserie;
        int asociacion;

        public ModuloProductos()
        {
            InitializeComponent();
            RellenarCbxConsulta();
            RellenarcbxMarcaProd();
            RellenarcbxMarcaProdCreado();
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

                if (val_seleccionado == "Codigo")
                    BusquedaCodigo();
            }

        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png| jpg files(*.jpg)|*.jpg| All files (*.*)|*.*";
            
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                route = dialog.FileName.ToString();
                ImgProducto.ImageLocation = route;
            }
        }

        private void btnGuardarImg_Click(object sender, EventArgs e)
        {
            byte[] images = null;

            FileStream stream = new FileStream(route, FileMode.Open, FileAccess.Read);
            BinaryReader binreader = new BinaryReader(stream);
            images = binreader.ReadBytes((int)stream.Length);

            bool eval2 = Int32.TryParse(cbxSerieProd.SelectedValue.ToString(), out idserie);
            bool eval1 = Int32.TryParse(cbxMarcaProd.SelectedValue.ToString(), out idmarca2);

            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertarProducto";
            cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = idmarca2;
            cmd.Parameters.Add("@id_serie", SqlDbType.Int).Value = idserie;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar, (100)).Value=txtCodProdNuevo.Text;
            cmd.Parameters.Add("@descripcion",SqlDbType.VarChar,(100)).Value=txtDescripProdNuevo.Text;
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = images;
            cmd.Parameters.Add("@nombre_prod", SqlDbType.VarChar, (100)).Value = txtProdNuevo.Text;
            cmd.Parameters.Add("@stock_prod", SqlDbType.VarChar, (100)).Value = txtStockNuevo.Text;
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar, (100)).Value = txtUbicacionNuevo.Text;
            cmd.Parameters.Add(new SqlParameter("@precio_prod", SqlDbType.Decimal) {Precision=18, Scale=2 }).Value= txtPrecioNuevo.Text;
            cmd.Parameters.Add(new SqlParameter("@precioreal", SqlDbType.Decimal) { Precision = 18, Scale = 2 }).Value = txtPrecioRealNuevo.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
            MessageBox.Show("Cambios guardados");
        }

        private void btnAgregaStock_Click(object sender, EventArgs e)
        {
            ActualizarStock();
            txtStockAgregar.Text = string.Empty;
        }

        private void gridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            byte[] imgData = (byte[])gridViewProductos.CurrentRow.Cells[7].Value;

            MemoryStream ms = new MemoryStream(imgData);
            imgProductoSelec.Image = Image.FromStream(ms);

            lblidproducto.Text = gridViewProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombreProductoEdit.Text = gridViewProductos.CurrentRow.Cells[1].Value.ToString();
            txtMarcaEdit.Text = gridViewProductos.CurrentRow.Cells[2].Value.ToString();
            txtSerieEdit.Text = gridViewProductos.CurrentRow.Cells[3].Value.ToString();
            txtStockEdit.Text = gridViewProductos.CurrentRow.Cells[4].Value.ToString();
            txtPrecioEdit.Text = gridViewProductos.CurrentRow.Cells[6].Value.ToString();
            txtDescripcionEdit.Text = gridViewProductos.CurrentRow.Cells[8].Value.ToString();
            txtCodigoEdit.Text = gridViewProductos.CurrentRow.Cells[5].Value.ToString();
            txtUbicacionEdit.Text = gridViewProductos.CurrentRow.Cells[9].Value.ToString();
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

            gridViewProductos.Columns["imagen"].Visible = false;
            gridViewProductos.Columns["Id"].Visible = false;
            gridViewProductos.Columns["PrecReal"].Visible = false;

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

            gridViewProductos.Columns["imagen"].Visible = false;
            gridViewProductos.Columns["Id"].Visible = false;
            gridViewProductos.Columns["PrecReal"].Visible = false;

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

            gridViewProductos.Columns["imagen"].Visible = false;
            gridViewProductos.Columns["Id"].Visible = false;
            gridViewProductos.Columns["PrecReal"].Visible = false;

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

            gridViewProductos.Columns["imagen"].Visible = false;
            gridViewProductos.Columns["Id"].Visible = false;
            gridViewProductos.Columns["PrecReal"].Visible = false;

            con.desconecta();
        }

        private void BusquedaCodigo()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BusquedaCodigoProducto", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@codigoprod", SqlDbType.VarChar, (50)).Value = txtBusquedaProd.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewProductos.DataSource = dt;

            gridViewProductos.Columns["imagen"].Visible = false;
            gridViewProductos.Columns["Id"].Visible = false;
            gridViewProductos.Columns["PrecReal"].Visible = false;

            con.desconecta();
        }

        private void ActualizarStock()
        {

            if(String.IsNullOrEmpty(lblidproducto.Text))
                MessageBox.Show("No ha seleccionado ningun producto");

            else
            {
                if (String.IsNullOrEmpty(txtStockAgregar.Text))
                    MessageBox.Show("Ingrese una cantidad");

                else
                {
                    int stock_actual = Convert.ToInt32(txtStockEdit.Text);
                    int stock_agregar = Convert.ToInt32(txtStockAgregar.Text);
                    int nuevo_stock = stock_actual + stock_agregar;

                    con.conecta();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = con.cadenaSql;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ActualizarStock";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = lblidproducto.Text;
                    cmd.Parameters.Add("@nuevostock",SqlDbType.Int).Value=nuevo_stock;

                    cmd.ExecuteNonQuery();

                    con.desconecta();
                }

            }
        }

        private void RellenarCbxConsulta()
        {
            cbxConsulta.Items.Add("Marca");
            cbxConsulta.Items.Add("Serie");
            cbxConsulta.Items.Add("Nombre");
            cbxConsulta.Items.Add("Codigo");
        }

        private void RellenarcbxMarcaProd()
        {
            try
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

                cbxMarcaProd.DataSource = dt;
                cbxMarcaProd.DisplayMember = "nombre_marca";
                cbxMarcaProd.ValueMember = "id_marca";
            }

            catch
            {
                MessageBox.Show("Los datos no pueden ser cargados porque no hay conexion a internet");
            }
        }

        private void RellenarcbxMarcaProdCreado()
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

            cbxMarcaProdCreado.DataSource = dt;
            cbxMarcaProdCreado.DisplayMember = "nombre_marca";
            cbxMarcaProdCreado.ValueMember = "id_marca";
        }

        private void cbxMarcaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool conversion= Int32.TryParse(cbxMarcaProd.SelectedValue.ToString(),out idmarca);
            RellenarcbxSerieProd(idmarca);

        }

        private void RellenarcbxSerieProd(int idmarca)
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

            cbxSerieProd.DataSource = dt;
            cbxSerieProd.DisplayMember = "nombre_serie";
            cbxSerieProd.ValueMember = "id_serie";
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CrearMarca";
            cmd.Parameters.Add("@nombre_marca", SqlDbType.VarChar, (50)).Value =  txtMarcaCrear.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();

            MessageBox.Show("Marca creada con exito");
        }

        private void btnGuardarSerie_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CrearSerie";

            bool eval3 = Int32.TryParse(cbxMarcaProdCreado.SelectedValue.ToString(), out asociacion);

            cmd.Parameters.Add("@nombre_serie", SqlDbType.VarChar, (50)).Value = txtSerieCrear.Text;
            cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = asociacion;

            cmd.ExecuteNonQuery();

            con.desconecta();

            MessageBox.Show("Serie creada con exito");
        }

        private void btnEditarProds_Click(object sender, EventArgs e)
        {
            txtNombreProductoEdit.ReadOnly = false;
            txtPrecioEdit.ReadOnly = false;
            txtCodigoEdit.ReadOnly = false;
            txtDescripcionEdit.ReadOnly = false;
            txtUbicacionEdit.ReadOnly = false;
            txtPrecioRealEdit.ReadOnly = false;
        }

        private void btnActualizarProds_Click(object sender, EventArgs e)
        {
            EditarInformacionProductos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreProductoEdit.Text = string.Empty;
            txtPrecioEdit.Text = string.Empty;
            txtCodigoEdit.Text = string.Empty;
            txtDescripcionEdit.Text = string.Empty;
            txtMarcaEdit.Text = string.Empty;
            txtSerieEdit.Text = string.Empty;
            txtStockEdit.Text = string.Empty;
            txtStockNuevo.Text = string.Empty;
        }

        private void EditarInformacionProductos()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarDatosProducto";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = lblidproducto.Text;
            cmd.Parameters.Add("@nomprod", SqlDbType.VarChar, (100)).Value = txtNombreProductoEdit.Text;
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar, (100)).Value = txtCodigoEdit.Text;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, (100)).Value = txtDescripcionEdit.Text;
            cmd.Parameters.Add(new SqlParameter("@precio", SqlDbType.Decimal) { Precision = 18, Scale = 2 }).Value = txtPrecioEdit.Text;
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar, (100)).Value = txtUbicacionEdit.Text;
            cmd.Parameters.Add(new SqlParameter("@precioreal", SqlDbType.Decimal) { Precision = 18, Scale = 2 }).Value = txtPrecioRealEdit.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();

            MessageBox.Show("Informacion editada");
        }

        private void EliminarInformacionProductos()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EliminarProducto";

            cmd.Parameters.Add("@idprod", SqlDbType.Int).Value = lblidproducto.Text;
            cmd.ExecuteNonQuery();
            con.desconecta();

            MessageBox.Show("Producto eliminado");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            EliminarInformacionProductos();
        }

        private void rbtnVer_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecioRealEdit.Text = gridViewProductos.CurrentRow.Cells[10].Value.ToString();
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecioRealEdit.Text = "";
        }
    }
}
