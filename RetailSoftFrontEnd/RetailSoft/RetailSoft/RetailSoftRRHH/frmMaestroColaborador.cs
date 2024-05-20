using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmMaestroColaborador : Form
    {
        private string _rutaFotoLocal;
        private RRHHWSClient _daoRRHHWS;
        private colaborador _colaborador;
        private salario _salario;
        private salario _salarioOriginal;
        private beneficioxColaborador _benxcolab;
        private List<beneficioxColaborador> _beneficiosxcolab;
        private BindingList<beneficio> _beneficios;
        private Estado _estado;
        private double tolerancia = 0.0001;
        public frmMaestroColaborador()
        {
            _estado = Estado.Inicial;
            _daoRRHHWS = new RRHHWSClient();
            _colaborador = new colaborador();
            _salario = new salario();
            _salarioOriginal = new salario();
            _colaborador.beneficios = new BindingList<beneficio>().ToArray();
            _beneficios = new BindingList<beneficio>();
            InitializeComponent();
            btnEliminar.Enabled = false;
            cboCargo.DataSource = _daoRRHHWS.listarTodosCargos();
            cboCargo.DisplayMember = "tipoCargo";
            cboCargo.ValueMember = "idCargo";
            cboCargo.SelectedIndex = -1;
            dgvBeneficiosColab.AutoGenerateColumns = false;
            dgvBeneficiosTodos.AutoGenerateColumns = false;
            dgvBeneficiosColab.DataSource = _beneficios;
            dgvBeneficiosTodos.DataSource = _daoRRHHWS.listarBeneficiosTodos();
        }

        public frmMaestroColaborador(colaborador _colabAux)
        {
            _estado = Estado.Modificar;
            _daoRRHHWS = new RRHHWSClient();
            _colaborador = new colaborador();
            _colaborador.idPersona = _colabAux.idPersona;
            _colaborador.imagen = _colabAux.imagen;
            _salario = new salario();
            _salarioOriginal = new salario();
            _colaborador.beneficios = new BindingList<beneficio>().ToArray();
            _beneficios = new BindingList<beneficio>();
            _beneficiosxcolab = new List<beneficioxColaborador>();
            InitializeComponent();
            btnGuardar.Text = "Actualizar";
            cboCargo.DataSource = _daoRRHHWS.listarTodosCargos();
            cboCargo.DisplayMember = "tipoCargo";
            cboCargo.ValueMember = "idCargo";
            cboCargo.SelectedValue = _colabAux.cargo.idCargo;
            dgvBeneficiosColab.AutoGenerateColumns = false;
            dgvBeneficiosTodos.AutoGenerateColumns = false;
            _beneficiosxcolab = _daoRRHHWS.listarBeneficiosPorIdColaborador(_colabAux.idPersona).ToList();
            foreach (beneficioxColaborador ben in _beneficiosxcolab) _beneficios.Add(ben.beneficio);
            dgvBeneficiosColab.DataSource = _beneficios;
            dgvBeneficiosTodos.DataSource = _daoRRHHWS.listarBeneficiosTodos();
            txtIdColaborador.Text = _colabAux.idPersona.ToString();
            txtDNI.Text = _colabAux.dni;
            txtNombres.Text = _colabAux.nombre;
            txtApellidoPaterno.Text = _colabAux.apellidoPaterno;
            txtApellidoMaterno.Text = _colabAux.apellidoMaterno;
            if (_colabAux.genero.Equals('M')) rbMasculino.Checked = true;
            else rbFemenino.Checked = true;
            dtpFechaNacimiento.Value = _colabAux.fechaNacimiento;
            txtTelefono.Text = _colabAux.telefono;
            txtCorreo.Text = _colabAux.correoElectronico;

            _salario = _daoRRHHWS.getSalarioPorIdColaborador(_colabAux.idPersona);
            txtSalario.Text = _salario.salarioBase.ToString("N2");
            _salarioOriginal.idSalario = _salario.idSalario;
            _salarioOriginal.salarioBase = _salario.salarioBase;
            string formato = "HH:mm:ss";
            if (DateTime.TryParseExact(_colabAux.horaIngreso, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaIngreso))
                dtpHoraIngreso.Value = horaIngreso;
            if (DateTime.TryParseExact(_colabAux.horaSalida, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaSalida))
                dtpHoraSalida.Value = horaSalida;
            MemoryStream ms = new MemoryStream(_colabAux.imagen);
            pbFoto.Image = new Bitmap(ms);
        }

        private void dgvBeneficiosTodos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            beneficio ben = (beneficio)dgvBeneficiosTodos.Rows[e.RowIndex].DataBoundItem;
            dgvBeneficiosTodos.Rows[e.RowIndex].Cells[0].Value = ben.nombre;
            dgvBeneficiosTodos.Rows[e.RowIndex].Cells[1].Value = ben.descripcion;
        }

        private void dgvBeneficiosColab_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                beneficio ben = (beneficio)dgvBeneficiosColab.Rows[e.RowIndex].DataBoundItem;
                if (ben != null)
                {
                    dgvBeneficiosColab.Rows[e.RowIndex].Cells[0].Value = ben.nombre;
                    dgvBeneficiosColab.Rows[e.RowIndex].Cells[1].Value = ben.descripcion;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            beneficio benaux;
            benaux = (beneficio)dgvBeneficiosTodos.CurrentRow.DataBoundItem;
            foreach (beneficio ben in this._beneficios)
            {
                if (ben.nombre.Equals(benaux.nombre))
                {
                    MessageBox.Show("Beneficio ya seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            _beneficios.Add(benaux);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvBeneficiosColab.CurrentRow != null)
            {
                beneficio ben = (beneficio)dgvBeneficiosColab.CurrentRow.DataBoundItem;
                _beneficios.Remove(ben);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un beneficio a quitar de los beneficios seleccionados", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validaciones
            if (txtDNI.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtNombres.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoMaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbMasculino.Checked == false && rbFemenino.Checked == false)
            {
                MessageBox.Show("Debe indicar el género del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el teléfono del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Debe ingresar el correo del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //verifica si es un correo electrónico válido
            if (!EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("El correo ingresado no es válido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSalario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el salario del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtSalario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un monto correcto como salario del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el cargo del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_beneficios.Count == 0)
            {
                MessageBox.Show("Debe seleccionar los beneficios del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _colaborador.nombre = txtNombres.Text;
            _colaborador.cargo = (cargo)cboCargo.SelectedItem;
            _colaborador.dni = txtDNI.Text;
            _colaborador.fechaNacimiento = dtpFechaNacimiento.Value;
            _colaborador.fechaNacimientoSpecified = true;
            _colaborador.apellidoPaterno = txtApellidoPaterno.Text;
            _colaborador.apellidoMaterno = txtApellidoMaterno.Text;
            _colaborador.correoElectronico = txtCorreo.Text;
            if (rbFemenino.Checked) _colaborador.genero = 'F';
            if (rbMasculino.Checked) _colaborador.genero = 'M';
            _colaborador.telefono = txtTelefono.Text;
            _colaborador.horaIngreso = dtpHoraIngreso.Value.ToString("HH:mm");
            _colaborador.horaSalida = dtpHoraSalida.Value.ToString("HH:mm");
            _colaborador.beneficios = _beneficios.ToArray();
            if(_colaborador.cargo.idCargo == 3 || _colaborador.cargo.idCargo == 4 || _colaborador.cargo.idCargo == 5)
            {
                _colaborador.usuario = _colaborador.nombre.ToLower() + "." + _colaborador.dni;
                _colaborador.contrasenha = _colaborador.apellidoMaterno;
            }
            _salario.salarioBase = Double.Parse(txtSalario.Text);
            _salario.salarioFinal = 0;
            // Verifica si se seleccionó una nueva imagen para actualizar
            if (!string.IsNullOrEmpty(_rutaFotoLocal))
            {
                FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _colaborador.imagen = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            else
            {
                if(_estado == Estado.Inicial)
                {
                    MessageBox.Show("Debe seleccionar la foto del colaborador", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (_estado == Estado.Inicial)
            {
                int resultado = _daoRRHHWS.insertarColaborador(_colaborador);
                if (resultado != 0)
                {
                    _salario.colaborador = new colaborador();
                    _salario.colaborador.idColaborador = resultado;
                    _daoRRHHWS.insertarSalario(_salario);
                    foreach (beneficio ben in this._beneficios)
                    {
                        _benxcolab = new beneficioxColaborador();
                        _benxcolab.colaborador = new colaborador();
                        _benxcolab.beneficio = new beneficio();
                        _benxcolab.colaborador.idColaborador = resultado;
                        _benxcolab.beneficio.idBeneficio = ben.idBeneficio;
                        _daoRRHHWS.insertarBeneficioxColaborador(_benxcolab);
                    }
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                int resultado = _daoRRHHWS.actualizarColaborador(_colaborador);
                if (resultado != 0)
                {
                    if(Math.Abs(_salarioOriginal.salarioBase - _salario.salarioBase) > tolerancia)
                    {
                        //los sueldos son diferentes
                        //actualizarlos, borrado lógico del anterior e inserción de nuevo salario
                        _daoRRHHWS.eliminarSalario(_salarioOriginal.idSalario);
                        
                        _salario.colaborador = new colaborador();
                        _salario.colaborador.idColaborador = _colaborador.idPersona;
                        _daoRRHHWS.insertarSalario(_salario);
                    }

                    foreach (beneficioxColaborador ben in _beneficiosxcolab)
                    {
                        //Eliminar los que no estén en _beneficios
                        if (!_beneficios.Contains(ben.beneficio))
                        {
                            _daoRRHHWS.eliminarBeneficioXColaborador(ben.idBeneficioxColaborador);
                        }
                    }

                    foreach (beneficio ben in this._beneficios)
                    {
                        //Insertar los que no estén en _beneficiosxcolab
                        bool esNuevoBeneficio = true;
                        foreach (beneficioxColaborador benxcol in _beneficiosxcolab)
                        {
                            if (ben.idBeneficio == benxcol.beneficio.idBeneficio)
                            {
                                esNuevoBeneficio = false;
                                break;
                            }
                        }
                        if (esNuevoBeneficio)
                        {
                            _benxcolab = new beneficioxColaborador();
                            _benxcolab.colaborador = new colaborador();
                            _benxcolab.beneficio = new beneficio();
                            _benxcolab.colaborador.idColaborador = _colaborador.idPersona;
                            _benxcolab.beneficio.idBeneficio = ben.idBeneficio;
                            _daoRRHHWS.insertarBeneficioxColaborador(_benxcolab);
                        }
                    }

                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsCorreoValido(string correo)
        {
            // Patrón de expresión regular para verificar un correo electrónico válido
            string patronCorreo = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            // Compara el texto con el patrón
            return Regex.IsMatch(correo, patronCorreo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar a este empleado?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) 
                == DialogResult.Yes)
            {
                int resultado = _daoRRHHWS.eliminarColaborador(_colaborador.idPersona);
                if (resultado != 0)
                {
                    MessageBox.Show("El empleado se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
