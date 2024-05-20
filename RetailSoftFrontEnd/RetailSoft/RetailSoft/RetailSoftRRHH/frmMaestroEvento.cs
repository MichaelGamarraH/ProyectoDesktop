using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmMaestroEvento : Form
    {
        private string _rutaFotoLocal;
        private RRHHWSClient _daoRRHHWS;
        private evento _evento;
        private BindingList<colaborador> _colaboradores;
        private List<colaboradorxEvento> _colaboradoresxEvento;
        private colaboradorxEvento _colxevento;
        private Estado _estado;

        public frmMaestroEvento()
        {
            _estado = Estado.Inicial;
            _daoRRHHWS = new RRHHWSClient();
            _evento = new evento();
            _colaboradores = new BindingList<colaborador>();
            InitializeComponent();
            btnEliminar.Enabled = false;
            dtpFechaRealizacion.Value = DateTime.Now;
            txtTotalInvitados.Text = "0";
            dgvColaboradores.AutoGenerateColumns = false;
            dgvColaboradores.DataSource = _colaboradores;
        }
        public frmMaestroEvento(evento _eventoAux)
        {
            _estado = Estado.Modificar;
            _daoRRHHWS = new RRHHWSClient();
            _evento = _eventoAux;
            _colaboradores = new BindingList<colaborador>();
            _colaboradoresxEvento = new List<colaboradorxEvento>();
            InitializeComponent();
            btnGuardar.Text = "Actualizar";
            btnEliminar.Enabled = true;
            
            txtIdEvento.Text = _eventoAux.idEvento.ToString();
            txtNombre.Text = _eventoAux.nombre;
            txtLugar.Text = _eventoAux.lugar;
            dtpFechaRealizacion.Value = _eventoAux.fechaRealizacion;
            string formato = "HH:mm:ss";
            if (DateTime.TryParseExact(_eventoAux.horaInicio, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaInicio))
                dtpHoraInicio.Value = horaInicio;
            if (DateTime.TryParseExact(_eventoAux.horaFin, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaFin))
                dtpHoraFin.Value = horaFin;
            _colaboradoresxEvento = _daoRRHHWS.listarColaboradoresPorIdEvento(_eventoAux.idEvento).ToList();
            foreach (colaboradorxEvento colxevento in _colaboradoresxEvento) _colaboradores.Add(colxevento.colaborador);
            txtTotalInvitados.Text = _colaboradores.Count().ToString();
            rtDescripcion.Text = _eventoAux.descripcion;
            MemoryStream ms = new MemoryStream(_eventoAux.imagen);
            pbFoto.Image = new Bitmap(ms);
            dgvColaboradores.AutoGenerateColumns = false;
            dgvColaboradores.DataSource = _colaboradores;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaColaboradores frmBusq = new frmBusquedaColaboradores(_colaboradores);
            if (frmBusq.ShowDialog() == DialogResult.OK)
            {
                _colaboradores.Clear();
                foreach (colaborador col in frmBusq.ColaboradoresSeleccionados) 
                    _colaboradores.Add(col);
                txtTotalInvitados.Text = _colaboradores.Count().ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _evento.totalInvitados = _colaboradores.Count;
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del evento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtLugar.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el lugar del evento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(_evento.totalInvitados == 0)
            {
                MessageBox.Show("Debe seleccionar invitados para el evento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _evento.nombre = txtNombre.Text;
            _evento.lugar = txtLugar.Text;
            _evento.descripcion = rtDescripcion.Text;
            _evento.fechaRealizacion = dtpFechaRealizacion.Value;
            _evento.fechaRealizacionSpecified = true;
            _evento.horaInicio = dtpHoraInicio.Value.ToString("HH:mm");
            _evento.horaFin = dtpHoraFin.Value.ToString("HH:mm");

            if (!string.IsNullOrEmpty(_rutaFotoLocal))
            {
                FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _evento.imagen = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            else
            {
                if (_estado == Estado.Inicial)
                {
                    MessageBox.Show("Debe seleccionar la foto del evento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (_estado == Estado.Inicial)
            {
                int resultado = _daoRRHHWS.insertarEvento(_evento);
                if (resultado != 0)
                {
                    foreach (colaborador col in this._colaboradores)
                    {
                        _colxevento = new colaboradorxEvento();
                        _colxevento.evento = new evento();
                        _colxevento.colaborador = new colaborador();
                        _colxevento.evento.idEvento = resultado;
                        _colxevento.colaborador.idPersona = col.idPersona;
                        _colxevento.colaborador.idColaborador = col.idPersona;
                        _colxevento.asistencia = true;
                        _daoRRHHWS.insertarColaboradorXEvento(_colxevento);
                    }

                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                int resultado = _daoRRHHWS.actualizarEvento(_evento);
                if (resultado != 0)
                {
                    foreach (colaboradorxEvento colxevevento in _colaboradoresxEvento)
                    {
                        //Eliminar los que no estén en _colaboradores
                        if (!_colaboradores.Any(colaborador => colaborador.idPersona == colxevevento.colaborador.idColaborador))
                        {
                            _daoRRHHWS.eliminarColaboradorXEvento(colxevevento.idColaboradorxEvento);
                        }
                    }
                    foreach (colaborador col in this._colaboradores)
                    {
                        //Insertar los que no estén en _colaboradoresxEvento
                        bool esNuevoColaborador = true;
                        foreach (colaboradorxEvento colxevento in _colaboradoresxEvento)
                        {
                            if (col.idPersona == colxevento.colaborador.idColaborador)
                            {
                                esNuevoColaborador = false;
                                break;
                            }
                        }
                        if (esNuevoColaborador)
                        {
                            _colxevento = new colaboradorxEvento();
                            _colxevento.evento = new evento();
                            _colxevento.colaborador = new colaborador();
                            _colxevento.evento.idEvento = _evento.idEvento;
                            _colxevento.colaborador.idPersona = col.idPersona;
                            _colxevento.colaborador.idColaborador = col.idPersona;
                            _colxevento.asistencia = true;
                            _daoRRHHWS.insertarColaboradorXEvento(_colxevento);
                        }
                    }
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void dgvColaboradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                colaborador col = (colaborador)dgvColaboradores.Rows[e.RowIndex].DataBoundItem;
                if (col != null)
                {
                    dgvColaboradores.Rows[e.RowIndex].Cells[0].Value = col.nombre;
                    dgvColaboradores.Rows[e.RowIndex].Cells[1].Value = col.apellidoPaterno + " " + col.apellidoMaterno;
                    dgvColaboradores.Rows[e.RowIndex].Cells[2].Value = col.dni;
                    dgvColaboradores.Rows[e.RowIndex].Cells[3].Value = col.correoElectronico;
                    dgvColaboradores.Rows[e.RowIndex].Cells[4].Value = col.cargo.tipoCargo;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este evento?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
               == DialogResult.Yes)
            {
                int resultado = _daoRRHHWS.eliminarEvento(_evento.idEvento);
                if (resultado != 0)
                {
                    MessageBox.Show("El evento se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
