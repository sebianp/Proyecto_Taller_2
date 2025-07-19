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
    public partial class FrmGrafico_VentasPorFecha : Form
    {
        public FrmGrafico_VentasPorFecha()
        {
            InitializeComponent();
        }

        private void FrmGrafico_VentasPorFecha_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerarGrafico_Click(object sender, EventArgs e)
        {
            //Se leen las fechas
            DateTime fi = DTPInicio.Value.Date;
            DateTime ff = DTPFinal.Value.Date;

            //Datos desde la capa de negocio
            DataTable dt = NReporte.EstadisticaVentasPeriodo(fi, ff);

            //Limpiar configuración previa del Chart
            chartVentas.Series.Clear();
            chartVentas.ChartAreas.Clear();
            chartVentas.Titles.Clear();

            //Crear el ChartArea
            var area = new ChartArea("MainArea");
            chartVentas.ChartAreas.Add(area);

            //Configurar los ejes
            area.AxisX.Title = "Fecha";
            area.AxisX.LabelStyle.Format = "dd/MM/yyyy";//día/mes/año
            area.AxisX.IntervalType = DateTimeIntervalType.Days;
            
            //controlar cuántas etiquetas se dibujan
            area.AxisX.Interval = Math.Max(1, dt.Rows.Count / 10);

            area.AxisY.Title = "Total Ventas";

            //Crear la Serie de tipo Línea
            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Fecha",          // columna del DataTable
                YValueMembers = "TotalVentas",   // columna del DataTable
                BorderWidth = 2,
                IsValueShownAsLabel = true      // true si querés mostrar el valor sobre el punto
            };
            chartVentas.Series.Add(serie);

            //Asignar los datos y enlazar
            chartVentas.DataSource = dt;
            chartVentas.DataBind();

            //Título del gráfico
            chartVentas.Titles.Add("Evolución de Ventas");
        }
    }
}
