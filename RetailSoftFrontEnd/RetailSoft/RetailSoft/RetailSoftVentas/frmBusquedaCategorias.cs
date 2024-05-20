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

namespace RetailSoft.RetailSoftVentas
{
    public partial class frmBusquedaCategorias : Form
    {
        private categoriaProducto categoriaSeleccionada;
        private LogisticaWSClient daoLogistica;

        public categoriaProducto CategoriaSeleccionada { get => categoriaSeleccionada; set => categoriaSeleccionada = value; }

        public frmBusquedaCategorias()
        {
            daoLogistica = new LogisticaWSClient();
            InitializeComponent(); 
            CategoriaSeleccionada = new categoriaProducto();
            dgvCategorias.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = daoLogistica.listarCategoriasProducto().ToList();

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            categoriaSeleccionada = (categoriaProducto)dgvCategorias.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            categoriaProducto catprod = (categoriaProducto) dgvCategorias.Rows[e.RowIndex].DataBoundItem;
            dgvCategorias.Rows[e.RowIndex].Cells[0].Value = catprod.nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
