using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Login(TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                //Se verifica que se recibe al menos un registro de parte del metodo login que coindice con los valores
                // de email y clave
                if (tabla.Rows.Count <=0)
                {
                    //Si no existe ningun registro, implica que no hay usuarios con ese email
                    MessageBox.Show("Los datos ingresados no corresponden a un usuario del sistema.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Si hay un registro que coincide se verifica que este ACTIVO
                    // La columna 4 es el estado
                    if (Convert.ToBoolean(tabla.Rows[0][4]) == false) 
                    {
                        MessageBox.Show("El usuario ingresado NO esta activo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    { 
                        FrmPrincipal frm = new FrmPrincipal();
                        Variables.IdUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                        Variables.UsuarioRol = Convert.ToString(tabla.Rows[0]["rol"]);
                        frm.idUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                        frm.idRol = Convert.ToInt32(tabla.Rows[0][1]);
                        frm.rol = Convert.ToString(tabla.Rows[0][2]);
                        frm.nombre = Convert.ToString(tabla.Rows[0][3]);
                        frm.estado = Convert.ToBoolean(tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();

                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
