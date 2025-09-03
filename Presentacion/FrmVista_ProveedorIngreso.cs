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
    public partial class FrmVista_ProveedorIngreso : Form
    {
        public FrmVista_ProveedorIngreso()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                DgvListado.DataSource = NPersona.BuscarProveedores(TxtBuscar.Text);
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

        private void Buscar()
        {
            try
            {
                //Agregamos como recurso el listado obtenido de la BD en base al parametro enviado
                //Esto permite mostrar los datos recibidos con los resultados de la busqueda
                DgvListado.DataSource = NPersona.BuscarProveedores(TxtBuscar.Text);
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

        //Este metodo permite darle un formato a las columnas del datagrid Categorias
        private void Formato()
        {
            //Visibilidad
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[4].Visible = false;


            //Dimensiones
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[2].Width = 100;
            DgvListado.Columns[3].Width = 170;
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[5].Width = 130;
            DgvListado.Columns[6].Width = 120;
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[8].Width = 120;

            //Headers
            DgvListado.Columns[2].HeaderText = "Tipo Persona";
            DgvListado.Columns[4].HeaderText = "Documento";
            DgvListado.Columns[5].HeaderText = "Número Doc";
            DgvListado.Columns[6].HeaderText = "Dirección";
            DgvListado.Columns[7].HeaderText = "Teléfono";

        }

        private void FrmVista_ProveedorIngreso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdProveedor = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
            Variables.NombreProveedor = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
            //Luego de mandar los valores indicamos que se cierre
            this.Close();
        }
    }
}
