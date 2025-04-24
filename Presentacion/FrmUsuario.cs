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
    public partial class Usuarios : Form
    {
        //Esta variable es utilizada para determinar si el email de un usuario esta repetida
        // en el método actualizar
        private string emailAnt;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                DgvListado.DataSource = NUsuario.Listar();
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
                DgvListado.DataSource = NUsuario.Buscar(TxtBuscar.Text);
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

            //Dimensiones
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Width = 170;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[6].Width = 150;
            DgvListado.Columns[7].Width = 120;
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[9].Width = 120;

            //Headers
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].HeaderText = "Número Doc";
            DgvListado.Columns[7].HeaderText = "Dirección";
            DgvListado.Columns[8].HeaderText = "Teléfono";

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
            TxtClave.Clear();
            TxtTelefono.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();

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

        //Método para cargar la lista de roles en el combobox
        private void CargarRol()
        {
            try
            {

                CboRol.DataSource = NRol.Listar();
                CboRol.ValueMember = "idrol";
                CboRol.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarRol();
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
                if (TxtNombre.Text == string.Empty || CboRol.Text == string.Empty || TxtEmail.Text == string.Empty || TxtClave.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(CboRol, "Ingrese un Rol");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(TxtEmail, "Ingrese un Email");
                    ErrorIcono.SetError(TxtClave, "Ingrese una Clave");
                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NUsuario.Insertar(Convert.ToInt32(CboRol.SelectedValue) ,TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El Usuario se registro de forma correcta");
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
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboRol.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idrol"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                CboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtNumDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                TxtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                TxtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                this.emailAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TabGeneral.SelectedIndex = 1;

            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Seleccione desde la celda nombre" + "| Error: "+ ex.Message + ex.StackTrace);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //El nombre debe tener algun valor porque es obligatorio
                if (TxtId.Text == string.Empty || TxtNombre.Text == string.Empty || CboRol.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(CboRol, "Ingrese un Rol");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(TxtEmail, "Ingrese un Email");
                    ErrorIcono.SetError(TxtClave, "Ingrese una Clave");
                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NUsuario.Actualizar(Convert.ToInt32(TxtId.Text), Convert.ToInt32(CboRol.SelectedValue), TxtNombre.Text.Trim(), CboTipoDocumento.Text, TxtNumDocumento.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(), this.emailAnt, TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El Usuario se actualizó de forma correcta");
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
                BtnEliminar.Visible = true;

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

                    //Elimino todos los registros seleccionados (ya que pueden ser muchos)
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        //Si el check box esta seleccionado se elimina ese registro
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //Guardo el codigo de la categoria que deseo eliminar
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            //envio la solicitud de eliminacion y guardo la respuesta recibida
                            respuesta = NUsuario.Eliminar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el Usuario: " + Convert.ToString(row.Cells[4].Value));
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

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizamos esta variable para guardar el resultado de la selección del mensaje
                DialogResult Opcion;
                //Se le pide al usuario por medio de un mensaje que confirme la eliminación
                Opcion = MessageBox.Show("Realmente deseas desactivar el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            respuesta = NUsuario.Desactivar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo el Usuario: " + Convert.ToString(row.Cells[4].Value));
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
                //Se le pide al usuario por medio de un mensaje que confirme la eliminación
                Opcion = MessageBox.Show("Realmente deseas activar el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            respuesta = NUsuario.Activar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se activo el Usuario: " + Convert.ToString(row.Cells[4].Value));
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
    }
}
