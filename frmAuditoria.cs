using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMartinez_IEFI
{
    public partial class frmAuditoria : Form
    {
        
        public frmAuditoria()
        {
            InitializeComponent();
            
        }
        clsUsuarios usuario = new clsUsuarios();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            usuario.Mostrar(dgvAuditoría);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Close();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {

        }
    }
}
