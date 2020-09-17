namespace WindowsFormsApp1.Forms
{
    partial class FormIngresarProducto
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
            this.btnAgregarMarca = new FontAwesome.Sharp.IconButton();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.btnAgregarSerie = new FontAwesome.Sharp.IconButton();
            this.txtNombreSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMarcaProducto = new System.Windows.Forms.ComboBox();
            this.cbxSerieProducto = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.cbxMarcaSerie = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarMarca.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarMarca.IconColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarMarca.IconSize = 16;
            this.btnAgregarMarca.Location = new System.Drawing.Point(679, 103);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Rotation = 0D;
            this.btnAgregarMarca.Size = new System.Drawing.Size(170, 40);
            this.btnAgregarMarca.TabIndex = 47;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMarca.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNombreMarca.Location = new System.Drawing.Point(326, 110);
            this.txtNombreMarca.MaxLength = 8;
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(214, 27);
            this.txtNombreMarca.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Crear nueva marca y serie";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.White;
            this.lblInstrucciones.Location = new System.Drawing.Point(54, 114);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(182, 19);
            this.lblInstrucciones.TabIndex = 43;
            this.lblInstrucciones.Text = "Nombre de la marca";
            // 
            // btnAgregarSerie
            // 
            this.btnAgregarSerie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarSerie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSerie.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarSerie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarSerie.IconColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarSerie.IconSize = 16;
            this.btnAgregarSerie.Location = new System.Drawing.Point(679, 206);
            this.btnAgregarSerie.Name = "btnAgregarSerie";
            this.btnAgregarSerie.Rotation = 0D;
            this.btnAgregarSerie.Size = new System.Drawing.Size(170, 40);
            this.btnAgregarSerie.TabIndex = 52;
            this.btnAgregarSerie.Text = "Agregar Serie";
            this.btnAgregarSerie.UseVisualStyleBackColor = true;
            this.btnAgregarSerie.Click += new System.EventHandler(this.btnAgregarSerie_Click);
            // 
            // txtNombreSerie
            // 
            this.txtNombreSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSerie.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNombreSerie.Location = new System.Drawing.Point(326, 179);
            this.txtNombreSerie.MaxLength = 8;
            this.txtNombreSerie.Name = "txtNombreSerie";
            this.txtNombreSerie.Size = new System.Drawing.Size(214, 27);
            this.txtNombreSerie.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre de la serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(740, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ingresar nuevo producto al almacen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(174, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Marca";
            // 
            // cbxMarcaProducto
            // 
            this.cbxMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarcaProducto.FormattingEnabled = true;
            this.cbxMarcaProducto.Location = new System.Drawing.Point(326, 376);
            this.cbxMarcaProducto.Name = "cbxMarcaProducto";
            this.cbxMarcaProducto.Size = new System.Drawing.Size(214, 28);
            this.cbxMarcaProducto.TabIndex = 56;
            this.cbxMarcaProducto.SelectedIndexChanged += new System.EventHandler(this.cbxMarcaProducto_SelectedIndexChanged);
            // 
            // cbxSerieProducto
            // 
            this.cbxSerieProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSerieProducto.FormattingEnabled = true;
            this.cbxSerieProducto.Location = new System.Drawing.Point(883, 376);
            this.cbxSerieProducto.Name = "cbxSerieProducto";
            this.cbxSerieProducto.Size = new System.Drawing.Size(214, 28);
            this.cbxSerieProducto.TabIndex = 57;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNombreProducto.Location = new System.Drawing.Point(326, 448);
            this.txtNombreProducto.MaxLength = 8;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(214, 27);
            this.txtNombreProducto.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(81, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nombre producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPrecioProducto.Location = new System.Drawing.Point(326, 523);
            this.txtPrecioProducto.MaxLength = 8;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(214, 27);
            this.txtPrecioProducto.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 526);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "Precio del producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(289, 526);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "s/.";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCodProducto.Location = new System.Drawing.Point(883, 526);
            this.txtCodProducto.MaxLength = 8;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(214, 27);
            this.txtCodProducto.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(640, 526);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "Codigo producto";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockProducto.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtStockProducto.Location = new System.Drawing.Point(883, 451);
            this.txtStockProducto.MaxLength = 8;
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(214, 27);
            this.txtStockProducto.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(656, 454);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 19);
            this.label10.TabIndex = 63;
            this.label10.Text = "Stock producto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarProducto.IconSize = 16;
            this.btnAgregarProducto.Location = new System.Drawing.Point(537, 595);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Rotation = 0D;
            this.btnAgregarProducto.Size = new System.Drawing.Size(200, 40);
            this.btnAgregarProducto.TabIndex = 67;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // cbxMarcaSerie
            // 
            this.cbxMarcaSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarcaSerie.FormattingEnabled = true;
            this.cbxMarcaSerie.Location = new System.Drawing.Point(326, 246);
            this.cbxMarcaSerie.Name = "cbxMarcaSerie";
            this.cbxMarcaSerie.Size = new System.Drawing.Size(214, 28);
            this.cbxMarcaSerie.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(83, 249);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 19);
            this.label11.TabIndex = 68;
            this.label11.Text = "Marca de la serie";
            // 
            // FormIngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1213, 724);
            this.Controls.Add(this.cbxMarcaSerie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxSerieProducto);
            this.Controls.Add(this.cbxMarcaProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarSerie);
            this.Controls.Add(this.txtNombreSerie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.lblInstrucciones);
            this.Name = "FormIngresarProducto";
            this.Text = "FormIngresarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAgregarMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInstrucciones;
        private FontAwesome.Sharp.IconButton btnAgregarSerie;
        private System.Windows.Forms.TextBox txtNombreSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMarcaProducto;
        private System.Windows.Forms.ComboBox cbxSerieProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private System.Windows.Forms.ComboBox cbxMarcaSerie;
        private System.Windows.Forms.Label label11;
    }
}