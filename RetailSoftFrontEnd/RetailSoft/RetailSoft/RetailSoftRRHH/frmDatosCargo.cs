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
    public partial class frmDatosCargo : Form
    {
        private cargo _cargo = null;
        private frmGestionColaboradores _parentForm;
        public frmDatosCargo(frmGestionColaboradores parentForm)
        {
            InitializeComponent();
            this.btnCargo.Text = "TODOS";
            _parentForm = parentForm;
        }
        public frmDatosCargo(cargo cargo, frmGestionColaboradores parentForm)
        {
            InitializeComponent();
            this.btnCargo.Text = cargo.tipoCargo;
            _cargo = cargo;
            _parentForm = parentForm;
        }
        private void btnCargo_Click(object sender, EventArgs e)
        {
            if (_cargo != null)
                _parentForm.ActualizarPanelColaboradores(_cargo.idCargo);
            else
                _parentForm.ActualizarPanelColaboradores();
        }
    }
}
