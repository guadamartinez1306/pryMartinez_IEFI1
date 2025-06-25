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
using System.Reflection;



namespace pryMartinez_IEFI
{
    internal class clsUsuarios
    {

        public void CargarCategorias(ComboBox cmbCategoria)
        {
            try
            {
                using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                {
                    string sql = "SELECT IdCategoria, Categoria FROM Categorias";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategoria.DataSource = dt;
                    cmbCategoria.DisplayMember = "Categoria";            // lo que se ve
                    cmbCategoria.ValueMember = "IdCategoria";           // lo que se guarda
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        public void CargarUsuarios(ComboBox cmbUsuario)
        {
            try
            {
                using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                {
                    string sql = "SELECT IdUsuario, Usuario FROM Usuarios";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbUsuario.DataSource = dt;
                    cmbUsuario.DisplayMember = "Usuario";            // lo que se ve
                    cmbUsuario.ValueMember = "IdUsuario";           // lo que se guarda
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }


        public void Mostrar(DataGridView dgvLogs)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string selectQuery = "SELECT Logs.Usuario, Logs.FechaHora, Logs.TiempoPantalla FROM Logs";
                    OleDbCommand cmd = new OleDbCommand(selectQuery, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable tabla = new DataTable();

                    adapter.Fill(tabla);
                    dgvLogs.DataSource = tabla;
                    dgvLogs.Columns[0].Width = 150;
                    dgvLogs.Columns[1].Width = 150;
                    dgvLogs.Columns[2].Width = 150;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al listar: " + ex.Message);
                }
        } 

        public DataRow BuscarUsuario(string usuario, string contraseña)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
            try
            {
                string consulta = "SELECT * FROM Usuarios WHERE Usuario = ? AND Contraseña = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, connection);
                cmd.Parameters.AddWithValue("?", usuario);
                cmd.Parameters.AddWithValue("?", contraseña);

                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0) 
                {
                        return tabla.Rows[0];
                } 
                else 
                {
                        return null;
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
                return null;
            }
        }

        public void RegistrarLog(string nombreUsuario, int idCategoria, string tiempo)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
            try
            {
                string insert = "INSERT INTO Logs (Usuario, IdCategoria, FechaHora, TiempoPantalla) VALUES (?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(insert, connection);

                    cmd.Parameters.AddWithValue("?", nombreUsuario);
                    cmd.Parameters.AddWithValue("?", idCategoria);
                    cmd.Parameters.AddWithValue("?", DateTime.Now.Date); 
                    cmd.Parameters.AddWithValue("?", tiempo);

                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar log: " + ex.Message);
            }
        }


        public void Agregar(string usuario, string contraseña, int idCategoria, string nombre, string apellido, DateTime fechaNac, string telefono, string correo, string domicilio) 
        {
            int nuevoIdUsuario = 0;
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string sqlUsuarios = "INSERT INTO Usuarios (Usuario, Contraseña, IdCategoria, FechaCreado, UltimaModificacion) " +
                         "VALUES (?, ?, ?, ?, ?)";

                    OleDbCommand cmd1 = new OleDbCommand(sqlUsuarios, connection);
                    cmd1.Parameters.AddWithValue("?", usuario);
                    cmd1.Parameters.AddWithValue("?", contraseña);
                    cmd1.Parameters.AddWithValue("?", idCategoria);
                    cmd1.Parameters.AddWithValue("?", OleDbType.Date).Value = DateTime.Now.Date;
                    cmd1.Parameters.AddWithValue("?", OleDbType.Date).Value = DateTime.Now.Date;
                    cmd1.ExecuteNonQuery();

                    // 2. Obtener el ID generado
                    OleDbCommand cmd2 = new OleDbCommand("SELECT @@IDENTITY", connection);
                    nuevoIdUsuario = Convert.ToInt32(cmd2.ExecuteScalar());

                    // 3. Insertar en la tabla DatosPersonales con ese ID
                    string sqlDatos = "INSERT INTO DatosPersonales (IdUsuario, Nombre, Apellido, FechaNac, Telefono, Correo, Domicilio) " +
                                      "VALUES (?, ?, ?, ?, ?, ?, ?)";

                    OleDbCommand cmd3 = new OleDbCommand(sqlDatos, connection);
                    cmd3.Parameters.AddWithValue("?", nuevoIdUsuario);
                    cmd3.Parameters.AddWithValue("?", nombre);
                    cmd3.Parameters.AddWithValue("?", apellido);
                    cmd3.Parameters.Add("?", OleDbType.Date).Value = fechaNac.Date;
                    cmd3.Parameters.AddWithValue("?", telefono);
                    cmd3.Parameters.AddWithValue("?", correo);
                    cmd3.Parameters.AddWithValue("?", domicilio);
                    cmd3.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
        }



        
        public void Modificar(int id, string nuevoUsuario, string nuevoContraseña, int idCategoria)
        {

            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string sql = "UPDATE Usuarios SET Usuario = ?, Contraseña = ?, IdCategoria = ?, UltimaModificacion = ? WHERE IdUsuario = ?";
                    OleDbCommand cmd = new OleDbCommand(sql, connection);
                    cmd.Parameters.AddWithValue("?", nuevoUsuario);
                    cmd.Parameters.AddWithValue("?", nuevoContraseña);
                    cmd.Parameters.AddWithValue("?", idCategoria);
                    cmd.Parameters.AddWithValue("?", OleDbType.Date).Value = DateTime.Now.Date;
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
        }

        public void Listar(DataGridView grilla) 
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
                try
                {
                    string listar = "SELECT Usuarios.Usuario, Categorias.Categoria, DatosPersonales.Nombre, DatosPersonales.Apellido, DatosPersonales.Telefono " +
                                    "FROM (Usuarios INNER JOIN Categorias ON Usuarios.IdCategoria = Categorias.IdCategoria) " +
                                    "INNER JOIN DatosPersonales ON Usuarios.IdUsuario = DatosPersonales.IdUsuario";

                    OleDbDataAdapter da = new OleDbDataAdapter(listar, connection);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    grilla.DataSource = tabla;

                    grilla.Columns[0].Width = 150;
                    grilla.Columns[1].Width = 150;
                    grilla.Columns[2].Width = 150;
                    grilla.Columns[3].Width = 150;
                    grilla.Columns[4].Width = 150;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar usuario: " + ex.Message);
                }
        }

        public void Eliminar(string usuario)
        {
            using (OleDbConnection connection = clsBaseDeDatos.ConectarBase())
            try
            {
                    string delete = "DELETE FROM Usuarios WHERE Usuario = ?";
                    OleDbCommand cmd = new OleDbCommand(delete, connection);
                    cmd.Parameters.AddWithValue("", usuario);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }
    }
}
