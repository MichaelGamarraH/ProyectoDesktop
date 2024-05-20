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
    public partial class frmBusquedaProductos : Form
    {
        private Form formActualAgregar;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public Form FormActualAgregar { get => formActualAgregar; set => formActualAgregar = value; }
        public frmBusquedaProductos(String texto)
        {
            
            InitializeComponent();
            lblContador.Text = texto;

            DatosCompartidos.OnTextoLabelCambiado += ActualizarTextoLabel;


        }
        private void ActualizarTextoLabel(object sender, string nuevoTexto)
        {
            lblContador.Text = nuevoTexto;
        }
        private void panelSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }


        private void btnFlechaIzquierda_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGestionarPedidos.Carro.Show();
            
        }
    }
}
