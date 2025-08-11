using BarcodeStandard;
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
using System.Runtime.InteropServices;
using SkiaSharp;
using System.IO;
using System.Drawing.Imaging;

namespace Presentacion
{
    public partial class FrmArticulo : Form
    {

        private string rutaOrigen; //Ruta de la imagen
        private string rutaDestino; //Directorio del proyecto donde se carga la imagen
        private string directorio = "C:\\Users\\sebia\\OneDrive\\Escritorio\\Proyecto_Taller_2_LIBERTEL\\Imagenes\\"; //Directorio donde se almacenaran las imagenes del sistema 
        
        //Variables utilizadas para actualizar un articulo (Control de que se trate del mismo o que se este arreglando un error)
        private string nombreAnt;
        private string marcaAnt;
        private string memoriaAnt;
        private string colorAnt;

        //Constructor
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                DgvListado.DataSource = NArticulo.Listar();
                this.Formato();
                this.Limpiar();
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
                DgvListado.DataSource = NArticulo.Buscar(TxtBuscar.Text);
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

        //Metodo que permite la busqueda de articulos aplicando filtros de Categoria y de Marca
        private void BuscarFiltros()
        {
            try
            {
                string texto = TxtBuscar.Text.Trim();
                int idCategoria = (CboCategoriaBuscar.SelectedValue != null)? Convert.ToInt32(CboCategoriaBuscar.SelectedValue) : 0;
                string marca = (CboMarcaBuscar.SelectedIndex > 0)? CboMarcaBuscar.SelectedItem.ToString() : string.Empty;

                
                DgvListado.DataSource = NArticulo.BuscarFiltros(texto, idCategoria, marca);

                Formato(); // tu formato actual
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Este metodo permite darle un formato a las columnas del datagrid del listado
        private void Formato()
        {
            //Columna 0: CheckBox para seleccionar
            DgvListado.Columns[0].Width = 100;

            //Columna 1: ID (oculta)
            DgvListado.Columns[1].Visible = false;

            //Columna 2: idcategoria (oculta)
            DgvListado.Columns[2].Visible = false;

            //Columna 3: Categoria
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Categoría";

            //Columna 4: Código
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Código";

            //Columna 5: Nombre
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[5].HeaderText = "Nombre";

            //Columna 6: Marca
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Marca";

            //Columna 7: Memoria
            DgvListado.Columns[7].Width = 80;
            DgvListado.Columns[7].HeaderText = "Memoria";

            //Columna 8: Color
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Color";

            //Columna 9: Precio
            DgvListado.Columns[9].Width = 120;
            DgvListado.Columns[9].HeaderText = "Precio";

            //Columna 10: Stock
            DgvListado.Columns[10].Width = 60;
            DgvListado.Columns[10].HeaderText = "Stock";

            //Columna 11: Descripción
            DgvListado.Columns[11].Width = 250;
            DgvListado.Columns[11].HeaderText = "Descripción";

            //Columna 12: Imagen
            DgvListado.Columns[12].Width = 120;
            DgvListado.Columns[12].HeaderText = "Imagen";

            //Columna 13: Estado
            DgvListado.Columns[13].Width = 80;
            DgvListado.Columns[13].HeaderText = "Estado";

        }

        //Metodo Limpiar: Vacia las textbox de mantenimiento y buscar de listado
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtId.Clear();
            TxtCodigo.Clear();
            TxtPrecioVenta.Clear();
            TxtStock.Clear();
            if(PicImagen != null)
            {
                TxtImagen.Clear();
                PicImagen.Image = null;
            }
            CboColor.SelectedIndex = -1;
            CboMemoria.SelectedIndex = -1;
            CboMarca.SelectedIndex = -1;
            TxtDescripcion.Clear();
            PanelCodigo.BackgroundImage = null;
            BtnGuardarCodigo.Enabled = false;
            TxtDescripcion.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
            this.rutaDestino = "";
            this.rutaOrigen = "";

            //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

        private void CargarCategoria()
        {
            try
            {
                //Obtengo los registros que voy a necesitar para visualizar las categorias
                CboCategoria.DataSource = NCategoria.Seleccionar();

                //Defino que campo del registro se va a visualizar en el combobox
                CboCategoria.ValueMember = "idcategoria";

                //El texto que se va a mostrar de cada item lo definimos del campo Nombre
                CboCategoria.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //mensaje de error
            }
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Listar(); //Listar todos los artículos
            this.CargarCategoria(); //Para alta y modificacion
            this.CargarCategoriaBuscar(); //Para busquedas con filtro
            lblTitulo.Text = "ALTA DE ARTÍCULO";
            BtnGuardarCodigo.Enabled = false;
            //mensaje sobre el datagrid avisando que puede hacer doble click para modificar.
            toolTipGeneral.SetToolTip(DgvListado, "Doble clic en una fila para modificar el artículo");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFiltros();
        }

        //Metodo asociado el evento click Cargar Imagen
        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            //Se verifica si se selecciono de forma correcta una imagen
            if(file.ShowDialog() == DialogResult.OK)
            {
                PicImagen.Image = Image.FromFile(file.FileName);
                //Esta linea de código permite solo mostrar el nombre de la imagen sin toda la ruta completa
                //TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")+1);
                TxtImagen.Text = Path.GetFileName(file.FileName);

                this.rutaOrigen = file.FileName; //En esta variable almacenamos todo el directorio
            }
            else
            {
                this.MensajeOk("No ha seleccionado ninguna imagen.");
            }
        }

        //Método asociado al evento Click de Generar Código
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese el número del código de barras que desea generar");
                BtnGuardarCodigo.Enabled = false;
                PanelCodigo.BackgroundImage = null;
            }
            else
            {
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true;

                //Se definen los colores del codigo de barras y el fondo
                var colorNegro = new SKColorF(0, 0, 0); //negro
                var colorBlanco = new SKColorF(1, 1, 1); //blanco

                var skImage = codigo.Encode(BarcodeStandard.Type.Code128, TxtCodigo.Text, colorNegro, colorBlanco, 350, 150);

                //Convercion de SKImage a System.Drawing.Image como PNG
                var data = skImage.Encode(SKEncodedImageFormat.Png, 150);
                var stream = new MemoryStream(data.ToArray());
                var imgFinal = Image.FromStream(stream);

                PanelCodigo.BackgroundImage = imgFinal;
                PanelCodigo.BackgroundImageLayout = ImageLayout.Zoom;

                //Se habilita el boton de guardar código
                BtnGuardarCodigo.Enabled = true;
            }
            

        }

