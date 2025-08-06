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
        private string nombreAnt; //Variable utilizada para actualizar un articulo

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

        //Este metodo permite darle un formato a las columnas del datagrid Categorias
        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Categoría";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Código";
            DgvListado.Columns[5].Width = 250;
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Precio";
            DgvListado.Columns[7].Width = 50;
            DgvListado.Columns[8].Width = 400;
            DgvListado.Columns[8].HeaderText = "Descripción";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;

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
            this.Listar();
            this.CargarCategoria();
            BtnGuardarCodigo.Enabled = false;
            //mensaje sobre el datagrid avisando que puede hacer doble click para modificar.
            toolTipGeneral.SetToolTip(DgvListado, "Doble clic en una fila para modificar el artículo");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
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
                    string.IsNullOrWhiteSpace(CboCategoria.Text))
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(CboCategoria, "Seleccione una Categoría");
                    //ErrorIcono.SetError(TxtPrecioVenta, "Ingrese un Precio de Venta");
                    //ErrorIcono.SetError(TxtStock, "Ingrese un valor de Stock");
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
                    0,
                    0,
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
                this.Limpiar();
                //Labels
                TxtPrice.Visible = true;
                TxtStk.Visible = true;
                //textBox
                TxtPrecioVenta.Visible = true;
                TxtStock.Visible = true;
                //Botones
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                //TextBox del producto
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboCategoria.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idcategoria"].Value);
                TxtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                this.nombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_Venta"].Value);
                TxtStock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);

                //Imagen CONTROL DE LOCALIZACION
                //MessageBox.Show("Imagen en DB: [" +DgvListado.CurrentRow.Cells["Imagen"].Value + "]");

                string imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if( imagen != string.Empty)
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

                TabGeneral.SelectedIndex = 1;

            } catch (Exception ex) {

                //Mostramos el mensaje en caso de que haya alguna excepcion y que el programa pueda
                //seguir ejecutandose, proporcionando una explicación de lo que ocurrio
                MessageBox.Show("Seleccione desde la celda nombre con doble click " + ex.Message + ex.StackTrace);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //El nombre debe tener algun valor porque es obligatorio
                if (TxtId.Text == string.Empty || TxtImagen.Text == string.Empty || TxtNombre.Text == string.Empty || CboCategoria.Text == string.Empty || TxtPrecioVenta.Text == string.Empty || TxtStock.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(CboCategoria, "Seleccione una Categoría");
                    ErrorIcono.SetError(TxtPrecioVenta, "Ingrese un Precio de Venta");
                    ErrorIcono.SetError(TxtStock, "Ingrese un valor de Stock");
                    ErrorIcono.SetError(TxtImagen, "Ingrese una imagen representativa");

                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NArticulo.Actualizar(Convert.ToInt32(TxtId.Text), Convert.ToInt32(CboCategoria.SelectedValue), TxtCodigo.Text.Trim(), this.nombreAnt, TxtNombre.Text.Trim(), Convert.ToDecimal(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), TxtDescripcion.Text.Trim(), TxtImagen.Text.Trim());
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El registro se actualizó de forma correcta");
                        //Verificacion de insercion de imagen
                        if (TxtImagen.Text != string.Empty && this.rutaOrigen != string.Empty)
                        {
                            //Se utiliza el directorio definido como variable inicial para guardar
                            this.rutaDestino = this.directorio + TxtImagen.Text;

                            //Liberar recursos
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            //pausa
                            System.Threading.Thread.Sleep(50); // 50ms de espera

                            // Eliminar la imagen anterior si existe
                            if (File.Exists(this.rutaDestino))
                            {
                                File.Delete(this.rutaDestino);
                            }

                            File.Copy(this.rutaOrigen, this.rutaDestino);
                        }
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        //Si hay algún error que muestre como un mensaje de error
                        this.MensajeError(respuesta);
                    }

                }

            }
            catch (Exception ex)
            {
                //Mostramos el mensaje en caso de que haya alguna excepcion y que el programa pueda
                //seguir ejecutandose, proporcionando una explicación de lo que ocurrio
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
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
    }
}
