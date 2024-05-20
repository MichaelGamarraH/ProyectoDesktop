using RetailSoft.LogisticaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftLogistica
{
    public partial class frmLote : Form
    {
        private Estado _estado;
        private LogisticaWSClient _daoLogisticaWS;
        private lote _lote;
        private producto _producto;
        private BindingList<criterioControlCalidad> _criteriosControlCalidad;
        private BindingList<lotexCriterioControlCalidad> _criteriosLote;
        private lotexCriterioControlCalidad _criterioLote;
        public frmLote(Estado _est)
        {
            InitializeComponent();
            _estado = _est;
            _daoLogisticaWS = new LogisticaWSClient();
            _lote = new lote();
            _criteriosControlCalidad = new BindingList<criterioControlCalidad>
                (_daoLogisticaWS.listarCriteriosControlCalidad().ToList());
            _criteriosLote = new BindingList<lotexCriterioControlCalidad>();
            cboProveedor.DataSource = _daoLogisticaWS.listadoProveedores();
            cboProveedor.DisplayMember = "razonSocial";
            cboProveedor.ValueMember = "idProveedor";
            cboAlmacen.DataSource = _daoLogisticaWS.listadoAlmacen();
            cboAlmacen.DisplayMember = "nombre";
            cboAlmacen.ValueMember = "idAlmacen";
            establecerEstadoComponentes();
        }

        public frmLote(Estado _est,lote _lot)
        {
            InitializeComponent();
            _estado = _est;
            _daoLogisticaWS = new LogisticaWSClient();
            _lote = _lot;
            _criteriosControlCalidad = new BindingList<criterioControlCalidad>
                (_daoLogisticaWS.listarCriteriosControlCalidad().ToList());
            _criteriosLote = new BindingList<lotexCriterioControlCalidad>(_daoLogisticaWS.listarLotexCriterioControlCalidad(_lote.idLote).ToList());
            cboProveedor.DataSource = _daoLogisticaWS.listadoProveedores();
            cboProveedor.DisplayMember = "razonSocial";
            cboProveedor.ValueMember = "idProveedor";
            cboAlmacen.DataSource = _daoLogisticaWS.listadoAlmacen();
            cboAlmacen.DisplayMember = "nombre";
            cboAlmacen.ValueMember = "idAlmacen";
            cboAlmacen.SelectedValue = _lote.almacen.idAlmacen;
            cboProveedor.SelectedValue = _lote.proveedor.idProveedor;
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Nuevo:
                    txtIDLote.Enabled = false;
                    txtIDLote.ReadOnly = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = false;
                    cboProveedor.SelectedIndex = -1;
                    cboAlmacen.SelectedIndex = -1;
                    dtpFechaCompra.Enabled = true;
                    dtpFechaCompra.Value = new DateTime(2000,01,01);
                    dtpFechaLlegada.Enabled = true;
                    dtpFechaLlegada.Value = new DateTime(2000, 01, 01);
                    txtObservacion.Enabled = true;
                    txtObservacion.ReadOnly = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminarLote.Enabled = false;
                    txtIDProducto.Enabled = false;
                    txtIDProducto.ReadOnly = true;
                    txtCostoUnitario.Enabled = true;
                    txtCostoUnitario.ReadOnly = false;
                    txtNombreProducto.Enabled = false;
                    txtNombreProducto.ReadOnly = true;
                    txtCantidad.Enabled = true;
                    txtCantidad.ReadOnly = false;
                    txtCostoTotal.Enabled = false;
                    txtCostoTotal.ReadOnly = true;
                    txtMarca.Enabled = false;
                    txtMarca.ReadOnly = true;
                    txtSubcategoria.Enabled = false;
                    txtSubcategoria.ReadOnly = true;
                    txtCategoria.Enabled = false;
                    txtCategoria.ReadOnly = true;
                    btnExaminarProducto.Enabled = true;

                    rbPesoSI.Enabled = true;
                    rbPesoNO.Enabled = true;
                    dtpCrit1.Enabled = true;
                    dtpCrit1.Value = new DateTime(2000, 01, 01);
                    rbEmbalajeSI.Enabled = true;
                    rbEmbalajeNO.Enabled = true;
                    dtpCrit2.Enabled = true;
                    dtpCrit2.Value = new DateTime(2000, 01, 01);

                    rbCantidadSI.Enabled = true;
                    rbCantidadNO.Enabled = true;
                    dtpCrit3.Enabled = true;
                    dtpCrit3.Value = new DateTime(2000, 01, 01);

                    rbProdDefSI.Enabled = true;
                    rbProdDefNO.Enabled = true;
                    dtpCrit4.Enabled = true;
                    dtpCrit4.Value = new DateTime(2000, 01, 01);

                    lblResultado1.Visible = false;
                    lblResultado2.Visible = false;
                    lblResultado3.Visible = false;
                    lblResultado4.Visible = false;


                    gbCriterio1.Text = _criteriosControlCalidad[0].nombre;
                    gbCriterio2.Text = _criteriosControlCalidad[1].nombre;
                    gbCriterio3.Text = _criteriosControlCalidad[2].nombre;
                    gbCriterio4.Text = _criteriosControlCalidad[3].nombre;
                    break;
                case Estado.Modificar:
                    txtIDLote.Enabled = false;
                    txtIDLote.ReadOnly = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = false;
                    dtpFechaCompra.Enabled = true;
                    dtpFechaLlegada.Enabled = true;
                    txtObservacion.Enabled = true;
                    txtObservacion.ReadOnly = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminarLote.Enabled = true;
                    txtIDProducto.Enabled = false;
                    txtIDProducto.ReadOnly = true;
                    txtCostoUnitario.Enabled = true;
                    txtCostoUnitario.ReadOnly = false;
                    txtNombreProducto.Enabled = false;
                    txtNombreProducto.ReadOnly = true;
                    txtCantidad.Enabled = true;
                    txtCantidad.ReadOnly = false;
                    txtCostoTotal.Enabled = false;
                    txtCostoTotal.ReadOnly = true;
                    txtMarca.Enabled = false;
                    txtMarca.ReadOnly = true;
                    txtSubcategoria.Enabled = false;
                    txtSubcategoria.ReadOnly = true;
                    txtCategoria.Enabled = false;
                    txtCategoria.ReadOnly = true;
                    btnExaminarProducto.Enabled = false;

                    txtIDProducto.Text = _lote.producto.idProducto.ToString();
                    txtNombreProducto.Text = _lote.producto.nombre;
                    txtCostoUnitario.Text = _lote.costoUnitario.ToString("N2");
                    txtCantidad.Text = _lote.cantidad.ToString();
                    txtCostoTotal.Text = _lote.costoTotal.ToString("N2");
                    MemoryStream ms = new MemoryStream(_lote.producto.marcaProducto.icono);
                    pbMarca.Image = new Bitmap(ms);
                    ms = new MemoryStream(_lote.producto.subcategoriaProducto.categoriaProducto.icono);
                    pbCategoria.Image = new Bitmap(ms);
                    ms = new MemoryStream(_lote.producto.subcategoriaProducto.icono);
                    pbSubcategoria.Image = new Bitmap(ms);
                    txtMarca.Text = _lote.producto.marcaProducto.nombre;
                    txtCategoria.Text = _lote.producto.subcategoriaProducto.categoriaProducto.nombre;
                    txtSubcategoria.Text = _lote.producto.subcategoriaProducto.nombre;

                    if(_lote.estado == 1)
                    {
                        txtPeso.Enabled = false;
                        txtPeso.ReadOnly = true;
                        cboProveedor.Enabled = false;
                        cboAlmacen.Enabled = false;
                        dtpFechaCompra.Enabled = false;
                        dtpFechaLlegada.Enabled = false;
                        txtObservacion.Enabled = false;
                        txtObservacion.ReadOnly = true;
                        txtCostoUnitario.Enabled = false;
                        txtCostoUnitario.ReadOnly = true;
                        txtCantidad.Enabled = false;
                        txtCantidad.ReadOnly = true;
                        btnGuardar.Enabled = false;
                        rbPesoSI.Enabled = false;
                        rbPesoNO.Enabled = false;
                        dtpCrit1.Enabled = false;

                        rbEmbalajeSI.Enabled = false;
                        rbEmbalajeNO.Enabled = false;
                        dtpCrit2.Enabled = false;

                        rbCantidadSI.Enabled = false;
                        rbCantidadNO.Enabled = false;
                        dtpCrit3.Enabled = false;

                        rbProdDefSI.Enabled = false;
                        rbProdDefNO.Enabled = false;
                        dtpCrit4.Enabled = false;
                    }
                    else
                    {
                        rbPesoSI.Enabled = true;
                        rbPesoNO.Enabled = true;
                        dtpCrit1.Enabled = true;

                        rbEmbalajeSI.Enabled = true;
                        rbEmbalajeNO.Enabled = true;
                        dtpCrit2.Enabled = true;

                        rbCantidadSI.Enabled = true;
                        rbCantidadNO.Enabled = true;
                        dtpCrit3.Enabled = true;

                        rbProdDefSI.Enabled = true;
                        rbProdDefNO.Enabled = true;
                        dtpCrit4.Enabled = true;
                    }

                    gbCriterio1.Text = _criteriosControlCalidad[0].nombre;
                    gbCriterio2.Text = _criteriosControlCalidad[1].nombre;
                    gbCriterio3.Text = _criteriosControlCalidad[2].nombre;
                    gbCriterio4.Text = _criteriosControlCalidad[3].nombre;

                    if (_criteriosLote[0].resultado == true)
                    {
                        rbPesoSI.Checked = true;
                        lblResultado1.Text = "PASÓ INSPECCIÓN";
                    }
                    else
                    {
                        rbPesoNO.Checked = true;
                        lblResultado1.Text = "EN REVISIÓN";
                    }
                    dtpCrit1.Value = _criteriosLote[0].fechaInspeccion;


                    if (_criteriosLote[1].resultado == true)
                    {
                        rbEmbalajeSI.Checked = true;
                        lblResultado2.Text = "PASÓ INSPECCIÓN";
                    }
                    else
                    {
                        rbEmbalajeNO.Checked = true;
                        lblResultado2.Text = "EN REVISIÓN";
                    }
                    dtpCrit2.Value = _criteriosLote[1].fechaInspeccion;


                    if (_criteriosLote[2].resultado == true)
                    {
                        rbCantidadSI.Checked = true;
                        lblResultado3.Text = "PASÓ INSPECCIÓN";
                    }
                    else
                    {
                        rbCantidadNO.Checked = true;
                        lblResultado3.Text = "EN REVISIÓN";
                    }
                    dtpCrit3.Value = _criteriosLote[2].fechaInspeccion;


                    if (_criteriosLote[3].resultado == true)
                    {
                        rbProdDefNO.Checked = true;
                        lblResultado4.Text = "PASÓ INSPECCIÓN";
                    }
                    else
                    {
                        rbProdDefSI.Checked = true;
                        lblResultado4.Text = "EN REVISIÓN";
                    }
                    dtpCrit4.Value = _criteriosLote[3].fechaInspeccion;


                    txtIDLote.Text = _lote.idLote.ToString();
                    txtPeso.Text = _lote.peso.ToString("N2");
                    dtpFechaCompra.Value = _lote.fechaCompra;
                    dtpFechaLlegada.Value = _lote.fechaLlegada;
                    txtObservacion.Text = _lote.observacion;
                    txtCostoTotal.Text = _lote.costoTotal.ToString("N2");
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el peso del lote", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtPeso.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un monto correcto como peso del lote", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el proveedor al que pertenece el lote", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboAlmacen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el almacen al que pertenece el lote", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dtpFechaCompra.Value >= dtpFechaLlegada.Value)
            {
                MessageBox.Show("Debe ingresar una fecha de llegada válida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtObservacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la observación correspondiente al lote", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtIDProducto.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ningún producto", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCostoUnitario.Text == "")
            {
                MessageBox.Show("Debe ingresar el costo del producto", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtCostoUnitario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un monto correcto como costo del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar la cantidad de productos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtCantidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número correcto para la cantidad de productos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rbPesoSI.Checked == false && rbPesoNO.Checked == false)
            {
                MessageBox.Show("Debe indicar si el lote cumple con el peso indicado por el proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbEmbalajeSI.Checked == false && rbEmbalajeNO.Checked == false)
            {
                MessageBox.Show("Debe indicar si el lote presenta un correcto embalaje", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbCantidadSI.Checked == false && rbCantidadNO.Checked == false)
            {
                MessageBox.Show("Debe indicar si el lote cumple con la cantidad de productos indicada por el proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbProdDefSI.Checked == false && rbProdDefNO.Checked == false)
            {
                MessageBox.Show("Debe indicar si el lote contiene productos defectuosos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (_estado.Equals(Estado.Nuevo))
            {
                _criterioLote = new lotexCriterioControlCalidad();
                _criterioLote.criterioControlCalidad = new criterioControlCalidad();
                _criterioLote.criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[0].idCriterioControlCalidad;
                _criterioLote.fechaInspeccion = dtpCrit1.Value;
                _criterioLote.fechaInspeccionSpecified = true;
                if (rbPesoSI.Checked == true)
                {
                    _criterioLote.resultado = true;
                }
                else _criterioLote.resultado = false;
                _criteriosLote.Add(_criterioLote);


                _criterioLote = new lotexCriterioControlCalidad();
                _criterioLote.criterioControlCalidad = new criterioControlCalidad();
                _criterioLote.criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[1].idCriterioControlCalidad;
                _criterioLote.fechaInspeccion = dtpCrit2.Value;
                _criterioLote.fechaInspeccionSpecified = true;
                if (rbEmbalajeSI.Checked == true)
                {
                    _criterioLote.resultado = true;
                }
                else _criterioLote.resultado = false;
                _criteriosLote.Add(_criterioLote);


                _criterioLote = new lotexCriterioControlCalidad();
                _criterioLote.criterioControlCalidad = new criterioControlCalidad();
                _criterioLote.criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[2].idCriterioControlCalidad;
                _criterioLote.fechaInspeccion = dtpCrit3.Value;
                _criterioLote.fechaInspeccionSpecified = true;
                if (rbCantidadSI.Checked == true)
                {
                    _criterioLote.resultado = true;
                }
                else _criterioLote.resultado = false;
                _criteriosLote.Add(_criterioLote);


                _criterioLote = new lotexCriterioControlCalidad();
                _criterioLote.criterioControlCalidad = new criterioControlCalidad();
                _criterioLote.criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[3].idCriterioControlCalidad;
                _criterioLote.fechaInspeccion = dtpCrit4.Value;
                _criterioLote.fechaInspeccionSpecified = true;
                if (rbProdDefNO.Checked == true)
                {
                    _criterioLote.resultado = true;
                }
                else _criterioLote.resultado = false;
                _criteriosLote.Add(_criterioLote);
            }

            else
            {
                _criteriosLote[0].criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[0].idCriterioControlCalidad;
                _criteriosLote[0].fechaInspeccion = dtpCrit1.Value;
                _criteriosLote[0].fechaInspeccionSpecified = true;
                if (rbPesoSI.Checked == true)
                {
                    _criteriosLote[0].resultado = true;
                }
                else _criteriosLote[0].resultado = false;


                _criteriosLote[1].criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[1].idCriterioControlCalidad;
                _criteriosLote[1].fechaInspeccion = dtpCrit2.Value;
                _criteriosLote[1].fechaInspeccionSpecified = true;
                if (rbEmbalajeSI.Checked == true)
                {
                    _criteriosLote[1].resultado = true;
                }
                else _criteriosLote[1].resultado = false;


                _criteriosLote[2].criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[2].idCriterioControlCalidad;
                _criteriosLote[2].fechaInspeccion = dtpCrit3.Value;
                _criteriosLote[2].fechaInspeccionSpecified = true;
                if (rbCantidadSI.Checked == true)
                {
                    _criteriosLote[2].resultado = true;
                }
                else _criteriosLote[2].resultado = false;


                _criteriosLote[3].criterioControlCalidad.idCriterioControlCalidad = _criteriosControlCalidad[3].idCriterioControlCalidad;
                _criteriosLote[3].fechaInspeccion = dtpCrit4.Value;
                _criteriosLote[3].fechaInspeccionSpecified = true;
                if (rbProdDefNO.Checked == true)
                {
                    _criteriosLote[3].resultado = true;
                }
                else _criteriosLote[3].resultado = false;
            }
            

            _lote.peso = Double.Parse(txtPeso.Text);
            if (_estado.Equals(Estado.Nuevo))
            {
                _lote.proveedor = new proveedor();
                _lote.almacen = new almacen();
                _lote.producto = new producto();
            }

            //IDK
            _lote.proveedor.idProveedor = (int)cboProveedor.SelectedValue;
            _lote.almacen.idAlmacen = (int)cboAlmacen.SelectedValue;
            _lote.producto.idProducto = Int32.Parse(txtIDProducto.Text);

            _lote.fechaCompra = dtpFechaCompra.Value;
            _lote.fechaCompraSpecified = true;
            _lote.fechaLlegada = dtpFechaLlegada.Value;
            _lote.fechaLlegadaSpecified = true;
            _lote.observacion = txtObservacion.Text;
            _lote.listaCriterios = _criteriosLote.ToArray();
            _lote.costoUnitario = Double.Parse(txtCostoUnitario.Text);
            _lote.cantidad = Int32.Parse(txtCantidad.Text);
            _lote.costoTotal = Double.Parse(txtCostoTotal.Text);

            if (_criteriosLote[0].resultado == true && _criteriosLote[1].resultado == true && _criteriosLote[2].resultado == true && _criteriosLote[3].resultado == true && _lote.estado != 1)
            {
                _lote.estado = 1;
                _lote.producto = _daoLogisticaWS.listarProductosxIdNombre(_lote.producto.idProducto.ToString())[0];
                _lote.producto.stock += _lote.cantidad;
            }

            if (_estado.Equals(Estado.Nuevo))
            {
                int resultado = _daoLogisticaWS.insertarLote(_lote);
                if (resultado != 0)
                {
                    txtIDLote.Text = resultado.ToString();
                    MessageBox.Show("El lote se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    if (_lote.estado == 1)
                    {
                        int resultado1 = _daoLogisticaWS.actualizarStock(_lote.producto.idProducto, _lote.producto.stock);
                        if (resultado1 == 0)
                        {
                            MessageBox.Show("Error al actualizar el stock", "Mensaje de Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Se actualizó correctamente el stock del producto " + _lote.producto.nombre 
                            + " a " + _lote.producto.stock + " unidades", "Mensaje de Confirmación", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    }
                    Timer timer1 = new Timer();
                    timer1.Interval = 3000; //delay de 3 segundos
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Start();
                }
            }

            if (_estado.Equals(Estado.Modificar))
            {
                int resultado = _daoLogisticaWS.modificarLote(_lote);
                if (resultado != 0)
                {
                    MessageBox.Show("El lote se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    if (_lote.estado == 1 && dtpCrit1.Enabled == true)
                    {
                        int resultado1 = _daoLogisticaWS.actualizarStock(_lote.producto.idProducto, _lote.producto.stock);
                        if (resultado1 == 0)
                        {
                            MessageBox.Show("Error al actualizar el stock", "Mensaje de Confirmación", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Se actualizó correctamente el stock del producto " + _lote.producto.nombre
                            + " a " + _lote.producto.stock + " unidades", "Mensaje de Confirmación", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    }
                    Timer timer1 = new Timer();
                    timer1.Interval = 3000; //delay de 3 segundos
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Start();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExaminarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto frmBP = new frmBusquedaProducto();
            if(frmBP.ShowDialog() == DialogResult.OK)
            {
                _producto = frmBP.ProductoSeleccionado;
                txtIDProducto.Text = _producto.idProducto.ToString();
                txtNombreProducto.Text = _producto.nombre;
                MemoryStream ms = new MemoryStream(_producto.marcaProducto.icono);
                pbMarca.Image = new Bitmap(ms);
                ms = new MemoryStream(_producto.subcategoriaProducto.categoriaProducto.icono);
                pbCategoria.Image = new Bitmap(ms);
                ms = new MemoryStream(_producto.subcategoriaProducto.icono);
                pbSubcategoria.Image = new Bitmap(ms);
                txtMarca.Text = _producto.marcaProducto.nombre;
                txtCategoria.Text = _producto.subcategoriaProducto.categoriaProducto.nombre;
                txtSubcategoria.Text = _producto.subcategoriaProducto.nombre;
            }
        }

        private void btnEliminarLote_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar la información de este lote?",
            "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                int res = _daoLogisticaWS.eliminarLote(_lote);
                if (res == 1)
                {
                    MessageBox.Show("Lote eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lote.estado == 1)
                    {
                        _lote.producto.stock -= _lote.cantidad;
                        int resultado1 = _daoLogisticaWS.actualizarStock(_lote.producto.idProducto, _lote.producto.stock);
                        if (resultado1 == 0)
                        {
                            MessageBox.Show("Error al actualizar el stock", "Mensaje de Confirmación", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Se actualizó correctamente el stock del producto " + _lote.producto.nombre
                            + " a " + _lote.producto.stock + " unidades", "Mensaje de Confirmación", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el lote", "Eliminación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "") txtCostoTotal.Text = "";
            try
            {
                Int32.Parse(txtCantidad.Text);
                txtCostoTotal.Text = (Int32.Parse(txtCantidad.Text) * Double.Parse(txtCostoUnitario.Text)).ToString("N2");
            }
            catch (Exception ex)
            {

            }
        }

        private void txtCostoUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtCostoUnitario.Text == "") txtCostoTotal.Text = "";
            try
            {
                Double.Parse(txtCostoUnitario.Text);
                txtCostoTotal.Text = (Int32.Parse(txtCantidad.Text) * Double.Parse(txtCostoUnitario.Text)).ToString("N2");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