        //Método asociado al evento CLICK del boton Guardar Código
        private void BtnGuardarCodigo_Click(object sender, EventArgs e)
        {
            //Guardamos la imagen en una variable representativa
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();

            //Abrimos los cuadros de dialogo para guardar la imagen
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.AddExtension = true;
            dialogo.Filter = "Image PNG (*.png) | *.png";
            dialogo.ShowDialog();
            if(!string.IsNullOrEmpty(dialogo.FileName))
            {
                imgFinal.Save(dialogo.FileName, ImageFormat.Png);
            }

            imgFinal.Dispose();
        }

        //Método asociado al evento Click en Insertar
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //1) Validaciones básicas de campos obligatorios
                if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                    string.IsNullOrWhiteSpace(TxtImagen.Text) ||
                    string.IsNullOrWhiteSpace(CboCategoria.Text) ||
                    string.IsNullOrWhiteSpace(CboMarca.Text) ||
                    string.IsNullOrWhiteSpace(CboColor.Text) ||
                    string.IsNullOrWhiteSpace(CboMemoria.Text)
                    )
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(CboCategoria, "Seleccione una Categoría");
                    ErrorIcono.SetError(CboMarca, "Ingrese la marca del artículo");
                    ErrorIcono.SetError(CboColor, "Ingrese el color del artículo");
                    ErrorIcono.SetError(CboMemoria, "Ingrese las memorias del artículo");
                    ErrorIcono.SetError(TxtImagen, "Ingrese una imagen representativa");
                    return;
                }

                //2)Comprobacion si la imagen ya existe en la carpeta
                string nombreArchivo = TxtImagen.Text.Trim();
                string rutaDestino = Path.Combine(this.directorio, nombreArchivo);

                if (File.Exists(rutaDestino))
                {
                    MessageBox.Show(
                        $"Ya existe una imagen con el nombre:\n{nombreArchivo}\n" +
                        "Por favor, seleccione otra imagen o cambie el nombre.",
                        "Imagen duplicada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return; //El sistema sale antes insertar en la BD
                }

                //Variable de los campos que se van a cargar por defecto en el alta del producto.

                //3)Inserto el artículo
                string respuesta = NArticulo.Insertar(
                     Convert.ToInt32(CboCategoria.SelectedValue),
                    TxtCodigo.Text.Trim(),
                    TxtNombre.Text.Trim(),
                    CboMarca.Text.Trim(),
                    CboMemoria.Text.Trim(),
                    CboColor.Text.Trim(),
                    0, //Precio por defecto
                    0, //Stock por defecto
                    TxtDescripcion.Text.Trim(),
                    nombreArchivo
                );

                //4)Reviso la respuesta del backend
                if (respuesta.Equals("OK", StringComparison.OrdinalIgnoreCase))
                {
                    this.MensajeOk("El registro se almacenó de forma correcta");

                    // 5) Ya que insertó bien, copio el fichero
                    File.Copy(this.rutaOrigen, rutaDestino);

                    // 6) Refresco el listado
                    this.Listar();
                }
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        //Método asociado a la validación de caracteres unicamente numéricos
        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        //Método asociado al evento KeyPress de código de barras
        //de caracteres unicamente numéricos
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite números y backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Método asociado a la validación de ingresos en Precio (Solo números)
        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite números y backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {
        }

        //Método asociado a la validación de ingresos en Stock (Solo Números)
        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite números y backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Ignorar doble click en encabezados o fuera de filas
                if (e.RowIndex < 0) return;

                //Ignorar si doble click fue en la columna "Seleccionar"
                var col = DgvListado.Columns[e.ColumnIndex];
                if (col is DataGridViewCheckBoxColumn ||
                    col.Name.Equals("Seleccionar", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                this.Limpiar();
                lblTitulo.Text = "MODIFICAR ARTÍCULO";

                //Mostrar campos visibles de modificación
                TxtPrice.Visible = true;
                TxtStk.Visible = true;
                TxtPrecioVenta.Visible = true;
                TxtStock.Visible = true;
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;

                //DATOS DEL ARTICULO QUE SE CARGAN
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboCategoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                TxtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);

                //Nombre
                this.nombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = nombreAnt;
                //Marca
                this.marcaAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Marca"].Value);
                CboMarca.Text = marcaAnt;
                //Memoria
                this.memoriaAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Memoria"].Value);
                CboMemoria.Text = memoriaAnt;
                //Color
                this.colorAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Color"].Value);
                CboColor.Text = colorAnt;
                //Precio y stock
                TxtPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
                TxtStock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                //Descripción
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                //Imagen (Se verifica si la imagen existe)
                string imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if (imagen != string.Empty)
                {
                    string rutaCompleta = Path.Combine(this.directorio, imagen);

                    if (File.Exists(rutaCompleta))
                    {
                        PicImagen.Image = Image.FromFile(rutaCompleta);
                        TxtImagen.Text = imagen;
                    }
                    else
                    {
                        MessageBox.Show("La imagen no se encontró: \n" + rutaCompleta);
                    }
                }
                else
                {
                    PicImagen = null;
                    TxtImagen = null;
                }

                // Cambiar a la pestaña de modificación
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre con doble click " + ex.Message + ex.StackTrace);
            }
        }

        //Método BTN actualizar. Evento Click.
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                // Validación de campos obligatorios
                if (TxtId.Text == string.Empty || TxtImagen.Text == string.Empty ||
                    TxtNombre.Text == string.Empty || CboCategoria.Text == string.Empty ||
                    CboMarca.Text == string.Empty || CboMemoria.Text == string.Empty || CboColor.Text == string.Empty ||
                    TxtPrecioVenta.Text == string.Empty || TxtStock.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(CboCategoria, "Seleccione una Categoría");
                    ErrorIcono.SetError(CboMarca, "Seleccione la marca del artículo");
                    ErrorIcono.SetError(CboMemoria, "Seleccione la memoria del artículo");
                    ErrorIcono.SetError(CboColor, "Seleccione el color del artículo");
                    ErrorIcono.SetError(TxtPrecioVenta, "Ingrese un Precio de Venta");
                    ErrorIcono.SetError(TxtStock, "Ingrese un valor de Stock"); //Esta deshabilitado pero por las dudas.
                    ErrorIcono.SetError(TxtImagen, "Ingrese una imagen representativa");
                    return;
                }

                //Llamada al método de la capa negocio con todos los datos
                respuesta = NArticulo.Actualizar(
                    Convert.ToInt32(TxtId.Text),
                    Convert.ToInt32(CboCategoria.SelectedValue),
                    TxtCodigo.Text.Trim(),
                    nombreAnt,
                    marcaAnt,
                    memoriaAnt,
                    colorAnt,
                    TxtNombre.Text.Trim(),
                    CboMarca.Text,
                    CboMemoria.Text,
                    CboColor.Text,
                    Convert.ToDecimal(TxtPrecioVenta.Text),
                    Convert.ToInt32(TxtStock.Text),
                    TxtDescripcion.Text.Trim(),
                    TxtImagen.Text.Trim()
                );

                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("El registro se actualizó de forma correcta");

                    //Guardado y Verificación de imagen. Si ya existe una similar se reemplaza
                    if (TxtImagen.Text != string.Empty && this.rutaOrigen != string.Empty)
                    {
                        this.rutaDestino = this.directorio + TxtImagen.Text;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        System.Threading.Thread.Sleep(50);

                        if (File.Exists(this.rutaDestino))
                        {
                            File.Delete(this.rutaDestino);
                        }

                        File.Copy(this.rutaOrigen, this.rutaDestino);
                    }

                    this.Listar();
                    lblTitulo.Text = "ALTA DE ARTÍCULO";
                    TabGeneral.SelectedIndex = 0;
                }
                else
                {
                    this.MensajeError(respuesta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            lblTitulo.Text = "ALTA DE ARTÍCULO";
            //Labels
            TxtPrice.Visible = false;
            TxtStk.Visible = false;
            //textBox
            TxtPrecioVenta.Visible = false;
            TxtStock.Visible = false;
            //Regresa al tab de listado
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Segun la documentación, esta es la forma técnica de poder marcar y desmarcar casillas en cada
            // fila del datagrid
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked == true)
            {
                //Si el check box Seleccionar esta activado se activan las siguientes funcionalidades
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = false;

            }
            else
            {
                //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizamos esta variable para guardar el resultado de la selección del mensaje
                DialogResult Opcion;
                //Se le pide al usuario por medio de un mensaje que confirme la eliminación
                Opcion = MessageBox.Show("Realmente deseas eliminar el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Se valida la entrada elegida por el usuario
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";
                    string imagen = ""; //Esta variable la usamos para eliminar la imagen asociada.

                    //Elimino todos los registros seleccionados (ya que pueden ser muchos)
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //Si el check box esta seleccionado se elimina ese registro
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Guardo el codigo del registro que deseo eliminar
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            imagen = Convert.ToString(row.Cells[9].Value);

                            //envio la solicitud de eliminacion y guardo la respuesta recibida
                            respuesta = NArticulo.Eliminar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(row.Cells[5].Value));
                                File.Delete(this.directorio + imagen);
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message + ex.StackTrace); }

        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizamos esta variable para guardar el resultado de la selección del mensaje
                DialogResult Opcion;
                //Se le pide al usuario por medio de un mensaje que confirme la desactivación
                Opcion = MessageBox.Show("Realmente deseas desactivar el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Se valida la entrada elegida por el usuario
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    //Desactivo todos los registros seleccionados (ya que pueden ser muchos)
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //Si el check box esta seleccionado se activa ese registro
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Guardo el codigo de la categoria que deseo eliminar
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            //Envio la solicitud de desactivación y guardo la respuesta recibida
                            respuesta = NArticulo.Desactivar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo el registro: " + Convert.ToString(row.Cells[5].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizamos esta variable para guardar el resultado de la selección del mensaje
                DialogResult Opcion;
                //Se le pide al usuario por medio de un mensaje que confirme la desactivación
                Opcion = MessageBox.Show("Realmente deseas desactivar el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Se valida la entrada elegida por el usuario
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    //Desactivo todos los registros seleccionados (ya que pueden ser muchos)
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //Si el check box esta seleccionado se activa ese registro
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Guardo el codigo de la categoria que deseo eliminar
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            //Envio la solicitud de desactivación y guardo la respuesta recibida
                            respuesta = NArticulo.Activar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo el registro: " + Convert.ToString(row.Cells[5].Value));
                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteArticulos Reporte = new Reportes.FrmReporteArticulos();
            Reporte.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarFiltros();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CboCategoria_DropDown(object sender, EventArgs e)
        {
            this.CargarCategoria(); //Para alta y modificacion
        }

        //Si se selecciona este FORM se ejecutan estos métodos.
        private void FrmArticulo_Activated(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();
            this.CargarCategoriaBuscar();
        }
    }
}
