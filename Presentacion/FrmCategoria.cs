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
    public partial class FrmCategoria : Form
    {
        //Variable para almacenar el nombre anterior, utilizada en el metodo Actualizar.
        private string NombreAnt;   

        //Constructor
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                //Agregamos como recurso del Datagrid el listado obtenido de la BD
                //Esto permite cargar y mostrar los datos de la tabla Categoria
                DgvListado.DataSource = NCategoria.Listar();
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
                DgvListado.DataSource = NCategoria.Buscar(TxtBuscar.Text);
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
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 200;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripción"; //Porque desde la BD recibe sin tilde
            DgvListado.Columns[4].Width = 150;

        }

        //Metodo Limpiar: Vacia las textbox de mantenimiento y buscar de listado
        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtId.Clear();
            TxtDescripcion.Clear();
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

        //FORMULARIO DE INICIO
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            //Cuando el formulario se cargue, se hace referencia al metodo Listar que
            //proporciona la información al bloque Listado para mostrar todas las categorias
            lblTitulo.Text = "ALTA DE CATEGORIA";
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
                if (TxtNombre.Text == string.Empty || TxtDescripcion.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                    ErrorIcono.SetError(TxtDescripcion, "Ingrese descripción");
                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NCategoria.Insertar(TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
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
            lblTitulo.Text = "ALTA DE CATEGORIA";
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                lblTitulo.Text = "MODIFICAR CATEGORIA";
                this.Limpiar();
                //Modificamos la visibilidad de los botones para actualizar
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                //Obtenemos los valores de las celdas para cargar en los textbox de actualizar
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                //Pasamos directamente a la tab page de mantenimiento
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception) 
            {
                MessageBox.Show("Para modificar haga doble click en la celda Nombre de la categoría especifica");
            }

            

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //El nombre debe tener algun valor porque es obligatorio
                if (TxtNombre.Text == string.Empty || TxtId.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre");
                }
                else //En caso de cumplir con el campo obligatorio del nombre, se puede almacenar
                {
                    //Se almacena la respuesta recibida al insertar un nuevo registro
                    //Enviado por el metodo insertar de la capa negocio
                    respuesta = NCategoria.Actualizar(Convert.ToInt32(TxtId.Text), this.NombreAnt, TxtNombre.Text.Trim(), TxtDescripcion.Text.Trim());
                    //Validamos que tipo de mensaje recibimos para mostrar al usuario
                    if (respuesta.Equals("OK"))
                    {
                        //Si almaceno correctamente recibirá OK y va a mostrar la respuesta OK
                        this.MensajeOk("El registro se actualizó de forma correcta");
                        this.Limpiar();
                        this.Listar();
                        lblTitulo.Text = "ALTA DE CATEGORIA";
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
                Opcion = MessageBox.Show("Realmente deseas eliminar el/los registro/s?","Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            respuesta = NCategoria.Eliminar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(row.Cells[2].Value));
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
                //Se le pide al usuario por medio de un mensaje que confirme la la activación.
                Opcion = MessageBox.Show("Realmente deseas activar el/los registro/s?", "Eliminar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            respuesta = NCategoria.Activar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se activo el registro: " + Convert.ToString(row.Cells[2].Value));
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
                            respuesta = NCategoria.Desactivar(codigo);

                            if (respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivo el registro: " + Convert.ToString(row.Cells[2].Value));
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
