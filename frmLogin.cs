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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsUsuarios login = new clsUsuarios();
        public string usuario;
        public int idCategoria;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            var fila = login.BuscarUsuario(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());

            if (fila != null)
            {
                usuario = fila["Usuario"].ToString();
                idCategoria = Convert.ToInt32(fila["IdCategoria"]);

                MessageBox.Show("Bienvenido " + usuario);

                frmPrincipal nuevoForm = new frmPrincipal();
                nuevoForm.usuario = usuario;
                nuevoForm.idCategoria = idCategoria;
                nuevoForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
