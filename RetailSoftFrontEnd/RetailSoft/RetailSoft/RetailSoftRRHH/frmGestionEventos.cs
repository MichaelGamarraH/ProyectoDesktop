using RetailSoft.LogisticaWS;
using RetailSoft.RetailSoftLogistica;
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
    public partial class frmGestionEventos : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private evento _evento;
        private string _cadenaBuscar = "Buscar evento por nombre...";

        public frmGestionEventos()
        {
            _daoRRHHWS = new RRHHWSClient();
            InitializeComponent();
            dgvEventos.AutoGenerateColumns = false;
            dgvEventos.DataSource = _daoRRHHWS.listarEventosTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMaestroEvento frmEvento = new frmMaestroEvento();
            if (frmEvento.ShowDialog() == DialogResult.OK)
            {
                dgvEventos.DataSource = _daoRRHHWS.listarEventosTodos();
            }
        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                evento ev = (evento)dgvEventos.Rows[e.RowIndex].DataBoundItem;
                if(ev != null)
                {
                    dgvEventos.Rows[e.RowIndex].Cells[0].Value = ev.nombre;
                    dgvEventos.Rows[e.RowIndex].Cells[1].Value = ev.lugar;
                    dgvEventos.Rows[e.RowIndex].Cells[2].Value = ev.fechaRealizacion;
                    dgvEventos.Rows[e.RowIndex].Cells[3].Value = ev.horaInicio;
                    dgvEventos.Rows[e.RowIndex].Cells[4].Value = ev.horaFin;
                    dgvEventos.Rows[e.RowIndex].Cells[5].Value = ev.totalInvitados;
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
            if (dgvEventos.CurrentRow != null)
            {
                _evento = (evento)dgvEventos.CurrentRow.DataBoundItem;
                if (_evento != null)
                {
                    frmMaestroEvento frmEvento = new frmMaestroEvento(_evento);
                    if (frmEvento.ShowDialog() == DialogResult.OK)
                    {
                        dgvEventos.DataSource = _daoRRHHWS.listarEventosTodos();
                    }
                }
            }
            else
                MessageBox.Show("No hay un evento seleccionado.", "Mensaje de advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == _cadenaBuscar) txtBuscar.Text = "";
                dgvEventos.DataSource = _daoRRHHWS.listarEventosPorNombre(txtBuscar.Text).ToList();

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
            dgvEventos.DataSource = _daoRRHHWS.listarEventosPorFecha(dtpDesde.Value,
                    dtpHasta.Value);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = _daoRRHHWS.listarEventosTodos();
        }

        private void pbCorreo_Click(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow != null)
            {
                _evento = (evento)dgvEventos.CurrentRow.DataBoundItem;
                if (_evento != null)
                {
                    frmEnviarCorreo frmEnviar = new frmEnviarCorreo(_evento);
                    if (frmEnviar.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            else
                MessageBox.Show("No hay un evento seleccionado.", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
