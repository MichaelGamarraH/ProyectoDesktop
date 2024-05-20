using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftVentas
{
    public partial class frmMenuDeslizante : Form
    {
        private bool sidebarExpand;
        private frmMenuVentas ventas;

        public frmMenuDeslizante(frmMenuVentas menuVentas)
        {
            InitializeComponent();
            ventas = menuVentas;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand, minimize 
                sidebar.Width -= 80; 
                if(sidebar.Width == sidebar.MinimumSize.Width) 
                { 
                    sidebarExpand = false;
                    sidebarTimer.Stop();    
                }

            }
            else
            {
                sidebar.Width += 80;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true; 
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //frm
            //panelContenedor.Controls.Add()
        }


        public void mostrarFormulario(Form form)
        {
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            form.Visible = true;
        }


        private void btnPromociones_Click_1(object sender, EventArgs e)
        {
            frmMaestroPromociones formMaestroPromociones = new frmMaestroPromociones();

            mostrarFormulario(formMaestroPromociones);
        }

        private void btnCategorias_Click_1(object sender, EventArgs e)
        {
            frmMaestroCategorias formMaestroCategorias = new frmMaestroCategorias();

            mostrarFormulario(formMaestroCategorias);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventas.Show();

        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            frmBusquedaVentas formBusqV = new frmBusquedaVentas();

            mostrarFormulario(formBusqV);
        }
    }
}
