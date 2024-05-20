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
    public partial class frmBusquedaProducto : Form
    {
        private LogisticaWSClient _daoLogisticaWS;
        private producto _productoSeleccionado;
        public frmBusquedaProducto()
        {
            InitializeComponent();
            _daoLogisticaWS = new LogisticaWSClient();
            dgvProductos.AutoGenerateColumns = false;
        }

        public producto ProductoSeleccionado { get => _productoSeleccionado; set => _productoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _daoLogisticaWS.listarProductosxIdNombre(txtBusqueda.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _productoSeleccionado = (producto)dgvProductos.CurrentRow.DataBoundItem;
            if(_productoSeleccionado != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            producto producto = (producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells[0].Value = producto.idProducto;
            dgvProductos.Rows[e.RowIndex].Cells[1].Value = producto.nombre;
            
        }
    }
}
