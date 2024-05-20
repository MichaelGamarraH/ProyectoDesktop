using RetailSoft.LogisticaWS;
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

namespace RetailSoft.RetailSoftVentas
{
    public partial class frmMenuVentas : Form
    {
        private LogisticaWSClient daoLogistica;
        private frmInicio ini;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmMenuVentas(frmInicio inicio)
        {
            InitializeComponent();
            daoLogistica = new LogisticaWSClient();
            ini = inicio; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ini.Show();
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            frmGestionarPedidos formGestPedidos = new frmGestionarPedidos(this);

            this.Hide();
            formGestPedidos.Show();

            BindingList<categoriaProducto> categorias = new BindingList<categoriaProducto>(daoLogistica.listarCategoriasProducto().ToList());


            int numCategorias = 0;

            frmFilaCategorias panel = new frmFilaCategorias();
            formGestPedidos.FormActualAgregar = panel;
            panel.TopLevel = false;

            formGestPedidos.PanelCategorias.Controls.Add(panel);

            panel.Dock = DockStyle.Top;
            panel.Visible = true;


            while (formGestPedidos.FormActualAgregar.Controls.Count != categorias.Count)
            {   //elementos por fila
                frmDatosCategoria boton = new frmDatosCategoria(categorias[numCategorias], formGestPedidos);
                boton.TopLevel = false;
                formGestPedidos.FormActualAgregar.Controls.Add(boton);
                boton.Dock = DockStyle.Left;
                boton.Visible = true;
                numCategorias++;
            }
        }

        private void btnGestionVentas_Click_1(object sender, EventArgs e)
        {
            frmMenuDeslizante formMenuDesli = new frmMenuDeslizante(this);
            this.Hide();
            formMenuDesli.Show();
        }
    }
}
