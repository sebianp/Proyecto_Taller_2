namespace Presentacion
{
    partial class FrmGrafico_VentasPorFecha
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnGenerarGrafico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.BtnGenerarGrafico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DTPFinal);
            this.panel1.Controls.Add(this.DTPInicio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 80);
            this.panel1.TabIndex = 0;
            // 
            // DTPInicio
            // 
            this.DTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPInicio.Location = new System.Drawing.Point(189, 30);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(200, 20);
            this.DTPInicio.TabIndex = 0;
            // 
            // DTPFinal
            // 
            this.DTPFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFinal.Location = new System.Drawing.Point(466, 30);
            this.DTPFinal.Name = "DTPFinal";
            this.DTPFinal.Size = new System.Drawing.Size(200, 20);
            this.DTPFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final";
            // 
            // chartVentas
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVentas.Legends.Add(legend3);
            this.chartVentas.Location = new System.Drawing.Point(12, 98);
            this.chartVentas.Name = "chartVentas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartVentas.Series.Add(series3);
            this.chartVentas.Size = new System.Drawing.Size(1006, 436);
            this.chartVentas.TabIndex = 1;
            this.chartVentas.Text = "chart1";
            // 
            // BtnGenerarGrafico
            // 
            this.BtnGenerarGrafico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGenerarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenerarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarGrafico.Location = new System.Drawing.Point(694, 28);
            this.BtnGenerarGrafico.Name = "BtnGenerarGrafico";
            this.BtnGenerarGrafico.Size = new System.Drawing.Size(138, 23);
            this.BtnGenerarGrafico.TabIndex = 4;
            this.BtnGenerarGrafico.Text = "Generar";
            this.BtnGenerarGrafico.UseVisualStyleBackColor = false;
            this.BtnGenerarGrafico.Click += new System.EventHandler(this.BtnGenerarGrafico_Click);
            // 
            // FrmGrafico_VentasPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 546);
            this.Controls.Add(this.chartVentas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGrafico_VentasPorFecha";
            this.Text = "Evolución de Ventas";
            this.Load += new System.EventHandler(this.FrmGrafico_VentasPorFecha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPFinal;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Button BtnGenerarGrafico;
    }
}