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
    public partial class FrmConsulta_VentaFechas : Form
    {
        public FrmConsulta_VentaFechas()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                //Agregamos como recurso el listado obtenido de la BD en base al parametro enviado
                //Esto permite mostrar los datos recibidos con los resultados de la busqueda
                if (Variables.UsuarioRol == "Administrador")
                {
                    DgvListado.DataSource = NVenta.ConsultaFechas(Convert.ToDateTime(DtpFechaInicio.Value), Convert.ToDateTime(DtpFechaFin.Value.AddDays(1)));
                }
                else
                {
                    DgvListado.DataSource = NVenta.ConsultaVentasFechasUsuario(Convert.ToDateTime(DtpFechaInicio.Value), Convert.ToDateTime(DtpFechaFin.Value.AddDays(1)),Variables.IdUsuario);
                }
                
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

        //Este metodo permite darle un formato a las columnas del datagrid Categorias
        private void Formato()
        {
            if (DgvListado.Columns.Count < 12)
            {
                MessageBox.Show("Error: Se esperaban al menos 12 columnas, hay " + DgvListado.Columns.Count);
                return;
            }

            DgvListado.Columns[0].Visible = false; // Seleccionar (checkbox)
            DgvListado.Columns[0].Width = 50;

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

            DgvListado.Columns[7].Width = 70;      // Número
            DgvListado.Columns[7].HeaderText = "Número";

            DgvListado.Columns[8].Width = 130;     // Fecha
            DgvListado.Columns[8].HeaderText = "Fecha";

            DgvListado.Columns[9].Width = 100;     // Impuesto
            DgvListado.Columns[9].HeaderText = "Impuesto";

            DgvListado.Columns[10].Width = 100;    // Total
            DgvListado.Columns[10].HeaderText = "Total";

            DgvListado.Columns[11].Width = 100;    // Estado
            DgvListado.Columns[11].HeaderText = "Estado";
        }

        

        //Metodo Limpiar: Vacia las textbox de mantenimiento y buscar de listado
        private void Limpiar()
        {
            //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
            DgvListado.Columns[0].Visible = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmConsulta_VentaFechas_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void FormatoDetalleVenta()
        {
            var g = DgvMostrarDetalle;

            // Oculto ID (si querés verlo, quitá esta línea)
            if (g.Columns.Contains("ID"))
                g.Columns["ID"].Visible = false;

            g.Columns["CODIGO"].HeaderText = "Código";
            g.Columns["CODIGO"].Width = 100;

            g.Columns["ARTICULO"].HeaderText = "Artículo";
            g.Columns["ARTICULO"].Width = 220;

            g.Columns["MARCA"].Width = 120;
            g.Columns["MEMORIA"].Width = 90;
            g.Columns["COLOR"].Width = 90;

            g.Columns["CANTIDAD"].HeaderText = "Cant.";
            g.Columns["CANTIDAD"].Width = 60;
            g.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            g.Columns["PRECIO"].DefaultCellStyle.Format = "C2";
            g.Columns["PRECIO"].Width = 100;
            g.Columns["PRECIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            g.Columns["DESCUENTO"].HeaderText = "Descuento (%)";
            g.Columns["DESCUENTO"].DefaultCellStyle.Format = "N0";
            g.Columns["DESCUENTO"].Width = 110;
            g.Columns["DESCUENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            g.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            g.Columns["IMPORTE"].Width = 110;
            g.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Opcionales que ayudan:
            g.ReadOnly = true; // es un detalle histórico
            g.AllowUserToAddRows = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Los datos obtenemos de listar detalles y como parametro usamos el ID de la fila seleccionada
                DgvMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));

                //Formato de columnas
                this.FormatoDetalleVenta();

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

        private void BtnComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // 1)validar que haya al menos una fila en el DataGridView
                if (DgvListado.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ventas para generar comprobante.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2)validar que CurrentRow no sea nulo (aunque Rows.Count > 0)
                if (DgvListado.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una venta antes de generar el comprobante.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3)validar que la celda ID tenga un valor
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

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
        }
    }
}
