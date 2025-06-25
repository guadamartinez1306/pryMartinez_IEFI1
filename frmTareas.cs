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
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }
        clsTareas Tareas = new clsTareas();
        int idUltimoRegistro = -1;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea agregar " + cmbTarea.Text + " en " + cmbLugar.Text + "?", "Confirmar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                DateTime fecha = dtpFecha.Value.Date; // solo fecha, sin hora
                int idTarea = Convert.ToInt32(cmbTarea.SelectedValue);
                int idLugar = Convert.ToInt32(cmbLugar.SelectedValue);
                string consulta = "SELECT T.Tarea, R.Fecha, L.Lugar " +
                  "FROM (Registros AS R " +
                  "INNER JOIN Tarea AS T ON R.IdTarea = T.IdTarea) " +
                  "INNER JOIN Lugar AS L ON R.IdLugar = L.IdLugar " +
                  "ORDER BY R.Fecha DESC";

                idUltimoRegistro = Tareas.AgregarRegistro(fecha, idTarea, idLugar);

                if (idUltimoRegistro > 0)
                {
                    MessageBox.Show("La tarea fue agregada correctamente.", "Tarea agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTareas.Rows.Clear();
                    Tareas.Mostrar(consulta, dgvTareas);

                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del registro insertado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("La tarea fue cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void frmTareas_Load(object sender, EventArgs e)
        {
            Tareas.CargarComboLugares(cmbLugar);
            Tareas.CargarComboTareas(cmbTarea);

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (idUltimoRegistro != -1)
            {
                
                if (txtComentario.Text != "")
                {

                    bool insumo = chkInsumo.Checked;
                    bool estudio = chkEstudio.Checked;
                    bool vacaciones = chkVacacion.Checked;
                    bool salario = chkSalario.Checked;
                    bool recibo = chkRecibo.Checked;
                    string comentario = txtComentario.Text;


                    Tareas.GrabarDetalle(idUltimoRegistro, insumo, estudio, vacaciones, salario, recibo, comentario);

                    MessageBox.Show("Detalle grabado correctamente.", "Detalle guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    chkInsumo.Checked = false;
                    chkEstudio.Checked = false;
                    chkVacacion.Checked = false;
                    chkSalario.Checked = false;
                    chkRecibo.Checked = false;
                    txtComentario.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un comentario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Primero debes agregar una tarea antes de grabar los detalles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
