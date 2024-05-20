namespace RetailSoft.RetailSoftRRHH
{
    partial class frmMaestroEvento
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
            this.lblEvento = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbIconoEvento = new System.Windows.Forms.PictureBox();
            this.tcEvento = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dtpFechaRealizacion = new System.Windows.Forms.DateTimePicker();
            this.txtTotalInvitados = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTotalInvitados = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblIdEvento = new System.Windows.Forms.Label();
            this.tbInvitados = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblInvitadosSeleccionados = new System.Windows.Forms.Label();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoEvento)).BeginInit();
            this.tcEvento.SuspendLayout();
            this.tbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tbInvitados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.Color.White;
            this.lblEvento.Location = new System.Drawing.Point(136, 32);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(375, 50);
            this.lblEvento.TabIndex = 1;
            this.lblEvento.Text = "Formato de Evento";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblEvento);
            this.panelSuperior.Controls.Add(this.pbIconoEvento);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1132, 111);
            this.panelSuperior.TabIndex = 2;
            // 
            // pbIconoEvento
            // 
            this.pbIconoEvento.Image = global::RetailSoft.Properties.Resources.evento;
            this.pbIconoEvento.Location = new System.Drawing.Point(15, 12);
            this.pbIconoEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIconoEvento.Name = "pbIconoEvento";
            this.pbIconoEvento.Size = new System.Drawing.Size(104, 82);
            this.pbIconoEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconoEvento.TabIndex = 0;
            this.pbIconoEvento.TabStop = false;
            // 
            // tcEvento
            // 
            this.tcEvento.Controls.Add(this.tbDatos);
            this.tcEvento.Controls.Add(this.tbInvitados);
            this.tcEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEvento.Location = new System.Drawing.Point(0, 111);
            this.tcEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcEvento.Name = "tcEvento";
            this.tcEvento.SelectedIndex = 0;
            this.tcEvento.Size = new System.Drawing.Size(1132, 645);
            this.tcEvento.TabIndex = 39;
            // 
            // tbDatos
            // 
            this.tbDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDatos.Controls.Add(this.btnEliminar);
            this.tbDatos.Controls.Add(this.rtDescripcion);
            this.tbDatos.Controls.Add(this.dtpHoraFin);
            this.tbDatos.Controls.Add(this.dtpHoraInicio);
            this.tbDatos.Controls.Add(this.btnSubirFoto);
            this.tbDatos.Controls.Add(this.btnCancelar);
            this.tbDatos.Controls.Add(this.btnGuardar);
            this.tbDatos.Controls.Add(this.pbFoto);
            this.tbDatos.Controls.Add(this.dtpFechaRealizacion);
            this.tbDatos.Controls.Add(this.txtTotalInvitados);
            this.tbDatos.Controls.Add(this.txtLugar);
            this.tbDatos.Controls.Add(this.txtNombre);
            this.tbDatos.Controls.Add(this.txtIdEvento);
            this.tbDatos.Controls.Add(this.lblFechaNacimiento);
            this.tbDatos.Controls.Add(this.lblTotalInvitados);
            this.tbDatos.Controls.Add(this.lblDescripcion);
            this.tbDatos.Controls.Add(this.lblApellidoPaterno);
            this.tbDatos.Controls.Add(this.lblNombre);
            this.tbDatos.Controls.Add(this.lblHoraFin);
            this.tbDatos.Controls.Add(this.lblHoraInicio);
            this.tbDatos.Controls.Add(this.lblIdEvento);
            this.tbDatos.Location = new System.Drawing.Point(4, 34);
            this.tbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatos.Size = new System.Drawing.Size(1124, 607);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos Generales";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(953, 530);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 57);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescripcion.Location = new System.Drawing.Point(263, 359);
            this.rtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(475, 139);
            this.rtDescripcion.TabIndex = 70;
            this.rtDescripcion.Text = "";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHoraFin.Location = new System.Drawing.Point(263, 262);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(200, 28);
            this.dtpHoraFin.TabIndex = 69;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(263, 212);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 28);
            this.dtpHoraInicio.TabIndex = 68;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirFoto.Image = global::RetailSoft.Properties.Resources.subir;
            this.btnSubirFoto.Location = new System.Drawing.Point(1012, 242);
            this.btnSubirFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(84, 57);
            this.btnSubirFoto.TabIndex = 67;
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(528, 530);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 57);
            this.btnCancelar.TabIndex = 65;
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
            this.btnGuardar.Location = new System.Drawing.Point(307, 530);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 57);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(784, 41);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(313, 259);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 63;
            this.pbFoto.TabStop = false;
            // 
            // dtpFechaRealizacion
            // 
            this.dtpFechaRealizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRealizacion.Location = new System.Drawing.Point(263, 164);
            this.dtpFechaRealizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaRealizacion.Name = "dtpFechaRealizacion";
            this.dtpFechaRealizacion.Size = new System.Drawing.Size(327, 24);
            this.dtpFechaRealizacion.TabIndex = 61;
            // 
            // txtTotalInvitados
            // 
            this.txtTotalInvitados.Enabled = false;
            this.txtTotalInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInvitados.Location = new System.Drawing.Point(263, 315);
            this.txtTotalInvitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalInvitados.Name = "txtTotalInvitados";
            this.txtTotalInvitados.Size = new System.Drawing.Size(128, 24);
            this.txtTotalInvitados.TabIndex = 57;
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(263, 122);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(475, 24);
            this.txtLugar.TabIndex = 55;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(263, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(475, 24);
            this.txtNombre.TabIndex = 53;
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Enabled = false;
            this.txtIdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEvento.Location = new System.Drawing.Point(263, 36);
            this.txtIdEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(100, 24);
            this.txtIdEvento.TabIndex = 51;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(44, 165);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(178, 25);
            this.lblFechaNacimiento.TabIndex = 50;
            this.lblFechaNacimiento.Text = "Fecha Realización:";
            // 
            // lblTotalInvitados
            // 
            this.lblTotalInvitados.AutoSize = true;
            this.lblTotalInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvitados.Location = new System.Drawing.Point(81, 315);
            this.lblTotalInvitados.Name = "lblTotalInvitados";
            this.lblTotalInvitados.Size = new System.Drawing.Size(145, 25);
            this.lblTotalInvitados.TabIndex = 47;
            this.lblTotalInvitados.Text = "Total Invitados:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(108, 363);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(120, 25);
            this.lblDescripcion.TabIndex = 46;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(164, 122);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(68, 25);
            this.lblApellidoPaterno.TabIndex = 44;
            this.lblApellidoPaterno.Text = "Lugar:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(144, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(137, 267);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(92, 25);
            this.lblHoraFin.TabIndex = 42;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(117, 217);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(110, 25);
            this.lblHoraInicio.TabIndex = 41;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // lblIdEvento
            // 
            this.lblIdEvento.AutoSize = true;
            this.lblIdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEvento.Location = new System.Drawing.Point(131, 36);
            this.lblIdEvento.Name = "lblIdEvento";
            this.lblIdEvento.Size = new System.Drawing.Size(99, 25);
            this.lblIdEvento.TabIndex = 38;
            this.lblIdEvento.Text = "ld Evento:";
            // 
            // tbInvitados
            // 
            this.tbInvitados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbInvitados.Controls.Add(this.btnBuscar);
            this.tbInvitados.Controls.Add(this.lblInvitadosSeleccionados);
            this.tbInvitados.Controls.Add(this.dgvColaboradores);
            this.tbInvitados.Controls.Add(this.lblIndicacion);
            this.tbInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvitados.Location = new System.Drawing.Point(4, 34);
            this.tbInvitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInvitados.Name = "tbInvitados";
            this.tbInvitados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInvitados.Size = new System.Drawing.Size(1124, 607);
            this.tbInvitados.TabIndex = 1;
            this.tbInvitados.Text = "Invitados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Location = new System.Drawing.Point(521, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 41);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblInvitadosSeleccionados
            // 
            this.lblInvitadosSeleccionados.AutoSize = true;
            this.lblInvitadosSeleccionados.Location = new System.Drawing.Point(32, 119);
            this.lblInvitadosSeleccionados.Name = "lblInvitadosSeleccionados";
            this.lblInvitadosSeleccionados.Size = new System.Drawing.Size(297, 29);
            this.lblInvitadosSeleccionados.TabIndex = 4;
            this.lblInvitadosSeleccionados.Text = "Invitados Seleccionados";
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.DNI,
            this.Correo,
            this.Cargo});
            this.dgvColaboradores.Location = new System.Drawing.Point(37, 175);
            this.dgvColaboradores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.RowHeadersWidth = 51;
            this.dgvColaboradores.RowTemplate.Height = 24;
            this.dgvColaboradores.Size = new System.Drawing.Size(1059, 404);
            this.dgvColaboradores.TabIndex = 3;
            this.dgvColaboradores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvColaboradores_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 120;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 200;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 150;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(32, 38);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(405, 29);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "Buscar invitados para seleccionar";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "evento";
            // 
            // frmMaestroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 756);
            this.Controls.Add(this.tcEvento);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaestroEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Formato de Evento";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoEvento)).EndInit();
            this.tcEvento.ResumeLayout(false);
            this.tbDatos.ResumeLayout(false);
            this.tbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tbInvitados.ResumeLayout(false);
            this.tbInvitados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.PictureBox pbIconoEvento;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TabControl tcEvento;
        private System.Windows.Forms.TabPage tbDatos;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DateTimePicker dtpFechaRealizacion;
        private System.Windows.Forms.TextBox txtTotalInvitados;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTotalInvitados;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblIdEvento;
        private System.Windows.Forms.TabPage tbInvitados;
        private System.Windows.Forms.Label lblInvitadosSeleccionados;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.RichTextBox rtDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}