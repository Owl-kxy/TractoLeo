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
            cmd.Parameters.Add(new SqlParameter("@precio_prod", SqlDbType.Decimal) {Precision=18, Scale=2 }).Value= txtPrecioNuevo.Text;

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
            lblidproducto.Text = gridViewProductos.CurrentRow.Cells[0].Value.ToString();
            lblNombreProd.Text = gridViewProductos.CurrentRow.Cells[1].Value.ToString();
            lblMarcaProd.Text = gridViewProductos.CurrentRow.Cells[2].Value.ToString();
            lblSerieProd.Text = gridViewProductos.CurrentRow.Cells[3].Value.ToString();
            lblStockProd.Text = gridViewProductos.CurrentRow.Cells[4].Value.ToString();
            lblPrecioProd.Text = gridViewProductos.CurrentRow.Cells[6].Value.ToString();

            byte[] imgData = (byte[])gridViewProductos.CurrentRow.Cells[7].Value;

            MemoryStream ms = new MemoryStream(imgData);
            imgProductoSelec.Image = Image.FromStream(ms);

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
                    int stock_actual = Convert.ToInt32(lblStockProd.Text);
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
        }

        private void RellenarcbxMarcaProd()
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
    }
}
