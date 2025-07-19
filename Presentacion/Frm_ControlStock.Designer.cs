namespace Presentacion
{
    partial class Frm_ControlStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlStock = new System.Windows.Forms.TabControl();
            this.tpCritico = new System.Windows.Forms.TabPage();
            this.chartStockCritico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCritico = new System.Windows.Forms.Button();
            this.nudUmbral = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPorCategoria = new System.Windows.Forms.TabPage();
            this.chartStockPorCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPorCategoria = new System.Windows.Forms.Button();
            this.tpSinVentas = new System.Windows.Forms.TabPage();
            this.chartStockSinVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSinVentas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSinVentasFin = new System.Windows.Forms.DateTimePicker();
            this.dtpSinVentasInicio = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCritico = new System.Windows.Forms.Label();
            this.lblTotalSinVentas = new System.Windows.Forms.Label();
            this.tabControlStock.SuspendLayout();
            this.tpCritico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockCritico)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUmbral)).BeginInit();
            this.tpPorCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockPorCategoria)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpSinVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockSinVentas)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStock
            // 
            this.tabControlStock.Controls.Add(this.tpCritico);
            this.tabControlStock.Controls.Add(this.tpPorCategoria);
            this.tabControlStock.Controls.Add(this.tpSinVentas);
            this.tabControlStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStock.Location = new System.Drawing.Point(-1, 1);
            this.tabControlStock.Name = "tabControlStock";
            this.tabControlStock.SelectedIndex = 0;
            this.tabControlStock.Size = new System.Drawing.Size(1023, 519);
            this.tabControlStock.TabIndex = 0;
            // 
            // tpCritico
            // 
            this.tpCritico.Controls.Add(this.chartStockCritico);
            this.tpCritico.Controls.Add(this.panel1);
            this.tpCritico.Location = new System.Drawing.Point(4, 25);
            this.tpCritico.Name = "tpCritico";
            this.tpCritico.Padding = new System.Windows.Forms.Padding(3);
            this.tpCritico.Size = new System.Drawing.Size(1015, 490);
            this.tpCritico.TabIndex = 0;
            this.tpCritico.Text = "Stock Critico";
            this.tpCritico.UseVisualStyleBackColor = true;
            // 
            // chartStockCritico
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStockCritico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStockCritico.Legends.Add(legend1);
            this.chartStockCritico.Location = new System.Drawing.Point(3, 102);
            this.chartStockCritico.Name = "chartStockCritico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStockCritico.Series.Add(series1);
            this.chartStockCritico.Size = new System.Drawing.Size(1006, 383);
            this.chartStockCritico.TabIndex = 1;
            this.chartStockCritico.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalCritico);
            this.panel1.Controls.Add(this.btnCritico);
            this.panel1.Controls.Add(this.nudUmbral);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnCritico
            // 
            this.btnCritico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCritico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCritico.Location = new System.Drawing.Point(511, 32);
            this.btnCritico.Name = "btnCritico";
            this.btnCritico.Size = new System.Drawing.Size(75, 26);
            this.btnCritico.TabIndex = 2;
            this.btnCritico.Text = "Visualizar";
            this.btnCritico.UseVisualStyleBackColor = false;
            this.btnCritico.Click += new System.EventHandler(this.btnCritico_Click);
            // 
            // nudUmbral
            // 
            this.nudUmbral.Location = new System.Drawing.Point(443, 35);
            this.nudUmbral.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUmbral.Name = "nudUmbral";
            this.nudUmbral.Size = new System.Drawing.Size(51, 22);
            this.nudUmbral.TabIndex = 1;
            this.nudUmbral.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Umbral";
            // 
            // tpPorCategoria
            // 
            this.tpPorCategoria.Controls.Add(this.chartStockPorCategoria);
            this.tpPorCategoria.Controls.Add(this.panel2);
            this.tpPorCategoria.Location = new System.Drawing.Point(4, 25);
            this.tpPorCategoria.Name = "tpPorCategoria";
            this.tpPorCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tpPorCategoria.Size = new System.Drawing.Size(1015, 490);
            this.tpPorCategoria.TabIndex = 1;
            this.tpPorCategoria.Text = "Stock por Categoría";
            this.tpPorCategoria.UseVisualStyleBackColor = true;
            // 
            // chartStockPorCategoria
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStockPorCategoria.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStockPorCategoria.Legends.Add(legend2);
            this.chartStockPorCategoria.Location = new System.Drawing.Point(6, 102);
            this.chartStockPorCategoria.Name = "chartStockPorCategoria";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStockPorCategoria.Series.Add(series2);
            this.chartStockPorCategoria.Size = new System.Drawing.Size(1003, 388);
            this.chartStockPorCategoria.TabIndex = 2;
            this.chartStockPorCategoria.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPorCategoria);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 93);
            this.panel2.TabIndex = 1;
            // 
            // btnPorCategoria
            // 
            this.btnPorCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorCategoria.Location = new System.Drawing.Point(421, 26);
            this.btnPorCategoria.Name = "btnPorCategoria";
            this.btnPorCategoria.Size = new System.Drawing.Size(116, 23);
            this.btnPorCategoria.TabIndex = 0;
            this.btnPorCategoria.Text = "Ver Distribución";
            this.btnPorCategoria.UseVisualStyleBackColor = false;
            this.btnPorCategoria.Click += new System.EventHandler(this.btnPorCategoria_Click);
            // 
            // tpSinVentas
            // 
            this.tpSinVentas.Controls.Add(this.chartStockSinVentas);
            this.tpSinVentas.Controls.Add(this.panel3);
            this.tpSinVentas.Location = new System.Drawing.Point(4, 25);
            this.tpSinVentas.Name = "tpSinVentas";
            this.tpSinVentas.Size = new System.Drawing.Size(1015, 490);
            this.tpSinVentas.TabIndex = 2;
            this.tpSinVentas.Text = "Sin Ventas";
            this.tpSinVentas.UseVisualStyleBackColor = true;
            // 
            // chartStockSinVentas
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStockSinVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStockSinVentas.Legends.Add(legend3);
            this.chartStockSinVentas.Location = new System.Drawing.Point(9, 102);
            this.chartStockSinVentas.Name = "chartStockSinVentas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartStockSinVentas.Series.Add(series3);
            this.chartStockSinVentas.Size = new System.Drawing.Size(996, 383);
            this.chartStockSinVentas.TabIndex = 2;
            this.chartStockSinVentas.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalSinVentas);
            this.panel3.Controls.Add(this.btnSinVentas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpSinVentasFin);
            this.panel3.Controls.Add(this.dtpSinVentasInicio);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 93);
            this.panel3.TabIndex = 1;
            // 
            // btnSinVentas
            // 
            this.btnSinVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSinVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSinVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinVentas.Location = new System.Drawing.Point(573, 29);
            this.btnSinVentas.Name = "btnSinVentas";
            this.btnSinVentas.Size = new System.Drawing.Size(75, 25);
            this.btnSinVentas.TabIndex = 4;
            this.btnSinVentas.Text = "Visualizar";
            this.btnSinVentas.UseVisualStyleBackColor = false;
            this.btnSinVentas.Click += new System.EventHandler(this.btnSinVentas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio";
            // 
            // dtpSinVentasFin
            // 
            this.dtpSinVentasFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSinVentasFin.Location = new System.Drawing.Point(344, 29);
            this.dtpSinVentasFin.Name = "dtpSinVentasFin";
            this.dtpSinVentasFin.Size = new System.Drawing.Size(200, 22);
            this.dtpSinVentasFin.TabIndex = 1;
            // 
            // dtpSinVentasInicio
            // 
            this.dtpSinVentasInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSinVentasInicio.Location = new System.Drawing.Point(83, 29);
            this.dtpSinVentasInicio.Name = "dtpSinVentasInicio";
            this.dtpSinVentasInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpSinVentasInicio.TabIndex = 0;
            // 
            // lblTotalCritico
            // 
            this.lblTotalCritico.AutoSize = true;
            this.lblTotalCritico.Location = new System.Drawing.Point(780, 64);
            this.lblTotalCritico.Name = "lblTotalCritico";
            this.lblTotalCritico.Size = new System.Drawing.Size(113, 16);
            this.lblTotalCritico.TabIndex = 3;
            this.lblTotalCritico.Text = "Total de artículos:";
            // 
            // lblTotalSinVentas
            // 
            this.lblTotalSinVentas.AutoSize = true;
            this.lblTotalSinVentas.Location = new System.Drawing.Point(797, 53);
            this.lblTotalSinVentas.Name = "lblTotalSinVentas";
            this.lblTotalSinVentas.Size = new System.Drawing.Size(113, 16);
            this.lblTotalSinVentas.TabIndex = 5;
            this.lblTotalSinVentas.Text = "Total de artículos:";
            // 
            // Frm_ControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 520);
            this.Controls.Add(this.tabControlStock);
            this.Name = "Frm_ControlStock";
            this.Text = "Control de Stock";
            this.Load += new System.EventHandler(this.Frm_ControlStock_Load);
            this.tabControlStock.ResumeLayout(false);
            this.tpCritico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockCritico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUmbral)).EndInit();
            this.tpPorCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockPorCategoria)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tpSinVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockSinVentas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStock;
        private System.Windows.Forms.TabPage tpCritico;
        private System.Windows.Forms.TabPage tpPorCategoria;
        private System.Windows.Forms.TabPage tpSinVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockCritico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCritico;
        private System.Windows.Forms.NumericUpDown nudUmbral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockPorCategoria;
        private System.Windows.Forms.Button btnPorCategoria;
        private System.Windows.Forms.Button btnSinVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSinVentasFin;
        private System.Windows.Forms.DateTimePicker dtpSinVentasInicio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockSinVentas;
        private System.Windows.Forms.Label lblTotalCritico;
        private System.Windows.Forms.Label lblTotalSinVentas;
    }
}