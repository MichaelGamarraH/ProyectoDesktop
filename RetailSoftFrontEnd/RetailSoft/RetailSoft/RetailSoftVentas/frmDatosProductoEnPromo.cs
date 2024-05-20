using RetailSoft.LogisticaWS;
using RetailSoft.RetailSoftVentas;
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
    public partial class frmDatosProductoEnPromo : Form
    {
        private productoxPromocion _producto;
        public frmDatosProductoEnPromo()
        {
            InitializeComponent();
        }
        public frmDatosProductoEnPromo(productoxPromocion producto_promo)
        {
            _producto = new productoxPromocion();
            InitializeComponent();
            //btnProducto.Text = producto.nombre;

            using (MemoryStream ms = new MemoryStream(producto_promo.producto.imagen))
            {
                // Crear una instancia de Image a partir del MemoryStream
                Image imagen = Image.FromStream(ms);

                Image imagenRedimensionada = new Bitmap(imagen, 120, 180);

                // Asignar la imagen al botón
                btnProducto.Image = imagenRedimensionada;
                
            }

            _producto = producto_promo;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDatosProductoSeleccionado formProdSelec = new frmDatosProductoSeleccionado(_producto);
            formProdSelec.Show();



        }
    }
}
