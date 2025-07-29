using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NBackup
    {
        //Llamado a la capa Datos para realizar el backup
        public static string Backup(string backupFilePath)
        {
            DBackup datos = new DBackup();
            return datos.BackupDatabase(backupFilePath);
        }

        //Llamado a la capa datos Restore del backup
        public static string Restore(string backupFilePath)
        {
            DBackup datos = new DBackup();
            return datos.RestoreDatabase(backupFilePath);
        }
    }
}
