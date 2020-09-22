namespace WindowsFormsApp1.Modulo
{
    partial class ModuloClientes
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
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.tabCrearCliente = new System.Windows.Forms.TabPage();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMantenimientoCliente = new System.Windows.Forms.TabControl();
            this.gridViewClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.btnBuscarDNI = new FontAwesome.Sharp.IconButton();
            this.btnVerTodo = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarRUC = new System.Windows.Forms.TextBox();
            this.btnBuscarRUC = new FontAwesome.Sharp.IconButton();
            this.tabMantenimiento.SuspendLayout();
            this.tabCrearCliente.SuspendLayout();
            this.tabMantenimientoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.groupBox2);
            this.tabMantenimiento.Controls.Add(this.groupBox1);
            this.tabMantenimiento.Controls.Add(this.label4);
            this.tabMantenimiento.Controls.Add(this.btnVerTodo);
            this.tabMantenimiento.Controls.Add(this.gridViewClientes);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 4);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(1137, 649);
            this.tabMantenimiento.TabIndex = 2;
            this.tabMantenimiento.Text = "Mantenimiento de clientes";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tabCrearCliente
            // 
            this.tabCrearCliente.Controls.Add(this.label3);
            this.tabCrearCliente.Controls.Add(this.txtRUC);
            this.tabCrearCliente.Controls.Add(this.txtDireccion);
            this.tabCrearCliente.Controls.Add(this.txtCorreo);
            this.tabCrearCliente.Controls.Add(this.txtTelefono);
            this.tabCrearCliente.Controls.Add(this.txtApellidoMaterno);
            this.tabCrearCliente.Controls.Add(this.txtApellidoPaterno);
            this.tabCrearCliente.Controls.Add(this.txtNombreCliente);
            this.tabCrearCliente.Controls.Add(this.txtDNI);
            this.tabCrearCliente.Controls.Add(this.label2);
            this.tabCrearCliente.Controls.Add(this.btnGuardar);
            this.tabCrearCliente.Controls.Add(this.label1);
            this.tabCrearCliente.Controls.Add(this.lblCorreo);
            this.tabCrearCliente.Controls.Add(this.lblTelefono);
            this.tabCrearCliente.Controls.Add(this.lblApellidoMaterno);
            this.tabCrearCliente.Controls.Add(this.lblApellidoPaterno);
            this.tabCrearCliente.Controls.Add(this.lblInstrucciones);
            this.tabCrearCliente.Controls.Add(this.lblNombreCliente);
            this.tabCrearCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCrearCliente.Location = new System.Drawing.Point(4, 4);
            this.tabCrearCliente.Name = "tabCrearCliente";
            this.tabCrearCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCrearCliente.Size = new System.Drawing.Size(1114, 645);
            this.tabCrearCliente.TabIndex = 1;
            this.tabCrearCliente.Text = "Ingresar clientes";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtDNI.Location = new System.Drawing.Point(290, 168);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(239, 27);
            this.txtDNI.TabIndex = 34;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtNombreCliente.Location = new System.Drawing.Point(290, 236);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(239, 27);
            this.txtNombreCliente.TabIndex = 20;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblNombreCliente.Location = new System.Drawing.Point(143, 240);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(90, 23);
            this.lblNombreCliente.TabIndex = 21;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(43, 79);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(547, 23);
            this.lblInstrucciones.TabIndex = 22;
            this.lblInstrucciones.Text = "Agregue los datos del cliente en el siguiente formulario";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(290, 300);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(239, 27);
            this.txtApellidoPaterno.TabIndex = 23;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(58, 304);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(175, 23);
            this.lblApellidoPaterno.TabIndex = 24;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(290, 372);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(239, 27);
            this.txtApellidoMaterno.TabIndex = 25;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(53, 376);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(180, 23);
            this.lblApellidoMaterno.TabIndex = 26;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtTelefono.Location = new System.Drawing.Point(817, 233);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(239, 27);
            this.txtTelefono.TabIndex = 27;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblTelefono.Location = new System.Drawing.Point(653, 236);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(93, 23);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtCorreo.Location = new System.Drawing.Point(817, 297);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(239, 27);
            this.txtCorreo.TabIndex = 29;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblCorreo.Location = new System.Drawing.Point(669, 300);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(77, 23);
            this.lblCorreo.TabIndex = 30;
            this.lblCorreo.Text = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtDireccion.Location = new System.Drawing.Point(817, 369);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 27);
            this.txtDireccion.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(645, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Direccion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(503, 460);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Rotation = 0D;
            this.btnGuardar.Size = new System.Drawing.Size(160, 49);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(188, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "DNI";
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.Color.White;
            this.txtRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtRUC.Location = new System.Drawing.Point(817, 165);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(239, 27);
            this.txtRUC.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(695, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "RUC";
            // 
            // tabMantenimientoCliente
            // 
            this.tabMantenimientoCliente.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMantenimientoCliente.Controls.Add(this.tabCrearCliente);
            this.tabMantenimientoCliente.Controls.Add(this.tabMantenimiento);
            this.tabMantenimientoCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMantenimientoCliente.Location = new System.Drawing.Point(25, 32);
            this.tabMantenimientoCliente.Name = "tabMantenimientoCliente";
            this.tabMantenimientoCliente.SelectedIndex = 0;
            this.tabMantenimientoCliente.Size = new System.Drawing.Size(1145, 683);
            this.tabMantenimientoCliente.TabIndex = 0;
            // 
            // gridViewClientes
            // 
            this.gridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewClientes.Location = new System.Drawing.Point(63, 368);
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridViewClientes.RowTemplate.Height = 24;
            this.gridViewClientes.Size = new System.Drawing.Size(1015, 235);
            this.gridViewClientes.TabIndex = 0;
            this.gridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewClientes_CellContentClick);
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtBuscarDNI.Location = new System.Drawing.Point(28, 57);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(236, 28);
            this.txtBuscarDNI.TabIndex = 1;
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscarDNI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDNI.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarDNI.IconColor = System.Drawing.Color.Black;
            this.btnBuscarDNI.IconSize = 16;
            this.btnBuscarDNI.Location = new System.Drawing.Point(313, 51);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Rotation = 0D;
            this.btnBuscarDNI.Size = new System.Drawing.Size(120, 40);
            this.btnBuscarDNI.TabIndex = 2;
            this.btnBuscarDNI.Text = "Buscar";
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerTodo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnVerTodo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerTodo.IconColor = System.Drawing.Color.Black;
            this.btnVerTodo.IconSize = 16;
            this.btnVerTodo.Location = new System.Drawing.Point(510, 293);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Rotation = 0D;
            this.btnVerTodo.Size = new System.Drawing.Size(120, 40);
            this.btnVerTodo.TabIndex = 3;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(40, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Consulte la informacion de sus clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarDNI);
            this.groupBox1.Controls.Add(this.btnBuscarDNI);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox1.Location = new System.Drawing.Point(63, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 133);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarRUC);
            this.groupBox2.Controls.Add(this.btnBuscarRUC);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox2.Location = new System.Drawing.Point(613, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 133);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por RUC";
            // 
            // txtBuscarRUC
            // 
            this.txtBuscarRUC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtBuscarRUC.Location = new System.Drawing.Point(39, 57);
            this.txtBuscarRUC.Name = "txtBuscarRUC";
            this.txtBuscarRUC.Size = new System.Drawing.Size(236, 28);
            this.txtBuscarRUC.TabIndex = 1;
            // 
            // btnBuscarRUC
            // 
            this.btnBuscarRUC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscarRUC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRUC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarRUC.IconColor = System.Drawing.Color.Black;
            this.btnBuscarRUC.IconSize = 16;
            this.btnBuscarRUC.Location = new System.Drawing.Point(312, 50);
            this.btnBuscarRUC.Name = "btnBuscarRUC";
            this.btnBuscarRUC.Rotation = 0D;
            this.btnBuscarRUC.Size = new System.Drawing.Size(120, 40);
            this.btnBuscarRUC.TabIndex = 2;
            this.btnBuscarRUC.Text = "Buscar";
            this.btnBuscarRUC.UseVisualStyleBackColor = true;
            // 
            // ModuloClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.tabMantenimientoCliente);
            this.Name = "ModuloClientes";
            this.Text = "ModuloClientes";
            this.tabMantenimiento.ResumeLayout(false);
            this.tabMantenimiento.PerformLayout();
            this.tabCrearCliente.ResumeLayout(false);
            this.tabCrearCliente.PerformLayout();
            this.tabMantenimientoCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.TabPage tabCrearCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TabControl tabMantenimientoCliente;
        private System.Windows.Forms.DataGridView gridViewClientes;
        private FontAwesome.Sharp.IconButton btnBuscarDNI;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private FontAwesome.Sharp.IconButton btnVerTodo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarRUC;
        private FontAwesome.Sharp.IconButton btnBuscarRUC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}