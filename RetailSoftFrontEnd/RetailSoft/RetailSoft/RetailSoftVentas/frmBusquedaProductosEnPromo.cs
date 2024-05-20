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
    public partial class frmBusquedaProductosEnPromo : Form
    {
        private producto productoSeleccionado;
        private LogisticaWSClient daoLogistica;


        public frmBusquedaProductosEnPromo()
        {
            InitializeComponent();
            daoLogistica = new LogisticaWSClient();
            ProductoSeleccionado = new producto();
            dgvProductos.AutoGenerateColumns = false;
        }

        public producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = daoLogistica.listarProductos().ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            productoSeleccionado = (producto)dgvProductos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            producto prod = (producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells[0].Value = prod.nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
