namespace WindowsFormsApp1.Modulo
{
    partial class RepFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_ReporteFactura_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ReporteFactura_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnCargar
            // 
            this.btnCargar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCargar.IconColor = System.Drawing.Color.Black;
            this.btnCargar.IconSize = 16;
            this.btnCargar.Location = new System.Drawing.Point(582, 13);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Rotation = 0D;
            this.btnCargar.Size = new System.Drawing.Size(145, 35);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.RepFactur.rdlc";
            reportDataSource1.Name = "FacturaDS";
            reportDataSource1.Value = this.SP_ReporteFactura_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(119, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(809, 461);
            this.reportViewer1.TabIndex = 3;
            // 
            // SP_ReporteFactura_ResultBindingSource
            // 
            this.SP_ReporteFactura_ResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_ReporteFactura_Result);
            // 
            // RepFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 657);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Name = "RepFactura";
            this.Text = "RepFactura";
            this.Load += new System.EventHandler(this.RepFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ReporteFactura_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCargar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_ReporteFactura_ResultBindingSource;
    }
}