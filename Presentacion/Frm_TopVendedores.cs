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
    public partial class Frm_TopVendedores : Form
    {
        public Frm_TopVendedores()
        {
            InitializeComponent();
        }

        private void BtnGenerarGrafico_Click(object sender, EventArgs e)
        {
            //Leer fechas (incluye todo el día final)
            DateTime fi = dtpFechaInicio.Value.Date;
            DateTime ff = dtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);

            //Obtenecion de datos
            DataTable dt = NReporte.EstadisticaRankingVendedores(fi, ff);

            //Limpiar el chart de otras consultas
            chartRankingVendedores.Series.Clear();
            chartRankingVendedores.ChartAreas.Clear();
            chartRankingVendedores.Titles.Clear();

            //Crear ChartArea
            var area = new ChartArea("AreaPrincipal");
            chartRankingVendedores.ChartAreas.Add(area);

            //Ejes Configuración.
            area.AxisX.Title = "Vendedor";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            area.AxisY.Title = "Total Importe";

            //5)Serie de columnas
            var serie = new Series("Importe")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Vendedor",     //nombre de la columna
                YValueMembers = "TotalImporte", //nombre de la columna
                IsValueShownAsLabel = true
            };

            var serie2 = new Series("Ventas")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = "Vendedor",
                YValueMembers = "NumVentas",
                BorderWidth = 2,
                Color = Color.DarkRed
            };

            chartRankingVendedores.Series.Add(serie);
            chartRankingVendedores.Series.Add(serie2);

            

            //Enlazar y actualizar
            chartRankingVendedores.DataSource = dt;
            chartRankingVendedores.DataBind();

            //Titulo del Gráfico
            chartRankingVendedores.Titles.Add(
                $"Ranking Vendedores ({dt.Rows.Count} registros)"
            );

        }
    
    }
}
