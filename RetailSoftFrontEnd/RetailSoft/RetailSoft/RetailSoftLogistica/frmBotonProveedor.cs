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
    public partial class frmBotonProveedor : Form
    {
        proveedor _proveedor;
        public frmGestionLote frmPadre { get; set; }
        public frmBotonProveedor(proveedor prov)
        {
            InitializeComponent();
            _proveedor = prov;
            btnProveedor.Text = _proveedor.razonSocial;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.frmPadre.actualizarXProveedor(_proveedor.idProveedor);
        }
    }
}
