namespace WindowsFormsApp1.Modulo
{
    partial class ModuloVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridviewVentas = new System.Windows.Forms.DataGridView();
            this.gridViewVerProds = new System.Windows.Forms.DataGridView();
            this.txtProdVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxPrecioUnitVenta = new System.Windows.Forms.TextBox();
            this.txtQtyVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdVentaStock = new System.Windows.Forms.TextBox();
            this.cbxMarcaVenta = new System.Windows.Forms.ComboBox();
            this.cbxSerieVenta = new System.Windows.Forms.ComboBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idProdVenta = new System.Windows.Forms.Label();
            this.btnAgregarProds = new FontAwesome.Sharp.IconButton();
            this.lblIdPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVerProds)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewVentas
            // 
            this.gridviewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewVentas.Location = new System.Drawing.Point(75, 380);
            this.gridviewVentas.Name = "gridviewVentas";
            this.gridviewVentas.RowHeadersWidth = 51;
            this.gridviewVentas.RowTemplate.Height = 24;
            this.gridviewVentas.Size = new System.Drawing.Size(703, 242);
            this.gridviewVentas.TabIndex = 0;
            // 
            // gridViewVerProds
            // 
            this.gridViewVerProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVerProds.Location = new System.Drawing.Point(933, 244);
            this.gridViewVerProds.Name = "gridViewVerProds";
            this.gridViewVerProds.RowHeadersWidth = 51;
            this.gridViewVerProds.RowTemplate.Height = 24;
            this.gridViewVerProds.Size = new System.Drawing.Size(749, 246);
            this.gridViewVerProds.TabIndex = 1;
            this.gridViewVerProds.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewVerProds_CellMouseDoubleClick);
            // 
            // txtProdVenta
            // 
            this.txtProdVenta.Location = new System.Drawing.Point(933, 82);
            this.txtProdVenta.Name = "txtProdVenta";
            this.txtProdVenta.Size = new System.Drawing.Size(293, 22);
            this.txtProdVenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "factura";
            // 
            // txtProductVenta
            // 
            this.txtProductVenta.Location = new System.Drawing.Point(152, 211);
            this.txtProductVenta.Name = "txtProductVenta";
            this.txtProductVenta.ReadOnly = true;
            this.txtProductVenta.Size = new System.Drawing.Size(126, 22);
            this.txtProductVenta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "s/.";
            // 
            // txtxPrecioUnitVenta
            // 
            this.txtxPrecioUnitVenta.Location = new System.Drawing.Point(178, 263);
            this.txtxPrecioUnitVenta.Name = "txtxPrecioUnitVenta";
            this.txtxPrecioUnitVenta.ReadOnly = true;
            this.txtxPrecioUnitVenta.Size = new System.Drawing.Size(100, 22);
            this.txtxPrecioUnitVenta.TabIndex = 8;
            // 
            // txtQtyVenta
            // 
            this.txtQtyVenta.Location = new System.Drawing.Point(178, 314);
            this.txtQtyVenta.Name = "txtQtyVenta";
            this.txtQtyVenta.Size = new System.Drawing.Size(100, 22);
            this.txtQtyVenta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "stock";
            // 
            // txtProdVentaStock
            // 
            this.txtProdVentaStock.Location = new System.Drawing.Point(477, 265);
            this.txtProdVentaStock.Name = "txtProdVentaStock";
            this.txtProdVentaStock.ReadOnly = true;
            this.txtProdVentaStock.Size = new System.Drawing.Size(100, 22);
            this.txtProdVentaStock.TabIndex = 11;
            // 
            // cbxMarcaVenta
            // 
            this.cbxMarcaVenta.FormattingEnabled = true;
            this.cbxMarcaVenta.Location = new System.Drawing.Point(933, 160);
            this.cbxMarcaVenta.Name = "cbxMarcaVenta";
            this.cbxMarcaVenta.Size = new System.Drawing.Size(121, 24);
            this.cbxMarcaVenta.TabIndex = 13;
            this.cbxMarcaVenta.SelectedIndexChanged += new System.EventHandler(this.cbxMarcaVenta_SelectedIndexChanged);
            // 
            // cbxSerieVenta
            // 
            this.cbxSerieVenta.FormattingEnabled = true;
            this.cbxSerieVenta.Location = new System.Drawing.Point(1105, 160);
            this.cbxSerieVenta.Name = "cbxSerieVenta";
            this.cbxSerieVenta.Size = new System.Drawing.Size(121, 24);
            this.cbxSerieVenta.TabIndex = 14;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(1251, 78);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(86, 30);
            this.btnBuscarVenta.TabIndex = 15;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(933, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1102, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "serie";
            // 
            // idProdVenta
            // 
            this.idProdVenta.AutoSize = true;
            this.idProdVenta.Location = new System.Drawing.Point(380, 215);
            this.idProdVenta.Name = "idProdVenta";
            this.idProdVenta.Size = new System.Drawing.Size(56, 17);
            this.idProdVenta.TabIndex = 18;
            this.idProdVenta.Text = "idVenta";
            // 
            // btnAgregarProds
            // 
            this.btnAgregarProds.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarProds.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProds.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProds.IconSize = 16;
            this.btnAgregarProds.Location = new System.Drawing.Point(628, 306);
            this.btnAgregarProds.Name = "btnAgregarProds";
            this.btnAgregarProds.Rotation = 0D;
            this.btnAgregarProds.Size = new System.Drawing.Size(150, 39);
            this.btnAgregarProds.TabIndex = 19;
            this.btnAgregarProds.Text = "Agregar a la venta";
            this.btnAgregarProds.UseVisualStyleBackColor = true;
            this.btnAgregarProds.Click += new System.EventHandler(this.btnAgregarProds_Click);
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(405, 137);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(16, 17);
            this.lblIdPedido.TabIndex = 20;
            this.lblIdPedido.Text = "5";
            // 
            // ModuloVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 826);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.btnAgregarProds);
            this.Controls.Add(this.idProdVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.cbxSerieVenta);
            this.Controls.Add(this.cbxMarcaVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProdVentaStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtyVenta);
            this.Controls.Add(this.txtxPrecioUnitVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdVenta);
            this.Controls.Add(this.gridViewVerProds);
            this.Controls.Add(this.gridviewVentas);
            this.Name = "ModuloVentas";
            this.Text = "ModuloVentas";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVerProds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewVentas;
        private System.Windows.Forms.DataGridView gridViewVerProds;
        private System.Windows.Forms.TextBox txtProdVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxPrecioUnitVenta;
        private System.Windows.Forms.TextBox txtQtyVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProdVentaStock;
        private System.Windows.Forms.ComboBox cbxMarcaVenta;
        private System.Windows.Forms.ComboBox cbxSerieVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idProdVenta;
        private FontAwesome.Sharp.IconButton btnAgregarProds;
        private System.Windows.Forms.Label lblIdPedido;
    }
}