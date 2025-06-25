using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMartinez_IEFI
{
    public partial class frmAgregarModificar : Form
    {
        public frmAgregarModificar()
        {
            InitializeComponent();
        }
        clsUsuarios usuarios = new clsUsuarios();

        private void frmAgregarModificar_Load(object sender, EventArgs e)
        {
            usuarios.CargarCategorias(cmbCategoria);
            usuarios.CargarCategorias(cmbCategoriaMod);
            usuarios.CargarUsuarios(cmbUsuarios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtCorreo.Text != "" && txtDomicilio.Text != "" && txtUsuario.Text != "" && txtContraseña.Text != "" && cmbCategoria.SelectedIndex != -1)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea agregar este usuario?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    DateTime fecha = dtpFechaNac.Value.Date;
                    usuarios.Agregar(txtUsuario.Text, txtContraseña.Text, Convert.ToInt32(cmbCategoria.SelectedValue), txtNombre.Text, txtApellido.Text, fecha, txtTelefono.Text, txtCorreo.Text, txtDomicilio.Text);
                    MessageBox.Show("Usuario agregado.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuarios.CargarUsuarios(cmbUsuarios);
                }
                else
                {
                    MessageBox.Show("No se agregó el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtDomicilio.Clear();
                txtUsuario.Clear();
                txtContraseña.Clear();
                dtpFechaNac = null;
                cmbCategoria.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioMod.Text != "" && cmbUsuarios.SelectedValue != null && txtContraseñaMod.Text != "" && cmbCategoriaMod.SelectedValue != null)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea modificar este usuario?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(cmbUsuarios.SelectedValue);
                    string nuevoUsuario = txtUsuarioMod.Text.Trim();
                    string nuevoContraseña = txtContraseñaMod.Text.Trim();
                    int idCategoria = Convert.ToInt32(cmbCategoriaMod.SelectedValue);

                    usuarios.Modificar(id, nuevoUsuario, nuevoContraseña, idCategoria);
                    MessageBox.Show("Usuario modificado.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuarios.CargarUsuarios(cmbUsuarios);


                }
                else
                {
                    MessageBox.Show("La modificación fue cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtUsuarioMod.Clear();
                cmbUsuarios.SelectedIndex = -1;
                txtContraseñaMod.Clear();
                cmbCategoriaMod.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos.", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            var fila = usuarios.BuscarUsuario(txtUsuarioEliminar.Text.Trim(), txtContraseñaEliminar.Text.Trim());

            if (fila != null)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    usuarios.Eliminar(txtUsuarioEliminar.Text);
                    
                }
                else
                {
                    MessageBox.Show("No se eliminó el usuario", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtUsuarioEliminar.Clear();
                txtContraseñaEliminar.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            usuarios.Listar(dgvUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
