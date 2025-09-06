namespace Presentacion
{
    partial class FrmArticulo
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
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboColor = new System.Windows.Forms.ComboBox();
            this.CboMemoria = new System.Windows.Forms.ComboBox();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtStk = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.BtnGuardarCodigo = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtCod = new System.Windows.Forms.Label();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.TxtImg = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.TxtCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.BtnReporte = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboMarcaBuscar = new System.Windows.Forms.ComboBox();
            this.CboCategoriaBuscar = new System.Windows.Forms.ComboBox();
            this.lblInstruccionDobleClick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.BtnReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Khaki;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(879, 419);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(123, 36);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(888, 382);
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
            this.BtnCancelar.Location = new System.Drawing.Point(1008, 419);
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
            this.BtnInsertar.Location = new System.Drawing.Point(879, 419);
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
            this.TxtId.Location = new System.Drawing.Point(354, 87);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 21);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Location = new System.Drawing.Point(473, 274);
            this.TxtDescripcion.MaxLength = 255;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(369, 148);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Location = new System.Drawing.Point(207, 155);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(247, 28);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción (*)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CboColor);
            this.tabPage2.Controls.Add(this.CboMemoria);
            this.tabPage2.Controls.Add(this.CboMarca);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.TxtStock);
            this.tabPage2.Controls.Add(this.TxtStk);
            this.tabPage2.Controls.Add(this.TxtPrecioVenta);
            this.tabPage2.Controls.Add(this.TxtPrice);
            this.tabPage2.Controls.Add(this.PanelCodigo);
            this.tabPage2.Controls.Add(this.BtnGuardarCodigo);
            this.tabPage2.Controls.Add(this.BtnGenerar);
            this.tabPage2.Controls.Add(this.TxtCodigo);
            this.tabPage2.Controls.Add(this.TxtCod);
            this.tabPage2.Controls.Add(this.PicImagen);
            this.tabPage2.Controls.Add(this.BtnCargarImagen);
            this.tabPage2.Controls.Add(this.TxtImagen);
            this.tabPage2.Controls.Add(this.TxtImg);
            this.tabPage2.Controls.Add(this.CboCategoria);
            this.tabPage2.Controls.Add(this.TxtCategoria);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1247, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Memoria (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Color (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Marca (*)";
            // 
            // CboColor
            // 
            this.CboColor.FormattingEnabled = true;
            this.CboColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Gris",
            "Gris Oscuro",
            "Gris Claro",
            "Plateado",
            "Dorado",
            "Champagne",
            "Azul",
            "Azul Oscuro",
            "Azul Claro",
            "Rojo",
            "Bordó",
            "Verde",
            "Verde Oscuro",
            "Verde Claro",
            "Amarillo",
            "Naranja",
            "Rosa",
            "Rosa Pastel",
            "Violeta",
            "Púrpura",
            "Celeste",
            "Beige",
            "Marrón",
            "Transparente",
            "Multicolor",
            "Otro"});
            this.CboColor.Location = new System.Drawing.Point(595, 154);
            this.CboColor.Name = "CboColor";
            this.CboColor.Size = new System.Drawing.Size(247, 29);
            this.CboColor.TabIndex = 28;
            // 
            // CboMemoria
            // 
            this.CboMemoria.FormattingEnabled = true;
            this.CboMemoria.Items.AddRange(new object[] {
            "No Posee",
            "2/32",
            "3/32",
            "3/64",
            "4/64",
            "4/128",
            "6/64",
            "6/128",
            "6/256",
            "8/64",
            "8/128",
            "8/256",
            "8/512",
            "8/1024",
            "12/128",
            "12/256",
            "12/512",
            "12/1024",
            "12/2048",
            "16/256",
            "16/512",
            "16/1024",
            "16/2048",
            "24/512",
            "24/1024",
            "32/1024",
            "32/2048"});
            this.CboMemoria.Location = new System.Drawing.Point(595, 197);
            this.CboMemoria.Name = "CboMemoria";
            this.CboMemoria.Size = new System.Drawing.Size(247, 29);
            this.CboMemoria.TabIndex = 27;
            // 
            // CboMarca
            // 
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Motorola",
            "Xiaomi",
            "Oppo",
            "Realme",
            "Huawei",
            "Honor",
            "OnePlus",
            "TCL",
            "Nokia",
            "Infinix",
            "Panasonic",
            "Zte",
            "Colmi",
            "Noblex",
            "Asus",
            "Vivo",
            "Lenovo",
            "HP",
            "Dell",
            "Acer",
            "MSI",
            "Microsoft",
            "Razer",
            "Gigabyte",
            "JBL",
            "Sony",
            "Beats",
            "Skullcandy",
            "Bose",
            "Logitech",
            "Philips",
            "Sennheiser",
            "HyperX",
            "Redragon",
            "LG",
            "Anker",
            "Marshall",
            "Harman Kardon",
            "Corsair",
            "Genius",
            "Trust",
            "SteelSeries",
            "GFast",
            "X-Tech",
            "Kanji",
            "Netmak",
            "Philco",
            "Noga",
            "UGreen",
            "Belkin",
            "Targus",
            "TP-Link",
            "Vention",
            "Manhattan",
            "Otros"});
            this.CboMarca.Location = new System.Drawing.Point(595, 114);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(247, 29);
            this.CboMarca.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(216, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 67);
            this.panel1.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(103, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 37);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "ALTA DE ARTÍCULO";
            // 
            // TxtStock
            // 
            this.TxtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStock.Location = new System.Drawing.Point(1008, 339);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.ReadOnly = true;
            this.TxtStock.Size = new System.Drawing.Size(123, 28);
            this.TxtStock.TabIndex = 23;
            this.TxtStock.Visible = false;
            this.TxtStock.TextChanged += new System.EventHandler(this.TxtStock_TextChanged);
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // TxtStk
            // 
            this.TxtStk.AutoSize = true;
            this.TxtStk.Location = new System.Drawing.Point(1033, 315);
            this.TxtStk.Name = "TxtStk";
            this.TxtStk.Size = new System.Drawing.Size(69, 21);
            this.TxtStk.TabIndex = 22;
            this.TxtStk.Text = "Stock (*)";
            this.TxtStk.Visible = false;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecioVenta.Location = new System.Drawing.Point(879, 339);
            this.TxtPrecioVenta.MaxLength = 14;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(123, 28);
            this.TxtPrecioVenta.TabIndex = 21;
            this.TxtPrecioVenta.Visible = false;
            this.TxtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioVenta_KeyPress);
            // 
            // TxtPrice
            // 
            this.TxtPrice.AutoSize = true;
            this.TxtPrice.Location = new System.Drawing.Point(904, 315);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(74, 21);
            this.TxtPrice.TabIndex = 20;
            this.TxtPrice.Text = "Precio (*)";
            this.TxtPrice.Visible = false;
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCodigo.Location = new System.Drawing.Point(85, 272);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(369, 150);
            this.PanelCodigo.TabIndex = 19;
            // 
            // BtnGuardarCodigo
            // 
            this.BtnGuardarCodigo.BackColor = System.Drawing.Color.Snow;
            this.BtnGuardarCodigo.Enabled = false;
            this.BtnGuardarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarCodigo.Image = global::Presentacion.Properties.Resources.save_24px;
            this.BtnGuardarCodigo.Location = new System.Drawing.Point(301, 232);
            this.BtnGuardarCodigo.Name = "BtnGuardarCodigo";
            this.BtnGuardarCodigo.Size = new System.Drawing.Size(153, 34);
            this.BtnGuardarCodigo.TabIndex = 18;
            this.BtnGuardarCodigo.Text = "Guardar Código";
            this.BtnGuardarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardarCodigo.UseVisualStyleBackColor = false;
            this.BtnGuardarCodigo.Click += new System.EventHandler(this.BtnGuardarCodigo_Click);
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.Snow;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenerar.Image = global::Presentacion.Properties.Resources.barcode_24px;
            this.BtnGenerar.Location = new System.Drawing.Point(87, 232);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(153, 34);
            this.BtnGenerar.TabIndex = 17;
            this.BtnGenerar.Text = "Generar Código";
            this.BtnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.Location = new System.Drawing.Point(207, 198);
            this.TxtCodigo.MaxLength = 50;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(247, 28);
            this.TxtCodigo.TabIndex = 16;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // TxtCod
            // 
            this.TxtCod.AutoSize = true;
            this.TxtCod.Location = new System.Drawing.Point(120, 200);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(81, 21);
            this.TxtCod.TabIndex = 15;
            this.TxtCod.Text = "Código (*)";
            // 
            // PicImagen
            // 
            this.PicImagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicImagen.Location = new System.Drawing.Point(879, 117);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(252, 191);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 14;
            this.PicImagen.TabStop = false;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCargarImagen.Location = new System.Drawing.Point(1005, 37);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(126, 29);
            this.BtnCargarImagen.TabIndex = 13;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = false;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // TxtImagen
            // 
            this.TxtImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImagen.Enabled = false;
            this.TxtImagen.Location = new System.Drawing.Point(879, 77);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(252, 28);
            this.TxtImagen.TabIndex = 12;
            // 
            // TxtImg
            // 
            this.TxtImg.AutoSize = true;
            this.TxtImg.Location = new System.Drawing.Point(875, 45);
            this.TxtImg.Name = "TxtImg";
            this.TxtImg.Size = new System.Drawing.Size(83, 21);
            this.TxtImg.TabIndex = 11;
            this.TxtImg.Text = "Imagen (*)";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(207, 114);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(247, 29);
            this.CboCategoria.TabIndex = 10;
            this.CboCategoria.DropDown += new System.EventHandler(this.CboCategoria_DropDown);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.AutoSize = true;
            this.TxtCategoria.Location = new System.Drawing.Point(103, 122);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(98, 21);
            this.TxtCategoria.TabIndex = 9;
            this.TxtCategoria.Text = "Categoria (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Location = new System.Drawing.Point(10, 40);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(214, 28);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(895, 435);
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
            this.DgvListado.Location = new System.Drawing.Point(6, 83);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1231, 342);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.BtnReporte);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(12, 12);
            this.TabGeneral.Multiline = true;
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1255, 497);
            this.TabGeneral.TabIndex = 1;
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnReporte.Controls.Add(this.label9);
            this.BtnReporte.Controls.Add(this.label8);
            this.BtnReporte.Controls.Add(this.label7);
            this.BtnReporte.Controls.Add(this.CboMarcaBuscar);
            this.BtnReporte.Controls.Add(this.CboCategoriaBuscar);
            this.BtnReporte.Controls.Add(this.lblInstruccionDobleClick);
            this.BtnReporte.Controls.Add(this.button1);
            this.BtnReporte.Controls.Add(this.BtnEliminar);
            this.BtnReporte.Controls.Add(this.BtnDesactivar);
            this.BtnReporte.Controls.Add(this.BtnActivar);
            this.BtnReporte.Controls.Add(this.ChkSeleccionar);
            this.BtnReporte.Controls.Add(this.BtnBuscar);
            this.BtnReporte.Controls.Add(this.TxtBuscar);
            this.BtnReporte.Controls.Add(this.LblTotal);
            this.BtnReporte.Controls.Add(this.DgvListado);
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(4, 25);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Padding = new System.Windows.Forms.Padding(3);
            this.BtnReporte.Size = new System.Drawing.Size(1247, 468);
            this.BtnReporte.TabIndex = 0;
            this.BtnReporte.Text = "Listado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // CboMarcaBuscar
            // 
            this.CboMarcaBuscar.FormattingEnabled = true;
            this.CboMarcaBuscar.Items.AddRange(new object[] {
            "Todas",
            "Samsung",
            "Apple",
            "Motorola",
            "Xiaomi",
            "Oppo",
            "Realme",
            "Huawei",
            "Honor",
            "OnePlus",
            "TCL",
            "Nokia",
            "Infinix",
            "Zte",
            "Colmi",
            "Noblex",
            "Asus",
            "Vivo",
            "Lenovo",
            "HP",
            "Dell",
            "Acer",
            "MSI",
            "Microsoft",
            "Razer",
            "Gigabyte",
            "JBL",
            "Sony",
            "Beats",
            "Skullcandy",
            "Bose",
            "Logitech",
            "Philips",
            "Sennheiser",
            "HyperX",
            "Redragon",
            "LG",
            "Anker",
            "Marshall",
            "Harman Kardon",
            "Corsair",
            "Genius",
            "Trust",
            "SteelSeries",
            "GFast",
            "X-Tech",
            "Kanji",
            "Netmak",
            "Philco",
            "Noga",
            "UGreen",
            "Belkin",
            "Targus",
            "TP-Link",
            "Vention",
            "Manhattan",
            "Otros"});
            this.CboMarcaBuscar.Location = new System.Drawing.Point(430, 40);
            this.CboMarcaBuscar.Name = "CboMarcaBuscar";
            this.CboMarcaBuscar.Size = new System.Drawing.Size(194, 29);
            this.CboMarcaBuscar.TabIndex = 10;
            // 
            // CboCategoriaBuscar
            // 
            this.CboCategoriaBuscar.FormattingEnabled = true;
            this.CboCategoriaBuscar.Location = new System.Drawing.Point(230, 39);
            this.CboCategoriaBuscar.Name = "CboCategoriaBuscar";
            this.CboCategoriaBuscar.Size = new System.Drawing.Size(194, 29);
            this.CboCategoriaBuscar.TabIndex = 9;
            // 
            // lblInstruccionDobleClick
            // 
            this.lblInstruccionDobleClick.AutoSize = true;
            this.lblInstruccionDobleClick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInstruccionDobleClick.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccionDobleClick.Location = new System.Drawing.Point(983, 64);
            this.lblInstruccionDobleClick.Name = "lblInstruccionDobleClick";
            this.lblInstruccionDobleClick.Size = new System.Drawing.Size(254, 16);
            this.lblInstruccionDobleClick.TabIndex = 8;
            this.lblInstruccionDobleClick.Text = "🛈 Doble clic sobre un artículo para modificarlo\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(834, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Location = new System.Drawing.Point(658, 432);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(125, 25);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDesactivar.Location = new System.Drawing.Point(527, 431);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(125, 26);
            this.BtnDesactivar.TabIndex = 5;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = false;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActivar.Location = new System.Drawing.Point(396, 432);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(125, 25);
            this.BtnActivar.TabIndex = 4;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = false;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(207, 432);
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
            this.BtnBuscar.Location = new System.Drawing.Point(640, 39);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 30);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnBuscar_KeyDown);
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 521);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Articulos";
            this.Activated += new System.EventHandler(this.FrmArticulo_Activated);
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.BtnReporte.ResumeLayout(false);
            this.BtnReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage BtnReporte;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label TxtCategoria;
        private System.Windows.Forms.PictureBox PicImagen;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Label TxtImg;
        private System.Windows.Forms.Label TxtCod;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnGuardarCodigo;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label TxtStk;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label TxtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInstruccionDobleClick;
        private System.Windows.Forms.ToolTip toolTipGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboColor;
        private System.Windows.Forms.ComboBox CboMemoria;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboMarcaBuscar;
        private System.Windows.Forms.ComboBox CboCategoriaBuscar;
    }
}