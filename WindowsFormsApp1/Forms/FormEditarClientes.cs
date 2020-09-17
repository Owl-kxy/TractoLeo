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
    public partial class FormEditarClientes : Form
    {
        Conexion con = new Conexion();

        public FormEditarClientes()
        {
            InitializeComponent();
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            buscarxDNI();
        }

        private void btnBuscarRUC_Click(object sender, EventArgs e)
        {
            buscarxRUC();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            MessageBox.Show("Datos actualizados con exito");
        }

        private void buscarxDNI()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarxDNI", con.cadenaSql);
            con.conecta();

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, (8)).Value = txtBuscarDNI.Text;
            da.SelectCommand.ExecuteNonQuery();
            SqlDataReader dr = da.SelectCommand.ExecuteReader();

            if (dr.Read() == true)
            {
                txtNombreCliente.Text = dr["nombre_cliente"].ToString();
                txtApellidoPaterno.Text = dr["ape_paterno_cliente"].ToString();
                txtApellidoMaterno.Text = dr["ape_materno_cliente"].ToString();
                txtTelefono.Text = dr["telefono_cliente"].ToString();
                txtCorreo.Text = dr["correo_cliente"].ToString();
                txtDireccion.Text = dr["direccion_cliente"].ToString();
                lblid.Text = dr["id_cliente"].ToString();
            }

            con.desconecta();
        }

        private void buscarxRUC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarxRUC", con.cadenaSql);
            con.conecta();

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ruc", SqlDbType.VarChar, (11)).Value = txtBuscarRUC.Text;
            da.SelectCommand.ExecuteNonQuery();
            SqlDataReader dr = da.SelectCommand.ExecuteReader();

            if (dr.Read() == true)
            {
                txtNombreCliente.Text = dr["nombre_cliente"].ToString();
                txtApellidoPaterno.Text = dr["ape_paterno_cliente"].ToString();
                txtApellidoMaterno.Text = dr["ape_materno_cliente"].ToString();
                txtTelefono.Text = dr["telefono_cliente"].ToString();
                txtCorreo.Text = dr["correo_cliente"].ToString();
                txtDireccion.Text = dr["direccion_cliente"].ToString();
                lblid.Text = dr["id_cliente"].ToString();
            }

            con.desconecta();
        }

        private void ActualizarDatos()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarCliente";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = lblid.Text;
            cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar, (50)).Value = txtNombreCliente.Text;
            cmd.Parameters.Add("@apePaterno_cliente", SqlDbType.VarChar, (50)).Value = txtApellidoPaterno.Text;
            cmd.Parameters.Add("@apeMaterno_cliente", SqlDbType.VarChar, (50)).Value = txtApellidoMaterno.Text;
            cmd.Parameters.Add("@telf_cliente", SqlDbType.VarChar, (50)).Value = txtTelefono.Text;
            cmd.Parameters.Add("@correo_cliente", SqlDbType.VarChar, (70)).Value = txtCorreo.Text;
            cmd.Parameters.Add("@direccion_cliente", SqlDbType.VarChar, (100)).Value = txtDireccion.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }
    }
}
