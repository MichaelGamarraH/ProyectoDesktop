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
     
    
    public partial class frmDatosProveedor : Form
    {
        private proveedor auxiliar;
        private Panel panelAux;
        public frmDatosProveedor()
        {

            InitializeComponent();
        }
        public frmDatosProveedor(proveedor proveedor,Panel panelFiltroE)
        {
            InitializeComponent();
            panelAux = panelFiltroE;
            colocandoData(proveedor);
        }
        public frmDatosProveedor(proveedor proveedor)
        {
            InitializeComponent();
            colocandoData(proveedor);
        }
        private void colocandoData(proveedor proveedor) {
            txtID.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.razonSocial;
            txtRUC.Text = proveedor.RUC;
            txtDireccion.Text = proveedor.direccion;
            dtpFecha.Value = proveedor.fechaInicio;

            auxiliar = proveedor;
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtRUC.Enabled = false;
            txtDireccion.Enabled = false;
            dtpFecha.Enabled = false;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmInformacionProveedor infoProveedor = new frmInformacionProveedor(auxiliar,panelAux);
            infoProveedor.ShowDialog();
        }

    }
}
