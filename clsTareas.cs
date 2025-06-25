using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.MonthCalendar;

namespace pryMartinez_IEFI
{
    internal class clsTareas
    {
        public void Mostrar(String consulta, DataGridView dgv)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string selectQuery = consulta;
                    OleDbCommand cmd = new OleDbCommand(selectQuery, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable tabla = new DataTable();

                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                    dgv.Columns[0].Width = 150; 
                    dgv.Columns[1].Width = 150; 


                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al mostrar: " + ex.Message);
                }
        }

        public void Eliminar(string consulta, int id)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string delete = consulta;
                    OleDbCommand cmd = new OleDbCommand(delete, connection);
                    cmd.Parameters.AddWithValue("", id);

                    int filasafectadas = cmd.ExecuteNonQuery();

                    if (filasafectadas == 0)
                    {
                        MessageBox.Show("Ingrese un dato válido");
                    }
                    else
                    {
                        MessageBox.Show("Se eliminó correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
        }

        public int AgregarRegistro(DateTime fecha, int idTarea, int idLugar)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string sql = "INSERT INTO Registros (Fecha, IdTarea, IdLugar) VALUES (?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(sql, connection);

                    cmd.Parameters.Add("?", OleDbType.Date).Value = fecha.Date;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idTarea;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idLugar;

                    cmd.ExecuteNonQuery();

                    //Recuperar el último ID generado
                    OleDbCommand cmdId = new OleDbCommand("SELECT @@IDENTITY", connection);
                    int idRegistro = Convert.ToInt32(cmdId.ExecuteScalar());

                    return idRegistro; //Devuelve el ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; //En caso de error devuelve -1
                }


        }


        public void GrabarDetalle(int idRegistro, bool insumo, bool estudio, bool vacaciones, bool salario, bool recibo, string comentario)
        {
           
                using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                 try
                 {
                    string sql = "INSERT INTO Detalle (ComentarioTarea, Insumo, Estudio, Vacacion, Salario, Recibo, IdRegistrarTarea) VALUES (?, ?, ?, ?, ?, ?, ?)";

                    

                    OleDbCommand cmd = new OleDbCommand(sql, connection);

                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = comentario;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = insumo;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = estudio;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = vacaciones;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = salario;
                    cmd.Parameters.Add("?", OleDbType.Boolean).Value = recibo;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = idRegistro;

                    cmd.ExecuteNonQuery();
                 }
                 catch (Exception ex)
                 {
                      MessageBox.Show("Error al grabar los detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }

        public void AgregarLugaresYTareas(string consulta, string agregado)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string insert = consulta;
                    OleDbCommand cmd = new OleDbCommand(insert, connection);
                    cmd.Parameters.AddWithValue("?", OleDbType.VarChar).Value = agregado;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
        }

        public void Modificar(int id, string nuevo, string consulta)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string sql = consulta;
                    OleDbCommand cmd = new OleDbCommand(sql, connection);
                    cmd.Parameters.AddWithValue("?", nuevo);
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
        }

        public void CargarComboTareas(ComboBox combo)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string sql = "SELECT IdTarea, Tarea FROM Tarea";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "Tarea";
                    combo.ValueMember = "IdTarea";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar combo de tarea: " + ex.Message);
                }
        }

        public void CargarComboLugares(ComboBox combo)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string sql = "SELECT IdLugar, Lugar FROM Lugar";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    combo.DataSource = dt;
                    combo.DisplayMember = "Lugar";
                    combo.ValueMember = "IdLugar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar combo de lugar: " + ex.Message);
                }
        }

    }
}
