using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmDatosColaborador : Form
    {
        colaborador _colabAux;
        frmGestionColaboradores _frmParent;
        public frmDatosColaborador(String cargo)
        {
            InitializeComponent();
            lblCargo.Text = cargo;

        }
        public frmDatosColaborador()
        {
            InitializeComponent();
            
        }
        public frmDatosColaborador(colaborador _colaborador, frmGestionColaboradores frmParent)
        {
            InitializeComponent();
            _colabAux = _colaborador;
            MemoryStream ms = new MemoryStream(_colaborador.imagen);
            pbColaborador.Image = new Bitmap(ms);
            lblNombre.Text += " " + _colaborador.nombre + " " + _colaborador.apellidoPaterno;
            lblCargo.Text += "    " + _colaborador.cargo.tipoCargo;
            lblDNI.Text += "       " + _colaborador.dni;
            lblCorreo.Text += "  " + _colaborador.correoElectronico;
            _frmParent = frmParent;

            pbColaborador.Click += new EventHandler(btnModificar_Click);
            lblNombre.Click += new EventHandler(btnModificar_Click);
            lblCargo.Click += new EventHandler(btnModificar_Click);
            lblDNI.Click += new EventHandler(btnModificar_Click);
            lblCorreo.Click += new EventHandler(btnModificar_Click);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmMaestroColaborador frmColab = new frmMaestroColaborador(_colabAux);
            if (frmColab.ShowDialog() == DialogResult.OK)
            {
                _frmParent.ActualizarPanelColaboradores();
            }
        }
    }
}
