namespace WindowsFormsApp1.Modulo
{
    partial class ModuloReportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPReporteClientesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProductosReporte = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombredelproductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPReporteProductosResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombremarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreserieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadventaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciototalpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPReportePedidosResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPedidosReport = new FontAwesome.Sharp.IconButton();
            this.cachedClientesReport1 = new WindowsFormsApp1.CachedClientesReport();
            this.sPReporteFacturaResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnCargarReportexFecha = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_ReportePedidosxFecha_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteClientesResultBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteProductosResultBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReportePedidosResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteFacturaResultBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ReportePedidosxFecha_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 683);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte de clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 643);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1009, 508);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientesDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPReporteClientesResultBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(53, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 451);
            this.dataGridView1.TabIndex = 2;
            // 
            // clientesDataGridViewTextBoxColumn
            // 
            this.clientesDataGridViewTextBoxColumn.DataPropertyName = "Clientes";
            this.clientesDataGridViewTextBoxColumn.HeaderText = "Clientes";
            this.clientesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientesDataGridViewTextBoxColumn.Name = "clientesDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // sPReporteClientesResultBindingSource
            // 
            this.sPReporteClientesResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReporteClientes_Result);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnImprimir, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 517);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1009, 123);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconSize = 16;
            this.btnImprimir.Location = new System.Drawing.Point(405, 44);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Rotation = 0D;
            this.btnImprimir.Size = new System.Drawing.Size(195, 34);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&Imprimir reporte";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1021, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte de productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1021, 649);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnProductosReporte, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 522);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1015, 124);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnProductosReporte
            // 
            this.btnProductosReporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductosReporte.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductosReporte.IconColor = System.Drawing.Color.Black;
            this.btnProductosReporte.IconSize = 16;
            this.btnProductosReporte.Location = new System.Drawing.Point(409, 44);
            this.btnProductosReporte.Name = "btnProductosReporte";
            this.btnProductosReporte.Rotation = 0D;
            this.btnProductosReporte.Size = new System.Drawing.Size(197, 35);
            this.btnProductosReporte.TabIndex = 0;
            this.btnProductosReporte.Text = "&Imprimir reporte";
            this.btnProductosReporte.UseVisualStyleBackColor = true;
            this.btnProductosReporte.Click += new System.EventHandler(this.btnProductosReporte_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridView3, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1015, 513);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelproductoDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn1,
            this.serieDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.sPReporteProductosResultBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(53, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(907, 455);
            this.dataGridView3.TabIndex = 1;
            // 
            // nombredelproductoDataGridViewTextBoxColumn1
            // 
            this.nombredelproductoDataGridViewTextBoxColumn1.DataPropertyName = "Nombre_del_producto";
            this.nombredelproductoDataGridViewTextBoxColumn1.HeaderText = "Nombre_del_producto";
            this.nombredelproductoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombredelproductoDataGridViewTextBoxColumn1.Name = "nombredelproductoDataGridViewTextBoxColumn1";
            // 
            // marcaDataGridViewTextBoxColumn1
            // 
            this.marcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn1.Name = "marcaDataGridViewTextBoxColumn1";
            // 
            // serieDataGridViewTextBoxColumn1
            // 
            this.serieDataGridViewTextBoxColumn1.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn1.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn1.Name = "serieDataGridViewTextBoxColumn1";
            // 
            // stockDataGridViewTextBoxColumn1
            // 
            this.stockDataGridViewTextBoxColumn1.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn1.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn1.Name = "stockDataGridViewTextBoxColumn1";
            // 
            // sPReporteProductosResultBindingSource
            // 
            this.sPReporteProductosResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReporteProductos_Result);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnPedidosReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1021, 649);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "ReportePedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpedidoDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.fechapedidoDataGridViewTextBoxColumn,
            this.nombremarcaDataGridViewTextBoxColumn,
            this.nombreserieDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.cantidadventaproductoDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.preciototalpedidoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sPReportePedidosResultBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(31, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(923, 461);
            this.dataGridView2.TabIndex = 1;
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            this.idpedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechapedidoDataGridViewTextBoxColumn
            // 
            this.fechapedidoDataGridViewTextBoxColumn.DataPropertyName = "fecha_pedido";
            this.fechapedidoDataGridViewTextBoxColumn.HeaderText = "fecha_pedido";
            this.fechapedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechapedidoDataGridViewTextBoxColumn.Name = "fechapedidoDataGridViewTextBoxColumn";
            this.fechapedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombremarcaDataGridViewTextBoxColumn
            // 
            this.nombremarcaDataGridViewTextBoxColumn.DataPropertyName = "nombre_marca";
            this.nombremarcaDataGridViewTextBoxColumn.HeaderText = "nombre_marca";
            this.nombremarcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombremarcaDataGridViewTextBoxColumn.Name = "nombremarcaDataGridViewTextBoxColumn";
            this.nombremarcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreserieDataGridViewTextBoxColumn
            // 
            this.nombreserieDataGridViewTextBoxColumn.DataPropertyName = "nombre_serie";
            this.nombreserieDataGridViewTextBoxColumn.HeaderText = "nombre_serie";
            this.nombreserieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreserieDataGridViewTextBoxColumn.Name = "nombreserieDataGridViewTextBoxColumn";
            this.nombreserieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            this.nombreproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadventaproductoDataGridViewTextBoxColumn
            // 
            this.cantidadventaproductoDataGridViewTextBoxColumn.DataPropertyName = "cantidad_venta_producto";
            this.cantidadventaproductoDataGridViewTextBoxColumn.HeaderText = "cantidad_venta_producto";
            this.cantidadventaproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadventaproductoDataGridViewTextBoxColumn.Name = "cantidadventaproductoDataGridViewTextBoxColumn";
            this.cantidadventaproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            this.precioproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // preciototalpedidoDataGridViewTextBoxColumn
            // 
            this.preciototalpedidoDataGridViewTextBoxColumn.DataPropertyName = "precio_total_pedido";
            this.preciototalpedidoDataGridViewTextBoxColumn.HeaderText = "precio_total_pedido";
            this.preciototalpedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciototalpedidoDataGridViewTextBoxColumn.Name = "preciototalpedidoDataGridViewTextBoxColumn";
            this.preciototalpedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPReportePedidosResultBindingSource
            // 
            this.sPReportePedidosResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReportePedidos_Result);
            // 
            // btnPedidosReport
            // 
            this.btnPedidosReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPedidosReport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPedidosReport.IconColor = System.Drawing.Color.Black;
            this.btnPedidosReport.IconSize = 16;
            this.btnPedidosReport.Location = new System.Drawing.Point(366, 547);
            this.btnPedidosReport.Name = "btnPedidosReport";
            this.btnPedidosReport.Rotation = 0D;
            this.btnPedidosReport.Size = new System.Drawing.Size(267, 39);
            this.btnPedidosReport.TabIndex = 0;
            this.btnPedidosReport.Text = "Ver Pedidos";
            this.btnPedidosReport.UseVisualStyleBackColor = true;
            this.btnPedidosReport.Click += new System.EventHandler(this.btnPedidosReport_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Controls.Add(this.btnCargarReportexFecha);
            this.tabPage4.Controls.Add(this.dpFechaFin);
            this.tabPage4.Controls.Add(this.dpFechaIni);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1021, 649);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dpFechaIni
            // 
            this.dpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaIni.Location = new System.Drawing.Point(89, 62);
            this.dpFechaIni.Name = "dpFechaIni";
            this.dpFechaIni.Size = new System.Drawing.Size(200, 28);
            this.dpFechaIni.TabIndex = 0;
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaFin.Location = new System.Drawing.Point(499, 62);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(200, 28);
            this.dpFechaFin.TabIndex = 1;
            // 
            // btnCargarReportexFecha
            // 
            this.btnCargarReportexFecha.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCargarReportexFecha.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCargarReportexFecha.IconColor = System.Drawing.Color.Black;
            this.btnCargarReportexFecha.IconSize = 16;
            this.btnCargarReportexFecha.Location = new System.Drawing.Point(813, 62);
            this.btnCargarReportexFecha.Name = "btnCargarReportexFecha";
            this.btnCargarReportexFecha.Rotation = 0D;
            this.btnCargarReportexFecha.Size = new System.Drawing.Size(139, 31);
            this.btnCargarReportexFecha.TabIndex = 2;
            this.btnCargarReportexFecha.Text = "Ver";
            this.btnCargarReportexFecha.UseVisualStyleBackColor = true;
            this.btnCargarReportexFecha.Click += new System.EventHandler(this.btnCargarReportexFecha_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "PedxFechaDS";
            reportDataSource3.Value = this.SP_ReportePedidosxFecha_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.RepPedxFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(72, 146);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(855, 449);
            this.reportViewer1.TabIndex = 3;
            // 
            // SP_ReportePedidosxFecha_ResultBindingSource
            // 
            this.SP_ReportePedidosxFecha_ResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReportePedidosxFecha_Result);
            // 
            // ModuloReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 683);
            this.Controls.Add(this.tabControl1);
            this.Name = "ModuloReportes";
            this.Text = "ModuloReportes";
            this.Load += new System.EventHandler(this.ModuloReportes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteClientesResultBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteProductosResultBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReportePedidosResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteFacturaResultBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ReportePedidosxFecha_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sPReporteClientesResultBindingSource;
        private System.Windows.Forms.BindingSource sPReporteProductosResultBindingSource;
        private CachedClientesReport cachedClientesReport1;
        private System.Windows.Forms.TabPage tabPage3;
        private FontAwesome.Sharp.IconButton btnProductosReporte;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelproductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource sPReporteFacturaResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton btnPedidosReport;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadventaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciototalpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPReportePedidosResultBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FontAwesome.Sharp.IconButton btnCargarReportexFecha;
        private System.Windows.Forms.DateTimePicker dpFechaFin;
        private System.Windows.Forms.DateTimePicker dpFechaIni;
        private System.Windows.Forms.BindingSource SP_ReportePedidosxFecha_ResultBindingSource;
    }
}