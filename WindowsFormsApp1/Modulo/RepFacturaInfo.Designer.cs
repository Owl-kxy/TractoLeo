namespace WindowsFormsApp1.Modulo
{
    partial class RepFacturaInfo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFacturaCompleta = new FontAwesome.Sharp.IconButton();
            this.SP_FacturaCompleta_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SP_FacturaCompleta_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "FacturaInfoDS";
            reportDataSource1.Value = this.SP_FacturaCompleta_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.RepFacturaInfo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(770, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnFacturaCompleta
            // 
            this.btnFacturaCompleta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFacturaCompleta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFacturaCompleta.IconColor = System.Drawing.Color.Black;
            this.btnFacturaCompleta.IconSize = 16;
            this.btnFacturaCompleta.Location = new System.Drawing.Point(339, 47);
            this.btnFacturaCompleta.Name = "btnFacturaCompleta";
            this.btnFacturaCompleta.Rotation = 0D;
            this.btnFacturaCompleta.Size = new System.Drawing.Size(75, 23);
            this.btnFacturaCompleta.TabIndex = 2;
            this.btnFacturaCompleta.Text = "iconButton1";
            this.btnFacturaCompleta.UseVisualStyleBackColor = true;
            this.btnFacturaCompleta.Click += new System.EventHandler(this.btnFacturaCompleta_Click);
            // 
            // SP_FacturaCompleta_ResultBindingSource
            // 
            this.SP_FacturaCompleta_ResultBindingSource.DataSource = typeof(WindowsFormsApp1.SP_FacturaCompleta_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // RepFacturaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacturaCompleta);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepFacturaInfo";
            this.Text = "RepFacturaInfo";
            this.Load += new System.EventHandler(this.RepFacturaInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_FacturaCompleta_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_FacturaCompleta_ResultBindingSource;
        private FontAwesome.Sharp.IconButton btnFacturaCompleta;
        private System.Windows.Forms.Label label1;
    }
}