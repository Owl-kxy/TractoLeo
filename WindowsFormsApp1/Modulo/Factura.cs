﻿using System;
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
    public partial class Factura : Form
    {
        Conexion con = new Conexion();

        public Factura()
        {
            InitializeComponent();
        }

        public Factura(String idPedido)
        {
            InitializeComponent();
            label1.Text = "Factura N°: " + idPedido;
            label2.Text = idPedido;
        }

        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {
            ClientePedido();
            RellenarGridPedido();
        }

        private void RellenarGridPedido()
        {
            con.conecta();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_RellenarFacturaDatos", con.cadenaSql);
            da.SelectCommand.Parameters.AddWithValue("@idpedido", label2.Text);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.ExecuteNonQuery();

            da.Fill(dt);
            gridDetalleVenta.DataSource = dt;
        }

        private void ClientePedido()
        {
            SqlCommand cmd = new SqlCommand();

            con.conecta();

            cmd.Connection = con.cadenaSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_RellenarFactura";
                        cmd.Parameters.Add("@idpedido", SqlDbType.Int).Value = label2.Text;
            cmd.ExecuteNonQuery();

            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                label3.Text = dr["cliente"].ToString();

                dr.Close();
            }

            con.desconecta();
        }

        private void ImprimirFactura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bpm, 0, 0);
        }

        Bitmap bpm;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bpm = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bpm);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            DialogImprimirFactura.ShowDialog();
        }

        private void DialogImprimirFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
