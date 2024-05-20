using RetailSoft.RetailSoftLogistica;
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
    public partial class frmGestionColaboradores : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private List<cargo> cargos;
        private List<colaborador> _colaboradores;
        private int numColaboradores = 0;
        private int totalColaboradores;
        private string _cadenaBuscar = "Buscar por nombre o DNI...";
        Form FormActualAgregar;
        public frmGestionColaboradores()
        {
            _daoRRHHWS = new RRHHWSClient();
            InitializeComponent();  
            cargos = _daoRRHHWS.listarTodosCargos().ToList();
            _colaboradores = _daoRRHHWS.listarColaboradoresTodos().ToList();
            totalColaboradores = _colaboradores.Count;
            foreach (cargo cargo in cargos)
            {
                frmDatosCargo formCargo = new frmDatosCargo(cargo,this);
                formCargo.TopLevel = false;
                formCargo.Dock = DockStyle.Top;
                panelCargos.Controls.Add(formCargo);
                formCargo.Visible = true;
            }
            frmDatosCargo formCargoTodos = new frmDatosCargo(this);
            formCargoTodos.TopLevel = false;
            formCargoTodos.Dock = DockStyle.Top;
            panelCargos.Controls.Add(formCargoTodos);
            formCargoTodos.Visible = true;
            this.MostrarColaboradores();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMaestroColaborador frmColab = new frmMaestroColaborador();
            if (frmColab.ShowDialog() == DialogResult.OK)
            {
                this.ActualizarPanelColaboradores();
            }
        }

        public void ActualizarPanelColaboradores(int idCargo)
        {
            _colaboradores = _daoRRHHWS.listarColaboradoresPorIdCargo(idCargo).ToList();
            numColaboradores = 0;
            totalColaboradores = _colaboradores.Count;

            this.MostrarColaboradores();
        }

        public void ActualizarPanelColaboradores()
        {
            _colaboradores = _daoRRHHWS.listarColaboradoresTodos().ToList();
            numColaboradores = 0;
            totalColaboradores = _colaboradores.Count;

            this.MostrarColaboradores();
        }

        private void MostrarColaboradores()
        {
            panelColaboradores.Controls.Clear();

            for (int i = 1; i <= totalColaboradores; i++)
            {
                if (numColaboradores == totalColaboradores) break;

                frmFilaColaborador panel = new frmFilaColaborador();
                panel.TopLevel = false;

                panelColaboradores.Controls.Add(panel);
                panelColaboradores.Controls.SetChildIndex(panel, 0);

                panel.Dock = DockStyle.Top;
                panel.Visible = true;

                do
                {
                    if (numColaboradores == totalColaboradores) break;
                    frmDatosColaborador boton = new frmDatosColaborador(_colaboradores[numColaboradores],this);
                    boton.TopLevel = false;
                    panel.Controls.Add(boton);
                    boton.Dock = DockStyle.Left;
                    boton.Visible = true;
                    numColaboradores++;
                }
                while (panel.Controls.Count != 2); //elementos por fila

            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == _cadenaBuscar)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = _cadenaBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == _cadenaBuscar) txtBuscar.Text = "";
                _colaboradores = _daoRRHHWS.listarColaboradoresPorDNINombre(txtBuscar.Text).ToList();

                numColaboradores = 0;
                totalColaboradores = _colaboradores.Count;
                panelColaboradores.Controls.Clear();

                txtBuscar.Text = _cadenaBuscar;
                txtBuscar.ForeColor = Color.Gray;
                this.MostrarColaboradores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron resultados para: " + txtBuscar.Text, 
                    "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
