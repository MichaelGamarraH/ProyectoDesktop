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
    public partial class frmNuevoAlmacen : Form
    {
        private Estado _estado;
        private LogisticaWSClient daoAlmacen;
        private almacen almacenNuevo;
        private Panel panelAux;

        //private List<vehiculo> vehiculos;
        private BindingList<vehiculo> _vehiculos;
        private almacenxVehiculo _almaxveh;

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    txtID.Enabled = false;
                    txtNombre.Enabled = true;
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
        public frmNuevoAlmacen(Panel panelPro)
        {
            InitializeComponent();
            tabPage1.Text = "Almacen";  
            tabPage2.Text = "Vehiculos Almacen";

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            panelAux = panelPro;
            
            daoAlmacen = new LogisticaWSClient();
            almacenNuevo = new almacen();
            almacenNuevo.vehiculos = new BindingList<vehiculo>().ToArray();
            _vehiculos = new BindingList<vehiculo>();

            dgvTodosVehiculos.AutoGenerateColumns = false;
            dgvVehiculosSelect.AutoGenerateColumns = false;
            dgvTodosVehiculos.DataSource = daoAlmacen.listadoVehiculos();
            dgvVehiculosSelect.DataSource = _vehiculos;
            listadoDistritos();

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
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que quieres cancelar el registro del almacén",
"Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Registro cancelado", "Cancelación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvTodosVehiculos.CurrentRow != null)
            {
                vehiculo veh = (vehiculo)dgvVehiculosSelect.CurrentRow.DataBoundItem;
                _vehiculos.Remove(veh);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehiculo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvVehiculosSelect_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                vehiculo veh = (vehiculo)dgvVehiculosSelect.Rows[e.RowIndex].DataBoundItem;
                if (veh != null)
                {
                    dgvVehiculosSelect.Rows[e.RowIndex].Cells[0].Value = veh.idVehiculo;
                    dgvVehiculosSelect.Rows[e.RowIndex].Cells[1].Value = veh.descripcion;
                    dgvVehiculosSelect.Rows[e.RowIndex].Cells[2].Value = veh.placa;

                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void dgvTodosVehiculos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)  
            {
                e.CellStyle.BackColor = Color.LightCyan;  
                e.CellStyle.ForeColor = Color.LightBlue;  
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                 
                e.CellStyle.BackColor = Color.LightGoldenrodYellow;  
                e.CellStyle.ForeColor = Color.Black;  
            }
        }

        private void dgvVehiculosSelect_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.CellStyle.BackColor = Color.LightCyan;
                e.CellStyle.ForeColor = Color.LightBlue;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                e.CellStyle.BackColor = Color.DarkGoldenrod;
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
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
            almacenNuevo.nombre = txtNombre.Text;
            almacenNuevo.responsable = txtResponsable.Text;
            almacenNuevo.capacidad = int.Parse(txtCapacidad.Text);
            almacenNuevo.direccion = cboDistritos.SelectedItem.ToString() + " - " + txtDireccion.Text;
            almacenNuevo.fechaActualizacion = dtpActualizacion.Value;
            almacenNuevo.fechaActualizacionSpecified = true;

            almacenNuevo.fecha_mantenimiento = dtpMantenimiento.Value;
            almacenNuevo.fecha_mantenimientoSpecified = true;
            almacenNuevo.descripcion = txtDescripcion.Text;
            if (cbCalidad.Checked) almacenNuevo.control_calidad = true;
            else almacenNuevo.control_calidad = false;

            if (cbEstanterias.Checked) almacenNuevo.stand_ajustable = true;
            else almacenNuevo.stand_ajustable = false;

            if (cbIluminacion.Checked) almacenNuevo.sistema_iluminacion = true;
            else almacenNuevo.sistema_iluminacion = false;

            if (cbPickPack.Checked) almacenNuevo.espacio_pickpack = true;
            else almacenNuevo.espacio_pickpack = false;

             

            int resultado = daoAlmacen.insertarAlmacen(almacenNuevo);
            if (resultado != 0)
            {
                foreach (vehiculo veh in this._vehiculos)
                {
                    _almaxveh = new almacenxVehiculo();
                    _almaxveh.almacen = new almacen();
                    _almaxveh.vehiculo = new vehiculo();
                    _almaxveh.almacen.idAlmacen = resultado;
                    _almaxveh.vehiculo.idVehiculo = veh.idVehiculo;
                    daoAlmacen.insertarAlmacenxVehiculo(_almaxveh);

                }
                MessageBox.Show("El almacen se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = resultado.ToString();
                almacen[] almacenUP = daoAlmacen.listadoAlmacen();
                mostrarActualizacionFiltro(almacenUP);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtID.Enabled = false;
            txtDireccion.Enabled = false;
            txtCapacidad.Enabled = false;
            txtNombre.Enabled = false;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que quieres cancelar el registro del almacén",
"Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Registro cancelado", "Cancelación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnRetroceder_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
