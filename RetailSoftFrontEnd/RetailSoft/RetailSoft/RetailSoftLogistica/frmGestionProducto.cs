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
    public partial class frmGestionProducto : Form
    {
        private Estado _estado;
        private LogisticaWSClient _daoLogisticaWS;
        private List<categoriaProducto> _categoriasProducto;
        private List<marcaProducto> _marcasProducto;
        private producto _producto;

        

        public frmGestionProducto()
        {
            InitializeComponent();
            _daoLogisticaWS = new LogisticaWSClient();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = _daoLogisticaWS.listarProductos();
            _categoriasProducto = _daoLogisticaWS.listarCategoriasProducto().ToList();
            _marcasProducto = _daoLogisticaWS.listarMarcasProducto().ToList();
            TimerProductos.Interval = 40000;
            TimerProductos.Start();
            foreach (categoriaProducto cat in _categoriasProducto)
            {
                frmBotonCategoria formBotCat = new frmBotonCategoria(cat);
                formBotCat.TopLevel = false;
                formBotCat.Dock = DockStyle.Top;
                panelCategorias.Controls.Add(formBotCat);
                formBotCat.Visible = true;
                formBotCat.frmPadre = this;
            }

            foreach(marcaProducto mar in _marcasProducto)
            {
                frmBotonMarca formBotMar = new frmBotonMarca(mar);
                formBotMar.TopLevel = false;
                formBotMar.Dock = DockStyle.Top;
                panelMarcas.Controls.Add(formBotMar);
                formBotMar.Visible = true;
                formBotMar.frmPadre = this;
            }
        }

        public void actualizarXCategoria(int _idCategoria)
        {
            dgvProductos.DataSource = _daoLogisticaWS.listarProductosxCategoria(_idCategoria);
        }

        public void actualizarXMarca(int _idMarca)
        {
            dgvProductos.DataSource = _daoLogisticaWS.listarProductosxMarca(_idMarca);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            frmProducto frmProd = new frmProducto(_estado);
            if(frmProd.ShowDialog() == DialogResult.OK)
            {
                dgvProductos.DataSource = _daoLogisticaWS.listarProductos();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            if (dgvProductos.CurrentRow != null)
            {
                _producto = (producto)dgvProductos.CurrentRow.DataBoundItem;
                frmProducto frmProd = new frmProducto(_estado, _producto);
                if (frmProd.ShowDialog() == DialogResult.OK)
                {
                    dgvProductos.DataSource = _daoLogisticaWS.listarProductos();
                }
            }

        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                producto producto = (producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                if(producto != null)
                {
                    dgvProductos.Rows[e.RowIndex].Cells[0].Value = producto.idProducto;
                    dgvProductos.Rows[e.RowIndex].Cells[1].Value = producto.nombre;
                    dgvProductos.Rows[e.RowIndex].Cells[2].Value = producto.marcaProducto.nombre;
                    dgvProductos.Rows[e.RowIndex].Cells[3].Value = producto.subcategoriaProducto.categoriaProducto.nombre;
                    dgvProductos.Rows[e.RowIndex].Cells[4].Value = producto.subcategoriaProducto.nombre;
                    dgvProductos.Rows[e.RowIndex].Cells[5].Value = producto.precio.ToString("N2");
                    dgvProductos.Rows[e.RowIndex].Cells[6].Value = producto.stock;
                }
            }
            catch(Exception ex) { }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "Buscar por ID o nombre del producto...") txtBuscarProducto.Text = "";
            dgvProductos.DataSource = _daoLogisticaWS.listarProductosxIdNombre(txtBuscarProducto.Text);
            txtBuscarProducto.Text = "Buscar por ID o nombre del producto...";
            txtBuscarProducto.ForeColor = Color.Gray;
        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "Buscar por ID o nombre del producto...")
            {
                txtBuscarProducto.Text = "";
                txtBuscarProducto.ForeColor = Color.Black;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                txtBuscarProducto.Text = "Buscar por ID o nombre del producto...";
                txtBuscarProducto.ForeColor = Color.Gray;
            }
        }

        private void TimerProductos_Tick(object sender, EventArgs e)
        {
            _categoriasProducto = _daoLogisticaWS.listarCategoriasProducto().ToList();
            _marcasProducto = _daoLogisticaWS.listarMarcasProducto().ToList();
            panelCategorias.Controls.Clear();
            panelMarcas.Controls.Clear();
            //this.Refresh();
            foreach (categoriaProducto cat in _categoriasProducto)
            {
                frmBotonCategoria formBotCat = new frmBotonCategoria(cat);
                formBotCat.TopLevel = false;
                formBotCat.Dock = DockStyle.Top;
                panelCategorias.Controls.Add(formBotCat);
                formBotCat.Visible = true;
                formBotCat.frmPadre = this;
            }

            foreach (marcaProducto mar in _marcasProducto)
            {
                frmBotonMarca formBotMar = new frmBotonMarca(mar);
                formBotMar.TopLevel = false;
                formBotMar.Dock = DockStyle.Top;
                panelMarcas.Controls.Add(formBotMar);
                formBotMar.Visible = true;
                formBotMar.frmPadre = this;
            }
        }
    }
}
