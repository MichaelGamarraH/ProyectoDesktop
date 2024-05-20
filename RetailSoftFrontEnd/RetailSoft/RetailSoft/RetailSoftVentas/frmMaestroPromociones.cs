using RetailSoft.LogisticaWS;
using RetailSoft.RRHHWS;
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

namespace RetailSoft.RetailSoftVentas  
{
    public partial class frmMaestroPromociones : Form
    {
        private Estado _estado;
        private categoriaProducto _categoria;
        private producto _producto;
        private promocion _promocion;
        private BindingList<LogisticaWS.productoxPromocion> _prodsXprom;
        private string _rutaFoto;
        private LogisticaWSClient _daoLogistica;

        public frmMaestroPromociones()
        {
            
            InitializeComponent();
            _daoLogistica = new LogisticaWSClient();
            _estado = Estado.Inicial;
            dgvProductosPromo.AutoGenerateColumns = false;
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscarCategoria.Enabled = false;
                    btnBuscarProdAsociados.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    dtpFechaLanzamiento.Enabled = false;

                    txtIDPromocion.Enabled = false;
                    txtIDPromocion.ReadOnly = true;
                    txtNombre.Enabled = false;
                    txtCategoria.Enabled = false;
                    txtDescuento.Enabled = false;
                    txtMarca.Enabled = false;
                    txtNombreProd.Enabled = false;
                    btnAgregarProd.Enabled = false;
                    btnEliminarProd.Enabled = false;

                    break;
                case Estado.Nuevo:
                case Estado.Modificar:

                    //txtIDPromocion.Enabled = true;
                    txtIDPromocion.ReadOnly = true;

                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscarCategoria.Enabled = true;
                    btnBuscarProdAsociados.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    dtpFechaLanzamiento.Enabled = true;

                    btnAgregarProd.Enabled = true;
                    btnEliminarProd.Enabled = true; 

                    txtNombre.Enabled = true;
                    txtDescuento.Enabled = true;
                    txtMarca.Enabled = false;
                    txtNombreProd.Enabled = false;

                    break;
                case Estado.Buscar:
                    break;
            }
        }
        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            frmBusquedaCategorias formBusqCategorias = new frmBusquedaCategorias();
            if (formBusqCategorias.ShowDialog() == DialogResult.OK)
            {
                _categoria = formBusqCategorias.CategoriaSeleccionada;

                txtCategoria.Text = _categoria.nombre;
            }
        }

        private void btnBuscarProdAsociados_Click(object sender, EventArgs e)
        {
            frmBusquedaProductosEnPromo formBusqProdEnProm= new frmBusquedaProductosEnPromo();
            if (formBusqProdEnProm.ShowDialog() == DialogResult.OK)
            {
                _producto = formBusqProdEnProm.ProductoSeleccionado;
                txtMarca.Text = _producto.marcaProducto.nombre;
                txtNombreProd.Text = _producto.nombre;
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtNombreProd.Text == "")
            {
                MessageBox.Show("Debe seleccionar un Producto, por favor.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            foreach (productoxPromocion linea in this._prodsXprom)
            {
                if (linea.producto.idProducto.Equals(_producto.idProducto))
                {
                    MessageBox.Show("¡Producto ya seleccionado!", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            productoxPromocion lov = new productoxPromocion();
            lov.producto = _producto;
            _prodsXprom.Add(lov);
            _producto = null;
            txtNombreProd.Text = "";
            txtMarca.Text = "";
          
        }


        private void dgvProductosPromo_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductosPromo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                productoxPromocion lov = (productoxPromocion)dgvProductosPromo.Rows[e.RowIndex].DataBoundItem;
                dgvProductosPromo.Rows[e.RowIndex].Cells[0].Value = lov.producto.nombre;
                dgvProductosPromo.Rows[e.RowIndex].Cells[1].Value = lov.producto.marcaProducto.nombre;
                dgvProductosPromo.Rows[e.RowIndex].Cells[2].Value = _categoria.nombre;
                dgvProductosPromo.Rows[e.RowIndex].Cells[3].Value = lov.producto.precio;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido.");
            }
        }

        public void limpiarComponentes()
        {
            txtIDPromocion.Text = "";
            dtpFechaLanzamiento.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtDescuento.Text = "";
            txtNombreProd.Text = "";
            txtMarca.Text = "";
            dgvProductosPromo.DataSource = null;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _promocion = new promocion();
            _prodsXprom = new BindingList<productoxPromocion>();
            dgvProductosPromo.AutoGenerateColumns = false;
            dgvProductosPromo.DataSource = _prodsXprom;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Complete la información correspondiente al nombre de la promoción.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Complete la categoría correspondiente a la promoción.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescuento.Text == "")
            {
                MessageBox.Show("Complete la categoría correspondiente al descuento de la promoción.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pbFoto.Image == null)
            {
                MessageBox.Show("Complete la categoría correspondiente a la foto de la promoción.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_prodsXprom.Count == 0)
            {
                MessageBox.Show("Ingrese los productos asociados a la promoción.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _promocion.nombre = txtNombre.Text;
            _promocion.descuento = double.Parse(txtDescuento.Text);

            _promocion.fechaInicio = dtpFechaLanzamiento.Value;
            _promocion.fechaFin = dtpFechaFin.Value;


            _promocion.productosXpromocion = _prodsXprom.ToArray();


            _promocion.categoriaProducto = new categoriaProducto();
            _promocion.categoriaProducto.idCategoriaProducto = _categoria.idCategoriaProducto;

            _promocion.fechaInicioSpecified = true;
            _promocion.fechaFinSpecified = true;


            FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _promocion.imagen = br.ReadBytes((int)fs.Length);
            fs.Close();


            int resultado = _daoLogistica.insertarPromocion(_promocion);
            if (resultado != 0)
            {
                //txtIDPromocion.Text = _promocion.idPromocion.ToString();
                MessageBox.Show("¡La promoción se ha registrado con éxito! :D", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDPromocion.Text = resultado.ToString();
            }
            else
                MessageBox.Show("¡Hubo un error en el registro!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dgvProductosPromo.CurrentRow != null)
            {
                productoxPromocion pp = (productoxPromocion)dgvProductosPromo.CurrentRow.DataBoundItem;
                _prodsXprom.Remove(pp);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto, por favor.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
