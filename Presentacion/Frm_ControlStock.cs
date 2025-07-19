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
    public partial class Frm_ControlStock : Form
    {
        public Frm_ControlStock()
        {
            InitializeComponent();
        }

        private void btnCritico_Click(object sender, EventArgs e)
        {
            
            int umbral = (int)nudUmbral.Value;
            //CONTROL
            //MessageBox.Show($"Umbral pasado al SP: {umbral}",
            //                "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Busqueda de datos y carga de datatable
            DataTable dt = NReporte.EstadisticaStockCritico(umbral);

            //CONTROL
            //MessageBox.Show($"Filas devueltas: {dt.Rows.Count}",
            //    "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //cantidad de artículos encontrados
            lblTotalCritico.Text = $"Total de artículos: {dt.Rows.Count}";

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    $"No se encontraron productos con stock ≤ {umbral}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return; //Salir
            }

            //Limpiar chart de consultas
            chartStockCritico.Series.Clear();
            chartStockCritico.ChartAreas.Clear();
            chartStockCritico.Titles.Clear();


            // Área
            var area = new ChartArea("AreaCritico");
            chartStockCritico.ChartAreas.Add(area);

            // Etiquetas del eje X (productos)
            area.AxisX.Title = "Producto";
            area.AxisX.LabelStyle.Angle = -45;  //45° grados
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.IsStaggered = false;

            // Eje Y (cantidad)
            area.AxisY.Title = "Cantidad";

            //Serie de barras horizontales
            var serie = new Series("Stock")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Producto",
                YValueMembers = "Cantidad",
                IsValueShownAsLabel = true
            };
            chartStockCritico.Series.Add(serie);

            chartStockCritico.DataSource = dt;
            chartStockCritico.DataBind();
            chartStockCritico.Titles.Add($"Productos con stock ≤ {umbral}");
        }

        private void btnPorCategoria_Click(object sender, EventArgs e)
        {
            DataTable dt = NReporte.EstadisticaStockPorCategoria();

            //Limpiar el chart
            chartStockPorCategoria.Series.Clear();
            chartStockPorCategoria.ChartAreas.Clear();
            chartStockPorCategoria.Titles.Clear();

            //Area
            var area = new ChartArea("AreaPorCat");
            chartStockPorCategoria.ChartAreas.Add(area);
            area.AxisX.Title = "Categoría";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;
            area.AxisY.Title = "Total Stock";

            //Serie
            var serie = new Series("StockCat")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Categoria",
                YValueMembers = "TotalStock",
                IsValueShownAsLabel = true
            };
            chartStockPorCategoria.Series.Add(serie);

            chartStockPorCategoria.DataSource = dt;
            chartStockPorCategoria.DataBind();
            chartStockPorCategoria.Titles.Add("Distribución de Stock por Categoría");
        }

        private void btnSinVentas_Click(object sender, EventArgs e)
        {
            DateTime fi = dtpSinVentasInicio.Value.Date;
            DateTime ff = dtpSinVentasFin.Value.Date.AddDays(1).AddTicks(-1);

            DataTable dt = NReporte.EstadisticaStockSinVentas(fi, ff);

            //cantidad de artículos encontrados
            lblTotalSinVentas.Text = $"Total de artículos: {dt.Rows.Count}";

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    $"No se encontraron artículos sin ventas en el periodo seleccionado.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return; //Sale
            }

            //Limpiar chart
            chartStockSinVentas.Series.Clear();
            chartStockSinVentas.ChartAreas.Clear();
            chartStockSinVentas.Titles.Clear();

            //Area
            var area = new ChartArea("AreaSinVentas");
            chartStockSinVentas.ChartAreas.Add(area);
            area.AxisX.Title = "Producto";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;
            area.AxisY.Title = "Stock Actual";

            //Serie
            var serie = new Series("SinVentas")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Producto",
                YValueMembers = "StockActual",
                IsValueShownAsLabel = true
            };
            chartStockSinVentas.Series.Add(serie);

            chartStockSinVentas.DataSource = dt;
            chartStockSinVentas.DataBind();
            chartStockSinVentas.Titles.Add($"Productos sin ventas ({fi:dd/MM/yyyy} – {ff:dd/MM/yyyy})");
        }

        private void Frm_ControlStock_Load(object sender, EventArgs e)
        {

        }
    }
}
