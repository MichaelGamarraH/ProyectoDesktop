using RetailSoft.LogisticaWS;
using RetailSoft.RetailSoftVentas;
using RetailSoft.RRHHWS;
using RetailSoft.VentasWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft    //Entrega lab 13
{
    
    public partial class frmGestionarVenta : Form
    {
        public static DataGridView dataGridViewA;
        public static TextBox textTotal;
        public static double sumaTotal;
        private venta _venta;
        public static BindingList<lineaVenta> _lineasVenta;
        private VentasWSClient _daoVentas;
        private RRHHWSClient _daoRRHH;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public frmGestionarVenta()
        {
            
            InitializeComponent();

            _lineasVenta = new BindingList<lineaVenta>();
            _venta = new venta();

            _daoVentas = new VentasWSClient();

           

            // Agrega las columnas al DataGridView
            dataGridView1.Columns.Add("Columna1", "Nombre");
            dataGridView1.Columns.Add("Columna2", "Marca");
            dataGridView1.Columns.Add("Columna3", "Precio");
            // Asignas el DataGridView al campo estático
            dataGridViewA = dataGridView1;


            textTotal = txtTotal;
            sumaTotal = 0;

            cboPromotor.DisplayMember = "nombre";
            cboPromotor.ValueMember = "idColaborador";

            _daoRRHH = new RRHHWSClient();
            cboPromotor.DataSource = _daoRRHH.listarColaboradoresTodos();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnFlechaIzquierda_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGestionarVenta_Load(object sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnEjecutarVenta_Click(object sender, EventArgs e)
        {
            _venta.montoTotal = double.Parse(txtTotal.Text);

            _venta.fechaVenta = dtpFechaPedido.Value;
            _venta.fechaVentaSpecified = true;


            _venta.cliente = new cliente();
            _venta.cliente.documentoIdentidad = txtDNICliente.Text;
            _venta.cliente.nombre = txtNombreCliente.Text;


            _venta.promotor = new VentasWS.colaborador();

            _venta.promotor.idColaborador = (int)cboPromotor.SelectedValue;

            _venta.promotor.nombre = cboPromotor.Text;


            _venta.lineasVenta = _lineasVenta.ToArray();


            int resultado = _daoVentas.insertarVenta(_venta);
            if (resultado != 0)
            {
                //txtIDPromocion.Text = _promocion.idPromocion.ToString();
                MessageBox.Show("¡La venta se ha realizado con éxito! :D", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtIDPromocion.Text = resultado.ToString();
                txtIDPedido.Text = resultado.ToString();

                frmGestionarVenta.textTotal.Text = "0";
                DatosCompartidos.TextoLabel = "0";
                frmGestionarPedidos.cont = 0;
                frmGestionarVenta.sumaTotal =0;
                frmGestionarVenta.textTotal.Text = "0";
                dataGridView1.ClearSelection();
                txtDNICliente.Text = "";
                cboPromotor.Text = "";
                txtNombreCliente.Text = "";
  

            }
            else
                MessageBox.Show("¡Hubo un error en el registro!", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                lineaVenta lv = (lineaVenta)dataGridView1.CurrentRow.DataBoundItem;
                _lineasVenta.Remove(lv);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto, por favor.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
