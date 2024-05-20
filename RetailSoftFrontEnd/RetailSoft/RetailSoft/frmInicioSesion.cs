using RetailSoft.RetailSoftLogistica;
using RetailSoft.RetailSoftRRHH;
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

namespace RetailSoft
{
    public partial class frmInicioSesion : Form
    {
        RRHHWSClient _daoRRHHWS;
        colaborador _colab;
        public frmInicioSesion()
        {
            _daoRRHHWS = new RRHHWSClient();
            InitializeComponent();

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            _colab = _daoRRHHWS.verificarCuenta(txtUsuario.Text, txtContrasenha.Text);
            if (_colab.idPersona != 0)
            {
                if(_colab.cargo.idCargo == 3)
                {
                    frmRRHHPrincipal frm = new frmRRHHPrincipal();
                    this.Hide();
                    frm.ShowDialog();
                }else if (_colab.cargo.idCargo == 4)
                {
                    frmInicio frm = new frmInicio();
                    this.Hide();
                    frm.ShowDialog();
                }
                else if (_colab.cargo.idCargo == 5)
                {
                    frmLogisticaPrincipal frm = new frmLogisticaPrincipal();
                    this.Hide();
                    frm.ShowDialog();
                }
                
            }
        }
    }
}
