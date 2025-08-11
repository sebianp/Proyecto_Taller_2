namespace Presentacion
{
    partial class FrmProveedor
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
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNumDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(1, 2);
            this.TabGeneral.Multiline = true;
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1267, 513);
            this.TabGeneral.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.BtnDesactivar);
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnActivar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1259, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDesactivar.Location = new System.Drawing.Point(330, 435);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(125, 26);
            this.BtnDesactivar.TabIndex = 7;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = false;
            this.BtnDesactivar.Visible = false;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Location = new System.Drawing.Point(461, 435);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(125, 26);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActivar.Location = new System.Drawing.Point(199, 436);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(125, 25);
            this.BtnActivar.TabIndex = 6;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = false;
            this.BtnActivar.Visible = false;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(66, 438);
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
            this.BtnBuscar.Location = new System.Drawing.Point(369, 25);
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
            this.TxtBuscar.Size = new System.Drawing.Size(357, 28);
            this.TxtBuscar.TabIndex = 1;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(535, 32);
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
            this.DgvListado.Size = new System.Drawing.Size(1244, 366);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.TxtEmail);
            this.tabPage2.Controls.Add(this.TxtTelefono);
            this.tabPage2.Controls.Add(this.TxtDireccion);
            this.tabPage2.Controls.Add(this.TxtNumDocumento);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.CboTipoDocumento);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1259, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Location = new System.Drawing.Point(479, 357);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(367, 28);
            this.TxtEmail.TabIndex = 19;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefono.Location = new System.Drawing.Point(479, 307);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(367, 28);
            this.TxtTelefono.TabIndex = 17;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDireccion.Location = new System.Drawing.Point(479, 257);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(367, 28);
            this.TxtDireccion.TabIndex = 16;
            // 
            // TxtNumDocumento
            // 
            this.TxtNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumDocumento.Location = new System.Drawing.Point(479, 207);
            this.TxtNumDocumento.Name = "TxtNumDocumento";
            this.TxtNumDocumento.Size = new System.Drawing.Size(367, 28);
            this.TxtNumDocumento.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "CUIL/CUIT",
            "PASAPORTE"});
            this.CboTipoDocumento.Location = new System.Drawing.Point(478, 156);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(369, 29);
            this.CboTipoDocumento.TabIndex = 14;
            this.CboTipoDocumento.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dirección (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número Documento (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Documento (*)";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Khaki;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(479, 433);
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
            this.label3.Location = new System.Drawing.Point(547, 388);
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
            this.BtnCancelar.Location = new System.Drawing.Point(722, 433);
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
            this.BtnInsertar.Location = new System.Drawing.Point(478, 433);
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
            this.TxtId.Location = new System.Drawing.Point(747, 79);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 21);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Location = new System.Drawing.Point(478, 106);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(369, 28);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1009, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "🛈 Doble clic sobre registro para modificarlo.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(405, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 67);
            this.panel1.TabIndex = 26;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(103, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(311, 37);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "ALTA DE PROVEEDOR";
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 530);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmProveedor";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNumDocumento;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
    }
}