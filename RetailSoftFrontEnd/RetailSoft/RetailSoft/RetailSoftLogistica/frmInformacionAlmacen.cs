using RetailSoft.LogisticaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftLogistica
{
    public partial class frmInformacionAlmacen : Form
    {
        private Estado _estado;
        private LogisticaWSClient daoAlmacen;
        private almacenxVehiculo almxveh;
        private List<almacenxVehiculo> _almaVehi;
        private almacen almacennuevo;
        private Panel panelAux;
        private BindingList<vehiculo> _vehiculos;
        private almacenxVehiculo _almaxveh;

        //
        private List<almacenxVehiculo> _almaVehiNuevo;
        public frmInformacionAlmacen()
        {
            InitializeComponent();
        }
        public void establecerEstadoComponentes() {
            switch (_estado) {
                case Estado.Inicial:
                    txtID.Enabled = false;
                    txtNombre.Enabled = false;
                    txtResponsable.Enabled = false;
                    txtCapacidad.Enabled = false;
                    txtDireccion.Enabled = false;
                    dtpActualizacion.Enabled = false;
                    dtpMantenimiento.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cbCalidad.Enabled = false;
                    cbEstanterias.Enabled = false;
                    cbIluminacion.Enabled = false;
                    cbPickPack.Enabled = false;
                    cboDistritos.Enabled = false;
                    break;

                case Estado.Modificar:
                    txtID.Enabled = false;
                    txtNombre.Enabled = true;
                    txtResponsable.Enabled = true;
                    txtCapacidad.Enabled = true;
                    txtDireccion.Enabled = true;
                    dtpActualizacion.Enabled = true;
                    dtpMantenimiento.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cbCalidad.Enabled = true;
                    cbEstanterias.Enabled = true;
                    cbIluminacion.Enabled = true;
                    cbPickPack.Enabled = true;
                    cboDistritos.Enabled = true;
                    break;
            }
        }
        public frmInformacionAlmacen(String idAlmacen,Panel panelPro)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            panelTransportista.Visible = false;
            panelAux = panelPro;
            dgvVehiculo.Location = new Point(dgvVehiculo.Location.X + 205, dgvVehiculo.Location.Y);
            btnAgregar.Visible = false;
            btnQuitar.Visible = false;
            lblListadoVehi.Visible = false;
            dgvTodosVehiculos.Visible = false;
            listadoDistritos();
            almacennuevo = new almacen();

            daoAlmacen = new LogisticaWSClient();
            almacen[] almacenes = daoAlmacen.listadoAlmacen();

            foreach (almacen almacen in almacenes)
            {
                if (almacen.idAlmacen == int.Parse(idAlmacen))
                {
                    almacennuevo = almacen;
                    txtID.Text = almacen.idAlmacen.ToString();
                    txtNombre.Text = almacen.nombre;
                    txtResponsable.Text = almacen.responsable;
                    txtCapacidad.Text = almacen.capacidad.ToString();
                    txtDireccion.Text = almacen.direccion;
                    dtpActualizacion.Value = almacen.fechaActualizacion;
                    dtpMantenimiento.Value = almacen.fecha_mantenimiento;
                    txtDescripcion.Text = almacen.descripcion;
                    if (almacen.control_calidad) cbCalidad.Checked = true;
                    if (almacen.sistema_iluminacion) cbIluminacion.Checked = true;
                    if (almacen.stand_ajustable) cbEstanterias.Checked = true;
                    if (almacen.espacio_pickpack) cbPickPack.Checked = true;
                    break;
                }
            }
            daoAlmacen = new LogisticaWSClient();
            dgvVehiculo.AutoGenerateColumns = false;
            _vehiculos = new BindingList<vehiculo>();
            _almaVehi = new List<almacenxVehiculo>();
            _almaVehi = daoAlmacen.listarPorIdAlmacen(int.Parse(idAlmacen)).ToList();
            //Agregado:
            dgvTodosVehiculos.AutoGenerateColumns = false;
            dgvTodosVehiculos.DataSource = daoAlmacen.listadoVehiculos();
            //
            foreach (almacenxVehiculo av in _almaVehi) _vehiculos.Add(av.vehiculo);
            dgvVehiculo.DataSource = _vehiculos;

        }
        public frmInformacionAlmacen(almacen almacen,Panel panelPro) {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            panelTransportista.Visible = false;
            listadoDistritos();
            cboDistritos.SelectedIndexChanged += cboDistritos_SelectedIndexChanged;
            panelAux = panelPro;
            dgvVehiculo.Location = new Point(dgvVehiculo.Location.X + 205, dgvVehiculo.Location.Y);
            btnAgregar.Visible = false;
            btnQuitar.Visible = false;
            lblListadoVehi.Visible = false;
            dgvTodosVehiculos.Visible = false;
            almacennuevo = new almacen();
            almacennuevo = almacen;
            
            daoAlmacen = new LogisticaWSClient();
            dgvTodosVehiculos.AutoGenerateColumns = false;
            dgvTodosVehiculos.DataSource = daoAlmacen.listadoVehiculos();
            txtID.Text = almacen.idAlmacen.ToString();
            txtNombre.Text = almacen.nombre;
            txtResponsable.Text = almacen.responsable;
            txtCapacidad.Text = almacen.capacidad.ToString();
            txtDireccion.Text = almacen.direccion;
            dtpActualizacion.Value = almacen.fechaActualizacion;
            dtpMantenimiento.Value = almacen.fecha_mantenimiento;
            txtDescripcion.Text = almacen.descripcion;
            if (almacen.control_calidad) cbCalidad.Checked= true;
            if (almacen.sistema_iluminacion) cbIluminacion.Checked = true;
            if(almacen.stand_ajustable) cbEstanterias.Checked = true;
            if(almacen.espacio_pickpack) cbPickPack.Checked = true;

            dgvVehiculo.AutoGenerateColumns = false;

            _vehiculos = new BindingList<vehiculo>();
            _almaVehi = new List<almacenxVehiculo>();

            _almaVehi = daoAlmacen.listarPorIdAlmacen(almacen.idAlmacen).ToList();

            foreach (almacenxVehiculo av in _almaVehi) _vehiculos.Add(av.vehiculo);
            dgvVehiculo.DataSource = _vehiculos;

            //
            _almaVehiNuevo = new List<almacenxVehiculo>();
            
        }
        public void listadoDistritos()
        {
            cboDistritos.Items.Add("SAN MIGUEL");
            cboDistritos.Items.Add("LA VICTORIA");
            cboDistritos.Items.Add("CALLAO");
            cboDistritos.Items.Add("SURCO");
            cboDistritos.Items.Add("MIRAFLORES");
            cboDistritos.Items.Add("COMAS");
            cboDistritos.Items.Add("BARRANCO");
            cboDistritos.Items.Add("PUEBLO LIBRE");
            cboDistritos.Items.Add("LOS OLIVOS");
            cboDistritos.Items.Add("SURQUILLO");
            cboDistritos.Items.Add("SAN ISIDRO");
            cboDistritos.Items.Add("SAN BORJA");
            cboDistritos.Items.Add("MAGDALENA");
            cboDistritos.Items.Add("SANTA ANITA");
            cboDistritos.Items.Add("CHORRILLOS");
            cboDistritos.Items.Add("JESUS MARIA");
            cboDistritos.SelectedIndex = 0;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            dgvVehiculo.Location = new Point(dgvVehiculo.Location.X - 200, dgvVehiculo.Location.Y);
            btnAgregar.Visible = true;
            btnQuitar.Visible = true;
            lblListadoVehi.Visible = true;
            dgvTodosVehiculos.Visible = true;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Trim().Length == 0){
                MessageBox.Show("Debe ingresar el nombre del almacén", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtResponsable.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar a la persona encargada del almacén", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCapacidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar a la persona encargada del almacén", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtCapacidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número correcto para la capacidad", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la dirección del almacén", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpActualizacion.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Debe seleccionar una fecha válida para la actualizacion", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpMantenimiento.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Debe seleccionar una fecha válida para el mantenimiento", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la descripcion del almacén", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panelTransportista.Visible = false;
            almacennuevo.nombre = txtNombre.Text;
            almacennuevo.responsable = txtResponsable.Text;
            almacennuevo.capacidad = int.Parse(txtCapacidad.Text);
            if (cboDistritos.SelectedItem != null && cboDistritos.SelectedIndex >= 0)
            {
                almacennuevo.direccion = cboDistritos.SelectedItem.ToString() + " - " + txtDireccion.Text;
            }
            else
            {
                almacennuevo.direccion = txtDireccion.Text;
            }
             


            almacennuevo.fechaActualizacion = dtpActualizacion.Value;
            almacennuevo.fechaActualizacionSpecified = true;

            almacennuevo.fecha_mantenimiento = dtpMantenimiento.Value;
            almacennuevo.fecha_mantenimientoSpecified = true;
            almacennuevo.descripcion = txtDescripcion.Text;
            //almacennuevo.vehiculos = _vehiculos.ToArray(); //
            if (cbCalidad.Checked) almacennuevo.control_calidad = true;
            else almacennuevo.control_calidad = false;

            if (cbEstanterias.Checked) almacennuevo.stand_ajustable = true;
            else almacennuevo.stand_ajustable = false;

            if (cbIluminacion.Checked) almacennuevo.sistema_iluminacion = true;
            else almacennuevo.sistema_iluminacion = false;

            if (cbPickPack.Checked) almacennuevo.espacio_pickpack = true;
            else almacennuevo.espacio_pickpack = false;
 
            if (_estado== Estado.Modificar) {
                int resultado = daoAlmacen.modificarAlmacen(almacennuevo);
                 
                if (resultado != 0)
                {

                    foreach (almacenxVehiculo av in _almaVehi) {
                        if (!_vehiculos.Contains(av.vehiculo)) {
                            daoAlmacen.eliminarAlmacenxVehiculo(av);
                        }
                         
                    }
                    foreach (vehiculo veh in this._vehiculos)
                    {
                         
                        bool esNuevoVehiculo = true;
                        foreach (almacenxVehiculo av in _almaVehi)
                        {
                            if (veh.idVehiculo == av.vehiculo.idVehiculo)
                            {
                                esNuevoVehiculo = false;
                                break;
                            }
                        }
                        if (esNuevoVehiculo)
                        {
                            _almaxveh = new almacenxVehiculo();
                            _almaxveh.almacen = new almacen();
                            _almaxveh.vehiculo = new vehiculo();
                            _almaxveh.almacen.idAlmacen = almacennuevo.idAlmacen;
                            _almaxveh.vehiculo.idVehiculo = veh.idVehiculo;
                            daoAlmacen.insertarAlmacenxVehiculo(_almaxveh);
                        }
                    }

                    btnAgregar.Visible = false;
                    btnQuitar.Visible = false;
                    dgvTodosVehiculos.Visible = false;
                    lblListadoVehi.Visible = false;
                    dgvVehiculo.Location = new Point(dgvVehiculo.Location.X + 200, dgvVehiculo.Location.Y);
                    MessageBox.Show("El almacen se ha actualizado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = resultado.ToString();
                     
                }
                else
                    MessageBox.Show("Ha ocurrido un problema en la actualizacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
             
            panelAux.Controls.Clear();
            almacen[] almacenUP = daoAlmacen.listadoAlmacen();
            mostrarActualizacionFiltro(almacenUP);
        }
 
        private void mostrarActualizacionFiltro(almacen[] almacenes)
        {
            foreach (almacen almacen in almacenes)
            {
                frmBusquedaAlmacen formDatos = new frmBusquedaAlmacen(almacen, panelAux);
                formDatos.TopLevel = false;
                formDatos.Dock = DockStyle.Top;
                panelAux.Controls.Add(formDatos);
                formDatos.Visible = true;
            }
            panelAux.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que se quiere eliminar esta información del Almacén",
"Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Información de Almacén eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVehiculo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                vehiculo veh = (vehiculo)dgvVehiculo.Rows[e.RowIndex].DataBoundItem;
                if (veh != null)
                {
                    dgvVehiculo.Rows[e.RowIndex].Cells[0].Value = veh.idVehiculo;
                    dgvVehiculo.Rows[e.RowIndex].Cells[1].Value = veh.descripcion;
                    dgvVehiculo.Rows[e.RowIndex].Cells[2].Value = veh.placa;

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvTodosVehiculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            vehiculo veh = (vehiculo)dgvTodosVehiculos.Rows[e.RowIndex].DataBoundItem;
            dgvTodosVehiculos.Rows[e.RowIndex].Cells[0].Value = veh.idVehiculo;
            dgvTodosVehiculos.Rows[e.RowIndex].Cells[1].Value = veh.descripcion;
            dgvTodosVehiculos.Rows[e.RowIndex].Cells[2].Value = veh.placa;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vehiculo vehAux;
            vehAux = (vehiculo)dgvTodosVehiculos.CurrentRow.DataBoundItem;
            foreach (vehiculo ben in this._vehiculos)
            {
                if (ben.placa.Equals(vehAux.placa))
                {
                    MessageBox.Show("vehiculo ya seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            _vehiculos.Add(vehAux);
            //
            //_almaVehi.Add(new almacenxVehiculo { vehiculo = vehAux, almacen = almacennuevo });
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculo.CurrentRow != null)
            {
                vehiculo veh = (vehiculo)dgvVehiculo.CurrentRow.DataBoundItem;
                _vehiculos.Remove(veh);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehiculo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cboDistritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistritos.SelectedIndex >= 0) {
                txtDireccion.Text = " ";
            }
        }

        private void frmInformacionAlmacen_Load(object sender, EventArgs e)
        {
            cboDistritos.SelectedIndex = -1;
        }

        private void dgvVehiculo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panelTransportista.Visible = true;
                // Obtén los datos de la fila seleccionada en el DataGridView
                string idVehiculo = dgvVehiculo.Rows[e.RowIndex].Cells["idVehiculo"].Value.ToString();
    
                // Encuentra el conductor correspondiente en tu arreglo de conductores basado en el idVehiculo
                transportista[] transportistas = daoAlmacen.listadoTransportista();
                
                foreach(transportista tra in transportistas)
                {
                    if (tra.vehiculo.idVehiculo == int.Parse(idVehiculo)) {
                         
                        MostrarInfoConductorEnPanel(tra);
                         
                        break;
                    }
                }
 
            }
        }
        private void MostrarInfoConductorEnPanel(transportista transportista)
        {
            // Configura tu panel con la información del conductor
            txtIdTransportista.Text = transportista.idTransportista.ToString();
            txtnumBreve.Text = transportista.numBrevete;
            txtTipoBreve.Text = transportista.tipoBrevete;
            panelTransportista.Visible = true;
        }
    }
}
