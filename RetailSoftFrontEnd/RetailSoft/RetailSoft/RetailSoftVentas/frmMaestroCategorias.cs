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

namespace RetailSoft.RetailSoftVentas
{
    public partial class frmMaestroCategorias : Form
    {
        private Estado _estado;
        private producto _producto;
        //private promocion _promocion;
        private BindingList<LogisticaWS.productoxPromocion> _prodsXprom;
        private string _rutaFoto;
        private LogisticaWSClient _daoLogistica;
        private categoriaProducto categoria;
        private subcategoriaProducto _subcategoriaprod;
        //private BindingList<LogisticaWS.subcategoriaProducto> _subs;

        public frmMaestroCategorias()
        {
            InitializeComponent();
            _daoLogistica = new LogisticaWSClient();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void frmMaestroCategorias_Load(object sender, EventArgs e)
        {

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
                    

                    txtIDCategoria.Enabled = false;
                    txtIDCategoria.ReadOnly = true;
                    txtNombre.Enabled = false;
                    //txtIDSub.Enabled = false;
                    //txtNombreSub.Enabled = false;

                    //btnAgregarSubCat.Enabled = false;
                    //btnEliminarSubCat.Enabled = false;
                    //btnBuscarSubCatAsociadas.Enabled = false;


                    break;
                case Estado.Nuevo:
                case Estado.Modificar:

                    //txtIDPromocion.Enabled = true;
                    txtIDCategoria.ReadOnly = true;

                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;

                    //txtIDSub.Enabled = true;
                    //txtNombreSub.Enabled = true;

                    //btnAgregarSubCat.Enabled = true;
                    //btnEliminarSubCat.Enabled = true;
                    //btnBuscarSubCatAsociadas.Enabled = true;

                    txtNombre.Enabled = true;

                    break;
                case Estado.Buscar:
                    break;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            categoria = new categoriaProducto();


        //    _subs = new BindingList<subcategoriaProducto>();
        //    dgvSubCategorias.AutoGenerateColumns = false;
        //    dgvSubCategorias.DataSource = _subs;
        //
        }


        private void limpiarComponentes()
        {
            txtIDCategoria.Text = "";
            txtNombre.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de Categoría.", "Mensaje de Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pbFoto.Image == null)
            {
                MessageBox.Show("Complete la foto de la categoría.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (_subs.Count == 0)
            //{
            //    MessageBox.Show("Ingrese las subcategorías asociadas a la categoría.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            categoria.nombre = txtNombre.Text;


            FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            categoria.icono = br.ReadBytes((int)fs.Length);
            fs.Close();


            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoLogistica.insertarCategoria(categoria);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDCategoria.Text = resultado.ToString();
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                int resultado = _daoLogistica.modificarCategoria(categoria);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnBuscarProdAsociados_Click(object sender, EventArgs e)
        //{
        //    frmBusquedaSubCategorias formBusqSubCat = new frmBusquedaSubCategorias();
        //    if (formBusqSubCat.ShowDialog() == DialogResult.OK)
        //    {
        //        _subcategoriaprod = formBusqSubCat.SubcategoriaSeleccionada;
        //        txtIDSub.Text = _subcategoriaprod.idSubcategoriaProducto.ToString();
        //        txtNombreSub.Text = _subcategoriaprod.nombre;
        //    }
        //}

        //private void btnAgregarSubCat_Click(object sender, EventArgs e)
        //{
        //    if (txtNombreSub.Text == "")
        //    {
        //        MessageBox.Show("Debe seleccionar una SubCategoría, por favor.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }



        //    foreach (subcategoriaProducto sub in this._subs)
        //    {
        //        if (sub.idSubcategoriaProducto.Equals(_subcategoriaprod.idSubcategoriaProducto))
        //        {
        //            MessageBox.Show("¡SubCategoría ya seleccionada!", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //    }

        //    subcategoriaProducto s = new subcategoriaProducto();
        //    s = _subcategoriaprod;
        //    _subs.Add(s);
        //    _subcategoriaprod = null;
        //    txtIDSub.Text = "";
        //    txtNombreSub.Text = "";
        //}

        //private void btnEliminarSubCat_Click(object sender, EventArgs e)
        //{
        //    if (dgvSubCategorias.CurrentRow != null)
        //    {
        //        subcategoriaProducto s = (subcategoriaProducto)dgvSubCategorias.CurrentRow.DataBoundItem;
        //        _subs.Remove(s);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Debe seleccionar una SubCategoría, por favor.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //}

        //private void dgvSubCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    try
        //    {
        //        subcategoriaProducto s = (subcategoriaProducto)dgvSubCategorias.Rows[e.RowIndex].DataBoundItem;
        //        dgvSubCategorias.Rows[e.RowIndex].Cells[0].Value = s.nombre;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        private void btnSubirFoto_Click_1(object sender, EventArgs e)
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
    }
}
