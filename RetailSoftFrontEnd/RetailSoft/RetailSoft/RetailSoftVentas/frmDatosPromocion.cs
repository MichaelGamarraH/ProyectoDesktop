using RetailSoft.LogisticaWS;
using RetailSoft.RetailSoftVentas;
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

namespace RetailSoft
{
    public partial class frmDatosPromocion : Form
    {
        private LogisticaWSClient daoLogistica;
        private int _idPromocion;
        public frmDatosPromocion()
        {
            InitializeComponent();
            daoLogistica = new LogisticaWSClient(); //tienes que crear el objeto cliente (del SW) para invocar sus metodos
        }

        public frmDatosPromocion(promocion promocion)
        {
            InitializeComponent();
            daoLogistica = new LogisticaWSClient();
            _idPromocion = promocion.idPromocion;
            //btnPromocion.Text = promocion.nombre;

            using (MemoryStream ms = new MemoryStream(promocion.imagen))
            {
                // Crear una instancia de Image a partir del MemoryStream
                Image imagen = Image.FromStream(ms);

                Image imagenRedimensionada = new Bitmap(imagen, 150, 180);

                // Asignar la imagen al botón
                btnPromocion.Image = imagenRedimensionada;

            }






        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            

            frmBusquedaProductos formBusqProd = new frmBusquedaProductos(DatosCompartidos.TextoLabel);
            formBusqProd.Show();

            BindingList<productoxPromocion> productos = new BindingList<productoxPromocion>(daoLogistica.listarProductosXPromocion(_idPromocion).ToList());


            int numProductos = 0;

            for (int i = 1; i <= 3; i++)
            {

                if (numProductos == productos.Count) break;

                frmFilaProducto panel = new frmFilaProducto();
                formBusqProd.FormActualAgregar = panel;
                panel.TopLevel = false;

                formBusqProd.Panel1.Controls.Add(panel);
                formBusqProd.Panel1.Controls.SetChildIndex(panel, 0);

                panel.Dock = DockStyle.Top;
                panel.Visible = true;

                do
                {
                    if (numProductos == productos.Count) break;
                    frmDatosProductoEnPromo boton = new frmDatosProductoEnPromo(productos[numProductos]);
                    boton.TopLevel = false;
                    formBusqProd.FormActualAgregar.Controls.Add(boton);
                    boton.Dock = DockStyle.Left;
                    boton.Visible = true;
                    numProductos++;
                }
                while (formBusqProd.FormActualAgregar.Controls.Count != 3);


               
            }

        }
    }
}
