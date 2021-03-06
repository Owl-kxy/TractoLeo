﻿using System;
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

namespace WindowsFormsApp1.Modulo
{
    public partial class ModuloClientes : Form
    {
        Conexion con = new Conexion();

        public ModuloClientes()
        {
            InitializeComponent();
            VerClientes();
            RellenarCbxConsulta();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear_Cliente();
            MessageBox.Show("Cliente agregado");
            Limpiar_Campos();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {

            if (cbxConsultaClientes.SelectedIndex == -1)
                MessageBox.Show("Seleccione una opcion");
            else
            {
                string valorseleccionado = cbxConsultaClientes.SelectedItem.ToString();

                if (valorseleccionado == "DNI")
                    BusquedaClientesDNI();

                if (valorseleccionado == "RUC")
                    BusquedaClientesRUC();

                if (valorseleccionado == "Nombre")
                    BusquedaClientesNombre();
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            VerClientes();
        }

        private void btnActualizarInformacion_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            MessageBox.Show("Datos actualizados con exito");
            Limpiar_CamposEdit();

        }

        private void gridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdcli.Text = gridViewClientes.CurrentRow.Cells[0].Value.ToString();
            txtEditNombre.Text = gridViewClientes.CurrentRow.Cells[1].Value.ToString();
            txtEditPaterno.Text = gridViewClientes.CurrentRow.Cells[2].Value.ToString();
            txtEditMaterno.Text = gridViewClientes.CurrentRow.Cells[3].Value.ToString();
            txtEditTelf.Text = gridViewClientes.CurrentRow.Cells[4].Value.ToString();
            txtEditCorreo.Text = gridViewClientes.CurrentRow.Cells[5].Value.ToString();
            txtEditDireccion.Text = gridViewClientes.CurrentRow.Cells[6].Value.ToString();
            txtEditDNI.Text = gridViewClientes.CurrentRow.Cells[7].Value.ToString();
            txtEditRUC.Text = gridViewClientes.CurrentRow.Cells[8].Value.ToString();
            txtEditCiudad.Text = gridViewClientes.CurrentRow.Cells[9].Value.ToString();
        }

        private void Crear_Cliente()
        {
            SqlCommand cmd = new SqlCommand();

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
            cmd.Parameters.Add("@dni_cliente", SqlDbType.VarChar, (8)).Value = txtDNI.Text;
            cmd.Parameters.Add("@ruc_cliente", SqlDbType.VarChar, (11)).Value = txtRUC.Text;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar, (100)).Value = txtCiudad.Text;

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
            txtDNI.Text = string.Empty;
            txtRUC.Text = string.Empty;
            txtCiudad.Text = string.Empty;
        }

        private void Limpiar_CamposEdit()
        {
            txtEditNombre.Text = string.Empty;
            txtEditPaterno.Text = string.Empty;
            txtEditMaterno.Text = string.Empty;
            txtEditTelf.Text = string.Empty;
            txtEditCorreo.Text = string.Empty;
            txtEditDireccion.Text = string.Empty;
            txtEditDNI.Text = string.Empty;
            txtEditRUC.Text = string.Empty;
            txtEditCiudad.Text = string.Empty;
        }

        private void VerClientes()
        {
            con.conecta();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_VerTodosClientes", con.cadenaSql);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewClientes.DataSource = dt;

            con.desconecta();
        }

        private void BusquedaClientesDNI()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarxDNI", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, (8)).Value = txtBusquedaClientes.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewClientes.DataSource = dt;

            con.desconecta();
        }

        private void BusquedaClientesRUC()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarxRUC", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ruc", SqlDbType.VarChar, (11)).Value = txtBusquedaClientes.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewClientes.DataSource = dt;

            con.desconecta();
        }

        private void BusquedaClientesNombre()
        {
            con.conecta();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarxNombre", con.cadenaSql);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nombre_cliente", SqlDbType.VarChar, (100)).Value = txtBusquedaClientes.Text;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridViewClientes.DataSource = dt;

            con.desconecta();
        }


        private void ActualizarDatos()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ActualizarCliente";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = lblIdcli.Text;
            cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar, (50)).Value = txtEditNombre.Text;
            cmd.Parameters.Add("@apePaterno_cliente", SqlDbType.VarChar, (50)).Value = txtEditPaterno.Text;
            cmd.Parameters.Add("@apeMaterno_cliente", SqlDbType.VarChar, (50)).Value = txtEditMaterno.Text;
            cmd.Parameters.Add("@telf_cliente", SqlDbType.VarChar, (50)).Value = txtEditTelf.Text;
            cmd.Parameters.Add("@correo_cliente", SqlDbType.VarChar, (70)).Value = txtEditCorreo.Text;
            cmd.Parameters.Add("@direccion_cliente", SqlDbType.VarChar, (100)).Value = txtEditDireccion.Text;
            cmd.Parameters.Add("@dni_cliente", SqlDbType.VarChar, (8)).Value = txtEditDNI.Text;
            cmd.Parameters.Add("@ruc_cliente", SqlDbType.VarChar, (11)).Value = txtEditRUC.Text;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar, (11)).Value = txtEditCiudad.Text;

            cmd.ExecuteNonQuery();

            con.desconecta();
        }

        public void RellenarCbxConsulta()
        {
            cbxConsultaClientes.Items.Add("DNI");
            cbxConsultaClientes.Items.Add("RUC");
            cbxConsultaClientes.Items.Add("Nombre");
        }
    }
}
