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
using System.Windows.Forms.VisualStyles;


namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int idUsuario;
        public int idRol;
        public string nombre;
        public string rol;
        public bool estado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Se instancia un objeto del formulario categoria
            AbrirFormularioUnico(new FrmCategoria());

            //FrmCategoria frm = new FrmCategoria();
            ////Indicamos que el formulario instanciado sea hijo del MDI principal
            //// De esta forma el FrmPrincipal va a ser contenedor del FrmCategoria
            //frm.MdiParent = this;

            ////Mostramos el formulario categoria
            //frm.Show();

            //



        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmArticulo());
            //FrmArticulo frm = new FrmArticulo();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmRol());
            //FrmRol frm = new FrmRol();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //La clase en Presentacion fue creada con el nombre Usuario, no FrmUsuario
            AbrirFormularioUnico(new Usuarios());
            //Usuarios frm = new Usuarios();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar la sesión? Se cerrarán todos los formularios abiertos.",
                "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                //Cierra todos los formularios contenidos
                foreach (Form hijo in this.MdiChildren)
                {
                    hijo.Close();
                }

                //Cierra este formulario
                this.Hide();

                FrmLogin login = Application.OpenForms["FrmLogin"] as FrmLogin;

                if (login != null)
                {
                    login.Show(); //reabre el login ya oculto
                }
                else
                {
                    FrmLogin nuevoLogin = new FrmLogin();
                    nuevoLogin.Show();
                }

                ////Muestra el login
                //FrmLogin frm = new FrmLogin();
                //frm.Show();

                //Reinicia la aplicación mostrando el login
                //Application.Restart();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Bienvenido " + this.nombre + " - ROL: " + Variables.UsuarioRol,
                    "Inicio de sesión", // Este es el título de la ventana
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            StBarraInferior.Text = "Desarrollado por Sebastian Prado - Taller de Programación 2 - UNNE - 2025  ----------- USUARIO:" + this.nombre;

            //MENSAJE DE STOCK CRITICO PARA ROL "ALMACENERO (Encargado del deposito)"
            if (Variables.UsuarioRol == "Almacenero")
            {
                const int UMBRAL_STOCK_CRITICO = 5; //UMBRAL DE STOCK CRITICO
                MostrarAvisoStockCritico(UMBRAL_STOCK_CRITICO);
            }


            if (this.rol.Equals("Administrador"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = true;
                MnuAccesos.Enabled = true;
                MnuConsultas.Enabled = true;
                Menu_Backup.Enabled = true;
                Menu_estadisticas.Enabled = true;
                OPC_Control_stock.Enabled = true;
                OPC_rank_vendedores.Enabled = true;
                OPC_evol_ventas.Enabled = true;
                OPC_rank_articulos.Enabled = true;
                
            }
            else
            {
                if (this.rol.Equals("Vendedor"))
                {
                    MnuAlmacen.Enabled = false;
                    MnuIngresos.Enabled = false;
                    MnuVentas.Enabled = true;
                    MnuAccesos.Enabled = false;
                    MnuConsultas.Enabled = true;
                    Menu_Backup.Enabled = false;
                    Menu_estadisticas.Enabled = true;
                    OPC_Control_stock.Enabled = false;
                    OPC_rank_vendedores.Enabled = true;
                    OPC_evol_ventas.Enabled = false;
                    OPC_rank_articulos.Enabled = true;
                    consultarComprasToolStripMenuItem.Enabled = false;

                }
                else
                {
                    if (this.rol.Equals("Almacenero"))
                    {
                        MnuAlmacen.Enabled = true;
                        MnuIngresos.Enabled = true;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = true;
                        Menu_Backup.Enabled = false;
                        Menu_estadisticas.Enabled = true;
                        OPC_Control_stock.Enabled = true;
                        OPC_rank_vendedores.Enabled = false;
                        OPC_evol_ventas.Enabled = false;
                        OPC_rank_articulos.Enabled = true;
                        consultarVentasToolStripMenuItem.Enabled= false;

                    }
                    else
                    {
                        MnuAlmacen.Enabled = false;
                        MnuIngresos.Enabled = false;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = false;
                        Menu_Backup.Enabled = false;
                        Menu_estadisticas.Enabled = false;
                        OPC_Control_stock.Enabled = false;
                        OPC_rank_vendedores.Enabled = false;
                        OPC_evol_ventas.Enabled = false;
                        OPC_rank_articulos.Enabled = false;

                    }
                }

            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
            
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmProveedor());
            //FrmProveedor frm = new FrmProveedor();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmCliente());
            //FrmCliente cliente = new FrmCliente();
            //cliente.MdiParent = this;
            //cliente.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmIngreso());
            //FrmIngreso ingreso = new FrmIngreso();
            //ingreso.MdiParent = this;
            //ingreso.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmVenta());
            //FrmVenta venta = new FrmVenta();
            //venta.MdiParent = this;
            //venta.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmConsulta_VentaFechas());
            //FrmConsulta_VentaFechas consulta = new FrmConsulta_VentaFechas();
            //consulta.MdiParent = this;
            //consulta.Show();
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmConsulta_ComprasFecha());
            //FrmConsulta_ComprasFecha consulta = new FrmConsulta_ComprasFecha();
            //consulta.MdiParent = this;
            //consulta.Show();
        }

        private void evoluciónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new FrmGrafico_VentasPorFecha());
            //FrmGrafico_VentasPorFecha consulta = new FrmGrafico_VentasPorFecha();
            //consulta.MdiParent = this;
            //consulta.Show();
        }

        private void rankingArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new Frm_TopArticulosVendidos());
            //Frm_TopArticulosVendidos consulta = new Frm_TopArticulosVendidos();
            //consulta.MdiParent = this;
            //consulta.Show();
        }

        private void rankingVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new Frm_TopVendedores());
            //Frm_TopVendedores consulta = new Frm_TopVendedores();
            //consulta.MdiParent = this;
            //consulta.Show();
        }

        private void controlDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico(new Frm_ControlStock());
            //Frm_ControlStock consulta = new Frm_ControlStock();
            //consulta.MdiParent = this;
            //consulta.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormularioUnico(new Frm_Backup());
            //Frm_Backup backup = new Frm_Backup();
            //backup.MdiParent = this;
            //backup.Show();
        }

        private void OPC_Consultar_Articulos_Click(object sender, EventArgs e)
        {
            //Frm_Consultar_Articulo consulta = new Frm_Consultar_Articulo();
            //consulta.MdiParent = this;
            //consulta.Show();

            AbrirFormularioUnico(new Frm_Consultar_Articulo());
        }

        //Método: Este método se agrego para evitar que haya formularios repetidos abiertos a la vez que puedan
        // sobrecargar el sistema, de esta manera se mantiene todo mas ordenado y se evitan errores.
        private void AbrirFormularioUnico(Form nuevoFormulario)
        {
            //Así estaba en la documentación
            Form formularioExistente = Application.OpenForms
                .Cast<Form>()
                .FirstOrDefault(f => f.GetType() == nuevoFormulario.GetType());

            //Verifico que existe el formulario abierto o no
            if (formularioExistente != null)
            {
                DialogResult resultado = MessageBox.Show(
                    "El formulario ya está abierto.\n¿Desea cerrarlo y abrir uno nuevo?",
                    "Formulario abierto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    formularioExistente.Close();
                }
                else
                {
                    //Si se elige que NO, el formulario vuelve a emerger al usuario por si no lo encontraba.
                    formularioExistente.BringToFront();
                    return;
                }
            }

            nuevoFormulario.MdiParent = this;
            nuevoFormulario.Show();
        }

        private void MostrarAvisoStockCritico(int umbral)
        {
            try
            {
                DataTable dt = NReporte.EstadisticaStockCritico(umbral, null);

                if (dt == null || dt.Rows.Count == 0)
                    return; //no hay avisos

                var sb = new System.Text.StringBuilder();
                sb.AppendLine($"Artículos con stock ≤ {umbral}");
                sb.AppendLine(new string('-', 38));

                // Columnas que devuelve tu SP: ID, Producto, Cantidad
                foreach (DataRow fila in dt.Rows)
                {
                    string producto = Convert.ToString(fila["Producto"]);
                    int cantidad = Convert.ToInt32(fila["Cantidad"]);
                    sb.AppendLine($"• {producto} — Stock: {cantidad}");
                }

                MessageBox.Show(
                    sb.ToString(),
                    "Advertencia de Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                // Evitamos que un error al consultar corte la carga del sistema
                MessageBox.Show(
                    "No se pudo obtener el stock crítico.\nDetalle: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
    
}
