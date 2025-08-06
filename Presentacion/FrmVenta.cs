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
    public partial class FrmVenta : Form
    {
        private DataTable DtDetalle = new DataTable();
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                DgvListado.DataSource = NVenta.Listar();
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
                DgvListado.DataSource = NVenta.Buscar(TxtBuscar.Text);
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
            if (DgvListado.Columns.Count < 12)
            {
                MessageBox.Show("Error: Se esperaban al menos 12 columnas, hay " + DgvListado.Columns.Count);
                return;
            }

            DgvListado.Columns[0].Visible = false; // Seleccionar (checkbox)
            DgvListado.Columns[0].Width = 100;

            DgvListado.Columns[1].Visible = false; // idventa
            DgvListado.Columns[2].Visible = false; // idusuario

            DgvListado.Columns[3].Width = 150;     // Usuario
            DgvListado.Columns[3].HeaderText = "Vendedor";

            DgvListado.Columns[4].Width = 170;     // Cliente
            DgvListado.Columns[4].HeaderText = "Cliente";

            DgvListado.Columns[5].Width = 100;     // Documento
            DgvListado.Columns[5].HeaderText = "Documento";

            DgvListado.Columns[6].Width = 70;      // Serie
            DgvListado.Columns[6].HeaderText = "Serie";

            DgvListado.Columns[7].Width = 90;      // Número
            DgvListado.Columns[7].HeaderText = "Número";

            DgvListado.Columns[8].Width = 140;     // Fecha
            DgvListado.Columns[8].HeaderText = "Fecha";

            DgvListado.Columns[9].Width = 90;     // Impuesto
            DgvListado.Columns[9].HeaderText = "Impuesto";

            DgvListado.Columns[10].Width = 120;    // Total
            DgvListado.Columns[10].HeaderText = "Total";

            DgvListado.Columns[11].Width = 100;    // Estado
            DgvListado.Columns[11].HeaderText = "Estado";
        }

        private void FormatoArticulo()
        {
            DgvArticulos.Columns[1].Visible = false;
            DgvArticulos.Columns[1].Width = 100;
            DgvArticulos.Columns[2].HeaderText = "Categoría";
            DgvArticulos.Columns[3].Width = 100;
            DgvArticulos.Columns[3].HeaderText = "Código";
            DgvArticulos.Columns[4].Width = 150;
            DgvArticulos.Columns[5].Width = 100;
            DgvArticulos.Columns[5].HeaderText = "Precio Venta";
            DgvArticulos.Columns[6].Width = 60;
            DgvArticulos.Columns[7].Width = 200;
            DgvArticulos.Columns[7].HeaderText = "Descripción";
            DgvArticulos.Columns[8].Width = 100;
        }

        //Metodo Limpiar: Vacia las textbox de mantenimiento y buscar de listado
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtId.Clear();
            TxtCodigo.Clear();
            TxtIdCliente.Clear();
            TxtNombreCliente.Clear();
            TxtSerieComprobante.Clear();
            TxtNumComprobante.Clear();
            DtDetalle.Clear();
            TxtSubTotal.Text = "0";
            TxtImpuesto.Text = "0";
            TxtTotal.Text = "0";

            BtnInsertar.Visible = true;
            ErrorIcono.Clear();

            //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
            DgvListado.Columns[0].Visible = false;
            BtnAnular.Visible = false;
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

        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("descuento", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            //Indico que la fuente de datos para el Data Grid View sea el dataTable DtDetalle
            DgvDetalle.DataSource = this.DtDetalle;

            //Formato de la tabla
            DgvDetalle.Columns[0].Visible = false;
            DgvDetalle.Columns[1].HeaderText = "Código";
            DgvDetalle.Columns[1].Width = 120;
            DgvDetalle.Columns[2].HeaderText = "Artículo";
            DgvDetalle.Columns[2].Width = 250;
            DgvDetalle.Columns[3].HeaderText = "Stock";
            DgvDetalle.Columns[3].Width = 50;
            DgvDetalle.Columns[4].HeaderText = "Cantidad";
            DgvDetalle.Columns[4].Width = 80;
            DgvDetalle.Columns[5].HeaderText = "Precio";
            DgvDetalle.Columns[5].Width = 150;
            DgvDetalle.Columns[6].HeaderText = "Descuento (%)";
            DgvDetalle.Columns[6].Width = 150;
            DgvDetalle.Columns[7].HeaderText = "Importe";
            DgvDetalle.Columns[7].Width = 150;

            DgvDetalle.Columns[1].ReadOnly = true;
            DgvDetalle.Columns[2].ReadOnly = true;
            DgvDetalle.Columns[3].ReadOnly = true;
            DgvDetalle.Columns[5].ReadOnly = true;
            DgvDetalle.Columns[7].ReadOnly = true;


        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVista_ClienteVenta vista = new FrmVista_ClienteVenta();
            vista.ShowDialog();
            TxtIdCliente.Text = Convert.ToString(Variables.IdCliente);
            TxtNombreCliente.Text = Variables.NombreCliente;
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //Creamos un DataTable que es lo que nos va a devolver la capa negocios.
                    DataTable tabla = new DataTable();
                    tabla = NArticulo.BuscarCodigoVenta(TxtCodigo.Text.Trim()); //Trim() borra los espacios al inicio y final

                    if (tabla.Rows.Count <= 0)
                    {
                        this.MensajeError("No existe un articulo con ese código o no hay stock");
                    }
                    else
                    {
                        //Se agrega el articulo al detalle, este orden se basa en el select del procedimiento de 
                        // buscar los articulos para venta
                        // orden: idarticulo[0], codigo[1], nombre[2], precio_venta[3], stock[4]
                        this.AgregarDetalle(
                                Convert.ToInt32(tabla.Rows[0][0]), //idarticulo
                                Convert.ToString(tabla.Rows[0][1]), //codigo
                                Convert.ToString(tabla.Rows[0][2]), //nombre
                                Convert.ToInt32(tabla.Rows[0][4]), //precio_venta
                                Convert.ToDecimal(tabla.Rows[0][3]) //stock
                            );
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre,int Stock, decimal Precio)
        {
            bool agregar = true;

            //Recorremos primero el detalle para saber si el articulo ya se encuentra agregado
            foreach (DataRow FilaTemp in DtDetalle.Rows)
            {
                //Si el id de un articulo que estoy por agregar ya existe, entonces no se agrega
                if (Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo)
                {
                    agregar = false;
                    this.MensajeError("El artículo ya ha sido agregado al detalle.");
                }
            }

            //Si la variable agregar se mantiene en true, quiere decir que en la lista aún no se agrego
            //Por lo tanto se permite agregar el articulo al detalle.
            if (agregar)
            {

                DataRow Fila = DtDetalle.NewRow();
                Fila["idarticulo"] = IdArticulo;
                Fila["codigo"] = Codigo;
                Fila["articulo"] = Nombre;
                Fila["stock"] = Stock;
                Fila["cantidad"] = 1;
                Fila["precio"] = Precio;
                Fila["descuento"] = 0;
                Fila["importe"] = Precio;

                //Agregamos la fila
                this.DtDetalle.Rows.Add(Fila);

                //Actualizamos los totales
                this.CalcularTotales();

                //Mensaje de exito
                this.MensajeOk("Se agrego el articulo: " + Nombre + " al detalle.");
            }


        }

        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            decimal impuesto;

            impuesto = Convert.ToDecimal(TxtImpuesto.Text);

            if (DgvDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            {
                //Recorremos todos los articulos
                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    //Verificación para evitar que intente sumar articulos eliminados de la lista.
                    if (FilaTemp.RowState != DataRowState.Deleted)
                    {
                        Total += Convert.ToDecimal(FilaTemp["importe"]);
                    }
                }

            }

            if (!decimal.TryParse(TxtImpuesto.Text, out impuesto) || impuesto < 0)
            {
                this.MensajeError("El valor del impuesto no puede ser negativo o inválido.");
                impuesto = 0;
                TxtImpuesto.Text = "0";
            }
            else
            {
                SubTotal = Total * (1 - Convert.ToDecimal(TxtImpuesto.Text));
            }

            TxtTotal.Text = Total.ToString("#0.00#"); //Lo que va en parentesis es el formato
            TxtSubTotal.Text = SubTotal.ToString("#0.00#");
            TxtTotalImpuesto.Text = (Total - SubTotal).ToString("#0.00#");

        }

        //Refresca la lista de artículos al poner "VER LISTADO"
        private void CargarListadoArticulos()
        {
            try
            {
                string vacio = string.Empty;
                DgvArticulos.DataSource = NArticulo.BuscarVenta(vacio);
                this.FormatoArticulo();
                LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DgvArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVerListado_Click(object sender, EventArgs e)
        {
            CargarListadoArticulos(); //Actualiza la lista de productos del panel
            //Luego de actualizar, muestra la lista del panel.
            PanelArticulos.Visible = true;
        }

        private void BtnCerrarArticulos_Click(object sender, EventArgs e)
        {
            PanelArticulos.Visible = false;

        }

        private void BtnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                DgvArticulos.DataSource = NArticulo.BuscarVenta(TxtBuscarArticulo.Text.Trim());
                this.FormatoArticulo();
                LblTotalArticulos.Text = "Total Registros: " + Convert.ToString(DgvArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Declaramos las variables que vamos a usar
            int IdArticulo;
            string Codigo, Nombre;
            decimal Precio;
            int Stock;

            //Agregamos a las variables los valores de la fila a la que se hizo doble click
            IdArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Stock = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["Stock"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);

            //Cargamos al detalle
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Stock, Precio);
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            string Articulo = Convert.ToString(Fila["articulo"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            int Stock = Convert.ToInt32(Fila["stock"]);
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            decimal Descuento = Convert.ToDecimal(Fila["descuento"]);

            //Control de cantidades y stock
            if (Cantidad > Stock)
            {
                Cantidad = Stock;
                this.MensajeError("La cantidad de venta de " + Articulo + " no puede superar el stock disponible. (Unidades Disponibles: " + Stock + ")");
                Fila["Cantidad"] = Cantidad;
            }
            else if (Cantidad <= 0)
            {
                Cantidad = 1;
                this.MensajeError("La cantidad de venta de " + Articulo + " no puede ser cero ni negativo.");
                Fila["Cantidad"] = Cantidad;
            }

                //Calculamos el importe
                Fila["importe"] = (Precio * Cantidad) - ((Precio * Cantidad)*Descuento/100);

            //Volver a calcular totales
            this.CalcularTotales();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //Validación de que los campos que sean obligatorios no estén vacíos.
                if (TxtIdCliente.Text == string.Empty || TxtImpuesto.Text == string.Empty || TxtNumComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtIdCliente, "Debe seleccionar un cliente");
                    ErrorIcono.SetError(TxtImpuesto, "Debe ingresar un valor de impuesto");
                    ErrorIcono.SetError(TxtNumComprobante, "Ingrese el número del comprobante");
                    ErrorIcono.SetError(DgvDetalle, "Debe ingresar al menos un artículo");
                }
                else //En caso de cumplir con los campos obligatorios, se puede almacenar
                {

                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NVenta.Insertar
                    (
                                                Convert.ToInt32(TxtIdCliente.Text),
                                                Variables.IdUsuario,
                                                CboComprobante.Text,
                                                TxtSerieComprobante.Text.Trim(),
                                                TxtNumComprobante.Text.Trim(),
                                                Convert.ToDecimal(TxtImpuesto.Text),
                                                Convert.ToDecimal(TxtTotal.Text),
                                                DtDetalle
                    );
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El registro se almacenó de forma correcta");
                        this.Limpiar();
                        this.Listar();
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
            TabGeneral.SelectedIndex = 0;
        }

        private void BtnActualizarTotales_Click(object sender, EventArgs e)
        {
            this.CalcularTotales();
        }

        private void DgvDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //indice de la columna del descuento
            int columnaDescuento = 6;

            if (e.ColumnIndex == columnaDescuento)
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal valor))
                {
                    MessageBox.Show("El valor ingresado no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                else if (valor < 0)
                {
                    MessageBox.Show("No se permite ingresar descuentos negativos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Los datos obtenemos de listar detalles y como parametro usamos el ID de la fila seleccionada
                DgvMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                
                //Formato de columnas
                DgvMostrarDetalle.Columns[5].HeaderText = "Descuento (%)";
                DgvMostrarDetalle.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                DgvMostrarDetalle.Columns["PRECIO"].DefaultCellStyle.Format = "C2";
                DgvMostrarDetalle.Columns["DESCUENTO"].DefaultCellStyle.Format = "N0";
                DgvMostrarDetalle.Columns[0].Width = 50;
                DgvMostrarDetalle.Columns[2].Width = 250;
                DgvMostrarDetalle.Columns[4].Width = 200;
                DgvMostrarDetalle.Columns[5].Width = 150;
                DgvMostrarDetalle.Columns[6].Width = 200;

                //Variables a mostrar
                decimal Total, Subtotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                //Total*(1 - Convert.ToDecimal(TxtImpuesto.Text));
                Subtotal = Total * (1 - Impuesto);
                TxtSubTotalD.Text = Subtotal.ToString("#0.00#");
                TxtImpuestosD.Text = (Total - Subtotal).ToString("#0.00#"); //TOTAL IMPUESTOS
                TxtTotalD.Text = Total.ToString("#0.00#");

                //Mostrar el panel
                PanelMostrar.Visible = true;

            }
            catch (Exception ex)
            {
                //Mensaje por si algo falla
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible=false;
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
                BtnAnular.Visible = true;


            }
            else
            {
                //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
                DgvListado.Columns[0].Visible = false;
                BtnAnular.Visible = false;

            }
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizamos esta variable para guardar el resultado de la selección del mensaje
                DialogResult Opcion;
                //Se le pide al usuario por medio de un mensaje que confirme la la activación.
                Opcion = MessageBox.Show("Realmente deseas anular el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Se valida la entrada elegida por el usuario
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string respuesta = "";

                    //Activo todos los registros seleccionados (ya que pueden ser muchos)
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //Si el check box esta seleccionado se activa ese registro
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Guardo el codigo de la categoria que deseo eliminar
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            //envio la solicitud de activacion y guardo la respuesta recibida
                            respuesta = NVenta.Anular(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se anulo el registro: " + Convert.ToString(row.Cells[6].Value) + " - " + Convert.ToString(row.Cells[7].Value));
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

        private void BtnComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Validamos que haya al menos una fila en el DataGridView
                if (DgvListado.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ventas para generar comprobante.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2) Validamos que CurrentRow no sea nulo (aunque Rows.Count > 0)
                if (DgvListado.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una venta antes de generar el comprobante.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3) Validamos que la celda ID tenga un valor
                var cellValue = DgvListado.CurrentRow.Cells["ID"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("La venta seleccionada no tiene ID válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4) Convertimos y seguimos con la lógica normal
                Variables.IdVenta = Convert.ToInt32(cellValue);

                var reporte = new Reportes.FrmReporteComprobanteVenta();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            try
            {

                //Creamos un DataTable que es lo que nos va a devolver la capa negocios.
                DataTable tabla = new DataTable();
                tabla = NArticulo.BuscarCodigoVenta(TxtCodigo.Text.Trim()); //Trim() borra los espacios al inicio y final

                if (tabla.Rows.Count <= 0)
                {
                    this.MensajeError("No existe un articulo con ese código o no hay stock disponible.");
                }
                else
                {
                    //Se agrega el articulo al detalle
                    this.AgregarDetalle(
                            Convert.ToInt32(tabla.Rows[0][0]),
                            Convert.ToString(tabla.Rows[0][1]),
                            Convert.ToString(tabla.Rows[0][2]),
                            Convert.ToInt32(tabla.Rows[0][4]),
                            Convert.ToDecimal(tabla.Rows[0][3])
                     );


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

    }
}
