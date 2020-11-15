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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClientesReporte = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnProductosReporte = new FontAwesome.Sharp.IconButton();
            this.cachedClientesReport1 = new WindowsFormsApp1.CachedClientesReport();
            this.sPReporteFacturaResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPReporteClientesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredelproductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPReporteProductosResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteFacturaResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteClientesResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteProductosResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 683);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientesDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPReporteClientesResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconSize = 16;
            this.btnImprimir.Location = new System.Drawing.Point(804, 520);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Rotation = 0D;
            this.btnImprimir.Size = new System.Drawing.Size(107, 36);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClientesReporte);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClientesReporte
            // 
            this.btnClientesReporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientesReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClientesReporte.IconColor = System.Drawing.Color.Black;
            this.btnClientesReporte.IconSize = 16;
            this.btnClientesReporte.Location = new System.Drawing.Point(714, 499);
            this.btnClientesReporte.Name = "btnClientesReporte";
            this.btnClientesReporte.Rotation = 0D;
            this.btnClientesReporte.Size = new System.Drawing.Size(149, 34);
            this.btnClientesReporte.TabIndex = 1;
            this.btnClientesReporte.Text = "Clientes";
            this.btnClientesReporte.UseVisualStyleBackColor = true;
            this.btnClientesReporte.Click += new System.EventHandler(this.btnClientesReporte_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientesDataGridViewTextBoxColumn1,
            this.dNIDataGridViewTextBoxColumn1,
            this.direccionDataGridViewTextBoxColumn1,
            this.telefonoDataGridViewTextBoxColumn1,
            this.correoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.sPReporteClientesResultBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(84, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(779, 191);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.btnProductosReporte);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(937, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelproductoDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn1,
            this.serieDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.sPReporteProductosResultBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(108, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(672, 352);
            this.dataGridView3.TabIndex = 1;
            // 
            // btnProductosReporte
            // 
            this.btnProductosReporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProductosReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductosReporte.IconColor = System.Drawing.Color.Black;
            this.btnProductosReporte.IconSize = 16;
            this.btnProductosReporte.Location = new System.Drawing.Point(742, 500);
            this.btnProductosReporte.Name = "btnProductosReporte";
            this.btnProductosReporte.Rotation = 0D;
            this.btnProductosReporte.Size = new System.Drawing.Size(153, 37);
            this.btnProductosReporte.TabIndex = 0;
            this.btnProductosReporte.Text = "Productos";
            this.btnProductosReporte.UseVisualStyleBackColor = true;
            this.btnProductosReporte.Click += new System.EventHandler(this.btnProductosReporte_Click);
            // 
            // clientesDataGridViewTextBoxColumn
            // 
            this.clientesDataGridViewTextBoxColumn.DataPropertyName = "Clientes";
            this.clientesDataGridViewTextBoxColumn.HeaderText = "Clientes";
            this.clientesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientesDataGridViewTextBoxColumn.Name = "clientesDataGridViewTextBoxColumn";
            this.clientesDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPReporteClientesResultBindingSource
            // 
            this.sPReporteClientesResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReporteClientes_Result);
            // 
            // clientesDataGridViewTextBoxColumn1
            // 
            this.clientesDataGridViewTextBoxColumn1.DataPropertyName = "Clientes";
            this.clientesDataGridViewTextBoxColumn1.HeaderText = "Clientes";
            this.clientesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientesDataGridViewTextBoxColumn1.Name = "clientesDataGridViewTextBoxColumn1";
            this.clientesDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dNIDataGridViewTextBoxColumn1
            // 
            this.dNIDataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dNIDataGridViewTextBoxColumn1.Name = "dNIDataGridViewTextBoxColumn1";
            this.dNIDataGridViewTextBoxColumn1.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn1
            // 
            this.direccionDataGridViewTextBoxColumn1.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn1.Name = "direccionDataGridViewTextBoxColumn1";
            this.direccionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn1
            // 
            this.telefonoDataGridViewTextBoxColumn1.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn1.Name = "telefonoDataGridViewTextBoxColumn1";
            this.telefonoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn1
            // 
            this.correoDataGridViewTextBoxColumn1.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn1.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn1.Name = "correoDataGridViewTextBoxColumn1";
            this.correoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nombredelproductoDataGridViewTextBoxColumn1
            // 
            this.nombredelproductoDataGridViewTextBoxColumn1.DataPropertyName = "Nombre_del_producto";
            this.nombredelproductoDataGridViewTextBoxColumn1.HeaderText = "Nombre_del_producto";
            this.nombredelproductoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombredelproductoDataGridViewTextBoxColumn1.Name = "nombredelproductoDataGridViewTextBoxColumn1";
            this.nombredelproductoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn1
            // 
            this.marcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn1.Name = "marcaDataGridViewTextBoxColumn1";
            this.marcaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // serieDataGridViewTextBoxColumn1
            // 
            this.serieDataGridViewTextBoxColumn1.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn1.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn1.Name = "serieDataGridViewTextBoxColumn1";
            this.serieDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn1
            // 
            this.stockDataGridViewTextBoxColumn1.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn1.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn1.Name = "stockDataGridViewTextBoxColumn1";
            this.stockDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sPReporteProductosResultBindingSource
            // 
            this.sPReporteProductosResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReporteProductos_Result);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteFacturaResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteClientesResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteProductosResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private FontAwesome.Sharp.IconButton btnClientesReporte;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource sPReporteFacturaResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
    }
}