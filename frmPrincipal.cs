using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;


namespace pryMartinez_IEFI
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        public string usuario;
        public int idCategoria;
        int contarTiempo = 0;
        clsUsuarios login = new clsUsuarios();
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           temporizador.Start();
            if (idCategoria == 1) // operador
            {
                administraciónToolStripMenuItem.Visible = false; // Desactiva el botón de Usuarios
                administrarTareasToolStripMenuItem.Visible = false;
                historialDeTareasToolStripMenuItem.Visible = false;
            }
           lblUsuario.Text = usuario;
           lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            temporizador.Stop();
            TimeSpan tiempo = TimeSpan.FromSeconds(contarTiempo);
            if (usuario == null || tiempo == null) 
            {
                MessageBox.Show("⚠ No se registró el log porque faltan datos.");
            }
            else 
            {
                string tiempoTexto = tiempo.ToString(@"hh\:mm\:ss");
                login.RegistrarLog(usuario, idCategoria, tiempoTexto);
            }
                
        }

        private void auditoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria(); 
            auditoria.Show();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            contarTiempo++;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarModificar frm = new frmAgregarModificar();
            frm.Show();
        }

        private void verTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTareas verTareas = new frmTareas();
            verTareas.Show();
        }

        private void administrarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTareasCRUD verTareas = new frmTareasCRUD();
            verTareas.Show();
        }

        private void historialDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.Show();
        }
    }
}
