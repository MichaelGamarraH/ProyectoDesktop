using RetailSoft.ReporteWS;
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
    public partial class frmVisorReporte : Form
    {
        private byte[] arregloPDF;
        private ReporteWSClient _daoReporteWS;
        public frmVisorReporte()
        {
            InitializeComponent();
            _daoReporteWS = new ReporteWSClient();

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            arregloPDF = _daoReporteWS.generarReporteProveedores(dtpInicio.Value,dtpFin.Value);
            File.WriteAllBytes("temporal.pdf", arregloPDF);
            pdfReader.LoadFile("temporal.pdf");
            pdfReader.setShowToolbar(true);
        }
    }
}
