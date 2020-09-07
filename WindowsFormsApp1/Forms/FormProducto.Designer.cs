namespace WindowsFormsApp1.Forms
{
    partial class FormProducto
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
            this.DataGridProductos = new System.Windows.Forms.DataGridView();
            this.btnVerProductos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridProductos
            // 
            this.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProductos.Location = new System.Drawing.Point(72, 153);
            this.DataGridProductos.Name = "DataGridProductos";
            this.DataGridProductos.Size = new System.Drawing.Size(442, 226);
            this.DataGridProductos.TabIndex = 0;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerProductos.IconColor = System.Drawing.Color.Black;
            this.btnVerProductos.IconSize = 16;
            this.btnVerProductos.Location = new System.Drawing.Point(584, 251);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Rotation = 0D;
            this.btnVerProductos.Size = new System.Drawing.Size(124, 23);
            this.btnVerProductos.TabIndex = 1;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.DataGridProductos);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridProductos;
        private FontAwesome.Sharp.IconButton btnVerProductos;
    }
}