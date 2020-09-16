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
    public partial class FormClientes : Form
    {
        Conexion con = new Conexion();

        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear_Cliente();
            MessageBox.Show("Cliente agregado");
            Limpiar_Campos();
        }

        private void Crear_Cliente()
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_InsertarCliente";
            cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar, (50)).Value = txtNombreCliente.Text;
            cmd.Parameters.Add("@apePaterno_cliente", SqlDbType.VarChar, (50)).Value = txtApellidoPaterno.Text;
            cmd.Parameters.Add("@apeMaterno_cliente", SqlDbType.VarChar, (50)).Value = txtApellidoMaterno.Text;
            cmd.Parameters.Add("@telf_cliente", SqlDbType.VarChar, (50)).Value = txtTelefono.Text;
            cmd.Parameters.Add("@correo_cliente", SqlDbType.VarChar, (70)).Value = txtCorreo.Text;
            cmd.Parameters.Add("@direccion_cliente", SqlDbType.VarChar, (100)).Value = txtDireccion.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        private void Limpiar_Campos()
        {
            txtNombreCliente.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }
    }
}
