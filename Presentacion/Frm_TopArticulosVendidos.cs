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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class Frm_TopArticulosVendidos : Form
    {
        public Frm_TopArticulosVendidos()
        {
            InitializeComponent();
        }

        private void btnTopProductos_Click(object sender, EventArgs e)
        {
            if (CboCategoria3.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría para continuar.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parámetros principales
            DateTime fi = dtpInicio.Value.Date;
            DateTime ff = dtpFin.Value.Date.AddDays(1);
            int topN = (int)nudTopN.Value;

            // Obtener ID y nombre de categoría seleccionada
            int? idCategoria = null;
            string nombreCategoria = "todas";

            if (CboCategoria3.SelectedValue != null && int.TryParse(CboCategoria3.SelectedValue.ToString(), out int id))
            {
                idCategoria = id;
                nombreCategoria = CboCategoria3.Text; // nombre visible en el ComboBox
            }

            // Obtener datos desde la base
            DataTable dt = NReporte.EstadisticaTopProductos(fi, ff, topN, idCategoria);

            MessageBox.Show("Cantidad de filas: " + dt.Rows.Count.ToString());

            // Limpiar chart
            chartTopProductos.Series.Clear();
            chartTopProductos.ChartAreas.Clear();
            chartTopProductos.Titles.Clear();

            // Área de gráfico
            var area = new ChartArea("Area");
            chartTopProductos.ChartAreas.Add(area);
            area.AxisX.Title = "Producto";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.IsStaggered = false;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;
            area.AxisY.Title = "Unidades Vendidas";

            // Serie de datos
            var serie = new Series("Unidades")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Producto",
                YValueMembers = "TotalUnidades",
                IsValueShownAsLabel = true
            };
            chartTopProductos.Series.Add(serie);

            // Asignar origen de datos y dibujar
            chartTopProductos.DataSource = dt;
            chartTopProductos.DataBind();

            // Título dinámico con categoría
            chartTopProductos.Titles.Add($"Top {topN} Productos Vendidos (Categoría: {nombreCategoria})");
        }

        private void Frm_TopArticulosVendidos_Load(object sender, EventArgs e)
        {
            CargarCategoriasObligatorio(CboCategoria3);
        }

        private void CargarCategoriasObligatorio(ComboBox combo)
        {
            try
            {
                DataTable dt = NCategoria.Seleccionar();

                //Ordenar por nombre
                DataView dv = dt.DefaultView;
                dv.Sort = "nombre ASC";
                DataTable dtOrdenado = dv.ToTable();

                combo.DataSource = dtOrdenado;
                combo.ValueMember = "idcategoria";
                combo.DisplayMember = "nombre";

                combo.DropDownStyle = ComboBoxStyle.DropDownList; // no permite escribir
                combo.SelectedIndex = -1;                         // obliga a elegir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Frm_TopArticulosVendidos_Activated(object sender, EventArgs e)
        {
            CargarCategoriasObligatorio(CboCategoria3);
        }
    }
}
