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
    public partial class frmBusquedaAlmacen : Form
    {

        private almacen auxiliar;
        private Panel panelAux;
        public frmBusquedaAlmacen()
        {
            InitializeComponent();
        }
        public frmBusquedaAlmacen(almacen almacen,Panel panelPro) 
        {
            InitializeComponent();

            panelAux = panelPro;
            txtID.Text = almacen.idAlmacen.ToString();
            txtNombre.Text = almacen.nombre;
            txtCapacidad.Text = almacen.capacidad.ToString();
            txtDireccion.Text = almacen.direccion;
            

            auxiliar = new almacen();
            auxiliar = almacen;
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtCapacidad.Enabled = false;
            txtDireccion.Enabled = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmInformacionAlmacen formInfoAlma = new frmInformacionAlmacen(auxiliar,panelAux);
            formInfoAlma.Show();
        }
    }
}
