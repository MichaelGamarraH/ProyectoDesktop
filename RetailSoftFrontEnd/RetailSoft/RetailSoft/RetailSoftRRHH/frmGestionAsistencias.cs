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
    public partial class frmGestionAsistencias : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private asistenciaColaborador _asistenciaColaborador;
        private List<asistenciaColaborador> _asistencias;
        private string _cadenaBuscar = "Buscar por nombre o DNI...";
        public frmGestionAsistencias()
        {
            _daoRRHHWS = new RRHHWSClient();
            _asistencias = new List<asistenciaColaborador>();
            InitializeComponent();
            lblFecha.Text += DateTime.Now.ToString("dd/MM/yyyy");
            try
            {
                _asistencias = _daoRRHHWS.listarAsistencias().ToList();
            }
            catch(Exception ex)
            {

            }
            dgvAsistencias.AutoGenerateColumns = false;
            dgvAsistencias.DataSource = _daoRRHHWS.listarColaboradoresTodos();
        }

        private void dgvAsistencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                colaborador colab = (colaborador)dgvAsistencias.Rows[e.RowIndex].DataBoundItem;
                if (colab != null)
                {
                    dgvAsistencias.Rows[e.RowIndex].Cells[0].Value = colab.nombre + " " + colab.apellidoPaterno + " " + colab.apellidoMaterno;
                    dgvAsistencias.Rows[e.RowIndex].Cells[1].Value = colab.dni;
                    asistenciaColaborador asist = _asistencias.FirstOrDefault(ac => ac.colaborador.idColaborador == colab.idPersona);
                    if (asist != null)
                    {
                        dgvAsistencias.Rows[e.RowIndex].Cells[2].Value = asist.horaIngreso != null ? asist.horaIngreso : "-";
                        dgvAsistencias.Rows[e.RowIndex].Cells[3].Value = asist.horaSalida != null ? asist.horaSalida : "-";
                    }
                    else
                    {
                        dgvAsistencias.Rows[e.RowIndex].Cells[2].Value = "-";
                        dgvAsistencias.Rows[e.RowIndex].Cells[3].Value = "-";
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            if(dgvAsistencias.CurrentRow != null && dgvAsistencias.CurrentRow.DataBoundItem != null)
            {
                colaborador colab = (colaborador)dgvAsistencias.CurrentRow.DataBoundItem;
                if (_daoRRHHWS.listarAsistenciaPorColaborador(colab.idPersona).idAsistencia == 0)
                {
                    // Confirmación del usuario
                    DialogResult confirmacion = MessageBox.Show($"¿Desea registrar la asistencia para {colab.nombre} {colab.apellidoPaterno}?",
                        "Confirmar Asistencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.Yes)
                    {
                        int resultado;
                        _asistenciaColaborador = new asistenciaColaborador();
                        _asistenciaColaborador.colaborador = new colaborador();
                        _asistenciaColaborador.colaborador.idColaborador = colab.idPersona;
                        resultado = _daoRRHHWS.insertarAsistenciaColaborador(_asistenciaColaborador);
                        if (resultado != 0)
                        {
                            MessageBox.Show("Asistencia registrada", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //dgvAsistencias.DataSource = _daoRRHHWS.listarColaboradoresTodos();
                            _asistencias = _daoRRHHWS.listarAsistencias().ToList();
                        }
                        else MessageBox.Show("Se produjo un error al marcar la asistencia", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else MessageBox.Show("Ya ha marcado su asistencia", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("No hay un colaborador seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.CurrentRow != null && dgvAsistencias.CurrentRow.DataBoundItem != null)
            {
                colaborador colab = (colaborador)dgvAsistencias.CurrentRow.DataBoundItem;
                _asistenciaColaborador = _daoRRHHWS.listarAsistenciaPorColaborador(colab.idPersona);
                if (_asistenciaColaborador.idAsistencia != 0)
                {
                    // Confirmación del usuario
                    DialogResult confirmacion = MessageBox.Show($"¿Desea registrar la salida para {colab.nombre} {colab.apellidoPaterno}?",
                        "Confirmar Asistencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.Yes)
                    {
                        int resultado;
                        _asistenciaColaborador.horaSalida = DateTime.Now.ToString("HH:mm:ss");
                        TimeSpan hstrabajadas = TimeSpan.Parse(_asistenciaColaborador.horaSalida) - TimeSpan.Parse(_asistenciaColaborador.horaIngreso);
                        _asistenciaColaborador.horasTrabajadas = hstrabajadas.TotalHours;
                        resultado = _daoRRHHWS.actualizarAsistencia(_asistenciaColaborador);
                        if (resultado != 0)
                        {
                            MessageBox.Show("Salida registrada", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //dgvAsistencias.DataSource = _daoRRHHWS.listarColaboradoresTodos();
                            _asistencias = _daoRRHHWS.listarAsistencias().ToList();
                        }
                        else MessageBox.Show("Se produjo un error al marcar la asistencia", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else MessageBox.Show("Debe registrar primero su ingreso", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("No hay un colaborador seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == _cadenaBuscar) txtBuscar.Text = "";
                dgvAsistencias.DataSource = _daoRRHHWS.listarColaboradoresPorDNINombre(txtBuscar.Text).ToList();
                try
                {
                    _asistencias = _daoRRHHWS.listarAsistencias().ToList();
                }
                catch(Exception ex)
                {

                }
                txtBuscar.Text = _cadenaBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron resultados para: " + txtBuscar.Text,
                    "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
