namespace pryMartinez_IEFI
{
    partial class frmAgregarModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarModificar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.MaskedTextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbCategoriaMod = new System.Windows.Forms.ComboBox();
            this.lblCategoriaMod = new System.Windows.Forms.Label();
            this.lblContraseñaMod = new System.Windows.Forms.Label();
            this.lblUsuarioMod = new System.Windows.Forms.Label();
            this.txtContraseñaMod = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuarioMod = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblContraseñaEliminar = new System.Windows.Forms.Label();
            this.lblUsuarioEliminar = new System.Windows.Forms.Label();
            this.txtContraseñaEliminar = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuarioEliminar = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 749);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar y Modificar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.lblDomicilio);
            this.groupBox5.Controls.Add(this.txtDomicilio);
            this.groupBox5.Controls.Add(this.lblCorreo);
            this.groupBox5.Controls.Add(this.lblTelefono);
            this.groupBox5.Controls.Add(this.txtCorreo);
            this.groupBox5.Controls.Add(this.txtTelefono);
            this.groupBox5.Controls.Add(this.lblFecha);
            this.groupBox5.Controls.Add(this.lblApellido);
            this.groupBox5.Controls.Add(this.lblNombre);
            this.groupBox5.Controls.Add(this.dtpFechaNac);
            this.groupBox5.Controls.Add(this.txtApellido);
            this.groupBox5.Controls.Add(this.txtNombre);
            this.groupBox5.Location = new System.Drawing.Point(131, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(500, 419);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Personales";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(22, 348);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(83, 21);
            this.lblDomicilio.TabIndex = 17;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(244, 345);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(189, 29);
            this.txtDomicilio.TabIndex = 16;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(22, 286);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 21);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 228);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 21);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(244, 283);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(189, 29);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(244, 225);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 29);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 168);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(168, 21);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha de nacimiento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 106);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(76, 21);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(244, 163);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(189, 29);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(244, 103);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(189, 29);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblSeleccionar);
            this.groupBox1.Controls.Add(this.cmbUsuarios);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.cmbCategoriaMod);
            this.groupBox1.Controls.Add(this.lblCategoriaMod);
            this.groupBox1.Controls.Add(this.lblContraseñaMod);
            this.groupBox1.Controls.Add(this.lblUsuarioMod);
            this.groupBox1.Controls.Add(this.txtContraseñaMod);
            this.groupBox1.Controls.Add(this.txtUsuarioMod);
            this.groupBox1.Location = new System.Drawing.Point(131, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 274);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Usuario";
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(24, 50);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(157, 21);
            this.lblSeleccionar.TabIndex = 15;
            this.lblSeleccionar.Text = "Seleccionar usuario:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(247, 47);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(189, 29);
            this.cmbUsuarios.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificar.Location = new System.Drawing.Point(783, 201);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(189, 48);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbCategoriaMod
            // 
            this.cmbCategoriaMod.FormattingEnabled = true;
            this.cmbCategoriaMod.Location = new System.Drawing.Point(783, 129);
            this.cmbCategoriaMod.Name = "cmbCategoriaMod";
            this.cmbCategoriaMod.Size = new System.Drawing.Size(189, 29);
            this.cmbCategoriaMod.TabIndex = 12;
            // 
            // lblCategoriaMod
            // 
            this.lblCategoriaMod.AutoSize = true;
            this.lblCategoriaMod.Location = new System.Drawing.Point(607, 132);
            this.lblCategoriaMod.Name = "lblCategoriaMod";
            this.lblCategoriaMod.Size = new System.Drawing.Size(85, 21);
            this.lblCategoriaMod.TabIndex = 10;
            this.lblCategoriaMod.Text = "Categoría:";
            // 
            // lblContraseñaMod
            // 
            this.lblContraseñaMod.AutoSize = true;
            this.lblContraseñaMod.Location = new System.Drawing.Point(607, 50);
            this.lblContraseñaMod.Name = "lblContraseñaMod";
            this.lblContraseñaMod.Size = new System.Drawing.Size(96, 21);
            this.lblContraseñaMod.TabIndex = 8;
            this.lblContraseñaMod.Text = "Contraseña:";
            // 
            // lblUsuarioMod
            // 
            this.lblUsuarioMod.AutoSize = true;
            this.lblUsuarioMod.Location = new System.Drawing.Point(24, 132);
            this.lblUsuarioMod.Name = "lblUsuarioMod";
            this.lblUsuarioMod.Size = new System.Drawing.Size(121, 21);
            this.lblUsuarioMod.TabIndex = 7;
            this.lblUsuarioMod.Text = "Nuevo usuario:";
            // 
            // txtContraseñaMod
            // 
            this.txtContraseñaMod.Location = new System.Drawing.Point(783, 47);
            this.txtContraseñaMod.Name = "txtContraseñaMod";
            this.txtContraseñaMod.Size = new System.Drawing.Size(189, 29);
            this.txtContraseñaMod.TabIndex = 5;
            // 
            // txtUsuarioMod
            // 
            this.txtUsuarioMod.Location = new System.Drawing.Point(247, 129);
            this.txtUsuarioMod.Name = "txtUsuarioMod";
            this.txtUsuarioMod.Size = new System.Drawing.Size(189, 29);
            this.txtUsuarioMod.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.lblContraseña);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Location = new System.Drawing.Point(714, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 419);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Usuario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgregar.Location = new System.Drawing.Point(200, 338);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(189, 48);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(200, 234);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(189, 29);
            this.cmbCategoria.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(24, 237);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(85, 21);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(24, 168);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 21);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(24, 98);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 21);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(200, 165);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(189, 29);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(200, 95);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 29);
            this.txtUsuario.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar y Listar";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.btnListar);
            this.groupBox4.Controls.Add(this.dgvUsuarios);
            this.groupBox4.Location = new System.Drawing.Point(576, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 512);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listar Usuarios";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnListar.Location = new System.Drawing.Point(373, 441);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(189, 48);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(37, 43);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(525, 370);
            this.dgvUsuarios.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.lblContraseñaEliminar);
            this.groupBox3.Controls.Add(this.lblUsuarioEliminar);
            this.groupBox3.Controls.Add(this.txtContraseñaEliminar);
            this.groupBox3.Controls.Add(this.txtUsuarioEliminar);
            this.groupBox3.Location = new System.Drawing.Point(109, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 512);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Usuario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminar.Location = new System.Drawing.Point(200, 441);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(189, 48);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblContraseñaEliminar
            // 
            this.lblContraseñaEliminar.AutoSize = true;
            this.lblContraseñaEliminar.Location = new System.Drawing.Point(24, 158);
            this.lblContraseñaEliminar.Name = "lblContraseñaEliminar";
            this.lblContraseñaEliminar.Size = new System.Drawing.Size(96, 21);
            this.lblContraseñaEliminar.TabIndex = 8;
            this.lblContraseñaEliminar.Text = "Contraseña:";
            // 
            // lblUsuarioEliminar
            // 
            this.lblUsuarioEliminar.AutoSize = true;
            this.lblUsuarioEliminar.Location = new System.Drawing.Point(24, 46);
            this.lblUsuarioEliminar.Name = "lblUsuarioEliminar";
            this.lblUsuarioEliminar.Size = new System.Drawing.Size(69, 21);
            this.lblUsuarioEliminar.TabIndex = 7;
            this.lblUsuarioEliminar.Text = "Usuario:";
            // 
            // txtContraseñaEliminar
            // 
            this.txtContraseñaEliminar.Location = new System.Drawing.Point(200, 155);
            this.txtContraseñaEliminar.Name = "txtContraseñaEliminar";
            this.txtContraseñaEliminar.Size = new System.Drawing.Size(189, 29);
            this.txtContraseñaEliminar.TabIndex = 5;
            // 
            // txtUsuarioEliminar
            // 
            this.txtUsuarioEliminar.Location = new System.Drawing.Point(200, 43);
            this.txtUsuarioEliminar.Name = "txtUsuarioEliminar";
            this.txtUsuarioEliminar.Size = new System.Drawing.Size(189, 29);
            this.txtUsuarioEliminar.TabIndex = 2;
            // 
            // frmAgregarModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1288, 749);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAgregarModificar";
            this.Text = "Administrar Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgregarModificar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbCategoriaMod;
        private System.Windows.Forms.Label lblCategoriaMod;
        private System.Windows.Forms.Label lblContraseñaMod;
        private System.Windows.Forms.Label lblUsuarioMod;
        private System.Windows.Forms.MaskedTextBox txtContraseñaMod;
        private System.Windows.Forms.MaskedTextBox txtUsuarioMod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MaskedTextBox txtContraseña;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblContraseñaEliminar;
        private System.Windows.Forms.Label lblUsuarioEliminar;
        private System.Windows.Forms.MaskedTextBox txtContraseñaEliminar;
        private System.Windows.Forms.MaskedTextBox txtUsuarioEliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.MaskedTextBox txtDomicilio;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtCorreo;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}