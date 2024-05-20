using RetailSoft.LogisticaWS;
using RetailSoft.RetailSoftLogistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft
{
    public partial class frmFiltroFechas : Form
    {
        private LogisticaWSClient daoProveedor;
        private Panel panelAux;
        public frmFiltroFechas(Panel panelFiltroE)
        {
            InitializeComponent();
            panelAux = panelFiltroE;
            daoProveedor = new LogisticaWSClient();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicial.Value == dtpFechaInicial.MinDate || dtpFechaFinal.Value == dtpFechaFinal.MinDate)
            {
                MessageBox.Show("Debe seleccionar ambas fechas", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            daoProveedor = new LogisticaWSClient();
            proveedor[] proveedores = daoProveedor.listarProveedorEntreFechas(dtpFechaInicial.Value,dtpFechaFinal.Value);
 
            if (proveedores != null)
            {
                foreach (Control control in panelAux.Controls.OfType<frmDatosProveedor>().ToList())
                {
                    if (control.Name != "panelFiltros")
                    {
                        panelAux.Controls.Remove(control);
                        control.Dispose();
                    }

                }
                foreach (proveedor proveedor in proveedores)
                {

                    frmDatosProveedor formDatos = new frmDatosProveedor(proveedor, panelAux);
                    formDatos.TopLevel = false;
                    formDatos.Dock = DockStyle.Top;
                    panelAux.Controls.Add(formDatos);
                    formDatos.Visible = true;

                }
                panelAux.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontro registro de proveedores en esas fechas", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             



        }
    }
}
