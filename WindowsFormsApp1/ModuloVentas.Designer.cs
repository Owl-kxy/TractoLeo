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
            this.btnNuevaVenta = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnActualizarVenta = new FontAwesome.Sharp.IconButton();
            this.btnTerminarVenta = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblGetIdCliente = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVerProds)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewVentas
            // 
            this.gridviewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewVentas.Location = new System.Drawing.Point(74, 538);
            this.gridviewVentas.Name = "gridviewVentas";
            this.gridviewVentas.RowHeadersWidth = 51;
            this.gridviewVentas.RowTemplate.Height = 24;
            this.gridviewVentas.Size = new System.Drawing.Size(703, 242);
            this.gridviewVentas.TabIndex = 0;
            this.gridviewVentas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewVentas_CellMouseDoubleClick);
            // 
            // gridViewVerProds
            // 
            this.gridViewVerProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVerProds.Location = new System.Drawing.Point(900, 302);
            this.gridViewVerProds.Name = "gridViewVerProds";
            this.gridViewVerProds.RowHeadersWidth = 51;
            this.gridViewVerProds.RowTemplate.Height = 24;
            this.gridViewVerProds.Size = new System.Drawing.Size(623, 246);
            this.gridViewVerProds.TabIndex = 1;
            this.gridViewVerProds.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewVerProds_CellMouseDoubleClick);
            // 
            // txtProdVenta
            // 
            this.txtProdVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtProdVenta.Location = new System.Drawing.Point(900, 140);
            this.txtProdVenta.Name = "txtProdVenta";
            this.txtProdVenta.Size = new System.Drawing.Size(398, 30);
            this.txtProdVenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(70, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "FACTURA";
            // 
            // txtProductVenta
            // 
            this.txtProductVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtProductVenta.Location = new System.Drawing.Point(192, 259);
            this.txtProductVenta.Name = "txtProductVenta";
            this.txtProductVenta.ReadOnly = true;
            this.txtProductVenta.Size = new System.Drawing.Size(172, 30);
            this.txtProductVenta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(74, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(74, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(156, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "s/.";
            // 
            // txtxPrecioUnitVenta
            // 
            this.txtxPrecioUnitVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxPrecioUnitVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtxPrecioUnitVenta.Location = new System.Drawing.Point(192, 326);
            this.txtxPrecioUnitVenta.Name = "txtxPrecioUnitVenta";
            this.txtxPrecioUnitVenta.Size = new System.Drawing.Size(172, 30);
            this.txtxPrecioUnitVenta.TabIndex = 8;
            // 
            // txtQtyVenta
            // 
            this.txtQtyVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtQtyVenta.Location = new System.Drawing.Point(192, 392);
            this.txtQtyVenta.Name = "txtQtyVenta";
            this.txtQtyVenta.Size = new System.Drawing.Size(172, 30);
            this.txtQtyVenta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(74, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(474, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock";
            // 
            // txtProdVentaStock
            // 
            this.txtProdVentaStock.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdVentaStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtProdVentaStock.Location = new System.Drawing.Point(557, 326);
            this.txtProdVentaStock.Name = "txtProdVentaStock";
            this.txtProdVentaStock.ReadOnly = true;
            this.txtProdVentaStock.Size = new System.Drawing.Size(172, 30);
            this.txtProdVentaStock.TabIndex = 11;
            // 
            // cbxMarcaVenta
            // 
            this.cbxMarcaVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarcaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.cbxMarcaVenta.FormattingEnabled = true;
            this.cbxMarcaVenta.Location = new System.Drawing.Point(900, 240);
            this.cbxMarcaVenta.Name = "cbxMarcaVenta";
            this.cbxMarcaVenta.Size = new System.Drawing.Size(164, 29);
            this.cbxMarcaVenta.TabIndex = 13;
            this.cbxMarcaVenta.SelectedIndexChanged += new System.EventHandler(this.cbxMarcaVenta_SelectedIndexChanged);
            // 
            // cbxSerieVenta
            // 
            this.cbxSerieVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSerieVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.cbxSerieVenta.FormattingEnabled = true;
            this.cbxSerieVenta.Location = new System.Drawing.Point(1134, 240);
            this.cbxSerieVenta.Name = "cbxSerieVenta";
            this.cbxSerieVenta.Size = new System.Drawing.Size(164, 29);
            this.cbxSerieVenta.TabIndex = 14;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnBuscarVenta.Location = new System.Drawing.Point(1374, 129);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(149, 49);
            this.btnBuscarVenta.TabIndex = 15;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label7.Location = new System.Drawing.Point(900, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label8.Location = new System.Drawing.Point(1130, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Serie";
            // 
            // idProdVenta
            // 
            this.idProdVenta.AutoSize = true;
            this.idProdVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProdVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.idProdVenta.Location = new System.Drawing.Point(566, 259);
            this.idProdVenta.Name = "idProdVenta";
            this.idProdVenta.Size = new System.Drawing.Size(0, 22);
            this.idProdVenta.TabIndex = 18;
            // 
            // btnAgregarProds
            // 
            this.btnAgregarProds.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarProds.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAgregarProds.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProds.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProds.IconSize = 16;
            this.btnAgregarProds.Location = new System.Drawing.Point(129, 464);
            this.btnAgregarProds.Name = "btnAgregarProds";
            this.btnAgregarProds.Rotation = 0D;
            this.btnAgregarProds.Size = new System.Drawing.Size(217, 49);
            this.btnAgregarProds.TabIndex = 19;
            this.btnAgregarProds.Text = "Agregar a la venta";
            this.btnAgregarProds.UseVisualStyleBackColor = true;
            this.btnAgregarProds.Click += new System.EventHandler(this.btnAgregarProds_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnNuevaVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNuevaVenta.IconColor = System.Drawing.Color.Black;
            this.btnNuevaVenta.IconSize = 16;
            this.btnNuevaVenta.Location = new System.Drawing.Point(591, 71);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Rotation = 0D;
            this.btnNuevaVenta.Size = new System.Drawing.Size(175, 39);
            this.btnNuevaVenta.TabIndex = 21;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label9.Location = new System.Drawing.Point(184, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "N°";
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnActualizarVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnActualizarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActualizarVenta.IconColor = System.Drawing.Color.Black;
            this.btnActualizarVenta.IconSize = 16;
            this.btnActualizarVenta.Location = new System.Drawing.Point(529, 464);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Rotation = 0D;
            this.btnActualizarVenta.Size = new System.Drawing.Size(200, 49);
            this.btnActualizarVenta.TabIndex = 23;
            this.btnActualizarVenta.Text = "Actualizar Venta";
            this.btnActualizarVenta.UseVisualStyleBackColor = true;
            this.btnActualizarVenta.Click += new System.EventHandler(this.btnActualizarVenta_Click);
            // 
            // btnTerminarVenta
            // 
            this.btnTerminarVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTerminarVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnTerminarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTerminarVenta.IconColor = System.Drawing.Color.Black;
            this.btnTerminarVenta.IconSize = 16;
            this.btnTerminarVenta.Location = new System.Drawing.Point(900, 692);
            this.btnTerminarVenta.Name = "btnTerminarVenta";
            this.btnTerminarVenta.Rotation = 0D;
            this.btnTerminarVenta.Size = new System.Drawing.Size(175, 39);
            this.btnTerminarVenta.TabIndex = 24;
            this.btnTerminarVenta.Text = "Terminar Venta";
            this.btnTerminarVenta.UseVisualStyleBackColor = true;
            this.btnTerminarVenta.Click += new System.EventHandler(this.btnTerminarVenta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1141, 620);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "S/.";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(1180, 620);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(0, 22);
            this.lblTotalPedido.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(900, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "TOTAL DE LA VENTA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label11.Location = new System.Drawing.Point(474, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Codigo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label13.Location = new System.Drawing.Point(897, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "Buscar el producto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label14.Location = new System.Drawing.Point(74, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cliente";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(241, 84);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(12, 17);
            this.lblIdPedido.TabIndex = 34;
            this.lblIdPedido.Text = " ";
            // 
            // cbxCliente
            // 
            this.cbxCliente.BackColor = System.Drawing.Color.White;
            this.cbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbxCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(192, 140);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(537, 30);
            this.cbxCliente.TabIndex = 35;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // lblGetIdCliente
            // 
            this.lblGetIdCliente.AutoSize = true;
            this.lblGetIdCliente.Location = new System.Drawing.Point(199, 186);
            this.lblGetIdCliente.Name = "lblGetIdCliente";
            this.lblGetIdCliente.Size = new System.Drawing.Size(12, 17);
            this.lblGetIdCliente.TabIndex = 36;
            this.lblGetIdCliente.Text = " ";
            this.lblGetIdCliente.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 28);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // ModuloVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 826);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblGetIdCliente);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTerminarVenta);
            this.Controls.Add(this.btnActualizarVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNuevaVenta);
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
        private FontAwesome.Sharp.IconButton btnNuevaVenta;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnActualizarVenta;
        private FontAwesome.Sharp.IconButton btnTerminarVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblGetIdCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}