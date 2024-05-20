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
    public partial class frmBotonMarca : Form
    {
        marcaProducto _marca;
        public frmGestionProducto frmPadre { get; set; }
        public frmBotonMarca(marcaProducto mar)
        {
            InitializeComponent();
            _marca = mar;
            btnMarca.Text = _marca.nombre;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            this.frmPadre.actualizarXMarca(_marca.idMarcaProducto);
        }
    }
}
