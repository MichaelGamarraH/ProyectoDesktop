using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmFilaBusquedaColaboradores : Form
    {
        private colaborador _colaborador;
        public bool ColaboradorSeleccionado => cbSeleccionado.Checked;

        public colaborador Colaborador { get => _colaborador; set => _colaborador = value; }

        public frmFilaBusquedaColaboradores()
        {
            InitializeComponent();
        }

        public frmFilaBusquedaColaboradores(colaborador colabAux)
        {
            InitializeComponent();
            lblNombre.Text = colabAux.nombre;
            lblApellido.Text = colabAux.apellidoPaterno + " " + colabAux.apellidoMaterno;
            lblDNI.Text = colabAux.dni;
            lblCargo.Text = colabAux.cargo.tipoCargo;
            Colaborador = colabAux;
        }

        public void SeleccionarColaborador()
        {
            cbSeleccionado.Checked = true;
        }

        public void DeseleccionarColaborador()
        {
            cbSeleccionado.Checked = false;
        }
    }
}
