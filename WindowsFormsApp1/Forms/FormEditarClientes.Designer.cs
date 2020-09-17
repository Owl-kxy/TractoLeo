namespace WindowsFormsApp1.Forms
{
    partial class FormEditarClientes
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.txtBuscarRUC = new System.Windows.Forms.TextBox();
            this.btnBuscarDNI = new FontAwesome.Sharp.IconButton();
            this.btnBuscarRUC = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtDireccion.Location = new System.Drawing.Point(810, 420);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 27);
            this.txtDireccion.TabIndex = 28;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCorreo.Location = new System.Drawing.Point(810, 359);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(239, 27);
            this.txtCorreo.TabIndex = 27;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTelefono.Location = new System.Drawing.Point(810, 299);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(239, 27);
            this.txtTelefono.TabIndex = 26;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(59, 424);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(150, 19);
            this.lblApellidoMaterno.TabIndex = 25;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(273, 420);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(239, 27);
            this.txtApellidoMaterno.TabIndex = 24;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(64, 363);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(145, 19);
            this.lblApellidoPaterno.TabIndex = 23;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(273, 359);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(239, 27);
            this.txtApellidoPaterno.TabIndex = 22;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.White;
            this.lblInstrucciones.Location = new System.Drawing.Point(50, 84);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(218, 19);
            this.lblInstrucciones.TabIndex = 21;
            this.lblInstrucciones.Text = "Escriba el numero de DNI";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreCliente.Location = new System.Drawing.Point(133, 303);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(76, 19);
            this.lblNombreCliente.TabIndex = 20;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNombreCliente.Location = new System.Drawing.Point(273, 299);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(239, 27);
            this.txtNombreCliente.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(644, 424);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Direccion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(667, 363);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 19);
            this.lblCorreo.TabIndex = 34;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(653, 303);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 19);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Escriba el numero de RUC";
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDNI.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtBuscarDNI.Location = new System.Drawing.Point(297, 80);
            this.txtBuscarDNI.MaxLength = 8;
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(214, 27);
            this.txtBuscarDNI.TabIndex = 38;
            // 
            // txtBuscarRUC
            // 
            this.txtBuscarRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRUC.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtBuscarRUC.Location = new System.Drawing.Point(297, 146);
            this.txtBuscarRUC.MaxLength = 11;
            this.txtBuscarRUC.Name = "txtBuscarRUC";
            this.txtBuscarRUC.Size = new System.Drawing.Size(214, 27);
            this.txtBuscarRUC.TabIndex = 39;
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscarDNI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDNI.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBuscarDNI.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarDNI.IconColor = System.Drawing.Color.DarkBlue;
            this.btnBuscarDNI.IconSize = 16;
            this.btnBuscarDNI.Location = new System.Drawing.Point(642, 73);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Rotation = 0D;
            this.btnBuscarDNI.Size = new System.Drawing.Size(120, 40);
            this.btnBuscarDNI.TabIndex = 40;
            this.btnBuscarDNI.Text = "Buscar";
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // btnBuscarRUC
            // 
            this.btnBuscarRUC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscarRUC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRUC.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBuscarRUC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarRUC.IconColor = System.Drawing.Color.DarkBlue;
            this.btnBuscarRUC.IconSize = 16;
            this.btnBuscarRUC.Location = new System.Drawing.Point(642, 139);
            this.btnBuscarRUC.Name = "btnBuscarRUC";
            this.btnBuscarRUC.Rotation = 0D;
            this.btnBuscarRUC.Size = new System.Drawing.Size(120, 40);
            this.btnBuscarRUC.TabIndex = 41;
            this.btnBuscarRUC.Text = "Buscar";
            this.btnBuscarRUC.UseVisualStyleBackColor = true;
            this.btnBuscarRUC.Click += new System.EventHandler(this.btnBuscarRUC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ingrese la siguiente informacion que tenga del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(736, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Estos son los datos que se tiene del cliente, edite en los campos si desea actual" +
    "izar algo";
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.DarkBlue;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(498, 501);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(180, 40);
            this.iconButton1.TabIndex = 44;
            this.iconButton1.Text = "Actualizar datos";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(982, 41);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(12, 17);
            this.lblid.TabIndex = 45;
            this.lblid.Text = " ";
            // 
            // FormEditarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1082, 585);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarRUC);
            this.Controls.Add(this.btnBuscarDNI);
            this.Controls.Add(this.txtBuscarRUC);
            this.Controls.Add(this.txtBuscarDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Name = "FormEditarClientes";
            this.Text = "FormEditarClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.TextBox txtBuscarRUC;
        private FontAwesome.Sharp.IconButton btnBuscarRUC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblid;
        private FontAwesome.Sharp.IconButton btnBuscarDNI;
    }
}