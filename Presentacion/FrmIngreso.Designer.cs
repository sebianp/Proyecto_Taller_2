namespace Presentacion
{
    partial class FrmIngreso
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
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.CboComprobante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEliminarItem = new System.Windows.Forms.Button();
            this.PanelArticulos = new System.Windows.Forms.Panel();
            this.lblInstruccionDobleClick = new System.Windows.Forms.Label();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnCerrarArticulos = new System.Windows.Forms.Button();
            this.BtnFiltrarArticulos = new System.Windows.Forms.Button();
            this.TxtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnVerListado = new System.Windows.Forms.Button();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.BtnBuscarArticulo = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnActualizarTotales = new System.Windows.Forms.Button();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtNumComprobante = new System.Windows.Forms.TextBox();
            this.TxtSerieComprobante = new System.Windows.Forms.TextBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.TxtIdProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.TxtImpuestosD = new System.Windows.Forms.TextBox();
            this.TxtSubTotalD = new System.Windows.Forms.TextBox();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PanelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // CboComprobante
            // 
            this.CboComprobante.FormattingEnabled = true;
            this.ErrorIcono.SetIconAlignment(this.CboComprobante, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA",
            "TICKET"});
            this.CboComprobante.Location = new System.Drawing.Point(141, 83);
            this.CboComprobante.Name = "CboComprobante";
            this.CboComprobante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CboComprobante.Size = new System.Drawing.Size(159, 29);
            this.CboComprobante.TabIndex = 12;
            this.CboComprobante.Text = "FACTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*) Indica campos obligatorios";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(615, 579);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 36);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.Location = new System.Drawing.Point(476, 579);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(123, 36);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "INSERTAR";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Location = new System.Drawing.Point(1024, 15);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 21);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1173, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo Ingreso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEliminarItem);
            this.groupBox2.Controls.Add(this.PanelArticulos);
            this.groupBox2.Controls.Add(this.BtnVerListado);
            this.groupBox2.Controls.Add(this.TxtSubTotal);
            this.groupBox2.Controls.Add(this.TxtTotalImpuesto);
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DgvDetalle);
            this.groupBox2.Controls.Add(this.BtnBuscarArticulo);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1157, 424);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // BtnEliminarItem
            // 
            this.BtnEliminarItem.BackColor = System.Drawing.Color.Coral;
            this.BtnEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarItem.Image = global::Presentacion.Properties.Resources.delete_16px;
            this.BtnEliminarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarItem.Location = new System.Drawing.Point(1043, 43);
            this.BtnEliminarItem.Name = "BtnEliminarItem";
            this.BtnEliminarItem.Size = new System.Drawing.Size(81, 26);
            this.BtnEliminarItem.TabIndex = 28;
            this.BtnEliminarItem.Text = "Quitar";
            this.BtnEliminarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarItem.UseVisualStyleBackColor = false;
            this.BtnEliminarItem.Click += new System.EventHandler(this.BtnEliminarItem_Click);
            // 
            // PanelArticulos
            // 
            this.PanelArticulos.BackColor = System.Drawing.Color.Snow;
            this.PanelArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelArticulos.Controls.Add(this.lblInstruccionDobleClick);
            this.PanelArticulos.Controls.Add(this.LblTotalArticulos);
            this.PanelArticulos.Controls.Add(this.DgvArticulos);
            this.PanelArticulos.Controls.Add(this.BtnCerrarArticulos);
            this.PanelArticulos.Controls.Add(this.BtnFiltrarArticulos);
            this.PanelArticulos.Controls.Add(this.TxtBuscarArticulo);
            this.PanelArticulos.Controls.Add(this.label11);
            this.PanelArticulos.Location = new System.Drawing.Point(17, 82);
            this.PanelArticulos.Name = "PanelArticulos";
            this.PanelArticulos.Size = new System.Drawing.Size(1145, 353);
            this.PanelArticulos.TabIndex = 26;
            this.PanelArticulos.Visible = false;
            // 
            // lblInstruccionDobleClick
            // 
            this.lblInstruccionDobleClick.AutoSize = true;
            this.lblInstruccionDobleClick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInstruccionDobleClick.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccionDobleClick.Location = new System.Drawing.Point(540, 29);
            this.lblInstruccionDobleClick.Name = "lblInstruccionDobleClick";
            this.lblInstruccionDobleClick.Size = new System.Drawing.Size(243, 16);
            this.lblInstruccionDobleClick.TabIndex = 10;
            this.lblInstruccionDobleClick.Text = "🛈 Doble clic sobre un artículo para agregarlo";
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Location = new System.Drawing.Point(816, 315);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(47, 21);
            this.LblTotalArticulos.TabIndex = 5;
            this.LblTotalArticulos.Text = "Total:";
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AllowUserToOrderColumns = true;
            this.DgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(27, 48);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(1090, 261);
            this.DgvArticulos.TabIndex = 4;
            this.DgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulos_CellDoubleClick);
            // 
            // BtnCerrarArticulos
            // 
            this.BtnCerrarArticulos.BackColor = System.Drawing.Color.DimGray;
            this.BtnCerrarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrarArticulos.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarArticulos.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrarArticulos.Location = new System.Drawing.Point(1106, 3);
            this.BtnCerrarArticulos.Name = "BtnCerrarArticulos";
            this.BtnCerrarArticulos.Size = new System.Drawing.Size(34, 36);
            this.BtnCerrarArticulos.TabIndex = 3;
            this.BtnCerrarArticulos.Text = "X";
            this.BtnCerrarArticulos.UseVisualStyleBackColor = false;
            this.BtnCerrarArticulos.Click += new System.EventHandler(this.BtnCerrarArticulos_Click);
            // 
            // BtnFiltrarArticulos
            // 
            this.BtnFiltrarArticulos.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnFiltrarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrarArticulos.Location = new System.Drawing.Point(442, 8);
            this.BtnFiltrarArticulos.Name = "BtnFiltrarArticulos";
            this.BtnFiltrarArticulos.Size = new System.Drawing.Size(75, 31);
            this.BtnFiltrarArticulos.TabIndex = 2;
            this.BtnFiltrarArticulos.Text = "Buscar";
            this.BtnFiltrarArticulos.UseVisualStyleBackColor = false;
            this.BtnFiltrarArticulos.Click += new System.EventHandler(this.BtnFiltrarArticulos_Click);
            // 
            // TxtBuscarArticulo
            // 
            this.TxtBuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarArticulo.Location = new System.Drawing.Point(85, 9);
            this.TxtBuscarArticulo.Name = "TxtBuscarArticulo";
            this.TxtBuscarArticulo.Size = new System.Drawing.Size(352, 28);
            this.TxtBuscarArticulo.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Buscar";
            // 
            // BtnVerListado
            // 
            this.BtnVerListado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnVerListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerListado.Location = new System.Drawing.Point(482, 27);
            this.BtnVerListado.Name = "BtnVerListado";
            this.BtnVerListado.Size = new System.Drawing.Size(174, 32);
            this.BtnVerListado.TabIndex = 25;
            this.BtnVerListado.Text = "Ver Lista de Artículos";
            this.BtnVerListado.UseVisualStyleBackColor = false;
            this.BtnVerListado.Click += new System.EventHandler(this.BtnVerListado_Click);
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Location = new System.Drawing.Point(100, 381);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(232, 28);
            this.TxtSubTotal.TabIndex = 24;
            // 
            // TxtTotalImpuesto
            // 
            this.TxtTotalImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalImpuesto.Enabled = false;
            this.TxtTotalImpuesto.Location = new System.Drawing.Point(470, 381);
            this.TxtTotalImpuesto.Name = "TxtTotalImpuesto";
            this.TxtTotalImpuesto.Size = new System.Drawing.Size(232, 28);
            this.TxtTotalImpuesto.TabIndex = 23;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(797, 381);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(232, 28);
            this.TxtTotal.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(746, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Impuesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sub-Total";
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.AllowUserToDeleteRows = false;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Location = new System.Drawing.Point(27, 75);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(1097, 291);
            this.DgvDetalle.TabIndex = 18;
            this.DgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit);
            this.DgvDetalle.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvDetalle_CellValidating);
            this.DgvDetalle.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvDetalle_UserDeletedRow);
            // 
            // BtnBuscarArticulo
            // 
            this.BtnBuscarArticulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarArticulo.Location = new System.Drawing.Point(374, 27);
            this.BtnBuscarArticulo.Name = "BtnBuscarArticulo";
            this.BtnBuscarArticulo.Size = new System.Drawing.Size(76, 32);
            this.BtnBuscarArticulo.TabIndex = 17;
            this.BtnBuscarArticulo.Text = "Agregar";
            this.BtnBuscarArticulo.UseVisualStyleBackColor = false;
            this.BtnBuscarArticulo.Click += new System.EventHandler(this.BtnBuscarArticulo_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.Location = new System.Drawing.Point(141, 31);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(226, 28);
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Código Artículo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnActualizarTotales);
            this.groupBox1.Controls.Add(this.TxtImpuesto);
            this.groupBox1.Controls.Add(this.BtnBuscarProveedor);
            this.groupBox1.Controls.Add(this.TxtNumComprobante);
            this.groupBox1.Controls.Add(this.TxtSerieComprobante);
            this.groupBox1.Controls.Add(this.CboComprobante);
            this.groupBox1.Controls.Add(this.TxtNombreProveedor);
            this.groupBox1.Controls.Add(this.TxtIdProveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // BtnActualizarTotales
            // 
            this.BtnActualizarTotales.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnActualizarTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarTotales.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarTotales.Location = new System.Drawing.Point(981, 84);
            this.BtnActualizarTotales.Name = "BtnActualizarTotales";
            this.BtnActualizarTotales.Size = new System.Drawing.Size(156, 28);
            this.BtnActualizarTotales.TabIndex = 17;
            this.BtnActualizarTotales.Text = "Actualizar Totales";
            this.BtnActualizarTotales.UseVisualStyleBackColor = false;
            this.BtnActualizarTotales.Click += new System.EventHandler(this.BtnActualizarTotales_Click);
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImpuesto.Location = new System.Drawing.Point(903, 84);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtImpuesto.Size = new System.Drawing.Size(49, 28);
            this.TxtImpuesto.TabIndex = 16;
            this.TxtImpuesto.Text = "0,05";
            this.TxtImpuesto.TextChanged += new System.EventHandler(this.TxtImpuesto_TextChanged);
            this.TxtImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImpuesto_KeyPress);
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(813, 27);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(74, 28);
            this.BtnBuscarProveedor.TabIndex = 15;
            this.BtnBuscarProveedor.Text = "Buscar";
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // TxtNumComprobante
            // 
            this.TxtNumComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumComprobante.Location = new System.Drawing.Point(556, 84);
            this.TxtNumComprobante.Name = "TxtNumComprobante";
            this.TxtNumComprobante.Size = new System.Drawing.Size(234, 28);
            this.TxtNumComprobante.TabIndex = 14;
            this.TxtNumComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumComprobante_KeyPress);
            // 
            // TxtSerieComprobante
            // 
            this.TxtSerieComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSerieComprobante.Location = new System.Drawing.Point(326, 84);
            this.TxtSerieComprobante.Name = "TxtSerieComprobante";
            this.TxtSerieComprobante.Size = new System.Drawing.Size(220, 28);
            this.TxtSerieComprobante.TabIndex = 13;
            this.TxtSerieComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerieComprobante_KeyPress);
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreProveedor.Enabled = false;
            this.TxtNombreProveedor.Location = new System.Drawing.Point(326, 27);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.ReadOnly = true;
            this.TxtNombreProveedor.Size = new System.Drawing.Size(464, 28);
            this.TxtNombreProveedor.TabIndex = 11;
            // 
            // TxtIdProveedor
            // 
            this.TxtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdProveedor.Enabled = false;
            this.TxtIdProveedor.Location = new System.Drawing.Point(141, 27);
            this.TxtIdProveedor.Name = "TxtIdProveedor";
            this.TxtIdProveedor.ReadOnly = true;
            this.TxtIdProveedor.Size = new System.Drawing.Size(159, 28);
            this.TxtIdProveedor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Impuesto (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comprobante (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proveedor(*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BtnAnular
            // 
            this.BtnAnular.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnular.Location = new System.Drawing.Point(128, 559);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(125, 26);
            this.BtnAnular.TabIndex = 5;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(5, 561);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(108, 25);
            this.ChkSeleccionar.TabIndex = 3;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(191, 25);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 28);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Location = new System.Drawing.Point(6, 25);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(179, 28);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(460, 32);
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
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            this.DgvListado.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvListado_RowsRemoved);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.PanelMostrar);
            this.tabPage1.Controls.Add(this.BtnAnular);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(925, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(238, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "🛈 Doble clic sobre registro para ver detalles.";
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
            this.PanelMostrar.Location = new System.Drawing.Point(64, 77);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(1019, 496);
            this.PanelMostrar.TabIndex = 6;
            this.PanelMostrar.Visible = false;
            // 
            // TxtTotalD
            // 
            this.TxtTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalD.Enabled = false;
            this.TxtTotalD.Location = new System.Drawing.Point(806, 455);
            this.TxtTotalD.Name = "TxtTotalD";
            this.TxtTotalD.Size = new System.Drawing.Size(179, 28);
            this.TxtTotalD.TabIndex = 7;
            // 
            // TxtImpuestosD
            // 
            this.TxtImpuestosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImpuestosD.Enabled = false;
            this.TxtImpuestosD.Location = new System.Drawing.Point(806, 422);
            this.TxtImpuestosD.Name = "TxtImpuestosD";
            this.TxtImpuestosD.Size = new System.Drawing.Size(179, 28);
            this.TxtImpuestosD.TabIndex = 6;
            // 
            // TxtSubTotalD
            // 
            this.TxtSubTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubTotalD.Enabled = false;
            this.TxtSubTotalD.Location = new System.Drawing.Point(806, 387);
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
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(973, 4);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(41, 35);
            this.BtnCerrarDetalle.TabIndex = 4;
            this.BtnCerrarDetalle.Text = "X";
            this.BtnCerrarDetalle.UseVisualStyleBackColor = false;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(752, 458);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(718, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Impuestos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(723, 394);
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
            this.DgvMostrarDetalle.Location = new System.Drawing.Point(33, 45);
            this.DgvMostrarDetalle.Name = "DgvMostrarDetalle";
            this.DgvMostrarDetalle.ReadOnly = true;
            this.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarDetalle.Size = new System.Drawing.Size(952, 337);
            this.DgvMostrarDetalle.TabIndex = 0;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(12, 12);
            this.TabGeneral.Multiline = true;
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1181, 655);
            this.TabGeneral.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Número de Comprobante";
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 669);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmIngreso";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PanelArticulos.ResumeLayout(false);
            this.PanelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelMostrar.ResumeLayout(false);
            this.PanelMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumComprobante;
        private System.Windows.Forms.TextBox TxtSerieComprobante;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.TextBox TxtIdProveedor;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Button BtnBuscarArticulo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.TextBox TxtTotalImpuesto;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnVerListado;
        private System.Windows.Forms.Panel PanelArticulos;
        private System.Windows.Forms.Button BtnCerrarArticulos;
        private System.Windows.Forms.Button BtnFiltrarArticulos;
        private System.Windows.Forms.TextBox TxtBuscarArticulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Button BtnActualizarTotales;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.TextBox TxtSubTotalD;
        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DgvMostrarDetalle;
        private System.Windows.Forms.TextBox TxtTotalD;
        private System.Windows.Forms.TextBox TxtImpuestosD;
        private System.Windows.Forms.Label lblInstruccionDobleClick;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnEliminarItem;
        private System.Windows.Forms.Label label16;
    }
}