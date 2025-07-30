using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Consultar_Articulo : Form
    {
        public Frm_Consultar_Articulo()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Articulo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                datagrid_productos.DataSource = NArticulo.Listar();
                this.Formato();
                
                LblTotal.Text = "Total Registros: " + Convert.ToString(datagrid_productos.Rows.Count); //Cuenta todas las filas
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
                datagrid_productos.DataSource = NArticulo.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total Registros: " + Convert.ToString(datagrid_productos.Rows.Count); //Cuenta todas las filas
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
            datagrid_productos.Columns[0].Visible = false;
            datagrid_productos.Columns[2].Visible = false;
            datagrid_productos.Columns[0].Width = 100;
            datagrid_productos.Columns[1].Width = 50;
            datagrid_productos.Columns[3].Width = 100;
            datagrid_productos.Columns[3].HeaderText = "Categoría";
            datagrid_productos.Columns[4].Width = 100;
            datagrid_productos.Columns[4].HeaderText = "Código";
            datagrid_productos.Columns[5].Width = 250;
            datagrid_productos.Columns[6].Width = 100;
            datagrid_productos.Columns[6].HeaderText = "Precio";
            datagrid_productos.Columns[7].Width = 50;
            datagrid_productos.Columns[8].Width = 400;
            datagrid_productos.Columns[8].HeaderText = "Descripción";
            datagrid_productos.Columns[9].Width = 100;
            datagrid_productos.Columns[10].Width = 100;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow fila = datagrid_productos.Rows[e.RowIndex];

                // Crear y mostrar el formulario con los datos
                Frm_Ver_Articulo ver = new Frm_Ver_Articulo();

                // Asignar los valores a los controles del formulario
                ver.Txt_Codigo.Text = fila.Cells["Codigo"].Value.ToString();
                ver.Txt_Nombre.Text = fila.Cells["Nombre"].Value.ToString();
                ver.Txt_Precio.Text = fila.Cells["Precio_Venta"].Value.ToString();
                ver.Txt_Stock.Text = fila.Cells["Stock"].Value.ToString();
                ver.Txt_Descripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                ver.Txt_Categoria.Text = fila.Cells["Categoria"].Value.ToString();

                //ESTADO
                if (fila.Cells["Estado"].Value != null && fila.Cells["Estado"].Value is bool)
                {
                    bool estadoActivo = (bool)fila.Cells["Estado"].Value;

                    ver.Lbl_Estado.Text = estadoActivo ? "ACTIVO" : "INACTIVO";
                    ver.Lbl_Estado.ForeColor = estadoActivo ? Color.Green : Color.Red;
                }

                string directorio = "C:\\Users\\sebia\\OneDrive\\Escritorio\\Proyecto_Taller_2_LIBERTEL\\Imagenes\\";
                string nombreImagen = fila.Cells["Imagen"].Value.ToString();
                string rutaCompleta = Path.Combine(directorio, nombreImagen);

                try
                {
                    if (!string.IsNullOrWhiteSpace(nombreImagen) && File.Exists(rutaCompleta))
                    {
                        ver.PB_Imagen.Image = Image.FromFile(rutaCompleta);
                    }
                    else
                    {
                        //Imagen no encontrada
                         ver.PB_Imagen.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la imagen del producto.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ver.PB_Imagen.Image = null;
                }

                ver.ShowDialog();
            }
        }
    }
}
