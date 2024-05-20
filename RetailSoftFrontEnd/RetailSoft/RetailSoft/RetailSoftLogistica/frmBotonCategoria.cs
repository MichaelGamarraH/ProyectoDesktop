using RetailSoft.LogisticaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftLogistica
{
    public partial class frmBotonCategoria : Form
    {
        categoriaProducto _categoria;
        public frmGestionProducto frmPadre { get; set; }
        public frmBotonCategoria(categoriaProducto cat)
        {
            InitializeComponent();
            _categoria = cat;
            btnCategoria.Text = _categoria.nombre;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.frmPadre.actualizarXCategoria(_categoria.idCategoriaProducto);
        }
    }
}
