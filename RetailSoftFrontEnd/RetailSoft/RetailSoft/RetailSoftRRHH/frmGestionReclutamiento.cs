using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmGestionReclutamiento : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private puestoTrabajo _puestoTrabajo;
        private string _cadenaBuscar = "Buscar Puesto de Trabajo por nombre...";
        public frmGestionReclutamiento()
        {
            _daoRRHHWS = new RRHHWSClient();
            InitializeComponent();
            dgvPuestos.AutoGenerateColumns = false;
            dgvPuestos.DataSource = _daoRRHHWS.listarPuestos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMaestroPuestoTrabajo frmNuevoPuesto = new frmMaestroPuestoTrabajo();
            if (frmNuevoPuesto.ShowDialog() == DialogResult.OK)
            {
                dgvPuestos.DataSource = _daoRRHHWS.listarPuestos();
            }
        }

        private void dgvPuestos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                puestoTrabajo puesto = (puestoTrabajo)dgvPuestos.Rows[e.RowIndex].DataBoundItem;
                if (puesto != null)
                {
                    dgvPuestos.Rows[e.RowIndex].Cells[0].Value = puesto.nombre;
                    dgvPuestos.Rows[e.RowIndex].Cells[1].Value = puesto.fechaPublicacion;
                    dgvPuestos.Rows[e.RowIndex].Cells[2].Value = puesto.fechaLimite;
                    dgvPuestos.Rows[e.RowIndex].Cells[3].Value = puesto.correoResponsable;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == _cadenaBuscar)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = _cadenaBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.CurrentRow != null)
            {
                _puestoTrabajo = (puestoTrabajo)dgvPuestos.CurrentRow.DataBoundItem;
                if (_puestoTrabajo != null)
                {
                    frmMaestroPuestoTrabajo frmPuesto = new frmMaestroPuestoTrabajo(_puestoTrabajo);
                    if (frmPuesto.ShowDialog() == DialogResult.OK)
                    {
                        dgvPuestos.DataSource = _daoRRHHWS.listarPuestos();
                    }
                }
            }
            else
                MessageBox.Show("No hay un Puesto de Trabajo seleccionado.", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == _cadenaBuscar) txtBuscar.Text = "";
                dgvPuestos.DataSource = _daoRRHHWS.listarPuestosPorNombre(txtBuscar.Text).ToList();

                txtBuscar.Text = _cadenaBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron resultados para: " + txtBuscar.Text,
                    "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAplicarFiltroFecha_Click(object sender, EventArgs e)
        {
            if (rbFechaPublicacion.Checked == false && rbFechaLimite.Checked == false)
            {
                MessageBox.Show("Debe seleccionar el tipo de fecha a filtrar", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbFechaPublicacion.Checked == true)
            {
                dgvPuestos.DataSource = _daoRRHHWS.listarPuestosPorFechaPublicacion(dtpDesde.Value, dtpHasta.Value);
            }
            else
            {
                dgvPuestos.DataSource = _daoRRHHWS.listarPuestosPorFechaLimite(dtpDesde.Value, dtpHasta.Value);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dgvPuestos.DataSource = _daoRRHHWS.listarPuestos();
        }
    }
}
