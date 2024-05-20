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
    public partial class frmBusquedaNombrePro : Form
    {
        private LogisticaWSClient daoProveedor;
        private Panel panelAux;
        public frmBusquedaNombrePro(Panel panelPro)
        {
            InitializeComponent();
            panelAux = panelPro;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre proveedor", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            daoProveedor = new LogisticaWSClient();
            int maxFormsPerRow = 1; // Máximo de formularios por fila
            int formWidth = panelNombrePro.ClientSize.Width / maxFormsPerRow; // Ancho del formulario, dividido en tres columnas
            int formHeight = 250; // Altura del formulario

            int x = 0;
            int y = 0;
            proveedor[] proveedores = daoProveedor.listarPorNombreProveedor(txtNombreProveedor.Text);

            foreach (proveedor proveedor in proveedores)
            {
                frmDatosProveedor formDatos = new frmDatosProveedor(proveedor,panelAux);
                formDatos.TopLevel = false;
                formDatos.FormBorderStyle = FormBorderStyle.None;
                formDatos.Size = new Size(formWidth, formHeight);
                formDatos.Location = new Point(x, y);

                panelNombrePro.Controls.Add(formDatos);

                x += formWidth; // Mover el próximo formulario a la derecha

                if (x + formWidth > panelNombrePro.ClientSize.Width) // Si el siguiente formulario no cabe en la misma fila
                {
                    x = 0; // Reiniciar en la primera columna
                    y += formHeight; // Mover hacia abajo para la siguiente fila
                }

                formDatos.Visible = true;
            }
        }
    }
}
