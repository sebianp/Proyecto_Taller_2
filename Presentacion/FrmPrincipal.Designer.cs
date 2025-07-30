namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAccesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_Consultar_Articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_evol_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_rank_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_rank_vendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.OPC_Control_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StBarraInferior = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlmacen,
            this.MnuIngresos,
            this.MnuVentas,
            this.MnuAccesos,
            this.MnuConsultas,
            this.Menu_estadisticas,
            this.Menu_Backup,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1090, 61);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuAlmacen
            // 
            this.MnuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPC_Categorias,
            this.OPC_articulos});
            this.MnuAlmacen.Image = global::Presentacion.Properties.Resources.shop_32px;
            this.MnuAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MnuAlmacen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuAlmacen.Name = "MnuAlmacen";
            this.MnuAlmacen.Size = new System.Drawing.Size(82, 57);
            this.MnuAlmacen.Text = "Almacén";
            this.MnuAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // OPC_Categorias
            // 
            this.OPC_Categorias.Name = "OPC_Categorias";
            this.OPC_Categorias.Size = new System.Drawing.Size(180, 26);
            this.OPC_Categorias.Text = "Cate&gorías";
            this.OPC_Categorias.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // OPC_articulos
            // 
            this.OPC_articulos.Name = "OPC_articulos";
            this.OPC_articulos.Size = new System.Drawing.Size(180, 26);
            this.OPC_articulos.Text = "&Articulos";
            this.OPC_articulos.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // MnuIngresos
            // 
            this.MnuIngresos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.MnuIngresos.Image = global::Presentacion.Properties.Resources.send_32px;
            this.MnuIngresos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuIngresos.Name = "MnuIngresos";
            this.MnuIngresos.Size = new System.Drawing.Size(81, 57);
            this.MnuIngresos.Text = "Ingresos";
            this.MnuIngresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.proveedoresToolStripMenuItem.Text = "&Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.comprasToolStripMenuItem.Text = "&Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem1});
            this.MnuVentas.Image = global::Presentacion.Properties.Resources.cart_32px;
            this.MnuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Size = new System.Drawing.Size(69, 57);
            this.MnuVentas.Text = "Ventas";
            this.MnuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.clientesToolStripMenuItem.Text = "Clien&tes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.ventasToolStripMenuItem1.Text = "&Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // MnuAccesos
            // 
            this.MnuAccesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.MnuAccesos.Image = global::Presentacion.Properties.Resources.users_32px;
            this.MnuAccesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuAccesos.Name = "MnuAccesos";
            this.MnuAccesos.Size = new System.Drawing.Size(77, 57);
            this.MnuAccesos.Text = "Accesos";
            this.MnuAccesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.rolesToolStripMenuItem.Text = "&Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MnuConsultas
            // 
            this.MnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPC_Consultar_Articulos,
            this.consultarVentasToolStripMenuItem,
            this.consultarComprasToolStripMenuItem});
            this.MnuConsultas.Image = global::Presentacion.Properties.Resources.consultas_32px;
            this.MnuConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuConsultas.Name = "MnuConsultas";
            this.MnuConsultas.Size = new System.Drawing.Size(90, 57);
            this.MnuConsultas.Text = "Consultas";
            this.MnuConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // OPC_Consultar_Articulos
            // 
            this.OPC_Consultar_Articulos.Name = "OPC_Consultar_Articulos";
            this.OPC_Consultar_Articulos.Size = new System.Drawing.Size(218, 26);
            this.OPC_Consultar_Articulos.Text = "Consultar Artículos";
            this.OPC_Consultar_Articulos.Click += new System.EventHandler(this.OPC_Consultar_Articulos_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.consultarVentasToolStripMenuItem.Text = "Ventas por Fechas";
            this.consultarVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasToolStripMenuItem_Click);
            // 
            // consultarComprasToolStripMenuItem
            // 
            this.consultarComprasToolStripMenuItem.Name = "consultarComprasToolStripMenuItem";
            this.consultarComprasToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.consultarComprasToolStripMenuItem.Text = "Ingresos por Fechas";
            this.consultarComprasToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasToolStripMenuItem_Click);
            // 
            // Menu_estadisticas
            // 
            this.Menu_estadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPC_evol_ventas,
            this.OPC_rank_articulos,
            this.OPC_rank_vendedores,
            this.OPC_Control_stock});
            this.Menu_estadisticas.Image = global::Presentacion.Properties.Resources.stats_32px;
            this.Menu_estadisticas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_estadisticas.Name = "Menu_estadisticas";
            this.Menu_estadisticas.Size = new System.Drawing.Size(101, 57);
            this.Menu_estadisticas.Text = "Estadisticas";
            this.Menu_estadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // OPC_evol_ventas
            // 
            this.OPC_evol_ventas.Name = "OPC_evol_ventas";
            this.OPC_evol_ventas.Size = new System.Drawing.Size(224, 26);
            this.OPC_evol_ventas.Text = "Evolución de Ventas";
            this.OPC_evol_ventas.Click += new System.EventHandler(this.evoluciónDeVentasToolStripMenuItem_Click);
            // 
            // OPC_rank_articulos
            // 
            this.OPC_rank_articulos.Name = "OPC_rank_articulos";
            this.OPC_rank_articulos.Size = new System.Drawing.Size(224, 26);
            this.OPC_rank_articulos.Text = "Ranking Articulos";
            this.OPC_rank_articulos.Click += new System.EventHandler(this.rankingArticulosToolStripMenuItem_Click);
            // 
            // OPC_rank_vendedores
            // 
            this.OPC_rank_vendedores.Name = "OPC_rank_vendedores";
            this.OPC_rank_vendedores.Size = new System.Drawing.Size(224, 26);
            this.OPC_rank_vendedores.Text = "Ranking Vendedores";
            this.OPC_rank_vendedores.Click += new System.EventHandler(this.rankingVendedoresToolStripMenuItem_Click);
            // 
            // OPC_Control_stock
            // 
            this.OPC_Control_stock.Name = "OPC_Control_stock";
            this.OPC_Control_stock.Size = new System.Drawing.Size(224, 26);
            this.OPC_Control_stock.Text = "Control de Stock";
            this.OPC_Control_stock.Click += new System.EventHandler(this.controlDeStockToolStripMenuItem_Click);
            // 
            // Menu_Backup
            // 
            this.Menu_Backup.Image = global::Presentacion.Properties.Resources.folder2_32px;
            this.Menu_Backup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Backup.Name = "Menu_Backup";
            this.Menu_Backup.Size = new System.Drawing.Size(72, 57);
            this.Menu_Backup.Text = "Backup";
            this.Menu_Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Backup.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Presentacion.Properties.Resources.exit_32px;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 57);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StBarraInferior});
            this.statusStrip.Location = new System.Drawing.Point(0, 586);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StBarraInferior
            // 
            this.StBarraInferior.Name = "StBarraInferior";
            this.StBarraInferior.Size = new System.Drawing.Size(513, 17);
            this.StBarraInferior.Text = "Desarrolado por Sebastian Prado - Taller de Programación 2 - Universidad Nacional" +
    " del Nordeste";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 608);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Ventas - LIBERTEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StBarraInferior;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem OPC_Categorias;
        private System.Windows.Forms.ToolStripMenuItem OPC_articulos;
        private System.Windows.Forms.ToolStripMenuItem MnuIngresos;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuVentas;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuAccesos;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_estadisticas;
        private System.Windows.Forms.ToolStripMenuItem OPC_evol_ventas;
        private System.Windows.Forms.ToolStripMenuItem OPC_rank_articulos;
        private System.Windows.Forms.ToolStripMenuItem OPC_rank_vendedores;
        private System.Windows.Forms.ToolStripMenuItem OPC_Control_stock;
        private System.Windows.Forms.ToolStripMenuItem Menu_Backup;
        private System.Windows.Forms.ToolStripMenuItem OPC_Consultar_Articulos;
    }
}



