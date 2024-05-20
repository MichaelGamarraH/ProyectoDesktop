using RetailSoft.LogisticaWS;
using RetailSoft.RetailSoftLogistica;
using RetailSoft.RetailSoftRRHH;
using RetailSoft.RetailSoftVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft
{
    public partial class frmInicio : Form
    {
        private LogisticaWSClient daoLogistica;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        public frmInicio()
        {
            InitializeComponent();
            daoLogistica = new LogisticaWSClient();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmMenuVentas formMenuVentas = new frmMenuVentas(this);

            this.Hide();
            formMenuVentas.Show();


            //frmGestionarPedidos formGestPedidos = new frmGestionarPedidos(this);
            //frmMaestroPromociones formMaestroPromociones = new frmMaestroPromociones();

            this.Hide();
            //formGestPedidos.Show();
            //formMaestroPromociones.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRRHHPrincipal formRRHHPrinc = new frmRRHHPrincipal(this);

            this.Hide();
            formRRHHPrinc.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogisticaPrincipal formLogPrinc = new frmLogisticaPrincipal(this);

            this.Hide();
            formLogPrinc.Show();
        }
    }
}
