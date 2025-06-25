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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        clsTareas Tareas = new clsTareas();

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT Lugar.Lugar, Registros.Fecha, Tarea.Tarea, Detalle.Insumo, Detalle.Estudio, Detalle.Vacacion, Detalle.Salario, Detalle.Recibo, Detalle.ComentarioTarea\r\nFROM (Lugar INNER JOIN (Tarea INNER JOIN Registros ON Tarea.IdTarea = Registros.IdTarea) ON Lugar.IdLugar = Registros.IdLugar) INNER JOIN Detalle ON Registros.IdRegistrarTarea = Detalle.IdRegistrarTarea;\r\n";
            Tareas.Mostrar(consulta, dgvHistorial);
        }
    }
}
