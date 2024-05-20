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

    public partial class frmMaestroPuestoTrabajo : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private puestoTrabajo _puestoTrabajo;
        private List<candidato> _candidatos;
        private List<trazabilidadCandidato> _trazas;
        private string _cadenaBuscar = "Buscar candidato por nombre o DNI...";
        private Estado _estado;

        public frmMaestroPuestoTrabajo()
        {
            _estado = RetailSoft.Estado.Inicial;
            _daoRRHHWS = new RRHHWSClient();
            _puestoTrabajo = new puestoTrabajo();
            _candidatos = new List<candidato>();
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;
            dgvCandidatos.AutoGenerateColumns = false;
        }

        public frmMaestroPuestoTrabajo(puestoTrabajo _puestoAux)
        {
            _estado = RetailSoft.Estado.Modificar;
            _daoRRHHWS = new RRHHWSClient();
            _candidatos = new List<candidato>();
            _trazas = new List<trazabilidadCandidato>();
            _puestoTrabajo = _puestoAux;
            InitializeComponent();
            btnGuardar.Text = "Actualizar";
            btnEliminar.Enabled = true;

            txtIdPuesto.Text = _puestoAux.idPuestoTrabajo.ToString();
            txtNombre.Text = _puestoAux.nombre;
            txtCorreo.Text = _puestoAux.correoResponsable;
            txtVacantes.Text = _puestoAux.vacantes.ToString();
            dtpFechaPublicacion.Value = _puestoAux.fechaPublicacion;
            dtpFechaLimite.Value = _puestoAux.fechaLimite;
            rtDescripcion.Text = _puestoAux.descripcion;
            rtRequisitos.Text = _puestoAux.requisitos;

            dgvCandidatos.AutoGenerateColumns = false;
            try
            {
                dgvCandidatos.DataSource = _candidatos = _daoRRHHWS.listarCandidatosXidPuesto(_puestoAux.idPuestoTrabajo).ToList();
                foreach (candidato c in _candidatos) _trazas.Add(_daoRRHHWS.listarTrazaActualIdCandidato(c.idPersona));
            }
            catch(Exception ex)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantVacantes;
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del Puesto de trabajo", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el Correo del responsable", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtVacantes.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la cantidad de vacantes", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                cantVacantes = Int32.Parse(txtVacantes.Text);
                if (cantVacantes == 0)
                {
                    MessageBox.Show("El número de Vacantes no puede ser cero", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número en Vacantes", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la Descripcion", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rtRequisitos.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar los Requisitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _puestoTrabajo.nombre = txtNombre.Text;
            _puestoTrabajo.correoResponsable = txtCorreo.Text;
            _puestoTrabajo.vacantes = cantVacantes;
            _puestoTrabajo.fechaPublicacion = dtpFechaPublicacion.Value;
            _puestoTrabajo.fechaPublicacionSpecified = true;
            _puestoTrabajo.fechaLimite = dtpFechaLimite.Value;
            _puestoTrabajo.fechaLimiteSpecified = true;
            _puestoTrabajo.descripcion = rtDescripcion.Text;
            _puestoTrabajo.requisitos = rtRequisitos.Text;
            if (_estado == RetailSoft.Estado.Inicial)
            {
                int resultado = _daoRRHHWS.insertarPuestoTrabajo(_puestoTrabajo);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == RetailSoft.Estado.Modificar)
            {
                int resultado = _daoRRHHWS.actualizarPuestoTrabajo(_puestoTrabajo);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVacantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMaestroCandidato frmCand = new frmMaestroCandidato(_puestoTrabajo);
            if (frmCand.ShowDialog() == DialogResult.OK)
            {
                dgvCandidatos.DataSource = _candidatos = _daoRRHHWS.listarCandidatosXidPuesto(_puestoTrabajo.idPuestoTrabajo).ToList();
                _trazas.Clear();
                foreach (candidato c in _candidatos) _trazas.Add(_daoRRHHWS.listarTrazaActualIdCandidato(c.idPersona));
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

        private void dgvCandidatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                candidato cand = (candidato)dgvCandidatos.Rows[e.RowIndex].DataBoundItem;
                if (cand != null)
                {
                    dgvCandidatos.Rows[e.RowIndex].Cells[0].Value = cand.nombre + " " + cand.apellidoPaterno + " " + cand.apellidoMaterno;
                    dgvCandidatos.Rows[e.RowIndex].Cells[1].Value = cand.dni;
                    dgvCandidatos.Rows[e.RowIndex].Cells[2].Value = cand.telefono;
                    trazabilidadCandidato tra = _trazas.FirstOrDefault(tr => tr.candidato.idCandidato == cand.idPersona);
                    if(tra != null)
                        dgvCandidatos.Rows[e.RowIndex].Cells[3].Value = tra.estadoCandidato.nombre;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCandidatos.CurrentRow != null)
            {
                candidato cand = (candidato)dgvCandidatos.CurrentRow.DataBoundItem;
                if (cand != null)
                {
                    frmMaestroCandidato frmCand = new frmMaestroCandidato(cand);
                    if (frmCand.ShowDialog() == DialogResult.OK)
                    {
                        dgvCandidatos.DataSource = _candidatos = _daoRRHHWS.listarCandidatosXidPuesto(_puestoTrabajo.idPuestoTrabajo).ToList();
                        _trazas.Clear();
                        foreach (candidato c in _candidatos) _trazas.Add(_daoRRHHWS.listarTrazaActualIdCandidato(c.idPersona));
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
                dgvCandidatos.DataSource = _candidatos = _daoRRHHWS.listarCandidatosXnombreDNIidPuesto(txtBuscar.Text,_puestoTrabajo.idPuestoTrabajo).ToList();

                txtBuscar.Text = _cadenaBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron resultados para: " + txtBuscar.Text,
                    "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este evento?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
               == DialogResult.Yes)
            {
                int resultado = _daoRRHHWS.eliminarPuesto(_puestoTrabajo.idPuestoTrabajo);
                if (resultado != 0)
                {
                    MessageBox.Show("El evento se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
