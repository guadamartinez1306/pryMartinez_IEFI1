namespace pryMartinez_IEFI
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.dgvAuditoría = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.Auditoría = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoría)).BeginInit();
            this.Auditoría.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuditoría
            // 
            this.dgvAuditoría.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvAuditoría.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoría.Location = new System.Drawing.Point(68, 66);
            this.dgvAuditoría.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAuditoría.Name = "dgvAuditoría";
            this.dgvAuditoría.RowHeadersWidth = 51;
            this.dgvAuditoría.RowTemplate.Height = 24;
            this.dgvAuditoría.Size = new System.Drawing.Size(718, 324);
            this.dgvAuditoría.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMostrar.Location = new System.Drawing.Point(670, 404);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 40);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Auditoría
            // 
            this.Auditoría.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Auditoría.BackColor = System.Drawing.Color.SandyBrown;
            this.Auditoría.Controls.Add(this.btnMostrar);
            this.Auditoría.Controls.Add(this.dgvAuditoría);
            this.Auditoría.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auditoría.Location = new System.Drawing.Point(76, 82);
            this.Auditoría.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Auditoría.Name = "Auditoría";
            this.Auditoría.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Auditoría.Size = new System.Drawing.Size(856, 456);
            this.Auditoría.TabIndex = 2;
            this.Auditoría.TabStop = false;
            this.Auditoría.Text = "Auditoría";
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1007, 609);
            this.Controls.Add(this.Auditoría);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoría";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoría)).EndInit();
            this.Auditoría.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditoría;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox Auditoría;
    }
}