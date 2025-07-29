using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Utilidades
{
    public class Frm_clave
    {
        //Formulario modal con Label, TextBox y botones OK/Cancelar.
        //Devuelve el texto si OK, o null si se Cancela o se cierra la ventana.
        //Es genérico para poder utilizarlo en cualquier momento que se requiera un pass
        public static string ShowDialog(string text, string caption)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 360;
                prompt.Height = 160;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label lbl = new Label() { Left = 10, Top = 20, Width = 320, Text = text };
                TextBox txt = new TextBox() { Left = 10, Top = 50, Width = 320 };
                txt.UseSystemPasswordChar = true; //Opcion para ocultar la contraseña
                Button btnOk = new Button() { Text = "OK", Left = 160, Width = 80, Top = 80, DialogResult = DialogResult.OK };
                Button btnCancel = new Button() { Text = "Cancelar", Left = 250, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(lbl);
                prompt.Controls.Add(txt);
                prompt.Controls.Add(btnOk);
                prompt.Controls.Add(btnCancel);
                prompt.AcceptButton = btnOk;
                prompt.CancelButton = btnCancel;

                var result = prompt.ShowDialog();
                return result == DialogResult.OK ? txt.Text : null;
            }
        }
    }
}
