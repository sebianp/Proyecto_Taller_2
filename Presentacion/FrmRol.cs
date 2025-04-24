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
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Rol
                DgvListado.DataSource = NRol.Listar();
                this.Formato();
                LblTotal.Text = "Total Registros: " + Convert.ToString(DgvListado.Rows.Count); //Cuenta todas las filas
            }
            catch (Exception ex)
            {
                //Mostramos el mensaje en caso de que haya alguna excepcion y que el programa pueda
                //seguir ejecutandose, proporcionando una explicación de lo que ocurrio
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[0].HeaderText = "ID";
            DgvListado.Columns[1].Width = 200;
            DgvListado.Columns[0].HeaderText = "Nombre";

        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
