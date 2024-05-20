using RetailSoft.LogisticaWS;
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
    public partial class frmDatosCategoria : Form
    {
        private int _idCategoria;
        private frmGestionarPedidos formGestPedidos;
        private LogisticaWSClient daoLogistica;

        public frmDatosCategoria()
        {
            InitializeComponent();
            daoLogistica = new LogisticaWSClient();
        }

        public frmDatosCategoria(categoriaProducto categoria, frmGestionarPedidos _formGestPedidos)
        {
            InitializeComponent();

            _idCategoria = categoria.idCategoriaProducto;
            btnCategoria.Name = categoria.nombre;
            formGestPedidos = _formGestPedidos;
            //btnCategoria.Image = categoria.icono;


            using (MemoryStream ms = new MemoryStream(categoria.icono))
            {
                // Crear una instancia de Image a partir del MemoryStream
                Image imagen = Image.FromStream(ms);

                Image imagenRedimensionada = new Bitmap(imagen, 80, 45);

                // Asignar la imagen al botón
                btnCategoria.Image = imagenRedimensionada;

            }



            daoLogistica = new LogisticaWSClient();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

            try
            {
                BindingList<promocion> promociones = new BindingList<promocion>(daoLogistica.listarPromocionesXCategoria(_idCategoria).ToList());

                int numPromociones = 0;


                frmFilaPromocion panel2 = new frmFilaPromocion();
                formGestPedidos.FormActualAgregar2 = panel2;
                panel2.TopLevel = false;

                formGestPedidos.PanelPromociones.Controls.Add(panel2);

                panel2.Dock = DockStyle.Top;
                panel2.Visible = true;

                while (formGestPedidos.FormActualAgregar2.Controls.Count != promociones.Count)
                {
                    frmDatosPromocion boton2 = new frmDatosPromocion(promociones[numPromociones]);
                    boton2.TopLevel = false;
                    formGestPedidos.FormActualAgregar2.Controls.Add(boton2);
                    boton2.Dock = DockStyle.Left;
                    boton2.Visible = true;
                    numPromociones++;

                }

                formGestPedidos.BtnFlechaDerecha.BringToFront();
                formGestPedidos.BtnFlechaIzquierda.BringToFront();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"La categoría {btnCategoria.Name} se encuentra vacía.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

