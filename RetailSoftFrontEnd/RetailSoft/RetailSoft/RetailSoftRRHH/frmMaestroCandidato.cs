using RetailSoft.RRHHWS;
using RetailSoft.VentasWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmMaestroCandidato : Form
    {
        private string _rutaArchivoPDF;
        private RRHHWSClient _daoRRHHWS;
        private candidato _candidato;
        private trazabilidadCandidato _traza;
        private trazabilidadCandidato _trazaActual;
        private puestoTrabajo _puesto;
        private Estado _estado;
        public frmMaestroCandidato(puestoTrabajo _puestoAux)
        {
            _estado = Estado.Inicial;
            _daoRRHHWS = new RRHHWSClient();
            _candidato = new candidato();
            _puesto = _puestoAux;
            InitializeComponent();
            cboEstado.DataSource = _daoRRHHWS.listarEstadosCandidato();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "idEstadoCandidato";
            cboEstado.SelectedIndex = 0;
            cboEstado.Enabled = false;
            btnDescargarCV.Enabled = false;
            dgvTrazabilidad.AutoGenerateColumns = false;
        }

        public frmMaestroCandidato(candidato _candidatoAux)
        {
            _estado = Estado.Modificar;
            _daoRRHHWS = new RRHHWSClient();
            _candidato = _candidatoAux;
            InitializeComponent();
            btnDescargarCV.Enabled = true;
            btnGuardar.Text = "Actualizar";
            cboEstado.DataSource = _daoRRHHWS.listarEstadosCandidato();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "idEstadoCandidato";
            _trazaActual = _daoRRHHWS.listarTrazaActualIdCandidato(_candidato.idPersona);
            cboEstado.SelectedIndex = _trazaActual.estadoCandidato.idEstadoCandidato - 1;
            txtIDCandidato.Text = _candidato.idPersona.ToString();
            txtDNI.Text = _candidato.dni;
            txtNombre.Text = _candidato.nombre;
            txtApellidoPaterno.Text = _candidato.apellidoPaterno;
            txtApellidoMaterno.Text = _candidato.apellidoMaterno;
            if (_candidato.genero.Equals('M')) rbMasculino.Checked = true;
            else rbFemenino.Checked = true;
            dtpFechaNacimiento.Value = _candidato.fechaNacimiento;
            txtTelefono.Text = _candidato.telefono;
            txtCorreo.Text = _candidato.correoElectronico;
            txtObservacion.Text = _trazaActual.observacion;

            pbDocumento.Image = Properties.Resources.archivoSubido;
            pbDocumento.SizeMode = PictureBoxSizeMode.StretchImage;
            dgvTrazabilidad.AutoGenerateColumns = false;
            dgvTrazabilidad.DataSource = _daoRRHHWS.listarTrazaXIdCandidato(_candidato.idPersona);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtDNI.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como DNI", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDNI.Text.Trim().Length != 8)
            {
                MessageBox.Show("Debe ingresar un DNI que tenga 8 dígitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoMaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbMasculino.Checked == false && rbFemenino.Checked == false)
            {
                MessageBox.Show("Debe indicar el género del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el teléfono del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtTelefono.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como teléfono", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar el correo del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //verifica si es un correo electrónico válido
            if (!EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("El correo ingresado no es válido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el estado del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _candidato.nombre = txtNombre.Text;
            _candidato.dni = txtDNI.Text;
            _candidato.fechaNacimiento = dtpFechaNacimiento.Value;
            _candidato.fechaNacimientoSpecified = true;
            _candidato.apellidoPaterno = txtApellidoPaterno.Text;
            _candidato.apellidoMaterno = txtApellidoMaterno.Text;
            _candidato.correoElectronico = txtCorreo.Text;
            if (rbFemenino.Checked) _candidato.genero = 'F';
            if (rbMasculino.Checked) _candidato.genero = 'M';
            _candidato.telefono = txtTelefono.Text;
            if (_estado == Estado.Inicial)
            {
                _candidato.puestoTrabajo = new puestoTrabajo();
                _candidato.puestoTrabajo.idPuestoTrabajo = _puesto.idPuestoTrabajo;
            }

            // Verifica si se seleccionó una nueva imagen para actualizar
            if (!string.IsNullOrEmpty(_rutaArchivoPDF))
            {
                //Adjuntar archivo
                FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _candidato.cv = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            else
            {
                if (_estado == Estado.Inicial)
                {
                    MessageBox.Show("Debe subir el CV del candidato", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (_estado == Estado.Inicial)
            {
                int resultado = _daoRRHHWS.insertarCandidato(_candidato);
                if (resultado != 0)
                {
                    _traza = new trazabilidadCandidato();
                    _traza.candidato = new candidato();
                    _traza.estadoCandidato = new estadoCandidato();
                    _traza.candidato.idCandidato = resultado;
                    _traza.estadoCandidato = (estadoCandidato)cboEstado.SelectedItem;
                    _traza.fecha = DateTime.Now;
                    _traza.fechaSpecified = true;
                    _traza.observacion = txtObservacion.Text;
                    _daoRRHHWS.insertarTrazabilidadCandidato(_traza);
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                int resultado = _daoRRHHWS.actualizarCandidato(_candidato);
                if (resultado != 0)
                {
                    estadoCandidato es = (estadoCandidato)cboEstado.SelectedItem;
                    if (_trazaActual.estadoCandidato.idEstadoCandidato != es.idEstadoCandidato)
                    {
                        _traza = new trazabilidadCandidato();
                        _traza.candidato = new candidato();
                        _traza.estadoCandidato = new estadoCandidato();
                        _traza.candidato.idCandidato = _candidato.idPersona;
                        _traza.estadoCandidato = (estadoCandidato)cboEstado.SelectedItem;
                        _traza.fecha = DateTime.Now;
                        _traza.fechaSpecified = true;
                        _traza.observacion = txtObservacion.Text;
                        _daoRRHHWS.insertarTrazabilidadCandidato(_traza);
                    }
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private bool EsCorreoValido(string correo)
        {
            // Patrón de expresión regular para verificar un correo electrónico válido
            string patronCorreo = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            // Compara el texto con el patrón
            return Regex.IsMatch(correo, patronCorreo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCargarCV_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPDF = ofdArchivo.FileName;
                    FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    pbDocumento.Image = Properties.Resources.archivoSubido;
                    pbDocumento.SizeMode = PictureBoxSizeMode.StretchImage;
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvTrazabilidad_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                trazabilidadCandidato trazaCand = (trazabilidadCandidato)dgvTrazabilidad.Rows[e.RowIndex].DataBoundItem;
                if (trazaCand != null)
                {
                    dgvTrazabilidad.Rows[e.RowIndex].Cells[0].Value = trazaCand.estadoCandidato.nombre;
                    dgvTrazabilidad.Rows[e.RowIndex].Cells[1].Value = trazaCand.fecha;
                    dgvTrazabilidad.Rows[e.RowIndex].Cells[2].Value = trazaCand.observacion;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDescargarCV_Click(object sender, EventArgs e)
        {
            if (sfdArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdArchivo.FileName;
                    //Convertimos el arreglo de Bytes a archivo
                    File.WriteAllBytes(archivoGenerar, _candidato.cv);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
