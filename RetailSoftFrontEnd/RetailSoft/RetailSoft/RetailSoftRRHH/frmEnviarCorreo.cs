using RetailSoft.RRHHWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSoft.RetailSoftLogistica
{
    public partial class frmEnviarCorreo : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private evento _evento;
        private BindingList<colaborador> _colaboradores;
        private List<colaboradorxEvento> _colaboradoresxEvento;
        public frmEnviarCorreo(evento _eventoAux)
        {
            _daoRRHHWS = new RRHHWSClient();
            _evento = _eventoAux;
            _colaboradores = new BindingList<colaborador>();
            _colaboradoresxEvento = new List<colaboradorxEvento>();
            InitializeComponent();
            _colaboradoresxEvento = _daoRRHHWS.listarColaboradoresPorIdEvento(_eventoAux.idEvento).ToList();
            foreach (colaboradorxEvento colxevento in _colaboradoresxEvento) _colaboradores.Add(colxevento.colaborador);

            lblNombre.Text += "   " + _eventoAux.nombre;
            lblFecha.Text += "                       " + _eventoAux.fechaRealizacion.ToString("dd/MM/yyyy");
            lblTotalInvitados.Text += "           " + _colaboradores.Count().ToString();
            
            dgvColaboradores.AutoGenerateColumns = false;
            dgvColaboradores.DataSource = _colaboradores;
        }

        private void dgvColaboradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                colaborador col = (colaborador)dgvColaboradores.Rows[e.RowIndex].DataBoundItem;
                if (col != null)
                {
                    dgvColaboradores.Rows[e.RowIndex].Cells[0].Value = col.nombre;
                    dgvColaboradores.Rows[e.RowIndex].Cells[1].Value = col.apellidoPaterno + " " + col.apellidoMaterno;
                    dgvColaboradores.Rows[e.RowIndex].Cells[2].Value = col.dni;
                    dgvColaboradores.Rows[e.RowIndex].Cells[3].Value = col.correoElectronico;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                string correoRemitente = "retailsoft.lp2@gmail.com";
                string contrasenhaCorreo = "sztuzrgrrfwnadaq";

                // Crear el cliente SMTP con las credenciales
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Credentials = new NetworkCredential(correoRemitente, contrasenhaCorreo);
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;

                foreach (colaborador _colab in _colaboradores)
                {
                    // creación del mensaje de correo con formato HTML
                    MailMessage mensaje = new MailMessage();
                    mensaje.From = new MailAddress(correoRemitente);
                    mensaje.To.Add(new MailAddress(_colab.correoElectronico));
                    mensaje.Subject = $"Confirmación de Asistencia: {_evento.nombre}";
                    mensaje.IsBodyHtml = true;

                    // Adjuntar la imagen del evento
                    Attachment imagenAdjunta = new Attachment(new MemoryStream(_evento.imagen), MediaTypeNames.Image.Jpeg);
                    imagenAdjunta.ContentId = "imagenEvento";  // Identificador único para la imagen

                    // cuerpo del correo en formato HTML
                    mensaje.Body = $"<html>" +
                                    $"<body>" +
                                    $"<p>Hola {_colab.nombre} {_colab.apellidoPaterno} {_colab.apellidoMaterno},</p>" +
                                    $"<p>Te invitamos a confirmar tu asistencia al evento {_evento.nombre} que se llevará a cabo el " +
                                    $"{_evento.fechaRealizacion.ToString("dd/MM/yyyy")} en {_evento.lugar}.</p>" +
                                    $"<p>Detalles del evento:</p>" +
                                    $"<ul>" +
                                    $"<li>Lugar: {_evento.lugar}</li>" +
                                    $"<li>Fecha: {_evento.fechaRealizacion.ToString("dd/MM/yyyy")}</li>" +
                                    $"<li>Hora: {_evento.horaInicio.Substring(0, 5)} - {_evento.horaFin.Substring(0, 5)}</li>" +
                                    $"{(!string.IsNullOrEmpty(_evento.descripcion) ? $"<li>Descripción: {_evento.descripcion}</li>" : "")}" +
                                    $"</ul>" +
                                    $"{(!string.IsNullOrEmpty(_evento.descripcion) ? $"<p>{_evento.descripcion}</p>" : "")}" +
                                    $"<img src='cid:imagenEvento' alt='Imagen del Evento' style='max-width:100%;'>" +  // imagen embebida
                                    $"<p>¡Esperamos verte allí!</p>" +
                                    $"<p>Saludos,<br>{_colab.nombre}</p>" +
                                    $"</body>" +
                                    $"</html>";

                    // Adjuntar la imagen embebida al mensaje
                    mensaje.Attachments.Add(imagenAdjunta);

                    // Enviar el correo
                    smtpClient.Send(mensaje);

                    // Liberar recursos del mensaje y de la imagen adjunta
                    imagenAdjunta.Dispose();
                    mensaje.Dispose();
                }

                MessageBox.Show("Todos los correos fueron enviados correctamente",
                    "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message,
                    "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
