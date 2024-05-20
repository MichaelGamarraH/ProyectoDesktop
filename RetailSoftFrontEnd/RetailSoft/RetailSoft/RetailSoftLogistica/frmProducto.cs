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
    public partial class frmProducto : Form
    {
        private Estado _estado;
        private LogisticaWSClient _daoLogisticaWS;
        private producto _producto;
        private string _rutaFotoImagen;
        public frmProducto(Estado _est)
        {
            InitializeComponent();
            _estado = _est;
            _daoLogisticaWS = new LogisticaWSClient();
            _producto = new producto();
            cboCategoria.DataSource = _daoLogisticaWS.listarCategoriasProducto();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "idCategoriaProducto";
            cboMarca.DataSource = _daoLogisticaWS.listarMarcasProducto();
            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "idMarcaProducto";
            establecerEstadoComponentes();
        }

        public frmProducto(Estado _est, producto _prod)
        {
            InitializeComponent();
            _estado = _est;
            _daoLogisticaWS = new LogisticaWSClient();
            _producto = _prod;
            cboCategoria.DataSource = _daoLogisticaWS.listarCategoriasProducto();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "idCategoriaProducto";
            cboMarca.DataSource = _daoLogisticaWS.listarMarcasProducto();
            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "idMarcaProducto";
            cboMarca.SelectedValue = _producto.marcaProducto.idMarcaProducto;
            cboCategoria.SelectedValue = _producto.subcategoriaProducto.categoriaProducto.idCategoriaProducto;
            cboSubcategoria.SelectedValue = _producto.subcategoriaProducto.idSubcategoriaProducto;
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Nuevo:
                    txtIDProducto.Enabled = false;
                    txtIDProducto.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtTallaModelo.Enabled = true;
                    txtTallaModelo.ReadOnly = false;
                    txtPrecio.Enabled = true;
                    txtPrecio.ReadOnly = false;
                    txtStock.Visible = false;
                    lblStock.Visible = false;
                    txtStock.Enabled = false;
                    txtStock.ReadOnly = true;
                    txtStock.Text = "0";
                    txtDescripcion.Location = new Point(145, 520);
                    lblDescripcion.Location = new Point(27, 520);
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnSubirImagen.Enabled = true;
                    cboMarca.SelectedIndex = -1;
                    cboCategoria.SelectedIndex = -1;
                    cboSubcategoria.SelectedIndex = -1;
                    break;
                case Estado.Modificar:
                    txtIDProducto.Enabled = false;
                    txtIDProducto.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtTallaModelo.Enabled = true;
                    txtTallaModelo.ReadOnly = false;
                    txtPrecio.Enabled = true;
                    txtPrecio.ReadOnly = false;
                    txtStock.Enabled = true;
                    txtStock.ReadOnly = false;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSubirImagen.Enabled = true;
                    txtIDProducto.Text = _producto.idProducto.ToString();
                    txtNombre.Text = _producto.nombre;
                    txtTallaModelo.Text = _producto.tallaModelo;
                    txtPrecio.Text = _producto.precio.ToString("N2");
                    txtStock.Text = _producto.stock.ToString();
                    txtDescripcion.Text = _producto.descripcion;
                    MemoryStream ms = new MemoryStream(_producto.imagen);
                    pbProducto.Image = new Bitmap(ms);
                    break;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtTallaModelo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la talla o modelo del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el precio del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un monto correcto como precio del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Double.Parse(txtPrecio.Text) < 0)
            {
                MessageBox.Show("No puede ingresar un número negativo como precio", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la marca a la que pertenece el producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la categoria a la que pertenece el producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboSubcategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la subcategoria a la que pertenece el producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtStock.Text.Trim().Length == 0 && _estado.Equals(Estado.Modificar))
            {
                MessageBox.Show("Debe ingresar el stock del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtStock.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número correcto para el stock", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(txtStock.Text) < 0)
            {
                MessageBox.Show("No puede ingresar un número negativo como precio", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la descripcion del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(_rutaFotoImagen == null && _estado.Equals(Estado.Nuevo))
            {
                MessageBox.Show("Debe subir una imagen del producto", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _producto.nombre = txtNombre.Text;
            _producto.tallaModelo = txtTallaModelo.Text;
            _producto.precio = Double.Parse(txtPrecio.Text);
            _producto.marcaProducto = new marcaProducto();
            _producto.marcaProducto.idMarcaProducto = (int)cboMarca.SelectedValue;
            _producto.subcategoriaProducto = new subcategoriaProducto();
            _producto.subcategoriaProducto.idSubcategoriaProducto = (int)cboSubcategoria.SelectedValue;
            _producto.subcategoriaProducto.categoriaProducto = new categoriaProducto();
            _producto.subcategoriaProducto.categoriaProducto.idCategoriaProducto = (int)cboCategoria.SelectedValue;
            _producto.stock = Int32.Parse(txtStock.Text);
            _producto.descripcion = txtDescripcion.Text;
            if(_rutaFotoImagen != null)
            {
                FileStream fs = new FileStream(_rutaFotoImagen, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _producto.imagen = br.ReadBytes((int)fs.Length);
                fs.Close();
            }

            if (_estado.Equals(Estado.Nuevo))
            {
                int resultado = _daoLogisticaWS.insertarProducto(_producto);
                if (resultado != 0)
                {
                    txtIDProducto.Text = resultado.ToString();
                    MessageBox.Show("El producto se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Timer timer1 = new Timer();
                    timer1.Interval = 3000; //delay de 3 segundos
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Start();
                }
            }
            else if (_estado.Equals(Estado.Modificar))
            {
                int resultado = _daoLogisticaWS.modificarProducto(_producto);
                if (resultado != 0)
                {
                    MessageBox.Show("El producto se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar la información de este producto?",
            "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                int res = _daoLogisticaWS.eliminarProducto(_producto);
                if (res == 1)
                {
                    MessageBox.Show("Producto eliminado", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto", "Eliminación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubcategoria.DataSource = _daoLogisticaWS.listarSubcategoriasXCategoria((cboCategoria.SelectedIndex) + 1);
            cboSubcategoria.DisplayMember = "nombre";
            cboSubcategoria.ValueMember = "idSubcategoriaProducto";
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdImagen.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoImagen = ofdImagen.FileName;
                    pbProducto.Image = Image.FromFile(_rutaFotoImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
