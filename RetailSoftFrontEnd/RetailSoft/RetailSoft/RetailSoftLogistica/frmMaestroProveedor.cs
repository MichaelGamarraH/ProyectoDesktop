using RetailSoft.LogisticaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftLogistica
{
    public partial class frmMaestroProveedor : Form
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem opcion1ToolStripMenuItem;
        private ToolStripMenuItem opcion2ToolStripMenuItem;

        private LogisticaWSClient daoProveedor;
        
        public frmMaestroProveedor()
        {
             
            InitializeComponent();
            InitializeContextMenu();
            panelFiltros.Visible = false;
            daoProveedor = new LogisticaWSClient();

            proveedor[] proveedores=daoProveedor.listadoProveedores();
            
            foreach(proveedor proveedor in proveedores)
            {
                frmDatosProveedor formDatos = new frmDatosProveedor(proveedor,panelProveedores);

                formDatos.TopLevel = false;
                formDatos.Dock = DockStyle.Top;
                panelProveedores.Controls.Add(formDatos);
                formDatos.Visible = true;
            }

        }
        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();

            opcion1ToolStripMenuItem = new ToolStripMenuItem("Búsqueda por ID");
            opcion1ToolStripMenuItem.Click += (s, ev) =>
            {
                frmBusquedaProveedor busProveedor = new frmBusquedaProveedor(panelProveedores);
                busProveedor.ShowDialog();
            };

            opcion2ToolStripMenuItem = new ToolStripMenuItem("Búsqueda por Nombre");
            opcion2ToolStripMenuItem.Click += (s, ev) =>
            {
                frmBusquedaNombrePro busNombrePro = new frmBusquedaNombrePro(panelProveedores);
                busNombrePro.ShowDialog();
            };

            contextMenuStrip.Items.Add(opcion1ToolStripMenuItem);
            contextMenuStrip.Items.Add(opcion2ToolStripMenuItem);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            frmInformacionProveedor inforProveedor = new frmInformacionProveedor(panelProveedores);
            inforProveedor.ShowDialog();
        }

        private void btnBusqueda_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip.Show(btnBusqueda, new System.Drawing.Point(0, btnBusqueda.Height));
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            if (!panelFiltros.Visible) {
                panelFiltros.Visible = true;
            }
            else
            {
                panelFiltros.Visible = false;
            }
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            daoProveedor = new LogisticaWSClient();
            proveedor[] proveedores = daoProveedor.listadoAntiguosProveedores();
            mostrarActualizacionFiltro(proveedores);

        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            daoProveedor = new LogisticaWSClient();
            proveedor[] proveedores = daoProveedor.listadoRecientesProveedores();
            mostrarActualizacionFiltro(proveedores);

        }
        private void mostrarActualizacionFiltro(proveedor[] proveedores) {
            foreach (Control control in panelProveedores.Controls.OfType<frmDatosProveedor>().ToList())
            {
                if (control.Name != "panelFiltros")
                {
                    panelProveedores.Controls.Remove(control);
                    control.Dispose();
                }

            }

            foreach (proveedor proveedor in proveedores)
            {
                frmDatosProveedor formDatos = new frmDatosProveedor(proveedor,panelProveedores);
                formDatos.TopLevel = false;
                formDatos.Dock = DockStyle.Top;
                panelProveedores.Controls.Add(formDatos);
                formDatos.Visible = true;
            }
            this.Refresh();
        }

        private void btnEntreFechas_Click(object sender, EventArgs e)
        {
            frmFiltroFechas formFiltro = new frmFiltroFechas(panelProveedores);
            Point location = btnEntreFechas.PointToScreen(new Point(btnEntreFechas.Width, 0));
            formFiltro.Location = location;
            formFiltro.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmVisorReporte frmVis = new frmVisorReporte();
            frmVis.ShowDialog();
        }
    }
}
