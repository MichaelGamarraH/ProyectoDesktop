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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace RetailSoft
{
    public partial class frmGestionarPedidos : Form
    {

        private Form formActualAgregar;
        private Form formActualAgregar2;
        private Form formPrincipal;
        public static frmGestionarVenta Carro { get; set; }
        public static Label labelPrueba { get; set; }

        public static int cont { get; set; }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public Form FormActualAgregar { get => formActualAgregar; set => formActualAgregar = value; }
        public Form FormActualAgregar2 { get => formActualAgregar2; set => formActualAgregar2 = value; }
        public Form FormPrincipal { get => formPrincipal; set => formPrincipal = value; }

        public frmGestionarPedidos(RetailSoft.frmInicio principal)
        {

            this.formPrincipal = principal;
            cont = 0;
            frmGestionarPedidos.Carro = new frmGestionarVenta();
            InitializeComponent();
            DatosCompartidos.OnTextoLabelCambiado += ActualizarTextoLabel;

        }

        public frmGestionarPedidos(Form principal)
        {
            this.formPrincipal = principal;
            cont = 0;
            frmGestionarPedidos.Carro = new frmGestionarVenta();
            InitializeComponent();
            DatosCompartidos.OnTextoLabelCambiado += ActualizarTextoLabel;
        }

        private void ActualizarTextoLabel(object sender, string nuevoTexto)
        {
            lblContador.Text = nuevoTexto;
        }

        private void frmGestionarPedidos_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnFlechaIzquierda_Click(object sender, EventArgs e)
        {
            if (panelPromociones.Location.X == 0) return;
            // Desplaza el panel de contenido hacia la derecha
            panelPromociones.Location = new Point(panelPromociones.Location.X + 50, panelPromociones.Location.Y);
            btnFlechaIzquierda.Location = new Point(btnFlechaIzquierda.Location.X - 50, btnFlechaIzquierda.Location.Y);
            btnFlechaDerecha.Location = new Point(btnFlechaDerecha.Location.X - 50, btnFlechaDerecha.Location.Y);

        }

        private void btnFlechaDerecha_Click(object sender, EventArgs e)
        {
            if (panelPromociones.Location.X == -350) return;
            // Desplaza el panel de contenido hacia la izquierda
            panelPromociones.Location = new Point(panelPromociones.Location.X - 50, panelPromociones.Location.Y);
            btnFlechaDerecha.Location = new Point(btnFlechaDerecha.Location.X + 50, btnFlechaDerecha.Location.Y);
            btnFlechaIzquierda.Location = new Point(btnFlechaIzquierda.Location.X + 50, btnFlechaIzquierda.Location.Y);

        }

        private void llPromocion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGestionarPedidos.Carro.Show();

        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        internal static void hide()
        {
            throw new NotImplementedException();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
