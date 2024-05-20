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
    public partial class frmGestionLote : Form
    {
        private Estado _estado;
        private LogisticaWSClient _daoLogisticaWS;
        private List<proveedor> _proveedores;
        //private List<lote> _lotes;
        private lote _lote;
        public frmGestionLote()
        {
            InitializeComponent();
            _daoLogisticaWS = new LogisticaWSClient();
            dgvLotes.AutoGenerateColumns = false;
            dgvLotes.DataSource = _daoLogisticaWS.listarLotes();
            _proveedores = _daoLogisticaWS.listadoProveedores().ToList();
            TimerLotes.Interval = 40000;
            TimerLotes.Start();
            foreach (proveedor prov in _proveedores)
            {
                frmBotonProveedor formBotProv = new frmBotonProveedor(prov);
                formBotProv.TopLevel = false;
                formBotProv.Dock = DockStyle.Top;
                panelProveedores.Controls.Add(formBotProv);
                formBotProv.Visible = true;
                formBotProv.frmPadre = this;
            }
        }

        public void actualizarXProveedor(int _idProveedor)
        {
            dgvLotes.DataSource = _daoLogisticaWS.listarLotesXProveedor(_idProveedor);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            frmLote frmLot = new frmLote(_estado);
            if(frmLot.ShowDialog() == DialogResult.OK)
            {
                dgvLotes.DataSource = _daoLogisticaWS.listarLotes();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            if (dgvLotes.CurrentRow != null)
            {
                _lote = (lote)dgvLotes.CurrentRow.DataBoundItem;
                _lote.producto = _daoLogisticaWS.listarProductosxIdNombre(_lote.producto.idProducto.ToString())[0];
                frmLote frmLot = new frmLote(_estado, _lote);
                if (frmLot.ShowDialog() == DialogResult.OK)
                {
                    dgvLotes.DataSource = _daoLogisticaWS.listarLotes();
                }
            }
        }

        private void dgvLotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                lote lote = (lote)dgvLotes.Rows[e.RowIndex].DataBoundItem;
                if (lote != null)
                {
                    dgvLotes.Rows[e.RowIndex].Cells[0].Value = lote.idLote;
                    dgvLotes.Rows[e.RowIndex].Cells[1].Value = lote.producto.nombre;
                    dgvLotes.Rows[e.RowIndex].Cells[2].Value = lote.proveedor.razonSocial;
                    dgvLotes.Rows[e.RowIndex].Cells[3].Value = lote.almacen.nombre;
                    dgvLotes.Rows[e.RowIndex].Cells[4].Value = lote.fechaCompra.ToString("dd/MM/yyyy");
                    dgvLotes.Rows[e.RowIndex].Cells[5].Value = lote.fechaLlegada.ToString("dd/MM/yyyy");
                    dgvLotes.Rows[e.RowIndex].Cells[6].Value = lote.costoTotal.ToString("N2");
                    if (lote.estado == 0)
                    {
                        dgvLotes.Rows[e.RowIndex].Cells[7].Value = "En revisión";
                    }
                    else if (lote.estado == 1)
                    {
                        dgvLotes.Rows[e.RowIndex].Cells[7].Value = "Pasado";
                    }
                    else
                    {
                        dgvLotes.Rows[e.RowIndex].Cells[7].Value = "No pasado";
                    }
                }
            }
            catch(Exception ex) { }
        }

        private void btnAplicarFiltroFecha_Click(object sender, EventArgs e)
        {
            if(rbFechaCompra.Checked == false && rbFechaLlegada.Checked == false)
            {
                MessageBox.Show("Debe seleccionar el tipo de fecha a filtrar", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rbFechaCompra.Checked == true)
            {
                dgvLotes.DataSource = _daoLogisticaWS.listarLotesXFechaCompra(dtpDesde.Value, dtpHasta.Value);
            }
            else
            {
                dgvLotes.DataSource = _daoLogisticaWS.listarLotesXFechaLlegada(dtpDesde.Value, dtpHasta.Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarLote.Text == "Buscar por ID del lote, proveedor o almacén...") txtBuscarLote.Text = "";
            dgvLotes.DataSource = _daoLogisticaWS.listarLotesXIDProveedorAlmacen(txtBuscarLote.Text);
            txtBuscarLote.Text = "Buscar por ID del lote, proveedor o almacén...";
            txtBuscarLote.ForeColor = Color.Gray;
        }

        private void txtBuscarLote_Enter(object sender, EventArgs e)
        {
            if (txtBuscarLote.Text == "Buscar por ID del lote, proveedor o almacén...")
            {
                txtBuscarLote.Text = "";
                txtBuscarLote.ForeColor = Color.Black;
            }
        }

        private void txtBuscarLote_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarLote.Text))
            {
                txtBuscarLote.Text = "Buscar por ID del lote, proveedor o almacén...";
                txtBuscarLote.ForeColor = Color.Gray;
            }
        }

        private void TimerLotes_Tick(object sender, EventArgs e)
        {
            _proveedores = _daoLogisticaWS.listadoProveedores().ToList();
            panelProveedores.Controls.Clear();
            //this.Refresh();
            foreach (proveedor prov in _proveedores)
            {
                frmBotonProveedor formBotProv = new frmBotonProveedor(prov);
                formBotProv.TopLevel = false;
                formBotProv.Dock = DockStyle.Top;
                panelProveedores.Controls.Add(formBotProv);
                formBotProv.Visible = true;
                formBotProv.frmPadre = this;
            }

        }
    }
}
