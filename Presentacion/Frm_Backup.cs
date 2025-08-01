using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Utilidades; //Para usar InputBox sin crear un form extra.

namespace Presentacion
{
    public partial class Frm_Backup : Form
    {
        //Carpeta donde se guardan los .bak de las copias de seguridad.
        private readonly string backupFolder;

        // Leer la contraseña desde appSettings
        //private readonly string restorePassword = ConfigurationManager.AppSettings["RestorePassword"];

        private readonly string restorePassword = Properties.Settings.Default.RestorePassword;


        public Frm_Backup()
        {
            InitializeComponent();

            //Carpeta base en ProgramData\Libertel\Backups
            string baseDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "Libertel", "Backups");
            if (!Directory.Exists(baseDir))
                Directory.CreateDirectory(baseDir);

            backupFolder = baseDir;

            //Llenar la lista de los backups disponibles.
            RefreshBackupList();

        }

        private void Frm_Backup_Load(object sender, EventArgs e)
        {
            //cargar y llenar la lista de backups disponibles para el list box
            RefreshBackupList();

        }

        //Método refrescar y llenar la lista de backaups disponibles
        private void RefreshBackupList()
        {
            LBCopiasAnteriores.Items.Clear();
            var files = Directory
                .GetFiles(backupFolder, "*.bak")
                .Select(Path.GetFileName)
                .OrderByDescending(n => n);

            foreach (var f in files)
                LBCopiasAnteriores.Items.Add(f);

            //Actualiza etiquetas de última copia
            LblUltimaCopia.Text = files.FirstOrDefault() is string latest
                ? $"Última copia: {latest}"
                : "No hay copias disponibles";
        }

        //Metodo para realizar la copia de seguridad presionando un botón.
        private void BtnCopiaSeguridad_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Filter = "Backup (*.bak)|*.bak",
                InitialDirectory = backupFolder,
                // Generamos un nombre con fecha y hora legibles
                FileName = $"CopiaSeguridad_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.bak"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                string resultado = NBackup.Backup(sfd.FileName);
                if (resultado == "OK")
                {
                    MessageBox.Show("Backup creado con éxito.", "Backup",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshBackupList();
                }
                else
                {
                    MessageBox.Show($"Error al crear backup:\n{resultado}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        //Método para cargar copia de seguridad desde la lista disponible en la list box
        //Selecciona un elemento (copia de seguridad) desde la lista para hacer el backup
        private void BtnCargarCopia_Click(object sender, EventArgs e)
        {
            // 1) Pedir contraseña
            string input = Frm_clave.ShowDialog(
                "Ingrese la contraseña de restauración:",
                "Contraseña requerida"
            );

            //2)Si input es null => Cancel o cerró, salimos sin mensaje
            if (input == null) return;

            //CONTROL: Mostramos en un MessageBox los dos valores entre comillas
            //MessageBox.Show(
            //    $"Valor ingresado:  '{input}'\n" +
            //    $"Valor esperado:   '{restorePassword}'",
            //    "DEBUG Contraseña",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            // );

            //Si se ingresa de forma incorrecta la contraseña
            if (!string.Equals(input.Trim(), restorePassword.Trim(),
                       StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "Contraseña incorrecta. No se realizará la restauración.",
                    "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }

            // 2)Ya autenticado, continúa con el flujo normal:
            if (LBCopiasAnteriores.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una copia de la lista.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string elegido = LBCopiasAnteriores.SelectedItem.ToString();
            string rutaBak = Path.Combine(backupFolder, elegido);

            var dr = MessageBox.Show(
                $"Se va a RESTAURAR la base desde:\n{elegido}\n\n" +
                "¡Esto reemplazará todos los datos actuales!\n¿Continuar?",
                "Confirmar Restore",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes) return;

            string resultado = NBackup.Restore(rutaBak);
            if (resultado == "OK")
            {
                MessageBox.Show("Restore completado. Por favor, reinicie la aplicación.",
                                "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al restaurar:\n{resultado}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método: Abrir carpeta de backup para ver los archivos
        //Acceso rápido a la carpeta para realizar una copia del backup a otro lado en caso de emergencias o prevención.
        private void BtnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(backupFolder))
                    System.Diagnostics.Process.Start("explorer.exe", backupFolder);
                else
                    MessageBox.Show($"La carpeta de backups no existe:\n{backupFolder}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir la carpeta:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ActualizarLista_Click(object sender, EventArgs e)
        {
            RefreshBackupList();
            MessageBox.Show("La lista de archivos de backup se ha actualizado.",
                                "Lista Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
