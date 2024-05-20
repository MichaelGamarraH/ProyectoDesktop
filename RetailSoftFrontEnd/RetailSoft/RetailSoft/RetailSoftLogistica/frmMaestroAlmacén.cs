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
    public partial class frmMaestroAlmacén : Form
    {
        private LogisticaWSClient daoAlmacen;
        public frmMaestroAlmacén()
        {
            InitializeComponent();
            daoAlmacen = new LogisticaWSClient();

            almacen[] almacenes = daoAlmacen.listadoAlmacen();
             
            
            foreach (almacen almacen in almacenes)
            {
                frmBusquedaAlmacen formDatos = new frmBusquedaAlmacen(almacen,panelAlmacen);
                
                formDatos.TopLevel = false;
                formDatos.Dock = DockStyle.Top;
                panelAlmacen.Controls.Add(formDatos);
                formDatos.Visible = true;
            }

        }

        private void btnBuscarAlmacen_Click(object sender, EventArgs e)
        {
            string idAlma = txtNombreAlmacen.Text;
            int bandera = 0;
            if (txtNombreAlmacen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el ID del almacen", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            almacen[] almacenes = daoAlmacen.listadoAlmacen();//
            foreach (almacen almacen in almacenes)
            {
                if (almacen.idAlmacen == int.Parse(idAlma))
                {
                    bandera = 1;
                }
            }
            if (bandera == 1) {
                frmInformacionAlmacen formInfoAlmacen = new frmInformacionAlmacen(idAlma, panelAlmacen);
                formInfoAlmacen.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra el ID del almacen, ingrese uno valido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

             
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoAlmacen formNuevoAlma = new frmNuevoAlmacen(panelAlmacen);
            formNuevoAlma.ShowDialog();
        }
    }
}
