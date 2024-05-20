using RetailSoft.LogisticaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RetailSoft.RetailSoftLogistica
{
     
    public partial class frmInformacionProveedor : Form
    {
        Estado _estado;
        private LogisticaWSClient daoProveedor;
        private proveedor proveedorNuevo;
        private proveedor auxiliarproveedor;
        private Panel panelAux;
        public void establecerEstadoComponentes() {
            switch (_estado) {
                case Estado.Nuevo:
                    txtID.Enabled = false;
                    txtNombre.Enabled = true;
                    txtRepresentante.Enabled = true;
                    txtRUC.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtSitioWeb.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    cboCategoria.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cboDistritos.Enabled = true;
                    break;
                case Estado.Inicial:
                    txtID.Enabled = false;
                    txtRepresentante.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtRUC.Enabled = false;
                    txtTelefono.Enabled = false;
                    cboCategoria.Enabled = false;
                    txtSitioWeb.Enabled = false;
                    cboDistritos.Enabled = false;
                    break;
                case Estado.Modificar:
                    txtNombre.Enabled = true;
                    txtRepresentante.Enabled = true;
                    txtRUC.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtCorreo.Enabled = true;
                    cboCategoria.Enabled = true;
                    txtSitioWeb.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cboDistritos.Enabled = true;
                    break;
            }
        }
        public frmInformacionProveedor(Panel panelFiltroE)
        {
            InitializeComponent();
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            panelAux = panelFiltroE;
            daoProveedor = new LogisticaWSClient();
            proveedorNuevo = new proveedor();

            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "idCategoriaProducto";
            cboCategoria.DataSource = daoProveedor.listarCategoriasProducto();
            listadoDistritos();
        }
        public void listadoDistritos() {
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
        public frmInformacionProveedor(String _idProveedor,Panel panelPro)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            panelAux = panelPro;
            daoProveedor = new LogisticaWSClient();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "idCategoriaProducto";
            cboCategoria.DataSource = daoProveedor.listarCategoriasProducto();
            listadoDistritos();
            proveedor[] proveedores = daoProveedor.listadoProveedores();
            foreach (proveedor proveedor in proveedores)
            {
                if (proveedor.idProveedor == int.Parse(_idProveedor)) {
                    proveedorNuevo = new proveedor();
                    proveedorNuevo = proveedor;
                    colocarInformacion(proveedor);
                    break;
                }    
            }
        }
        public frmInformacionProveedor(proveedor proveedor,Panel panelAuxPro)
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            panelAux = panelAuxPro;
            daoProveedor = new LogisticaWSClient();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "idCategoriaProducto";
            cboCategoria.DataSource = daoProveedor.listarCategoriasProducto();
            listadoDistritos();
            proveedorNuevo = new proveedor();
            proveedorNuevo = proveedor;

            colocarInformacion(proveedorNuevo);

        }
        private void colocarInformacion(proveedor proveedor) {
            txtID.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.razonSocial;
            txtRepresentante.Text = proveedor.representante;
            txtRUC.Text = proveedor.RUC;
            txtDireccion.Text = proveedor.direccion;
            txtTelefono.Text = proveedor.telefono;
            txtCorreo.Text = proveedor.correo;
            txtSitioWeb.Text = proveedor.sitioWeb;
            dtpFechaInicio.Value = proveedor.fechaInicio;
            cboCategoria.SelectedValue = proveedor.categoriaProducto.idCategoriaProducto;
            txtDescripcion.Text = proveedor.notaProveedor;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim().Length ==0) {
                MessageBox.Show("Debe ingresar la razon social del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (txtRepresentante.Text.Trim().Length == 0) { 
                MessageBox.Show("Debe ingresar el representante del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRUC.Text.Trim().Length == 0) { 
                MessageBox.Show("Debe ingresar el RUC del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCategoria.SelectedIndex == -1) { 
                MessageBox.Show("Debe seleccionar la categoria de producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text.Trim().Length == 0) { 
                MessageBox.Show("Debe ingresar la direccion del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboDistritos.SelectedIndex == -1){
                MessageBox.Show("Debe seleccionar el distrito del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Trim().Length == 0){
                MessageBox.Show("Debe ingresar el telefono del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text.Trim().Length == 0){
                MessageBox.Show("Debe ingresar el correo del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFechaInicio.Value == DateTimePicker.MinimumDateTime){
                MessageBox.Show("Debe seleccionar una fecha válida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Trim().Length == 0){
                MessageBox.Show("Debe ingresar la descripcion del proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            proveedorNuevo.razonSocial = txtNombre.Text;
            proveedorNuevo.representante = txtRepresentante.Text;
            proveedorNuevo.RUC = txtRUC.Text;
            proveedorNuevo.direccion = cboDistritos.SelectedItem.ToString() + " - " + txtDireccion.Text;
            proveedorNuevo.telefono = txtTelefono.Text;
            proveedorNuevo.correo = txtCorreo.Text;
            proveedorNuevo.categoriaProducto = new categoriaProducto();
            proveedorNuevo.categoriaProducto.idCategoriaProducto = (int)cboCategoria.SelectedValue;
            proveedorNuevo.sitioWeb = txtSitioWeb.Text;
            proveedorNuevo.fechaInicio = dtpFechaInicio.Value;
            proveedorNuevo.fechaInicioSpecified = true;
            proveedorNuevo.notaProveedor = txtDescripcion.Text;

            if (_estado==Estado.Nuevo) {
                int resultado = daoProveedor.insertarProveedor(proveedorNuevo);
                if (resultado != 0)
                {
                    MessageBox.Show("El empleado se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = resultado.ToString();
                    proveedor[] proveedorUP = daoProveedor.listadoProveedores();
                    mostrarActualizacionFiltro(proveedorUP);
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(_estado==Estado.Modificar)
            {
                int resultado = daoProveedor.modificarProveedor(proveedorNuevo);
                if (resultado != 0)
                {
                    MessageBox.Show("El empleado se ha actualizado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = resultado.ToString();
                    proveedor[] proveedorUP = daoProveedor.listadoProveedores();
                    mostrarActualizacionFiltro(proveedorUP);

                }
                else
                    MessageBox.Show("Ha ocurrido un problema en la actualizacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarActualizacionFiltro(proveedor[] proveedores)
        {
            foreach (Control control in panelAux.Controls.OfType<frmDatosProveedor>().ToList())
            {
                if (control.Name != "panelFiltros")
                {
                    panelAux.Controls.Remove(control);
                    control.Dispose();
                }
            }
            foreach (proveedor proveedor in proveedores)
            {
                frmDatosProveedor formDatos = new frmDatosProveedor(proveedor,panelAux);
                formDatos.TopLevel = false;
                formDatos.Dock = DockStyle.Top;
                panelAux.Controls.Add(formDatos);
                formDatos.Visible = true;
            }
            panelAux.Refresh();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que se quiere eliminar este proveedor",
    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                int result = daoProveedor.eliminarProveedor(proveedorNuevo);
                MessageBox.Show("Proveedor eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Length != 9 || !int.TryParse(txtTelefono.Text, out _))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar un número de 9 dígitos");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, ""); 
            }
        }
        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^.{11}$"; // Coincide con exactamente 11 caracteres.

            if (Regex.IsMatch(txtRUC.Text, pattern))
            {
                errorProvider2.SetError(txtRUC, ""); // RUC válido
            }
            else
            {
                errorProvider2.SetError(txtRUC, "El RUC debe de tener 11 caracteres");
            }
        }
    }
}
