using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftRRHH
{
    public partial class frmBusquedaColaboradores : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private List<colaborador> _colaboradores; //muestra a todos los colaboradores
        private List<colaborador> _colaboradoresSeleccionados;
        private List<frmFilaBusquedaColaboradores> listaFormularios;
        private BindingList<colaborador> _colaboradoresAux; //son los colabs previos
        private bool marcarTodos;
        public List<colaborador> ColaboradoresSeleccionados { get => _colaboradoresSeleccionados; set => _colaboradoresSeleccionados = value; }

        public frmBusquedaColaboradores(BindingList<colaborador> _colabsAux)
        {
            _daoRRHHWS = new RRHHWSClient();
            _colaboradores = new List<colaborador>();
            _colaboradoresSeleccionados = new List<colaborador>();
            _colaboradoresAux = _colabsAux;
            listaFormularios = new List<frmFilaBusquedaColaboradores>();
            InitializeComponent();
            _colaboradores = _daoRRHHWS.listarColaboradoresTodos().ToList();
            VerificarEstadoMarcarTodos();
            EstablecerEstadoInicialbntMarcarTodos();
            this.MostrarColaboradores();
        }

        private void MostrarColaboradores()
        {
            panelColaboradores.Controls.Clear();
            listaFormularios.Clear();
            foreach (colaborador col in _colaboradores)
            {
                frmFilaBusquedaColaboradores frmFilaBusq = new frmFilaBusquedaColaboradores(col);
                listaFormularios.Add(frmFilaBusq);
                frmFilaBusq.TopLevel = false;
                frmFilaBusq.Dock = DockStyle.Top;
                panelColaboradores.Controls.Add(frmFilaBusq);
                frmFilaBusq.Visible = true;

                if (_colaboradoresAux.Any(auxCol => auxCol.idPersona == col.idPersona))
                {
                    frmFilaBusq.SeleccionarColaborador();
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _colaboradoresSeleccionados.Clear();

            foreach (frmFilaBusquedaColaboradores frm in listaFormularios)
            {
                if (frm.ColaboradorSeleccionado)
                {
                    ColaboradoresSeleccionados.Add(frm.Colaborador);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (frmFilaBusquedaColaboradores frm in listaFormularios)
            {
                if (marcarTodos) frm.SeleccionarColaborador();
                else frm.DeseleccionarColaborador();
            }
            EstablecerEstadoInicialbntMarcarTodos();
        }

        private void VerificarEstadoMarcarTodos()
        {
            if (_colaboradoresAux.Count() == 0) marcarTodos = false;
            else if (_colaboradoresAux.All(col => _colaboradores.Contains(col))) marcarTodos = true;
            else marcarTodos = true;
        }

        private void EstablecerEstadoInicialbntMarcarTodos()
        {
            if (!marcarTodos)
            {
                marcarTodos = true;
                btnMarcarTodos.Text = "Marcar Todos";
            }
            else
            {
                marcarTodos = false;
                btnMarcarTodos.Text = "Desmarcar Todos";
            }
        }

        private void btnPorDNI_Click(object sender, EventArgs e)
        {
            _colaboradoresSeleccionados.Clear();
            _colaboradores = _daoRRHHWS.listarColaboradoresPorDNIDesc().ToList();
            VerificarEstadoMarcarTodos();
            EstablecerEstadoInicialbntMarcarTodos();
            this.MostrarColaboradores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            _colaboradoresSeleccionados.Clear();
            _colaboradores = _daoRRHHWS.listarColaboradoresPorApellidoDesc().ToList();
            VerificarEstadoMarcarTodos();
            EstablecerEstadoInicialbntMarcarTodos();
            this.MostrarColaboradores();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _colaboradoresSeleccionados.Clear();
            _colaboradores = _daoRRHHWS.listarColaboradoresTodos().ToList();
            VerificarEstadoMarcarTodos();
            EstablecerEstadoInicialbntMarcarTodos();
            this.MostrarColaboradores();
        }
    }
}
