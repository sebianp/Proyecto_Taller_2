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
            this.CargarCategoriaBuscar();
        }

        //Metodo para cargar las categorias para el buscador.
        private void CargarCategoriaBuscar()
        {
            try
            {
                DataTable dt = NCategoria.Seleccionar();

                //Inserto "Todas" al inicio para buscar todas las categorias
                //creo una nueva row con el formato datatable
                DataRow dr = dt.NewRow();
                //se le asigna valores al nuevo row, en este caso Todas (para buscar en todas las categorias)
                dr["idcategoria"] = 0;
                dr["nombre"] = "Todas";
                //Agrego la nueva row en el indice 0
                dt.Rows.InsertAt(dr, 0);
                //Cargo el ComboBox CboCategoriaBuscar
                CboCategoriaBuscar.DataSource = dt;
                CboCategoriaBuscar.ValueMember = "idcategoria";
                CboCategoriaBuscar.DisplayMember = "nombre";
                CboCategoriaBuscar.SelectedIndex = 0; //por defecto "Todas"
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
            // 0: ID (oculta)
            datagrid_productos.Columns[0].Visible = false;

            // 1: idcategoria (oculta)
            datagrid_productos.Columns[1].Visible = false;

            // 2: Categoria
            datagrid_productos.Columns[2].HeaderText = "Categoría";
            datagrid_productos.Columns[2].Width = 120;

            // 3: Código
            datagrid_productos.Columns[3].HeaderText = "Código";
            datagrid_productos.Columns[3].Width = 100;

            // 4: Nombre
            datagrid_productos.Columns[4].HeaderText = "Nombre";
            datagrid_productos.Columns[4].Width = 180;

            // 5: Marca
            datagrid_productos.Columns[5].HeaderText = "Marca";
            datagrid_productos.Columns[5].Width = 100;

            // 6: Memoria
            datagrid_productos.Columns[6].HeaderText = "Memoria";
            datagrid_productos.Columns[6].Width = 90;

            // 7: Color
            datagrid_productos.Columns[7].HeaderText = "Color";
            datagrid_productos.Columns[7].Width = 90;

            // 8: Precio
            datagrid_productos.Columns[8].HeaderText = "Precio";
            datagrid_productos.Columns[8].Width = 140;
            //datagrid_productos.Columns[8].DefaultCellStyle.Format = "N2";
            datagrid_productos.Columns[8].DefaultCellStyle.Format = "C2";
            datagrid_productos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // 9: Stock
            datagrid_productos.Columns[9].HeaderText = "Stock";
            datagrid_productos.Columns[9].Width = 60;
            datagrid_productos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 10: Descripción
            datagrid_productos.Columns[10].HeaderText = "Descripción";
            datagrid_productos.Columns[10].Width = 300;

            // 11: Imagen (si no te sirve mostrarla, podés ocultarla)
            //datagrid_productos.Columns[11].HeaderText = "Imagen";
            datagrid_productos.Columns[11].Visible=false;

            // 12: Estado
            datagrid_productos.Columns[12].HeaderText = "Estado";
            datagrid_productos.Columns[12].Width = 80;

            // Opcional de UX
            datagrid_productos.ReadOnly = true;
            datagrid_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_productos.MultiSelect = false;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFiltros();
        }

        private void BuscarFiltros()
        {
            try
            {
                string texto = TxtBuscar.Text.Trim();
                int idCategoria = (CboCategoriaBuscar.SelectedValue != null) ? Convert.ToInt32(CboCategoriaBuscar.SelectedValue) : 0;
                string marca = (CboMarcaBuscar.SelectedIndex > 0) ? CboMarcaBuscar.SelectedItem.ToString() : string.Empty;


                datagrid_productos.DataSource = NArticulo.BuscarFiltros(texto, idCategoria, marca);

                Formato(); // tu formato actual
                LblTotal.Text = "Total Registros: " + datagrid_productos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Valores de la fila seleccionada en el datagrid
                DataGridViewRow fila = datagrid_productos.Rows[e.RowIndex];

                //crear y mostrar form con datos
                Frm_Ver_Articulo ver = new Frm_Ver_Articulo();

                //Asignar los valores al formulario
                ver.Txt_Codigo.Text = fila.Cells["Codigo"].Value.ToString();
                ver.Txt_Nombre.Text = fila.Cells["Nombre"].Value.ToString();
                ver.Txt_Marca.Text = Convert.ToString(fila.Cells["Marca"].Value);
                ver.Txt_Memoria.Text = Convert.ToString(fila.Cells["Memoria"].Value);
                ver.Txt_Color.Text = Convert.ToString(fila.Cells["Color"].Value);
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

        private void Frm_Consultar_Articulo_Activated(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoriaBuscar();
        }
    }
}
