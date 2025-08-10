namespace Presentacion
{
    partial class FrmConsulta_ComprasFecha
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.TxtImpuestosD = new System.Windows.Forms.TextBox();
            this.TxtSubTotalD = new System.Windows.Forms.TextBox();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblInstruccionDobleClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(593, 25);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 28);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(891, 568);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(51, 21);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total: ";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(5, 59);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1158, 496);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(3, 3);
            this.TabGeneral.Multiline = true;
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1181, 628);
            this.TabGeneral.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.lblInstruccionDobleClick);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DtpFechaFin);
            this.tabPage1.Controls.Add(this.DtpFechaInicio);
            this.tabPage1.Controls.Add(this.PanelMostrar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(360, 25);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(200, 28);
            this.DtpFechaFin.TabIndex = 9;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(62, 25);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 28);
            this.DtpFechaInicio.TabIndex = 8;
            // 
            // PanelMostrar
            // 
            this.PanelMostrar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PanelMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMostrar.Controls.Add(this.TxtTotalD);
            this.PanelMostrar.Controls.Add(this.TxtImpuestosD);
            this.PanelMostrar.Controls.Add(this.TxtSubTotalD);
            this.PanelMostrar.Controls.Add(this.BtnCerrarDetalle);
            this.PanelMostrar.Controls.Add(this.label14);
            this.PanelMostrar.Controls.Add(this.label13);
            this.PanelMostrar.Controls.Add(this.label12);
            this.PanelMostrar.Controls.Add(this.DgvMostrarDetalle);
            this.PanelMostrar.Location = new System.Drawing.Point(7, 78);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(1140, 496);
            this.PanelMostrar.TabIndex = 6;
            this.PanelMostrar.Visible = false;
            // 
            // TxtTotalD
            // 
            this.TxtTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalD.Enabled = false;
            this.TxtTotalD.Location = new System.Drawing.Point(931, 457);
            this.TxtTotalD.Name = "TxtTotalD";
            this.TxtTotalD.Size = new System.Drawing.Size(179, 28);
            this.TxtTotalD.TabIndex = 7;
            // 
            // TxtImpuestosD
            // 
            this.TxtImpuestosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImpuestosD.Enabled = false;
            this.TxtImpuestosD.Location = new System.Drawing.Point(931, 424);
            this.TxtImpuestosD.Name = "TxtImpuestosD";
            this.TxtImpuestosD.Size = new System.Drawing.Size(179, 28);
            this.TxtImpuestosD.TabIndex = 6;
            // 
            // TxtSubTotalD
            // 
            this.TxtSubTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubTotalD.Enabled = false;
            this.TxtSubTotalD.Location = new System.Drawing.Point(931, 389);
            this.TxtSubTotalD.Name = "TxtSubTotalD";
            this.TxtSubTotalD.Size = new System.Drawing.Size(179, 28);
            this.TxtSubTotalD.TabIndex = 5;
            // 
            // BtnCerrarDetalle
            // 
            this.BtnCerrarDetalle.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCerrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrarDetalle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarDetalle.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(1094, 3);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(41, 36);
            this.BtnCerrarDetalle.TabIndex = 4;
            this.BtnCerrarDetalle.Text = "X";
            this.BtnCerrarDetalle.UseVisualStyleBackColor = false;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(877, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(843, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Impuestos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(848, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sub-Total";
            // 
            // DgvMostrarDetalle
            // 
            this.DgvMostrarDetalle.AllowUserToAddRows = false;
            this.DgvMostrarDetalle.AllowUserToDeleteRows = false;
            this.DgvMostrarDetalle.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarDetalle.Location = new System.Drawing.Point(28, 45);
            this.DgvMostrarDetalle.Name = "DgvMostrarDetalle";
            this.DgvMostrarDetalle.ReadOnly = true;
            this.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarDetalle.Size = new System.Drawing.Size(1082, 337);
            this.DgvMostrarDetalle.TabIndex = 0;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // lblInstruccionDobleClick
            // 
            this.lblInstruccionDobleClick.AutoSize = true;
            this.lblInstruccionDobleClick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInstruccionDobleClick.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccionDobleClick.Location = new System.Drawing.Point(876, 40);
            this.lblInstruccionDobleClick.Name = "lblInstruccionDobleClick";
            this.lblInstruccionDobleClick.Size = new System.Drawing.Size(287, 16);
            this.lblInstruccionDobleClick.TabIndex = 12;
            this.lblInstruccionDobleClick.Text = "🛈 Doble clic sobre un registro para visualizar detalles.";
            // 
            // FrmConsulta_ComprasFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 647);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmConsulta_ComprasFecha";
            this.Text = "Ingresos por Fecha";
            this.Load += new System.EventHandler(this.FrmConsulta_ComprasFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelMostrar.ResumeLayout(false);
            this.PanelMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.TextBox TxtTotalD;
        private System.Windows.Forms.TextBox TxtImpuestosD;
        private System.Windows.Forms.TextBox TxtSubTotalD;
        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DgvMostrarDetalle;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label lblInstruccionDobleClick;
    }
}