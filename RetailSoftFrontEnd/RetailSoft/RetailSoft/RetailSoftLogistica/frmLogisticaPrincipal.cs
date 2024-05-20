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
    public partial class frmLogisticaPrincipal : Form
    {
        private Form formPrincipal;

        public Form FormPrincipal { get => formPrincipal; set => formPrincipal = value; }

        public frmLogisticaPrincipal()
        {
            InitializeComponent();
        }
        public frmLogisticaPrincipal(frmInicio principal)
        {
            formPrincipal = principal;
            InitializeComponent();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            frmGestionProducto frmGestProd = new frmGestionProducto();
            frmGestProd.Show();
        }

        private void btnGestionLotes_Click(object sender, EventArgs e)
        {
            frmGestionLote frmGestLot = new frmGestionLote();
            frmGestLot.Show();
        }

        private void btnMaestroProveedor_Click(object sender, EventArgs e)
        {
            frmMaestroProveedor frmMaestroProv = new frmMaestroProveedor();
            frmMaestroProv.ShowDialog();
        }

        private void btnMaestroAlmacen_Click(object sender, EventArgs e)
        {
            frmMaestroAlmacén frmMaestroAlma = new frmMaestroAlmacén();
            frmMaestroAlma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //this.Hide();
            //formPrincipal.Show();
        }
    }
}
