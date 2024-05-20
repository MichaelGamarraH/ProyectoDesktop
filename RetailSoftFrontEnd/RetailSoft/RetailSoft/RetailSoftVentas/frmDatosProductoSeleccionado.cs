using RetailSoft.LogisticaWS;
using RetailSoft.VentasWS;
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

namespace RetailSoft.RetailSoftVentas
{
    public partial class frmDatosProductoSeleccionado : Form
    {
        private LogisticaWS.productoxPromocion p;
        private double a;

        public frmDatosProductoSeleccionado(LogisticaWS.productoxPromocion productopromo)
        {

            InitializeComponent();
            p = productopromo;
            lblNombreProducto.Text = productopromo.producto.nombre;
            lblPrecioTienda.Text = productopromo.producto.precio.ToString();
            lblDscto.Text = productopromo.promocion.descuento.ToString();
            a = productopromo.producto.precio * (100.00 - productopromo.promocion.descuento) / 100;
            lblPrecioApp.Text = a.ToString();

            using (MemoryStream ms = new MemoryStream(productopromo.producto.imagen))
            {
                // Crear una instancia de Image a partir del MemoryStream
                Image imagen = Image.FromStream(ms);

                Image imagenRedimensionada = new Bitmap(imagen, 400, 250);

                // Asignar la imagen al botón
                pbProducto.Image = imagenRedimensionada;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionarPedidos.cont++;

            //DatosCompartidos.TextoLabel = "prueba";

            DatosCompartidos.TextoLabel = frmGestionarPedidos.cont.ToString();
            frmGestionarVenta.dataGridViewA.Rows.Add(p.producto.nombre, p.producto.marcaProducto.nombre,a);
            frmGestionarVenta.sumaTotal += a;
            frmGestionarVenta.textTotal.Text = frmGestionarVenta.sumaTotal.ToString();



            //foreach (lineaVenta linea in frmGestionarVenta._lineasVenta)
            //{
            //    if (linea.producto.idProducto.Equals(p.producto.idProducto))
            //    {
            //    }
            //}

            lineaVenta lv = new lineaVenta();
            lv.producto = new VentasWS.producto();

            lv.producto.idProducto = p.producto.idProducto;
            lv.producto.nombre = p.producto.nombre;

            lv.producto.marcaProducto = new VentasWS.marcaProducto();

            lv.producto.marcaProducto.idMarcaProducto = p.producto.marcaProducto.idMarcaProducto;
            lv.producto.marcaProducto.nombre = p.producto.marcaProducto.nombre;
            lv.subTotal = a; 


            frmGestionarVenta._lineasVenta.Add(lv);

            this.Close();
        }
    }
}
