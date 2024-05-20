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
    public partial class frmBusquedaProveedor : Form
    {
        private LogisticaWSClient daoProveedor;
        private Panel panelAux;
        public frmBusquedaProveedor(Panel panelPro)
        {
            InitializeComponent();
            daoProveedor = new LogisticaWSClient();//
            panelAux = panelPro;

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            string idProveedor = txtIdProveedor.Text;

            int bandera = 0;
            if (txtIdProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el ID del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            proveedor[] proveedores = daoProveedor.listadoProveedores();//
            foreach (proveedor proveedor in proveedores)
            {
                if (proveedor.idProveedor == int.Parse(idProveedor))
                {
                    bandera = 1;
                }
            }
            if (bandera == 1) {
                frmInformacionProveedor formProveedor = new frmInformacionProveedor(idProveedor, panelAux);
                formProveedor.FormBorderStyle = FormBorderStyle.None;
                formProveedor.TopLevel = false;
                formProveedor.Dock = DockStyle.Top;
                panelBusqueda.Controls.Add(formProveedor);
                formProveedor.Visible = true;
            }
            else
            {
                MessageBox.Show("No se encuentra el ID de proveedor, ingrese uno valido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
        }
    }
}
