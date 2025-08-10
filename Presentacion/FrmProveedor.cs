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
    public partial class FrmProveedor : Form
    {
        private string nombreAnt;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                DgvListado.DataSource = NPersona.ListarProveedores();
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
            

            //Dimensiones
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[2].Width = 100;
            DgvListado.Columns[3].Width = 170;
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[5].Width = 130;
            DgvListado.Columns[6].Width = 180;
            DgvListado.Columns[7].Width = 130;
            DgvListado.Columns[8].Width = 200;

            //Headers
            DgvListado.Columns[2].HeaderText = "Tipo Persona";
            DgvListado.Columns[4].HeaderText = "Documento";
            DgvListado.Columns[5].HeaderText = "Número Doc";
            DgvListado.Columns[6].HeaderText = "Dirección";
            DgvListado.Columns[7].HeaderText = "Teléfono";

        }

        //Metodo Limpiar: Vacia las textbox de mantenimiento y buscar de listado
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtId.Clear();
            TxtNumDocumento.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();
            TxtTelefono.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();

            //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
            DgvListado.Columns[0].Visible = false;
           
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


        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //El nombre debe tener algun valor porque es obligatorio
                if (TxtNombre.Text == string.Empty || TxtNumDocumento.Text == string.Empty || TxtDireccion.Text == string.Empty || TxtTelefono.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(TxtNumDocumento, "Ingrese un número de documento");
                    ErrorIcono.SetError(TxtDireccion, "Ingrese una dirección");
                    ErrorIcono.SetError(TxtTelefono, "Ingrese un número de teléfono");
                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NPersona.Insertar("Proveedor",TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim());
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El Proveedor se registro de forma correcta");
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
                //Se prepara la ventana del formulario para Actualizar
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;

                //Se cargan todos los datos correspondiente a la casilla seleccionada
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.nombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                CboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtNumDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                TxtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                TxtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                
                //Pasamos al formulario de actualizar con todos los datos cargados
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + " | Error:" + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //El nombre debe tener algun valor porque es obligatorio
                if (TxtNombre.Text == string.Empty || TxtNumDocumento.Text == string.Empty || TxtDireccion.Text == string.Empty || TxtTelefono.Text == string.Empty || TxtId.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(TxtNumDocumento, "Ingrese un número de documento");
                    ErrorIcono.SetError(TxtDireccion, "Ingrese una dirección");
                    ErrorIcono.SetError(TxtTelefono, "Ingrese un número de teléfono");
                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NPersona.Actualizar(Convert.ToInt32(TxtId.Text),"Proveedor", this.nombreAnt, TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim());
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El Proveedor se actualizo de forma correcta");
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

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked == true)
            {
                //Si el check box Seleccionar esta activado se activan las siguientes funcionalidades
                DgvListado.Columns[0].Visible = true;
                BtnEliminar.Visible = false;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;

            }
            else
            {
                //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
                DgvListado.Columns[0].Visible = false;
                BtnEliminar.Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
            }
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

                    //Elimino todos los registros seleccionados (ya que pueden ser muchos)
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //Si el check box esta seleccionado se elimina ese registro
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Guardo el codigo de la categoria que deseo eliminar
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            //envio la solicitud de eliminacion y guardo la respuesta recibida
                            respuesta = NPersona.Eliminar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(row.Cells[4].Value));
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

        //Metodo que se ejecuta al hacer click en Activar: Activa nuevamente un registro de la tabla Persona
        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificacion de si hay registros seleccionados o no
                int seleccionados = 0;

                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                    {
                        seleccionados++;
                    }
                }

                if (seleccionados == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un registro para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del evento
                }

                //SI HAY SELECCIONADOS, se pasa a este bloque de código
                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    bool seleccionado = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                    if (seleccionado)
                    {
                        int idpersona = Convert.ToInt32(row.Cells["ID"].Value);
                        string respuesta = NPersona.DarDeAlta(idpersona);

                        if (respuesta != "OK")
                        {
                            MessageBox.Show($"Error al dar de alta a la persona con ID {idpersona}: {respuesta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show("Los registros seleccionados fueron dados de alta correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Listar(); //recargar lista
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Metodo que al presionar el botón Desactivar de la baja de un registro de la tabla Persona.
        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificacion de si hay registros seleccionados o no
                int seleccionados = 0;

                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                    {
                        seleccionados++;
                    }
                }

                if (seleccionados == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un registro para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del evento
                }

                //SI HAY SELECCIONADOS, se pasa a este bloque de código
                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    bool seleccionado = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                    if (seleccionado)
                    {
                        int idpersona = Convert.ToInt32(row.Cells["ID"].Value);
                        string respuesta = NPersona.DarDeBaja(idpersona);

                        if (respuesta != "OK")
                        {
                            MessageBox.Show($"Error al dar de baja a la persona con ID {idpersona}: {respuesta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show("Los registros seleccionados fueron dados de baja correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Listar(); // Re-carga la lista
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
