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
    public partial class frmTareasCRUD : Form
    {
        public frmTareasCRUD()
        {
            InitializeComponent();
        }

        clsTareas Tareas = new clsTareas();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * FROM Tarea";
            Tareas.Mostrar(consulta, dgvTarea);
        }

        private void btnMostrarLugar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * FROM Lugar";
            Tareas.Mostrar(consulta, dgvLugar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedValue != null)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar " + cmbTarea.Text + "?", "Confirmar modificación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    string consulta = "DELETE FROM Tarea WHERE IdTarea = ?";
                    int id = Convert.ToInt32(cmbTarea.SelectedValue);
                    Tareas.Eliminar(consulta, id);
                    Tareas.CargarComboTareas(cmbTarea);


                }
                else
                {
                    MessageBox.Show("No se eliminó el dato", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtTarea.Clear();
                cmbTarea.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione la tarea que desee eliminar.", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            if (cmbLugar.SelectedValue != null)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar " + cmbLugar.Text + "?", "Confirmar modificación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    string consulta = "DELETE FROM Lugar WHERE IdLugar = ?";
                    int id = Convert.ToInt32(cmbLugar.SelectedValue);
                    Tareas.Eliminar(consulta, id);
                    Tareas.CargarComboLugares(cmbLugar);


                }
                else
                {
                    MessageBox.Show("No se eliminó el dato", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtLugar.Clear();
                cmbLugar.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione el lugar que desee eliminar.", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            if (txtLugar.Text == "")
            {
                MessageBox.Show("Ingrese un nuevo lugar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string consulta = "INSERT INTO Lugar (Lugar) VALUES (?)";
                string agregado = txtLugar.Text;
                Tareas.AgregarLugaresYTareas(consulta, agregado);
                MessageBox.Show("Lugar agregado.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tareas.CargarComboLugares(cmbLugar);
                txtLugar.Clear();
                cmbLugar.SelectedIndex = -1;
            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            if(txtTarea.Text == "") 
            {
                MessageBox.Show("Ingrese una nueva tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                string consulta = "INSERT INTO Tarea (Tarea) VALUES (?)";
                string agregado = txtTarea.Text;
                Tareas.AgregarLugaresYTareas(consulta, agregado);
                MessageBox.Show("Tarea agregada.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tareas.CargarComboTareas(cmbTarea);
                txtTarea.Clear();
                cmbTarea.SelectedIndex = -1;
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtTarea.Text != "" && cmbTarea.SelectedValue != null) 
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea reemplazar " + cmbTarea.Text + " por " + txtTarea.Text, "Confirmar modificación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(cmbTarea.SelectedValue);
                    string nuevo = txtTarea.Text.Trim();
                    string consulta = "UPDATE Tarea SET Tarea = ? WHERE IdTarea = ?";

                    Tareas.Modificar(id, nuevo, consulta);
                    MessageBox.Show("Tarea modificada.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tareas.CargarComboTareas(cmbTarea);

                   
                }
                else
                {
                    MessageBox.Show("La modificación fue cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtTarea.Clear();
                cmbTarea.SelectedIndex = -1;
            }
            else 
            {
                MessageBox.Show("Ingrese datos válidos.", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void frmTareasCRUD_Load(object sender, EventArgs e)
        {
            Tareas.CargarComboLugares(cmbLugar);
            Tareas.CargarComboTareas(cmbTarea);
        }

        private void btnModificarLugar_Click(object sender, EventArgs e)
        {
            if (txtLugar.Text != "" && cmbLugar.SelectedValue != null)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea reemplazar " + cmbLugar.Text + " por " + txtLugar.Text, "Confirmar modificación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(cmbLugar.SelectedValue);
                    string nuevo = txtLugar.Text.Trim();
                    string consulta = "UPDATE Lugar SET Lugar = ? WHERE IdLugar = ?";

                    Tareas.Modificar(id, nuevo, consulta);
                    MessageBox.Show("Lugar modificado.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tareas.CargarComboLugares(cmbLugar);


                }
                else
                {
                    MessageBox.Show("La modificación fue cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtLugar.Clear();
                cmbLugar.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos.", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
