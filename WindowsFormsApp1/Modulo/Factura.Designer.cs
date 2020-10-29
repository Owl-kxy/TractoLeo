namespace WindowsFormsApp1.Modulo
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevisualizar = new FontAwesome.Sharp.IconButton();
            this.gridDetalleVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImprimirFactura = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.DialogImprimirFactura = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnPrevisualizar
            // 
            this.btnPrevisualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrevisualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrevisualizar.IconColor = System.Drawing.Color.Black;
            this.btnPrevisualizar.IconSize = 16;
            this.btnPrevisualizar.Location = new System.Drawing.Point(220, 57);
            this.btnPrevisualizar.Name = "btnPrevisualizar";
            this.btnPrevisualizar.Rotation = 0D;
            this.btnPrevisualizar.Size = new System.Drawing.Size(116, 32);
            this.btnPrevisualizar.TabIndex = 1;
            this.btnPrevisualizar.Text = "Ver Factura";
            this.btnPrevisualizar.UseVisualStyleBackColor = true;
            this.btnPrevisualizar.Click += new System.EventHandler(this.btnPrevisualizar_Click);
            // 
            // gridDetalleVenta
            // 
            this.gridDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleVenta.Location = new System.Drawing.Point(72, 215);
            this.gridDetalleVenta.Name = "gridDetalleVenta";
            this.gridDetalleVenta.RowHeadersWidth = 51;
            this.gridDetalleVenta.RowTemplate.Height = 24;
            this.gridDetalleVenta.Size = new System.Drawing.Size(629, 150);
            this.gridDetalleVenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // ImprimirFactura
            // 
            this.ImprimirFactura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirFactura_PrintPage);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconSize = 16;
            this.btnImprimir.Location = new System.Drawing.Point(394, 57);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Rotation = 0D;
            this.btnImprimir.Size = new System.Drawing.Size(116, 32);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // DialogImprimirFactura
            // 
            this.DialogImprimirFactura.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DialogImprimirFactura.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DialogImprimirFactura.ClientSize = new System.Drawing.Size(400, 300);
            this.DialogImprimirFactura.Document = this.ImprimirFactura;
            this.DialogImprimirFactura.Enabled = true;
            this.DialogImprimirFactura.Icon = ((System.Drawing.Icon)(resources.GetObject("DialogImprimirFactura.Icon")));
            this.DialogImprimirFactura.Name = "DialogImprimirFactura";
            this.DialogImprimirFactura.Visible = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 671);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDetalleVenta);
            this.Controls.Add(this.btnPrevisualizar);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPrevisualizar;
        private System.Windows.Forms.DataGridView gridDetalleVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument ImprimirFactura;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.PrintPreviewDialog DialogImprimirFactura;
    }
}