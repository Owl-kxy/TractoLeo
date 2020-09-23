namespace WindowsFormsApp1.Modulo
{
    partial class ModuloProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaProd = new System.Windows.Forms.TextBox();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.cbxConsulta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerTodoProd = new FontAwesome.Sharp.IconButton();
            this.gridViewProductos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStockProd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSerieProd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarcaProd = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStockAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregaStock = new FontAwesome.Sharp.IconButton();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ImgProducto = new System.Windows.Forms.PictureBox();
            this.btnBuscarImagen = new FontAwesome.Sharp.IconButton();
            this.btnGuardarImg = new FontAwesome.Sharp.IconButton();
            this.txtProdNuevo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioNuevo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStockNuevo = new System.Windows.Forms.TextBox();
            this.cbxMarcaProd = new System.Windows.Forms.ComboBox();
            this.cbxSerieProd = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(37, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 671);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBusquedaProd);
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.cbxConsulta);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnVerTodoProd);
            this.tabPage1.Controls.Add(this.gridViewProductos);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1104, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver lista de productos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label9.Location = new System.Drawing.Point(339, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ingrese el nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(47, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Seleccione la entrada";
            // 
            // txtBusquedaProd
            // 
            this.txtBusquedaProd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtBusquedaProd.Location = new System.Drawing.Point(343, 162);
            this.txtBusquedaProd.Name = "txtBusquedaProd";
            this.txtBusquedaProd.Size = new System.Drawing.Size(300, 28);
            this.txtBusquedaProd.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsultar.IconColor = System.Drawing.Color.Black;
            this.btnConsultar.IconSize = 16;
            this.btnConsultar.Location = new System.Drawing.Point(698, 156);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Rotation = 0D;
            this.btnConsultar.Size = new System.Drawing.Size(157, 40);
            this.btnConsultar.TabIndex = 36;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.FormattingEnabled = true;
            this.cbxConsulta.Location = new System.Drawing.Point(51, 162);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(236, 29);
            this.cbxConsulta.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(47, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Consulte la informacion de sus productos";
            // 
            // btnVerTodoProd
            // 
            this.btnVerTodoProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerTodoProd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodoProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnVerTodoProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerTodoProd.IconColor = System.Drawing.Color.Black;
            this.btnVerTodoProd.IconSize = 16;
            this.btnVerTodoProd.Location = new System.Drawing.Point(898, 155);
            this.btnVerTodoProd.Name = "btnVerTodoProd";
            this.btnVerTodoProd.Rotation = 0D;
            this.btnVerTodoProd.Size = new System.Drawing.Size(157, 40);
            this.btnVerTodoProd.TabIndex = 31;
            this.btnVerTodoProd.Text = "Ver todo";
            this.btnVerTodoProd.UseVisualStyleBackColor = true;
            this.btnVerTodoProd.Click += new System.EventHandler(this.btnVerTodoProd_Click);
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.AllowUserToAddRows = false;
            this.gridViewProductos.AllowUserToDeleteRows = false;
            this.gridViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewProductos.Location = new System.Drawing.Point(40, 253);
            this.gridViewProductos.Name = "gridViewProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridViewProductos.RowTemplate.Height = 24;
            this.gridViewProductos.Size = new System.Drawing.Size(1015, 343);
            this.gridViewProductos.TabIndex = 30;
            this.gridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProductos_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.lblidproducto);
            this.tabPage2.Controls.Add(this.btnAgregaStock);
            this.tabPage2.Controls.Add(this.txtStockAgregar);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblStockProd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblPrecioProd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblSerieProd);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblMarcaProd);
            this.tabPage2.Controls.Add(this.lblNombreProd);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle del producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label8.Location = new System.Drawing.Point(320, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "s/. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(90, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Stock";
            // 
            // lblStockProd
            // 
            this.lblStockProd.AutoSize = true;
            this.lblStockProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblStockProd.Location = new System.Drawing.Point(320, 419);
            this.lblStockProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockProd.Name = "lblStockProd";
            this.lblStockProd.Size = new System.Drawing.Size(0, 23);
            this.lblStockProd.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label7.Location = new System.Drawing.Point(90, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Precio";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblPrecioProd.Location = new System.Drawing.Point(357, 352);
            this.lblPrecioProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(16, 23);
            this.lblPrecioProd.TabIndex = 40;
            this.lblPrecioProd.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(90, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Serie";
            // 
            // lblSerieProd
            // 
            this.lblSerieProd.AutoSize = true;
            this.lblSerieProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerieProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblSerieProd.Location = new System.Drawing.Point(320, 289);
            this.lblSerieProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerieProd.Name = "lblSerieProd";
            this.lblSerieProd.Size = new System.Drawing.Size(16, 23);
            this.lblSerieProd.TabIndex = 38;
            this.lblSerieProd.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(90, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Marca:";
            // 
            // lblMarcaProd
            // 
            this.lblMarcaProd.AutoSize = true;
            this.lblMarcaProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblMarcaProd.Location = new System.Drawing.Point(320, 227);
            this.lblMarcaProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaProd.Name = "lblMarcaProd";
            this.lblMarcaProd.Size = new System.Drawing.Size(16, 23);
            this.lblMarcaProd.TabIndex = 36;
            this.lblMarcaProd.Text = " ";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblNombreProd.Location = new System.Drawing.Point(228, 164);
            this.lblNombreProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(16, 23);
            this.lblNombreProd.TabIndex = 35;
            this.lblNombreProd.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(702, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 292);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(414, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Informacion del producto";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.cbxSerieProd);
            this.tabPage3.Controls.Add(this.cbxMarcaProd);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtStockNuevo);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtPrecioNuevo);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtProdNuevo);
            this.tabPage3.Controls.Add(this.btnGuardarImg);
            this.tabPage3.Controls.Add(this.btnBuscarImagen);
            this.tabPage3.Controls.Add(this.ImgProducto);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1104, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label12.Location = new System.Drawing.Point(49, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Ingresar nuevo producto";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label19.Location = new System.Drawing.Point(698, 482);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 23);
            this.label19.TabIndex = 45;
            this.label19.Text = "Agregar stock";
            // 
            // txtStockAgregar
            // 
            this.txtStockAgregar.Location = new System.Drawing.Point(870, 481);
            this.txtStockAgregar.MaxLength = 4;
            this.txtStockAgregar.Name = "txtStockAgregar";
            this.txtStockAgregar.Size = new System.Drawing.Size(132, 28);
            this.txtStockAgregar.TabIndex = 46;
            // 
            // btnAgregaStock
            // 
            this.btnAgregaStock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregaStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregaStock.IconColor = System.Drawing.Color.Black;
            this.btnAgregaStock.IconSize = 16;
            this.btnAgregaStock.Location = new System.Drawing.Point(785, 536);
            this.btnAgregaStock.Name = "btnAgregaStock";
            this.btnAgregaStock.Rotation = 0D;
            this.btnAgregaStock.Size = new System.Drawing.Size(146, 46);
            this.btnAgregaStock.TabIndex = 47;
            this.btnAgregaStock.Text = "Agregar";
            this.btnAgregaStock.UseVisualStyleBackColor = true;
            this.btnAgregaStock.Click += new System.EventHandler(this.btnAgregaStock_Click);
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Location = new System.Drawing.Point(939, 56);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(0, 21);
            this.lblidproducto.TabIndex = 48;
            this.lblidproducto.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label20.Location = new System.Drawing.Point(90, 164);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 23);
            this.label20.TabIndex = 49;
            this.label20.Text = "Producto >>";
            // 
            // ImgProducto
            // 
            this.ImgProducto.Location = new System.Drawing.Point(789, 136);
            this.ImgProducto.Name = "ImgProducto";
            this.ImgProducto.Size = new System.Drawing.Size(230, 243);
            this.ImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgProducto.TabIndex = 57;
            this.ImgProducto.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscarImagen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarImagen.IconColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.IconSize = 16;
            this.btnBuscarImagen.Location = new System.Drawing.Point(826, 417);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Rotation = 0D;
            this.btnBuscarImagen.Size = new System.Drawing.Size(157, 46);
            this.btnBuscarImagen.TabIndex = 58;
            this.btnBuscarImagen.Text = "Browse";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // btnGuardarImg
            // 
            this.btnGuardarImg.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarImg.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarImg.IconColor = System.Drawing.Color.Black;
            this.btnGuardarImg.IconSize = 16;
            this.btnGuardarImg.Location = new System.Drawing.Point(385, 492);
            this.btnGuardarImg.Name = "btnGuardarImg";
            this.btnGuardarImg.Rotation = 0D;
            this.btnGuardarImg.Size = new System.Drawing.Size(112, 46);
            this.btnGuardarImg.TabIndex = 59;
            this.btnGuardarImg.Text = "Save";
            this.btnGuardarImg.UseVisualStyleBackColor = true;
            this.btnGuardarImg.Click += new System.EventHandler(this.btnGuardarImg_Click);
            // 
            // txtProdNuevo
            // 
            this.txtProdNuevo.Location = new System.Drawing.Point(280, 168);
            this.txtProdNuevo.Name = "txtProdNuevo";
            this.txtProdNuevo.Size = new System.Drawing.Size(100, 28);
            this.txtProdNuevo.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label10.Location = new System.Drawing.Point(49, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 61;
            this.label10.Text = "Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label11.Location = new System.Drawing.Point(49, 295);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 23);
            this.label11.TabIndex = 63;
            this.label11.Text = "Precio";
            // 
            // txtPrecioNuevo
            // 
            this.txtPrecioNuevo.Location = new System.Drawing.Point(280, 295);
            this.txtPrecioNuevo.Name = "txtPrecioNuevo";
            this.txtPrecioNuevo.Size = new System.Drawing.Size(182, 28);
            this.txtPrecioNuevo.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label13.Location = new System.Drawing.Point(49, 383);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 23);
            this.label13.TabIndex = 65;
            this.label13.Text = "Stock";
            // 
            // txtStockNuevo
            // 
            this.txtStockNuevo.Location = new System.Drawing.Point(280, 383);
            this.txtStockNuevo.Name = "txtStockNuevo";
            this.txtStockNuevo.Size = new System.Drawing.Size(182, 28);
            this.txtStockNuevo.TabIndex = 64;
            // 
            // cbxMarcaProd
            // 
            this.cbxMarcaProd.FormattingEnabled = true;
            this.cbxMarcaProd.Location = new System.Drawing.Point(280, 221);
            this.cbxMarcaProd.Name = "cbxMarcaProd";
            this.cbxMarcaProd.Size = new System.Drawing.Size(182, 29);
            this.cbxMarcaProd.TabIndex = 66;
            this.cbxMarcaProd.SelectedIndexChanged += new System.EventHandler(this.cbxMarcaProd_SelectedIndexChanged);
            // 
            // cbxSerieProd
            // 
            this.cbxSerieProd.FormattingEnabled = true;
            this.cbxSerieProd.Location = new System.Drawing.Point(574, 221);
            this.cbxSerieProd.Name = "cbxSerieProd";
            this.cbxSerieProd.Size = new System.Drawing.Size(179, 29);
            this.cbxSerieProd.TabIndex = 67;
            // 
            // ModuloProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1226, 753);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Name = "ModuloProductos";
            this.Text = "ModuloProductos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBusquedaProd;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnVerTodoProd;
        private System.Windows.Forms.DataGridView gridViewProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStockProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSerieProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarcaProd;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbxConsulta;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnAgregaStock;
        private System.Windows.Forms.TextBox txtStockAgregar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconButton btnBuscarImagen;
        private System.Windows.Forms.PictureBox ImgProducto;
        private FontAwesome.Sharp.IconButton btnGuardarImg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStockNuevo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProdNuevo;
        private System.Windows.Forms.ComboBox cbxMarcaProd;
        private System.Windows.Forms.ComboBox cbxSerieProd;
    }
}