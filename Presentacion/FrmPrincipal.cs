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

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

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
            FrmCategoria frm = new FrmCategoria();
            //Indicamos que el formulario instanciado sea hijo del MDI principal
            // De esta forma el FrmPrincipal va a ser contenedor del FrmCategoria
            frm.MdiParent = this;

            //Mostramos el formulario categoria
            frm.Show();

            //



        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //La clase en Presentacion fue creada con el nombre Usuario, no FrmUsuario
            Usuarios frm = new Usuarios();
            frm.MdiParent = this;
            frm.Show();
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
                this.Close();

                //Muestra el login
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido " + this.nombre, "LIBERTEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StBarraInferior.Text = "Desarrollado por Sebastian Prado - Taller de Programación 2 - UNNE - 2025  ----------- USUARIO:" + this.nombre;
            if (this.rol.Equals("Administrador"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = true;
                MnuAccesos.Enabled = true;
                MnuConsultas.Enabled = true;
                TsCompras.Enabled = true;
                TsVentas.Enabled = true;
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
                    TsCompras.Enabled = false;
                    TsVentas.Enabled = true;
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
                        TsCompras.Enabled = false;
                        TsVentas.Enabled = false;
                    }
                    else
                    {
                        MnuAlmacen.Enabled = false;
                        MnuIngresos.Enabled = false;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = false;
                        TsCompras.Enabled = false;
                        TsVentas.Enabled = false;
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
            FrmProveedor frm = new FrmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso ingreso = new FrmIngreso();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta venta = new FrmVenta();
            venta.MdiParent = this;
            venta.Show();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_VentaFechas consulta = new FrmConsulta_VentaFechas();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_ComprasFecha consulta = new FrmConsulta_ComprasFecha();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void evoluciónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrafico_VentasPorFecha consulta = new FrmGrafico_VentasPorFecha();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void rankingArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TopArticulosVendidos consulta = new Frm_TopArticulosVendidos();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void rankingVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TopVendedores consulta = new Frm_TopVendedores();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void controlDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ControlStock consulta = new Frm_ControlStock();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Backup backup = new Frm_Backup();
            backup.MdiParent = this;
            backup.Show();
        }
    }
    
}
