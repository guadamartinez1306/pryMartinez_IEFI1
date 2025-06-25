namespace pryMartinez_IEFI
{
    partial class frmTareasCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareasCRUD));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvTarea = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMostrarLugar = new System.Windows.Forms.Button();
            this.dgvLugar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarLugar = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnModificarLugar = new System.Windows.Forms.Button();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1092, 715);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnMostrar);
            this.groupBox3.Controls.Add(this.dgvTarea);
            this.groupBox3.Location = new System.Drawing.Point(59, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(968, 339);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar tareas:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMostrar.Location = new System.Drawing.Point(385, 280);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(199, 41);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvTarea
            // 
            this.dgvTarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTarea.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarea.Location = new System.Drawing.Point(193, 45);
            this.dgvTarea.Name = "dgvTarea";
            this.dgvTarea.RowHeadersWidth = 51;
            this.dgvTarea.RowTemplate.Height = 24;
            this.dgvTarea.Size = new System.Drawing.Size(582, 212);
            this.dgvTarea.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cmbTarea);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblTarea);
            this.groupBox1.Controls.Add(this.txtTarea);
            this.groupBox1.Location = new System.Drawing.Point(59, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar tareas:";
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.ItemHeight = 21;
            this.cmbTarea.Location = new System.Drawing.Point(268, 190);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(199, 29);
            this.cmbTarea.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminar.Location = new System.Drawing.Point(697, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(199, 41);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificar.Location = new System.Drawing.Point(697, 121);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(199, 41);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgregar.Location = new System.Drawing.Point(697, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(42, 193);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(139, 21);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Seleccione Tarea:";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(42, 61);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(54, 21);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Tarea:";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(268, 58);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(199, 33);
            this.txtTarea.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1092, 715);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lugares";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.btnMostrarLugar);
            this.groupBox4.Controls.Add(this.dgvLugar);
            this.groupBox4.Location = new System.Drawing.Point(59, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(968, 339);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listar lugares:";
            // 
            // btnMostrarLugar
            // 
            this.btnMostrarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMostrarLugar.Location = new System.Drawing.Point(385, 280);
            this.btnMostrarLugar.Name = "btnMostrarLugar";
            this.btnMostrarLugar.Size = new System.Drawing.Size(199, 41);
            this.btnMostrarLugar.TabIndex = 11;
            this.btnMostrarLugar.Text = "MOSTRAR";
            this.btnMostrarLugar.UseVisualStyleBackColor = false;
            this.btnMostrarLugar.Click += new System.EventHandler(this.btnMostrarLugar_Click);
            // 
            // dgvLugar
            // 
            this.dgvLugar.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvLugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugar.Location = new System.Drawing.Point(193, 45);
            this.dgvLugar.Name = "dgvLugar";
            this.dgvLugar.RowHeadersWidth = 51;
            this.dgvLugar.RowTemplate.Height = 24;
            this.dgvLugar.Size = new System.Drawing.Size(582, 212);
            this.dgvLugar.TabIndex = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnEliminarLugar);
            this.groupBox6.Controls.Add(this.cmbLugar);
            this.groupBox6.Controls.Add(this.btnModificarLugar);
            this.groupBox6.Controls.Add(this.btnAgregarLugar);
            this.groupBox6.Controls.Add(this.lblLugar);
            this.groupBox6.Controls.Add(this.txtLugar);
            this.groupBox6.Location = new System.Drawing.Point(59, 36);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(974, 283);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Administrar lugares:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione Lugar:";
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminarLugar.Location = new System.Drawing.Point(697, 187);
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.Size = new System.Drawing.Size(199, 41);
            this.btnEliminarLugar.TabIndex = 5;
            this.btnEliminarLugar.Text = "ELIMINAR";
            this.btnEliminarLugar.UseVisualStyleBackColor = false;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.ItemHeight = 21;
            this.cmbLugar.Location = new System.Drawing.Point(268, 190);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(199, 29);
            this.cmbLugar.TabIndex = 6;
            // 
            // btnModificarLugar
            // 
            this.btnModificarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificarLugar.Location = new System.Drawing.Point(697, 121);
            this.btnModificarLugar.Name = "btnModificarLugar";
            this.btnModificarLugar.Size = new System.Drawing.Size(199, 41);
            this.btnModificarLugar.TabIndex = 2;
            this.btnModificarLugar.Text = "MODIFICAR";
            this.btnModificarLugar.UseVisualStyleBackColor = false;
            this.btnModificarLugar.Click += new System.EventHandler(this.btnModificarLugar_Click);
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgregarLugar.Location = new System.Drawing.Point(697, 55);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(199, 41);
            this.btnAgregarLugar.TabIndex = 2;
            this.btnAgregarLugar.Text = "AGREGAR";
            this.btnAgregarLugar.UseVisualStyleBackColor = false;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(42, 61);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(55, 21);
            this.lblLugar.TabIndex = 1;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(268, 58);
            this.txtLugar.Multiline = true;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(199, 33);
            this.txtLugar.TabIndex = 0;
            // 
            // frmTareasCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTareasCRUD";
            this.Text = "Administrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTareasCRUD_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvTarea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Button btnMostrarLugar;
        private System.Windows.Forms.DataGridView dgvLugar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnModificarLugar;
        private System.Windows.Forms.Button btnEliminarLugar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Label label1;
    }
}