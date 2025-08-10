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
            DgvListado.Columns[8].Width = 130;
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
            var g = DgvMostrarDetalle;

            //Control
            if (g.Columns.Count < 9)
            {
                MessageBox.Show($"Se esperaban 9 columnas y hay {g.Columns.Count}.", "FormatoArticulos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 0 ID
            g.Columns[0].Visible = false;

            // 1 CODIGO
            g.Columns[1].HeaderText = "Código";
            g.Columns[1].Width = 100;

            // 2 ARTICULO
            g.Columns[2].HeaderText = "Artículo";
            g.Columns[2].Width = 220;

            // 3 MARCA, 4 COLOR, 5 MEMORIA
            g.Columns[3].Width = 120;
            g.Columns[4].Width = 90;
            g.Columns[5].Width = 90;

            // 6 CANTIDAD
            g.Columns[6].HeaderText = "Cantidad";
            g.Columns[6].Width = 90;
            g.Columns[6].DefaultCellStyle.Format = "N0";
            g.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // 7 PRECIO
            g.Columns[7].HeaderText = "Precio";
            g.Columns[7].Width = 150;
            g.Columns[7].DefaultCellStyle.Format = "C2";
            g.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // 8 IMPORTE
            g.Columns[8].HeaderText = "Importe";
            g.Columns[8].Width = 150;
            g.Columns[8].DefaultCellStyle.Format = "C2";
            g.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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

        private void FrmConsulta_ComprasFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
