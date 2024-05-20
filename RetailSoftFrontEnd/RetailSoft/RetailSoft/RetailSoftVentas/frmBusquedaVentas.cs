using RetailSoft.LogisticaWS;
using RetailSoft.VentasWS;
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
    public partial class frmBusquedaVentas : Form
    {
        private VentasWSClient daoVentas;
        private BindingList<lineaVenta> _lineasVenta;
        private venta v;
        public frmBusquedaVentas()
        {
            InitializeComponent();
            daoVentas = new VentasWSClient();
            dgvVentas.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = daoVentas.listarVentasXIdDNICliente(txtDNICliente.Text).ToList();
        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            v = (venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;
            dgvVentas.Rows[e.RowIndex].Cells[0].Value = v.idVenta;
            dgvVentas.Rows[e.RowIndex].Cells[1].Value = v.cliente.documentoIdentidad;
            dgvVentas.Rows[e.RowIndex].Cells[2].Value = v.cliente.nombre;
            dgvVentas.Rows[e.RowIndex].Cells[3].Value = v.promotor.nombre;
            dgvVentas.Rows[e.RowIndex].Cells[4].Value = v.montoTotal;
            dgvVentas.Rows[e.RowIndex].Cells[5].Value = v.fechaVenta;


        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                frmGestionarVenta form = new frmGestionarVenta();

                
                _lineasVenta = new BindingList<lineaVenta>(v.lineasVenta.ToList());
                v.lineasVenta = null;
                frmGestionarVenta.dataGridViewA.DataSource = _lineasVenta;
                form.Show();
            }
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvVentas.Rows[e.RowIndex];

            frmGestionarVenta form = new frmGestionarVenta();

            frmGestionarVenta.dataGridViewA.AutoGenerateColumns = false;

            _lineasVenta = new BindingList<lineaVenta>(daoVentas.listarVentasXIdVenta(row.Cells["IdVenta"].Value.ToString()).ToList());

            frmGestionarVenta.dataGridViewA.DataSource = _lineasVenta;

            form.Show();


        }
    }
}
