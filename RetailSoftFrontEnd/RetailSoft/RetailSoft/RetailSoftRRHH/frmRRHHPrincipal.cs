using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmRRHHPrincipal : Form
    {
        private Form formPrincipal;

        public Form FormPrincipal { get => formPrincipal; set => formPrincipal = value; }
        public frmRRHHPrincipal(frmInicio principal)
        {
            formPrincipal = principal;
            InitializeComponent();
        }

        public frmRRHHPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestColaboradores_Click(object sender, EventArgs e)
        {
            frmGestionColaboradores frmColab = new frmGestionColaboradores();
            frmColab.ShowDialog();
        }

        private void btnGestReclutamiento_Click(object sender, EventArgs e)
        {
            frmGestionReclutamiento frmRec = new frmGestionReclutamiento();
            frmRec.ShowDialog();
        }

        private void btnGestEventos_Click(object sender, EventArgs e)
        {
            frmGestionEventos frmEvent = new frmGestionEventos();
            frmEvent.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           // formPrincipal.Show();
        }

        private void btnGestAsistencias_Click(object sender, EventArgs e)
        {
            frmGestionAsistencias frmAsist = new frmGestionAsistencias();
            frmAsist.ShowDialog();
        }
    }
}
