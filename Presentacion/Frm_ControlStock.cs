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
            if (CboCategoria2.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría para continuar.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int umbral = (int)nudUmbral.Value;

            int? idCategoria = null;

            //Validacion que haya una categoría seleccionada
            if (CboCategoria2.SelectedValue != null && int.TryParse(CboCategoria2.SelectedValue.ToString(), out int id))
            {
                idCategoria = id;
            }

            DataTable dt = NReporte.EstadisticaStockCritico(umbral, idCategoria);


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

            // quitar cuadrícula y limpiar fondo
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

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

            //quitar cuadrícula y limpiar fondo
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

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

        //Método que activa el boton sin ventas. Esto trae los datos desde la BD y los muestra en un chart.
        private void btnSinVentas_Click(object sender, EventArgs e)
        {
            if (CboCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría para continuar.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategoria = Convert.ToInt32(CboCategoria.SelectedValue);
            DateTime fi = dtpSinVentasInicio.Value.Date;
            DateTime ff = dtpSinVentasFin.Value.Date.AddDays(1).AddTicks(-1);

            DataTable dt = NReporte.EstadisticaStockSinVentas(fi, ff, idCategoria);

            lblTotalSinVentas.Text = $"Total de artículos: {dt.Rows.Count}";
            if (dt.Rows.Count == 0)
            {
                chartStockSinVentas.Series.Clear();
                chartStockSinVentas.ChartAreas.Clear();
                chartStockSinVentas.Titles.Clear();
                MessageBox.Show("No se encontraron artículos sin ventas en el periodo seleccionado.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Orden por Stock desc y luego nombre
            dt.DefaultView.Sort = "StockActual DESC, Producto ASC";
            DataTable datos = dt.DefaultView.ToTable();

            // Limpiar y configurar
            chartStockSinVentas.Series.Clear();
            chartStockSinVentas.ChartAreas.Clear();
            chartStockSinVentas.Titles.Clear();

            var area = new ChartArea("AreaSinVentas");
            chartStockSinVentas.ChartAreas.Add(area);
            area.AxisX.Title = "Producto";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            // Scroll/zoom en X (si hay muchos productos)
            int visibles = Math.Min(20, datos.Rows.Count);
            area.AxisX.ScaleView.Size = visibles;
            area.AxisX.ScrollBar.Enabled = (datos.Rows.Count > visibles);
            area.CursorX.IsUserEnabled = (datos.Rows.Count > visibles);
            area.CursorX.IsUserSelectionEnabled = (datos.Rows.Count > visibles);

            area.AxisY.Title = "Stock Actual";
            area.AxisY.Minimum = 0;

            // quitar cuadrícula y limpiar fondo
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

            area.BackColor = Color.Transparent;          // área sin fondo
            chartStockSinVentas.BackColor = Color.White; // fondo del chart

            // ejes más livianos (opcional)
            area.AxisX.LineColor = Color.Silver;
            area.AxisY.LineColor = Color.Silver;

            // Serie
            var serie = new Series("SinVentas")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Producto",
                YValueMembers = "StockActual",
                IsValueShownAsLabel = true,
                LabelFormat = "N0"
            };
            serie.ChartArea = area.Name; // aseguro que use esta área
            serie["PointWidth"] = "0.55";  // deja un poco de espacio entre columnas
            serie.BorderWidth = 0;         // sin borde en las barras

            chartStockSinVentas.Series.Add(serie);

            chartStockSinVentas.DataSource = datos;
            chartStockSinVentas.DataBind();
            chartStockSinVentas.Titles.Add(
                $"Productos sin ventas ({fi:dd/MM/yyyy} – {ff:dd/MM/yyyy}) · Categoría: {CboCategoria.Text}"
            );
        }

        private void Frm_ControlStock_Load(object sender, EventArgs e)
        {
            CargarCategoriasObligatorio(CboCategoria);
            CargarCategoriasObligatorio(CboCategoria2);
        }

        //Método para cargar el Combo Box de categorias
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

        //Al activarse el formulario se ejecutan los siguientes métodos.
        private void Frm_ControlStock_Activated(object sender, EventArgs e)
        {
            CargarCategoriasObligatorio(CboCategoria);
            CargarCategoriasObligatorio(CboCategoria2);
        }
    }
}
