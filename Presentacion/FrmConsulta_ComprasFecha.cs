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
    public partial class FrmConsulta_ComprasFecha : Form
    {
        public FrmConsulta_ComprasFecha()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            //Si el check box Seleccionar esta desactivado se desactivan las siguientes funcionalidades
            DgvListado.Columns[0].Visible = false;
        }

        private void Formato()
        {
            //Control para ver si recibe todas las columnas esperadas.
            if (DgvListado.Columns.Count < 12)
            {
                MessageBox.Show("Error: se esperaban 12 columnas, hay "
                                 + DgvListado.Columns.Count,
                                 "Formato",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            // Ocultar Select / ID / idusuario
            DgvListado.Columns[0].Visible = false; // Seleccionar
            DgvListado.Columns[1].Visible = false; // ID
            DgvListado.Columns[2].Visible = false; // idusuario

            // Seleccionar
            DgvListado.Columns[0].Width = 100;

            // Usuario
            DgvListado.Columns[3].Visible = true;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[3].HeaderText = "Usuario";

            // Proveedor
            DgvListado.Columns[4].Visible = true;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[4].HeaderText = "Proveedor";

            // Documento
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";

            // Serie
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";

            // Número
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";

            // Fecha
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Fecha";

            // Impuesto
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[9].HeaderText = "Impuesto";

            // Total
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[10].HeaderText = "Total";

            // Estado
            DgvListado.Columns[11].Width = 100;
            DgvListado.Columns[11].HeaderText = "Estado";

        }

        private void FormatoArticulos()
        {
            // Verificamos que haya al menos las 6 columnas esperadas
            if (DgvMostrarDetalle.Columns.Count < 6)
            {
                MessageBox.Show($"Error: se esperaban 6 columnas en DgvArticulos, hay {DgvMostrarDetalle.Columns.Count}",
                                "FormatoArticulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //0: ID (oculto)
            DgvMostrarDetalle.Columns[0].Visible = false;

            //1: CODIGO
            DgvMostrarDetalle.Columns[1].Visible = true;
            DgvMostrarDetalle.Columns[1].HeaderText = "Código";
            DgvMostrarDetalle.Columns[1].Width = 100;

            //2: ARTICULO
            DgvMostrarDetalle.Columns[2].Visible = true;
            DgvMostrarDetalle.Columns[2].HeaderText = "Artículo";
            DgvMostrarDetalle.Columns[2].Width = 200;

            //3: CANTIDAD
            DgvMostrarDetalle.Columns[3].Visible = true;
            DgvMostrarDetalle.Columns[3].HeaderText = "Cantidad";
            DgvMostrarDetalle.Columns[3].Width = 80;
            DgvMostrarDetalle.Columns[3].DefaultCellStyle.Format = "N0"; //entero

            //4: PRECIO
            DgvMostrarDetalle.Columns[4].Visible = true;
            DgvMostrarDetalle.Columns[4].HeaderText = "Precio";
            DgvMostrarDetalle.Columns[4].Width = 100;
            DgvMostrarDetalle.Columns[4].DefaultCellStyle.Format = "C2"; //moneda

            //5: IMPORTE
            DgvMostrarDetalle.Columns[5].Visible = true;
            DgvMostrarDetalle.Columns[5].HeaderText = "Importe";
            DgvMostrarDetalle.Columns[5].Width = 100;
            DgvMostrarDetalle.Columns[5].DefaultCellStyle.Format = "C2"; //moneda
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables de fechas
                DateTime fi = DtpFechaInicio.Value.Date;
                DateTime ff = DtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);

                //Efectuar la consulta
                DataTable Datos = NIngreso.ConsultaFechas(fi, ff);
                DgvListado.DataSource = Datos;

                //Formato y Reset de selección
                Formato();
                Limpiar();
                LblTotal.Text = "Total Registros: " + DgvListado.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ingresos por fecha:\n" + ex.Message,
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Los datos obtenemos de listar detalles y como parametro usamos el ID de la fila seleccionada
                DgvMostrarDetalle.DataSource = NIngreso.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                this.FormatoArticulos(); // Formato para ordenar el DgvMostrarDetalle
                decimal Total, Subtotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                //Total*(1 - Convert.ToDecimal(TxtImpuesto.Text));
                Subtotal = Total * (1 - Impuesto);
                TxtSubTotalD.Text = Subtotal.ToString("#0.00#");
                TxtImpuestosD.Text = (Total - Subtotal).ToString("#0.00#"); //TOTAL IMPUESTOS
                TxtTotalD.Text = Total.ToString("#0.00#");
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
    }
}
