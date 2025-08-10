namespace Presentacion
{
    partial class Frm_Consultar_Articulo
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.datagrid_productos = new System.Windows.Forms.DataGridView();
            this.LblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboMarcaBuscar = new System.Windows.Forms.ComboBox();
            this.CboCategoriaBuscar = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.lblInstruccionDobleClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_productos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(627, 46);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 28);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // datagrid_productos
            // 
            this.datagrid_productos.AllowUserToAddRows = false;
            this.datagrid_productos.AllowUserToDeleteRows = false;
            this.datagrid_productos.AllowUserToOrderColumns = true;
            this.datagrid_productos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.datagrid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_productos.Location = new System.Drawing.Point(7, 79);
            this.datagrid_productos.Name = "datagrid_productos";
            this.datagrid_productos.ReadOnly = true;
            this.datagrid_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_productos.Size = new System.Drawing.Size(1212, 333);
            this.datagrid_productos.TabIndex = 3;
            this.datagrid_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(762, 52);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(51, 21);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "Total: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInstruccionDobleClick);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CboMarcaBuscar);
            this.panel1.Controls.Add(this.CboCategoriaBuscar);
            this.panel1.Controls.Add(this.TxtBuscar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.datagrid_productos);
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 434);
            this.panel1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(496, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre";
            // 
            // CboMarcaBuscar
            // 
            this.CboMarcaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CboMarcaBuscar.Location = new System.Drawing.Point(427, 47);
            this.CboMarcaBuscar.Name = "CboMarcaBuscar";
            this.CboMarcaBuscar.Size = new System.Drawing.Size(194, 28);
            this.CboMarcaBuscar.TabIndex = 16;
            // 
            // CboCategoriaBuscar
            // 
            this.CboCategoriaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategoriaBuscar.FormattingEnabled = true;
            this.CboCategoriaBuscar.Location = new System.Drawing.Point(227, 46);
            this.CboCategoriaBuscar.Name = "CboCategoriaBuscar";
            this.CboCategoriaBuscar.Size = new System.Drawing.Size(194, 28);
            this.CboCategoriaBuscar.TabIndex = 15;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(7, 47);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(214, 26);
            this.TxtBuscar.TabIndex = 14;
            // 
            // lblInstruccionDobleClick
            // 
            this.lblInstruccionDobleClick.AutoSize = true;
            this.lblInstruccionDobleClick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInstruccionDobleClick.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccionDobleClick.Location = new System.Drawing.Point(958, 60);
            this.lblInstruccionDobleClick.Name = "lblInstruccionDobleClick";
            this.lblInstruccionDobleClick.Size = new System.Drawing.Size(261, 16);
            this.lblInstruccionDobleClick.TabIndex = 20;
            this.lblInstruccionDobleClick.Text = "🛈 Doble clic sobre un artículo para información.\n";
            // 
            // Frm_Consultar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1259, 464);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Consultar_Articulo";
            this.Text = "Consultar Artículo";
            this.Load += new System.EventHandler(this.Frm_Consultar_Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_productos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView datagrid_productos;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboMarcaBuscar;
        private System.Windows.Forms.ComboBox CboCategoriaBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label lblInstruccionDobleClick;
    }
}