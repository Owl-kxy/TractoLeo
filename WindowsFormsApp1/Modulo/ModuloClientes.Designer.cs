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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.btnConsultarClientes = new FontAwesome.Sharp.IconButton();
            this.txtBusquedaClientes = new System.Windows.Forms.TextBox();
            this.cbxConsultaClientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerTodo = new FontAwesome.Sharp.IconButton();
            this.gridViewClientes = new System.Windows.Forms.DataGridView();
            this.tabCrearCliente = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.tabMantenimientoCliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblIdcli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditRUC = new System.Windows.Forms.TextBox();
            this.txtEditDireccion = new System.Windows.Forms.TextBox();
            this.txtEditCorreo = new System.Windows.Forms.TextBox();
            this.txtEditTelf = new System.Windows.Forms.TextBox();
            this.txtEditMaterno = new System.Windows.Forms.TextBox();
            this.txtEditPaterno = new System.Windows.Forms.TextBox();
            this.txtEditNombre = new System.Windows.Forms.TextBox();
            this.txtEditDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizarInformacion = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            this.tabCrearCliente.SuspendLayout();
            this.tabMantenimientoCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.BackColor = System.Drawing.Color.LightGray;
            this.tabMantenimiento.Controls.Add(this.btnConsultarClientes);
            this.tabMantenimiento.Controls.Add(this.txtBusquedaClientes);
            this.tabMantenimiento.Controls.Add(this.cbxConsultaClientes);
            this.tabMantenimiento.Controls.Add(this.label4);
            this.tabMantenimiento.Controls.Add(this.btnVerTodo);
            this.tabMantenimiento.Controls.Add(this.gridViewClientes);
            this.tabMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 4);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(1107, 649);
            this.tabMantenimiento.TabIndex = 2;
            this.tabMantenimiento.Text = "Mantenimiento de clientes";
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsultarClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConsultarClientes.IconColor = System.Drawing.Color.Black;
            this.btnConsultarClientes.IconSize = 16;
            this.btnConsultarClientes.Location = new System.Drawing.Point(635, 176);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Rotation = 0D;
            this.btnConsultarClientes.Size = new System.Drawing.Size(131, 45);
            this.btnConsultarClientes.TabIndex = 31;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // txtBusquedaClientes
            // 
            this.txtBusquedaClientes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtBusquedaClientes.Location = new System.Drawing.Point(323, 181);
            this.txtBusquedaClientes.Name = "txtBusquedaClientes";
            this.txtBusquedaClientes.Size = new System.Drawing.Size(236, 28);
            this.txtBusquedaClientes.TabIndex = 1;
            // 
            // cbxConsultaClientes
            // 
            this.cbxConsultaClientes.FormattingEnabled = true;
            this.cbxConsultaClientes.Location = new System.Drawing.Point(139, 181);
            this.cbxConsultaClientes.Name = "cbxConsultaClientes";
            this.cbxConsultaClientes.Size = new System.Drawing.Size(121, 29);
            this.cbxConsultaClientes.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(39, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Consulte la informacion de sus clientes";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVerTodo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnVerTodo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerTodo.IconColor = System.Drawing.Color.Black;
            this.btnVerTodo.IconSize = 16;
            this.btnVerTodo.Location = new System.Drawing.Point(827, 178);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Rotation = 0D;
            this.btnVerTodo.Size = new System.Drawing.Size(120, 40);
            this.btnVerTodo.TabIndex = 3;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // gridViewClientes
            // 
            this.gridViewClientes.AllowUserToAddRows = false;
            this.gridViewClientes.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewClientes.Location = new System.Drawing.Point(63, 368);
            this.gridViewClientes.Name = "gridViewClientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridViewClientes.RowTemplate.Height = 24;
            this.gridViewClientes.Size = new System.Drawing.Size(1015, 235);
            this.gridViewClientes.TabIndex = 0;
            this.gridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewClientes_CellContentClick);
            // 
            // tabCrearCliente
            // 
            this.tabCrearCliente.BackColor = System.Drawing.Color.LightGray;
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
            this.tabCrearCliente.Size = new System.Drawing.Size(1107, 649);
            this.tabCrearCliente.TabIndex = 1;
            this.tabCrearCliente.Text = "Ingresar clientes";
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // tabMantenimientoCliente
            // 
            this.tabMantenimientoCliente.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMantenimientoCliente.Controls.Add(this.tabCrearCliente);
            this.tabMantenimientoCliente.Controls.Add(this.tabMantenimiento);
            this.tabMantenimientoCliente.Controls.Add(this.tabPage1);
            this.tabMantenimientoCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMantenimientoCliente.Location = new System.Drawing.Point(25, 32);
            this.tabMantenimientoCliente.Name = "tabMantenimientoCliente";
            this.tabMantenimientoCliente.SelectedIndex = 0;
            this.tabMantenimientoCliente.Size = new System.Drawing.Size(1115, 683);
            this.tabMantenimientoCliente.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.lblIdcli);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEditRUC);
            this.tabPage1.Controls.Add(this.txtEditDireccion);
            this.tabPage1.Controls.Add(this.txtEditCorreo);
            this.tabPage1.Controls.Add(this.txtEditTelf);
            this.tabPage1.Controls.Add(this.txtEditMaterno);
            this.tabPage1.Controls.Add(this.txtEditPaterno);
            this.tabPage1.Controls.Add(this.txtEditNombre);
            this.tabPage1.Controls.Add(this.txtEditDNI);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnActualizarInformacion);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 649);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Editar informacion del cliente";
            // 
            // lblIdcli
            // 
            this.lblIdcli.AutoSize = true;
            this.lblIdcli.Location = new System.Drawing.Point(892, 31);
            this.lblIdcli.Name = "lblIdcli";
            this.lblIdcli.Size = new System.Drawing.Size(0, 21);
            this.lblIdcli.TabIndex = 56;
            this.lblIdcli.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(714, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "RUC";
            // 
            // txtEditRUC
            // 
            this.txtEditRUC.BackColor = System.Drawing.Color.White;
            this.txtEditRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditRUC.Location = new System.Drawing.Point(836, 195);
            this.txtEditRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditRUC.MaxLength = 11;
            this.txtEditRUC.Name = "txtEditRUC";
            this.txtEditRUC.Size = new System.Drawing.Size(239, 27);
            this.txtEditRUC.TabIndex = 54;
            // 
            // txtEditDireccion
            // 
            this.txtEditDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditDireccion.Location = new System.Drawing.Point(836, 399);
            this.txtEditDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditDireccion.MaxLength = 100;
            this.txtEditDireccion.Name = "txtEditDireccion";
            this.txtEditDireccion.Size = new System.Drawing.Size(239, 27);
            this.txtEditDireccion.TabIndex = 49;
            // 
            // txtEditCorreo
            // 
            this.txtEditCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditCorreo.Location = new System.Drawing.Point(836, 327);
            this.txtEditCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditCorreo.MaxLength = 50;
            this.txtEditCorreo.Name = "txtEditCorreo";
            this.txtEditCorreo.Size = new System.Drawing.Size(239, 27);
            this.txtEditCorreo.TabIndex = 47;
            // 
            // txtEditTelf
            // 
            this.txtEditTelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTelf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditTelf.Location = new System.Drawing.Point(836, 263);
            this.txtEditTelf.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditTelf.MaxLength = 9;
            this.txtEditTelf.Name = "txtEditTelf";
            this.txtEditTelf.Size = new System.Drawing.Size(239, 27);
            this.txtEditTelf.TabIndex = 45;
            // 
            // txtEditMaterno
            // 
            this.txtEditMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditMaterno.Location = new System.Drawing.Point(309, 402);
            this.txtEditMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditMaterno.Name = "txtEditMaterno";
            this.txtEditMaterno.Size = new System.Drawing.Size(239, 27);
            this.txtEditMaterno.TabIndex = 43;
            // 
            // txtEditPaterno
            // 
            this.txtEditPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditPaterno.Location = new System.Drawing.Point(309, 330);
            this.txtEditPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditPaterno.Name = "txtEditPaterno";
            this.txtEditPaterno.Size = new System.Drawing.Size(239, 27);
            this.txtEditPaterno.TabIndex = 41;
            // 
            // txtEditNombre
            // 
            this.txtEditNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditNombre.Location = new System.Drawing.Point(309, 266);
            this.txtEditNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditNombre.Name = "txtEditNombre";
            this.txtEditNombre.Size = new System.Drawing.Size(239, 27);
            this.txtEditNombre.TabIndex = 38;
            // 
            // txtEditDNI
            // 
            this.txtEditDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEditDNI.Location = new System.Drawing.Point(309, 198);
            this.txtEditDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditDNI.MaxLength = 8;
            this.txtEditDNI.Name = "txtEditDNI";
            this.txtEditDNI.Size = new System.Drawing.Size(239, 27);
            this.txtEditDNI.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(207, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "DNI";
            // 
            // btnActualizarInformacion
            // 
            this.btnActualizarInformacion.BackColor = System.Drawing.Color.Gainsboro;
            this.btnActualizarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInformacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnActualizarInformacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnActualizarInformacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnActualizarInformacion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnActualizarInformacion.IconSize = 16;
            this.btnActualizarInformacion.Location = new System.Drawing.Point(522, 490);
            this.btnActualizarInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarInformacion.Name = "btnActualizarInformacion";
            this.btnActualizarInformacion.Rotation = 0D;
            this.btnActualizarInformacion.Size = new System.Drawing.Size(160, 49);
            this.btnActualizarInformacion.TabIndex = 51;
            this.btnActualizarInformacion.Text = "Actualizar";
            this.btnActualizarInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarInformacion.UseVisualStyleBackColor = false;
            this.btnActualizarInformacion.Click += new System.EventHandler(this.btnActualizarInformacion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label7.Location = new System.Drawing.Point(664, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label8.Location = new System.Drawing.Point(688, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label9.Location = new System.Drawing.Point(672, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label10.Location = new System.Drawing.Point(72, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "Apellido Materno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label11.Location = new System.Drawing.Point(77, 334);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Apellido Paterno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label12.Location = new System.Drawing.Point(62, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(479, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Actualice los campos que considere necesarios";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label13.Location = new System.Drawing.Point(162, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 39;
            this.label13.Text = "Nombre";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            this.tabCrearCliente.ResumeLayout(false);
            this.tabCrearCliente.PerformLayout();
            this.tabMantenimientoCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBusquedaClientes;
        private FontAwesome.Sharp.IconButton btnVerTodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditRUC;
        private System.Windows.Forms.TextBox txtEditDireccion;
        private System.Windows.Forms.TextBox txtEditCorreo;
        private System.Windows.Forms.TextBox txtEditTelf;
        private System.Windows.Forms.TextBox txtEditMaterno;
        private System.Windows.Forms.TextBox txtEditPaterno;
        private System.Windows.Forms.TextBox txtEditNombre;
        private System.Windows.Forms.TextBox txtEditDNI;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnActualizarInformacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIdcli;
        private System.Windows.Forms.ComboBox cbxConsultaClientes;
        private FontAwesome.Sharp.IconButton btnConsultarClientes;
    }
}