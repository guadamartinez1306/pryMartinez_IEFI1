using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryMartinez_IEFI
{
    internal class clsBaseDeDatos
    {
        #region Conexion
        
        private static string ConexionBD =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=UsuariosBD.mdb";
        #endregion

        public static OleDbConnection ConectarBase()
        {
            OleDbConnection conexion = new OleDbConnection(ConexionBD);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return conexion;
        }
      
    }
}
