namespace RetailSoft.RetailSoftRRHH
{
    partial class frmMaestroPuestoTrabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.pbIconoColaborador = new System.Windows.Forms.PictureBox();
            this.tcColaborador = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.txtVacantes = new System.Windows.Forms.TextBox();
            this.lblVacante = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.rtRequisitos = new System.Windows.Forms.RichTextBox();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdPuesto = new System.Windows.Forms.Label();
            this.tbCandidatos = new System.Windows.Forms.TabPage();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCandidatos = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoColaborador)).BeginInit();
            this.tcColaborador.SuspendLayout();
            this.tbDatos.SuspendLayout();
            this.tbCandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.panelCandidatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblColaborador);
            this.panelSuperior.Controls.Add(this.pbIconoColaborador);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(727, 90);
            this.panelSuperior.TabIndex = 2;
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaborador.Location = new System.Drawing.Point(102, 26);
            this.lblColaborador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(427, 40);
            this.lblColaborador.TabIndex = 1;
            this.lblColaborador.Text = "Formato Puesto de Trabajo";
            // 
            // pbIconoColaborador
            // 
            this.pbIconoColaborador.Image = global::RetailSoft.Properties.Resources.PerfilHombre;
            this.pbIconoColaborador.Location = new System.Drawing.Point(9, 10);
            this.pbIconoColaborador.Margin = new System.Windows.Forms.Padding(2);
            this.pbIconoColaborador.Name = "pbIconoColaborador";
            this.pbIconoColaborador.Size = new System.Drawing.Size(80, 72);
            this.pbIconoColaborador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconoColaborador.TabIndex = 0;
            this.pbIconoColaborador.TabStop = false;
            // 
            // tcColaborador
            // 
            this.tcColaborador.Controls.Add(this.tbDatos);
            this.tcColaborador.Controls.Add(this.tbCandidatos);
            this.tcColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcColaborador.Location = new System.Drawing.Point(0, 90);
            this.tcColaborador.Margin = new System.Windows.Forms.Padding(2);
            this.tcColaborador.Name = "tcColaborador";
            this.tcColaborador.SelectedIndex = 0;
            this.tcColaborador.Size = new System.Drawing.Size(727, 547);
            this.tcColaborador.TabIndex = 90;
            // 
            // tbDatos
            // 
            this.tbDatos.AutoScroll = true;
            this.tbDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDatos.Controls.Add(this.btnEliminar);
            this.tbDatos.Controls.Add(this.btnCancelar);
            this.tbDatos.Controls.Add(this.btnGuardar);
            this.tbDatos.Controls.Add(this.dtpFechaLimite);
            this.tbDatos.Controls.Add(this.lblFechaLimite);
            this.tbDatos.Controls.Add(this.dtpFechaPublicacion);
            this.tbDatos.Controls.Add(this.lblFechaPublicacion);
            this.tbDatos.Controls.Add(this.txtVacantes);
            this.tbDatos.Controls.Add(this.lblVacante);
            this.tbDatos.Controls.Add(this.txtCorreo);
            this.tbDatos.Controls.Add(this.lblCorreo);
            this.tbDatos.Controls.Add(this.rtRequisitos);
            this.tbDatos.Controls.Add(this.rtDescripcion);
            this.tbDatos.Controls.Add(this.txtNombre);
            this.tbDatos.Controls.Add(this.txtIdPuesto);
            this.tbDatos.Controls.Add(this.lblRequisitos);
            this.tbDatos.Controls.Add(this.lblDescripcion);
            this.tbDatos.Controls.Add(this.lblNombre);
            this.tbDatos.Controls.Add(this.lblIdPuesto);
            this.tbDatos.Location = new System.Drawing.Point(4, 29);
            this.tbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.tbDatos.Size = new System.Drawing.Size(719, 514);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos Generales";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(605, 461);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 46);
            this.btnEliminar.TabIndex = 100;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(392, 461);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 46);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(213, 461);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 46);
            this.btnGuardar.TabIndex = 98;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLimite.Location = new System.Drawing.Point(204, 225);
            this.dtpFechaLimite.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(248, 21);
            this.dtpFechaLimite.TabIndex = 97;
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.Location = new System.Drawing.Point(87, 224);
            this.lblFechaLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(104, 20);
            this.lblFechaLimite.TabIndex = 96;
            this.lblFechaLimite.Text = "Fecha Límite:";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(204, 186);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(248, 21);
            this.dtpFechaPublicacion.TabIndex = 95;
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPublicacion.Location = new System.Drawing.Point(52, 184);
            this.lblFechaPublicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(142, 20);
            this.lblFechaPublicacion.TabIndex = 94;
            this.lblFechaPublicacion.Text = "Fecha Publicación:";
            // 
            // txtVacantes
            // 
            this.txtVacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacantes.Location = new System.Drawing.Point(204, 147);
            this.txtVacantes.Margin = new System.Windows.Forms.Padding(2);
            this.txtVacantes.Name = "txtVacantes";
            this.txtVacantes.Size = new System.Drawing.Size(66, 21);
            this.txtVacantes.TabIndex = 93;
            this.txtVacantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVacantes_KeyPress);
            // 
            // lblVacante
            // 
            this.lblVacante.AutoSize = true;
            this.lblVacante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacante.Location = new System.Drawing.Point(108, 145);
            this.lblVacante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVacante.Name = "lblVacante";
            this.lblVacante.Size = new System.Drawing.Size(81, 20);
            this.lblVacante.TabIndex = 92;
            this.lblVacante.Text = "Vacantes:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(204, 109);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(248, 21);
            this.txtCorreo.TabIndex = 91;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(36, 107);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(159, 20);
            this.lblCorreo.TabIndex = 90;
            this.lblCorreo.Text = "Correo Responsable:";
            // 
            // rtRequisitos
            // 
            this.rtRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtRequisitos.Location = new System.Drawing.Point(204, 363);
            this.rtRequisitos.Margin = new System.Windows.Forms.Padding(2);
            this.rtRequisitos.Name = "rtRequisitos";
            this.rtRequisitos.Size = new System.Drawing.Size(321, 71);
            this.rtRequisitos.TabIndex = 89;
            this.rtRequisitos.Text = "";
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescripcion.Location = new System.Drawing.Point(204, 269);
            this.rtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(321, 71);
            this.rtDescripcion.TabIndex = 88;
            this.rtDescripcion.Text = "";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(204, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 21);
            this.txtNombre.TabIndex = 87;
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPuesto.Location = new System.Drawing.Point(204, 28);
            this.txtIdPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(66, 21);
            this.txtIdPuesto.TabIndex = 86;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitos.Location = new System.Drawing.Point(101, 363);
            this.lblRequisitos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(88, 20);
            this.lblRequisitos.TabIndex = 85;
            this.lblRequisitos.Text = "Requisitos:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(94, 269);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 84;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(46, 67);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 20);
            this.lblNombre.TabIndex = 83;
            this.lblNombre.Text = "Nombre del Puesto:";
            // 
            // lblIdPuesto
            // 
            this.lblIdPuesto.AutoSize = true;
            this.lblIdPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPuesto.Location = new System.Drawing.Point(55, 28);
            this.lblIdPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPuesto.Name = "lblIdPuesto";
            this.lblIdPuesto.Size = new System.Drawing.Size(138, 20);
            this.lblIdPuesto.TabIndex = 82;
            this.lblIdPuesto.Text = "Id Puesto Trabajo:";
            // 
            // tbCandidatos
            // 
            this.tbCandidatos.AutoScroll = true;
            this.tbCandidatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCandidatos.Controls.Add(this.dgvCandidatos);
            this.tbCandidatos.Controls.Add(this.panelCandidatos);
            this.tbCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCandidatos.Location = new System.Drawing.Point(4, 29);
            this.tbCandidatos.Margin = new System.Windows.Forms.Padding(2);
            this.tbCandidatos.Name = "tbCandidatos";
            this.tbCandidatos.Padding = new System.Windows.Forms.Padding(2);
            this.tbCandidatos.Size = new System.Drawing.Size(719, 514);
            this.tbCandidatos.TabIndex = 1;
            this.tbCandidatos.Text = "Candidatos";
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Teléfono,
            this.Estado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidatos.Location = new System.Drawing.Point(2, 57);
            this.dgvCandidatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.Size = new System.Drawing.Size(715, 455);
            this.dgvCandidatos.TabIndex = 1;
            this.dgvCandidatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCandidatos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 300;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 110;
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.MinimumWidth = 6;
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.Width = 120;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 220;
            // 
            // panelCandidatos
            // 
            this.panelCandidatos.Controls.Add(this.btnSeleccionar);
            this.panelCandidatos.Controls.Add(this.btnBuscar);
            this.panelCandidatos.Controls.Add(this.txtBuscar);
            this.panelCandidatos.Controls.Add(this.btnNuevo);
            this.panelCandidatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCandidatos.Location = new System.Drawing.Point(2, 2);
            this.panelCandidatos.Margin = new System.Windows.Forms.Padding(2);
            this.panelCandidatos.Name = "panelCandidatos";
            this.panelCandidatos.Size = new System.Drawing.Size(715, 55);
            this.panelCandidatos.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(131, 10);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(117, 34);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::RetailSoft.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(652, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(297, 15);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(351, 26);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Text = "Buscar candidato por nombre o DNI...";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(11, 10);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 34);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmMaestroPuestoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 637);
            this.Controls.Add(this.tcColaborador);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMaestroPuestoTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoPuesto";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoColaborador)).EndInit();
            this.tcColaborador.ResumeLayout(false);
            this.tbDatos.ResumeLayout(false);
            this.tbDatos.PerformLayout();
            this.tbCandidatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.panelCandidatos.ResumeLayout(false);
            this.panelCandidatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.PictureBox pbIconoColaborador;
        private System.Windows.Forms.TabControl tcColaborador;
        private System.Windows.Forms.TabPage tbDatos;
        private System.Windows.Forms.RichTextBox rtRequisitos;
        private System.Windows.Forms.RichTextBox rtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdPuesto;
        private System.Windows.Forms.TabPage tbCandidatos;
        private System.Windows.Forms.TextBox txtVacantes;
        private System.Windows.Forms.Label lblVacante;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.Panel panelCandidatos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}