using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBackup
    {
        // Ejecuta el procedimiento backup_libertel en db_libertel.
        public string BackupDatabase(string backupFilePath)
        {
            try
            {
                using (SqlConnection cn = Conexion.getInstancia().CrearConexion())
                using (SqlCommand cmd = new SqlCommand("backup_libertel", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@backupPath", SqlDbType.NVarChar, 500)
                                .Value = backupFilePath;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Ejecuta el procedimiento restore_libertel en la base master.
        public string RestoreDatabase(string backupFilePath)
        {
            try
            {
                //Preparamos conexión a master ya que no se puede hacer el backup sobre una base de datos
                //Utilizada en el momento de hacer la restauracion.
                var baseConn = Conexion.getInstancia().CrearConexion();
                var builder = new SqlConnectionStringBuilder(baseConn.ConnectionString)
                {
                    InitialCatalog = "master"
                };
                using (SqlConnection cn = new SqlConnection(builder.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("restore_libertel", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@backupPath", SqlDbType.NVarChar, 500)
                                .Value = backupFilePath;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
