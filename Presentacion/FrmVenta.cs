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
                DgvListado.DataSource = NVenta.ListarVentasVendedor(Variables.IdUsuario);
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
                DgvListado.DataSource = NVenta.Buscar(TxtBuscar.Text, Variables.IdUsuario);
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

            DgvListado.Columns[0].Visible = false; //Seleccionar
            DgvListado.Columns[0].Width = 100;

            DgvListado.Columns[1].Visible = false; //idventa
            DgvListado.Columns[2].Visible = false; //idusuario

            DgvListado.Columns[3].Width = 150;     //Usuario
            DgvListado.Columns[3].HeaderText = "Vendedor";

            DgvListado.Columns[4].Width = 170;     //Cliente
            DgvListado.Columns[4].HeaderText = "Cliente";

            DgvListado.Columns[5].Width = 100;     //Documento
            DgvListado.Columns[5].HeaderText = "Documento";

            DgvListado.Columns[6].Width = 70;      //Serie
            DgvListado.Columns[6].HeaderText = "Serie";

            DgvListado.Columns[7].Width = 120;      //Número
            DgvListado.Columns[7].HeaderText = "Número";

            DgvListado.Columns[8].Width = 140;     //Fecha
            DgvListado.Columns[8].HeaderText = "Fecha";

            DgvListado.Columns[9].Width = 90;     //Impuesto
            DgvListado.Columns[9].HeaderText = "Impuesto";

            DgvListado.Columns[10].Width = 120;    //Total
            DgvListado.Columns[10].HeaderText = "Total";

            DgvListado.Columns[11].Width = 100;    //Estado
            DgvListado.Columns[11].HeaderText = "Estado";
        }

        private void FormatoArticulo()
        {
            //Ocultas
            DgvArticulos.Columns[0].Visible = false; // ID
            DgvArticulos.Columns[1].Visible = false; //idcategoria
            DgvArticulos.Columns[11].Visible = false; //imagen

            //categoria
            DgvArticulos.Columns[2].HeaderText = "Categoría";
            DgvArticulos.Columns[2].Width = 140;

            //codigo
            DgvArticulos.Columns[3].HeaderText = "Código";
            DgvArticulos.Columns[3].Width = 100;

            //nombre
            DgvArticulos.Columns[4].HeaderText = "Nombre";
            DgvArticulos.Columns[4].Width = 150;

            //marca
            DgvArticulos.Columns[5].HeaderText = "Marca";
            DgvArticulos.Columns[5].Width = 100;

            //memoria
            DgvArticulos.Columns[6].HeaderText = "Memoria";
            DgvArticulos.Columns[6].Width = 100;

            //color
            DgvArticulos.Columns[7].HeaderText = "Color";
            DgvArticulos.Columns[7].Width = 90;

            //precio de venta
            DgvArticulos.Columns[8].HeaderText = "Precio Venta";
            DgvArticulos.Columns[8].Width = 100;
            DgvArticulos.Columns[8].DefaultCellStyle.Format = "N2";
            DgvArticulos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //stock
            DgvArticulos.Columns[9].HeaderText = "Stock";
            DgvArticulos.Columns[9].Width = 60;
            DgvArticulos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //descripción
            DgvArticulos.Columns[10].HeaderText = "Descripción";
            DgvArticulos.Columns[10].Width = 220;

            // Estado
            DgvArticulos.Columns[12].HeaderText = "Estado";
            DgvArticulos.Columns[12].Width = 60;

            DgvArticulos.ReadOnly = true;
            DgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvArticulos.MultiSelect = false;
        }

        //Metodo Limpiar: Vacia las textbox de mantenimiento y buscar de listado
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtId.Clear();
            TxtCodigo.Clear();
            TxtIdCliente.Clear();
            TxtNombreCliente.Clear();
            //TxtSerieComprobante.Clear();
            //TxtNumComprobante.Clear();
            DtDetalle.Clear();
            TxtSubTotal.Text = "0";
            //TxtImpuesto.Text = "0";
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
            this.DtDetalle.Columns.Add("idarticulo", typeof(int));
            this.DtDetalle.Columns.Add("codigo", typeof(string));
            this.DtDetalle.Columns.Add("articulo", typeof(string));
            this.DtDetalle.Columns.Add("marca", typeof(string));
            this.DtDetalle.Columns.Add("memoria", typeof(string));
            this.DtDetalle.Columns.Add("color", typeof(string));
            this.DtDetalle.Columns.Add("stock", typeof(int));
            this.DtDetalle.Columns.Add("cantidad", typeof(int));
            this.DtDetalle.Columns.Add("precio", typeof(decimal));
            this.DtDetalle.Columns.Add("descuento", typeof(decimal));//decimal
            this.DtDetalle.Columns.Add("importe", typeof(decimal));

            DgvDetalle.DataSource = this.DtDetalle;

            //formato de columnas
            DgvDetalle.Columns["idarticulo"].Visible = false;
            DgvDetalle.Columns["codigo"].HeaderText = "Código";
            DgvDetalle.Columns["codigo"].Width = 100;
            DgvDetalle.Columns["articulo"].HeaderText = "Artículo";
            DgvDetalle.Columns["articulo"].Width = 180;
            DgvDetalle.Columns["marca"].HeaderText = "Marca";
            DgvDetalle.Columns["marca"].Width = 100;
            DgvDetalle.Columns["memoria"].HeaderText = "Memoria";
            DgvDetalle.Columns["memoria"].Width = 100;
            DgvDetalle.Columns["color"].HeaderText = "Color";
            DgvDetalle.Columns["color"].Width = 100;
            DgvDetalle.Columns["stock"].HeaderText = "Stock";
            DgvDetalle.Columns["stock"].Width = 50;
            DgvDetalle.Columns["cantidad"].HeaderText = "Cantidad";
            DgvDetalle.Columns["cantidad"].Width = 80;
            DgvDetalle.Columns["precio"].HeaderText = "Precio";
            DgvDetalle.Columns["precio"].Width = 100;
            DgvDetalle.Columns["descuento"].HeaderText = "Descuento (%)";
            DgvDetalle.Columns["descuento"].Width = 100;
            DgvDetalle.Columns["importe"].HeaderText = "Importe";
            DgvDetalle.Columns["importe"].Width = 100;

            //columnas de solo lectura
            DgvDetalle.Columns["codigo"].ReadOnly = true;
            DgvDetalle.Columns["articulo"].ReadOnly = true;
            DgvDetalle.Columns["marca"].ReadOnly = true;
            DgvDetalle.Columns["memoria"].ReadOnly = true;
            DgvDetalle.Columns["color"].ReadOnly = true;
            DgvDetalle.Columns["stock"].ReadOnly = true;
            DgvDetalle.Columns["precio"].ReadOnly = true;
            DgvDetalle.Columns["importe"].ReadOnly = true;


        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            TxtNumComprobante.Text = NVenta.ObtenerSiguienteNumeroVenta();
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
                                Convert.ToString(tabla.Rows[0][3]), //marca
                                Convert.ToString(tabla.Rows[0][4]), //memoria
                                Convert.ToString(tabla.Rows[0][5]), //color
                                Convert.ToInt32(tabla.Rows[0][7]),  //stock
                                Convert.ToDecimal(tabla.Rows[0][6]) //precio_venta
                            );
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, string Marca, string Memoria, string Color, int Stock, decimal Precio)
        {
            bool agregar = true;

            //Recorremos primero el detalle para saber si el articulo ya se encuentra agregado
            foreach (DataRow FilaTemp in DtDetalle.Rows)
            {
                //Si el id de un articulo que estoy por agregar ya existe, entonces no se agrega
                if (
                    Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo &&
                    Convert.ToString(FilaTemp["marca"]) == Marca &&
                    Convert.ToString(FilaTemp["memoria"]) == Memoria &&
                    Convert.ToString(FilaTemp["color"]) == Color
                 ){
                    agregar = false;
                    this.MensajeError("El artículo con la misma Marca, Memoria y Color ya fue agregado.");
                    break;
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
                Fila["marca"] = Marca;
                Fila["memoria"] = Memoria;
                Fila["color"] = Color;
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
                this.MensajeOk($"Se agregó el artículo: {Nombre} ({Marca} - {Memoria} - {Color}) al detalle.");
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

                DgvArticulos.Columns.Clear();//evita columnas duplicadas
                DgvArticulos.AutoGenerateColumns = true;

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
            BtnInsertar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEliminarItem.Enabled = false;
            PanelArticulos.Visible = true;
        }

        private void BtnCerrarArticulos_Click(object sender, EventArgs e)
        {
            BtnInsertar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnEliminarItem.Enabled = true;
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
            //Variables que utilozo
            int IdArticulo;
            string Codigo, Nombre, Marca, Memoria, Color;
            decimal Precio;
            int Stock;

            //Cargo los valores necesarios
            IdArticulo = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(DgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(DgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Marca = Convert.ToString(DgvArticulos.CurrentRow.Cells["Marca"].Value);
            Memoria = Convert.ToString(DgvArticulos.CurrentRow.Cells["Memoria"].Value);
            Color = Convert.ToString(DgvArticulos.CurrentRow.Cells["Color"].Value);
            Stock = Convert.ToInt32(DgvArticulos.CurrentRow.Cells["Stock"].Value);
            Precio = Convert.ToDecimal(DgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);

            //Paso al metodo de agregarDetalle para el carrito
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Marca, Memoria, Color, Stock, Precio);
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DtDetalle.Rows.Count) return;

            DataRow Fila = DtDetalle.Rows[e.RowIndex];

            string Articulo = Convert.ToString(Fila["articulo"]);
            int Cantidad = 1;
            int Stock = 0;
            decimal Precio = 0m;
            decimal Descuento = 0m;

            // cantidad segura (mín 1; máx Stock)
            int.TryParse(Convert.ToString(Fila["cantidad"]), out Cantidad);
            if (Cantidad < 1) Cantidad = 1;

            int.TryParse(Convert.ToString(Fila["stock"]), out Stock);
            if (Stock > 0 && Cantidad > Stock)
            {
                Cantidad = Stock;
                this.MensajeError($"La cantidad de venta de {Articulo} no puede superar el stock disponible. (Unidades disponibles: {Stock})");
            }
            Fila["cantidad"] = Cantidad;

            // precio
            decimal.TryParse(Convert.ToString(Fila["precio"]), out Precio);

            // descuento seguro (vacío -> 0; rango 0..80)
            var vDesc = Fila["descuento"];
            if (vDesc != DBNull.Value && !string.IsNullOrWhiteSpace(Convert.ToString(vDesc)))
                decimal.TryParse(Convert.ToString(vDesc), out Descuento);
            if (Descuento < 0) Descuento = 0m;
            if (Descuento > 80) Descuento = 80m;
            Fila["descuento"] = Descuento;

            // importe = Precio * Cantidad * (1 - Descuento/100)
            var bruto = Precio * Cantidad;
            var importe = bruto * (1 - (Descuento / 100m));
            Fila["importe"] = importe;

            this.CalcularTotales();
        }

        //Metodo de adaptación de la tabla DtDetalle para enviar los parametros necesarios unicamente para el detalle_venta
        private DataTable CrearTablaEnvio()
        {
            DataTable tablaEnvio = new DataTable();

            tablaEnvio.Columns.Add("idarticulo", typeof(int));
            tablaEnvio.Columns.Add("codigo", typeof(string));
            tablaEnvio.Columns.Add("articulo", typeof(string));
            tablaEnvio.Columns.Add("stock", typeof(int));
            tablaEnvio.Columns.Add("cantidad", typeof(int));
            tablaEnvio.Columns.Add("precio", typeof(decimal));
            tablaEnvio.Columns.Add("descuento", typeof(decimal));
            tablaEnvio.Columns.Add("importe", typeof(decimal));

            foreach (DataRow fila in DtDetalle.Rows)
            {
                tablaEnvio.Rows.Add(
                    Convert.ToInt32(fila["idarticulo"]),
                    fila["codigo"].ToString(),
                    fila["articulo"].ToString(),
                    Convert.ToInt32(fila["stock"]),
                    Convert.ToInt32(fila["cantidad"]),
                    Convert.ToDecimal(fila["precio"]),
                    Convert.ToDecimal(fila["descuento"]),
                    Convert.ToDecimal(fila["importe"])
                );
            }

            return tablaEnvio;
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
                    //Mensaje de confirmación de la Venta.
                    if (MessageBox.Show("¿Está seguro que desea realizar la venta?",
                                        "Confirmar venta",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return; //Si elige NO vuelve hacia atrás.
                    }
                    //Encapsulamos en esta variable solo los datos necesarios para el detalle_venta, ignorando varios que se usaron
                    //unicamente para la visualizacion del carrito.
                    DataTable tablaEnvio = CrearTablaEnvio();
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
                                                tablaEnvio
                    );
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("La VENTA fue realizada con éxito");
                        this.Limpiar();
                        TxtNumComprobante.Text = NVenta.ObtenerSiguienteNumeroVenta();
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
            //Mensaje de confirmación de cancelacion.
            if (MessageBox.Show("¿Está seguro que desea CANCELAR la venta?",
                                "Confirmar Cancelación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                return; //Si elige NO vuelve hacia atrás.
            }
            //Si selecciona SI entonces se resetean todos los datos de la venta.
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void BtnActualizarTotales_Click(object sender, EventArgs e)
        {
            this.CalcularTotales();
        }

        private void DgvDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;
            string col = grid.Columns[e.ColumnIndex].Name;

            // Obtenemos la DataRow de la fila actual
            var rowView = grid.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (rowView == null) return;
            var Fila = rowView.Row;

            // ===== Validación CANTIDAD (entero, 1..Stock) =====
            if (col.Equals("cantidad", StringComparison.OrdinalIgnoreCase))
            {
                string texto = Convert.ToString(e.FormattedValue)?.Trim();
                if (!int.TryParse(texto, out int cant))
                {
                    this.MensajeError("La cantidad debe ser un número entero.");
                    e.Cancel = true;
                    return;
                }

                int stock = 0;
                int.TryParse(Convert.ToString(Fila["stock"]), out stock);

                if (cant < 1)
                {
                    this.MensajeError("La cantidad mínima es 1.");
                    e.Cancel = true;
                    return;
                }
                if (stock > 0 && cant > stock)
                {
                    this.MensajeError($"La cantidad no puede superar el stock disponible ({stock}).");
                    e.Cancel = true;
                    return;
                }
            }

            // ===== Validación DESCUENTO (decimal, 0..80) =====
            if (col.Equals("descuento", StringComparison.OrdinalIgnoreCase))
            {
                string texto = Convert.ToString(e.FormattedValue)?.Trim();
                if (string.IsNullOrWhiteSpace(texto))
                {
                    // Permitimos vacío, lo transformaremos a 0 en EndEdit
                    return;
                }

                if (!decimal.TryParse(texto, out decimal desc))
                {
                    this.MensajeError("El descuento debe ser un número.");
                    e.Cancel = true;
                    return;
                }
                if (desc < 0 || desc > 80)
                {
                    this.MensajeError("El descuento debe estar entre 0 y 80.");
                    e.Cancel = true;
                    return;
                }
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
                //Los datos obtenemos de listar detalles y como parametro usamos el ID de la fila seleccionada
                DgvMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));

                //Formato de columnas
                // ----- Formato de columnas -----
                var g = DgvMostrarDetalle;

                //Orden visual
                g.Columns["ID"].DisplayIndex = 0;
                g.Columns["CODIGO"].DisplayIndex = 1;
                g.Columns["ARTICULO"].DisplayIndex = 2;
                g.Columns["MARCA"].DisplayIndex = 3;
                g.Columns["MEMORIA"].DisplayIndex = 4;
                g.Columns["COLOR"].DisplayIndex = 5;
                g.Columns["CANTIDAD"].DisplayIndex = 6;
                g.Columns["PRECIO"].DisplayIndex = 7;
                g.Columns["DESCUENTO"].DisplayIndex = 8;
                g.Columns["IMPORTE"].DisplayIndex = 9;

                //encabezados
                g.Columns["ID"].Visible = false;
                g.Columns["CODIGO"].HeaderText = "Código";
                g.Columns["ARTICULO"].HeaderText = "Artículo";
                g.Columns["MARCA"].HeaderText = "Marca";
                g.Columns["MEMORIA"].HeaderText = "Memoria";
                g.Columns["COLOR"].HeaderText = "Color";
                g.Columns["CANTIDAD"].HeaderText = "Cantidad";
                g.Columns["PRECIO"].HeaderText = "Precio";
                g.Columns["DESCUENTO"].HeaderText = "Descuento (%)";
                g.Columns["IMPORTE"].HeaderText = "Importe";

                //ancho
                g.Columns["CODIGO"].Width = 100;
                g.Columns["ARTICULO"].Width = 180;
                g.Columns["MARCA"].Width = 100;
                g.Columns["MEMORIA"].Width = 90;
                g.Columns["COLOR"].Width = 90;
                g.Columns["CANTIDAD"].Width = 80;
                g.Columns["PRECIO"].Width = 120;
                g.Columns["DESCUENTO"].Width = 130;
                g.Columns["IMPORTE"].Width = 150;

                //formato de numero
                g.Columns["PRECIO"].DefaultCellStyle.Format = "C2";
                g.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                g.Columns["DESCUENTO"].DefaultCellStyle.Format = "N2"; //% con decimales
                g.Columns["CANTIDAD"].DefaultCellStyle.Format = "N0";

                //Alineacion
                g.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                g.Columns["PRECIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                g.Columns["DESCUENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                g.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //Solo lectura en los campos calculados
                g.Columns["CODIGO"].ReadOnly = true;
                g.Columns["ARTICULO"].ReadOnly = true;
                g.Columns["MARCA"].ReadOnly = true;
                g.Columns["MEMORIA"].ReadOnly = true;
                g.Columns["COLOR"].ReadOnly = true;
                g.Columns["PRECIO"].ReadOnly = true;
                g.Columns["IMPORTE"].ReadOnly = true;

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
                            Convert.ToInt32(tabla.Rows[0][0]), //idarticulo
                            Convert.ToString(tabla.Rows[0][1]), //codigo
                            Convert.ToString(tabla.Rows[0][2]), //nombre
                            Convert.ToString(tabla.Rows[0][3]), //marca
                            Convert.ToString(tabla.Rows[0][4]), //memoria
                            Convert.ToString(tabla.Rows[0][5]), //color
                            Convert.ToInt32(tabla.Rows[0][7]),  //stock
                            Convert.ToDecimal(tabla.Rows[0][6]) //precio_venta
                     );


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvArticulos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotales();
        }

        private void DgvArticulos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.CalcularTotales();
        }

        private void DgvDetalle_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.CalcularTotales();
        }

        private void DgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvDetalle.Columns[e.ColumnIndex].Name == "ColEliminar")
            {
                DgvDetalle.EndEdit();

                //Si está enlazado a DataTable:
                var view = DgvDetalle.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (view != null)
                {
                    view.Row.Delete();
                    
                    CalcularTotales();
                }
                else
                {
                    //Grilla no enlazada
                    DgvDetalle.Rows.RemoveAt(e.RowIndex);
                    CalcularTotales();
                }
            }
        }

        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            //nada seleccionado
            if (DgvDetalle.CurrentRow == null || DgvDetalle.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccioná un Artículo primero.");
                return;
            }

            //confirmar
            if (MessageBox.Show("¿Eliminar el Artículo seleccionado?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //cerrar edición por las dudas
            DgvDetalle.EndEdit();

            //si está enlazado a DataTable/BindingSource
            var view = DgvDetalle.CurrentRow.DataBoundItem as DataRowView;
            if (view != null)
                view.Row.Delete();//elimina de la DataTable
            else
                DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow);// grilla no enlazada

            CalcularTotales(); //
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo números y tecla de backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir control (retroceso, suprimir, etc.) y números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //Permitir solo una coma para evitar errores
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void TxtImpuesto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtImpuesto.Text))
            {
                TxtImpuesto.Text = "0";
                TxtImpuesto.SelectionStart = TxtImpuesto.Text.Length; //Pone el cursor al final
            }
            this.CalcularTotales();
        }
    }
}
