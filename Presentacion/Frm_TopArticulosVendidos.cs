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
            //Obtención de parametros
            DateTime fi = dtpInicio.Value.Date;
            DateTime ff = dtpFin.Value.Date;
            int topN = (int)nudTopN.Value;

            //Pedido de datos a la DB
            DataTable dt = NReporte.EstadisticaTopProductos(fi, ff, topN);

            //Limpieza del chart para agregar nuevos datos
            chartTopProductos.Series.Clear();
            chartTopProductos.ChartAreas.Clear();
            chartTopProductos.Titles.Clear();

            //Area de dibujo
            var area = new ChartArea("Area");
            chartTopProductos.ChartAreas.Add(area);
            area.AxisX.Title = "Producto";
            area.AxisX.LabelStyle.Angle = -45;//Rotacion
            area.AxisX.Interval = 1;//cada producto

            //quitar cuadrícula y limpiar fondo
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

            area.AxisY.Title = "Unidades Vendidas";

            //Serie de barras
            var serie = new Series("Unidades")
            {
                ChartType = SeriesChartType.Column,  
                XValueMember = "Producto",              
                YValueMembers = "TotalUnidades",         
                IsValueShownAsLabel = true
            };
            chartTopProductos.Series.Add(serie);

            //Enlace y dibujo
            chartTopProductos.DataSource = dt;
            chartTopProductos.DataBind();

            //Título del chart
            chartTopProductos.Titles.Add($"Top {topN} Productos Vendidos");
        }

        private void Frm_TopArticulosVendidos_Load(object sender, EventArgs e)
        {

        }
    }
}
