namespace RetailSoft.RetailSoftLogistica
{
    partial class frmInformacionAlmacen
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActualizacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbPickPack = new System.Windows.Forms.CheckBox();
            this.cbEstanterias = new System.Windows.Forms.CheckBox();
            this.cbCalidad = new System.Windows.Forms.CheckBox();
            this.cbIluminacion = new System.Windows.Forms.CheckBox();
            this.lblVehiAlmacen = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvTodosVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListadoVehi = new System.Windows.Forms.Label();
            this.lblDistritos = new System.Windows.Forms.Label();
            this.cboDistritos = new System.Windows.Forms.ComboBox();
            this.panelTransportista = new System.Windows.Forms.Panel();
            this.lblIdTransport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTransportista = new System.Windows.Forms.TextBox();
            this.txtnumBreve = new System.Windows.Forms.TextBox();
            this.txtTipoBreve = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosVehiculos)).BeginInit();
            this.panelTransportista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(351, 211);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(405, 27);
            this.txtDireccion.TabIndex = 75;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(351, 171);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(68, 27);
            this.txtCapacidad.TabIndex = 74;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(351, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 27);
            this.txtNombre.TabIndex = 73;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(351, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(68, 27);
            this.txtID.TabIndex = 72;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(134, 213);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(104, 25);
            this.lblDireccion.TabIndex = 71;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(134, 173);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(113, 25);
            this.lblPlaca.TabIndex = 70;
            this.lblPlaca.Text = "Capacidad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(134, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 25);
            this.lblNombre.TabIndex = 69;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(134, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 25);
            this.lblID.TabIndex = 68;
            this.lblID.Text = "ID: ";
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculo,
            this.Descripcion,
            this.Plac});
            this.dgvVehiculo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVehiculo.Location = new System.Drawing.Point(17, 488);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculo.Size = new System.Drawing.Size(484, 147);
            this.dgvVehiculo.TabIndex = 76;
            this.dgvVehiculo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVehiculo_CellFormatting);
            this.dgvVehiculo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVehiculo_CellMouseDoubleClick);
            // 
            // idVehiculo
            // 
            this.idVehiculo.HeaderText = "idVehiculo";
            this.idVehiculo.MinimumWidth = 6;
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            this.idVehiculo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Plac
            // 
            this.Plac.HeaderText = "PLACA";
            this.Plac.MinimumWidth = 6;
            this.Plac.Name = "Plac";
            this.Plac.ReadOnly = true;
            this.Plac.Width = 180;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(163, -3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 33);
            this.btnModificar.TabIndex = 77;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(273, -3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 33);
            this.btnGuardar.TabIndex = 78;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(385, -3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 33);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(-3, -3);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(129, 33);
            this.btnRetroceder.TabIndex = 80;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetailSoft.Properties.Resources.AlmacenIa;
            this.pictureBox1.Location = new System.Drawing.Point(877, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(134, 137);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(137, 25);
            this.lblResponsable.TabIndex = 113;
            this.lblResponsable.Text = "Responsable: ";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(351, 135);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(305, 27);
            this.txtResponsable.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 115;
            this.label4.Text = "Fecha Actualización: ";
            // 
            // dtpActualizacion
            // 
            this.dtpActualizacion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualizacion.Location = new System.Drawing.Point(351, 250);
            this.dtpActualizacion.Name = "dtpActualizacion";
            this.dtpActualizacion.Size = new System.Drawing.Size(405, 27);
            this.dtpActualizacion.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 118;
            this.label5.Text = "Fecha Mantenimiento: ";
            // 
            // dtpMantenimiento
            // 
            this.dtpMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMantenimiento.Location = new System.Drawing.Point(351, 290);
            this.dtpMantenimiento.Name = "dtpMantenimiento";
            this.dtpMantenimiento.Size = new System.Drawing.Size(405, 27);
            this.dtpMantenimiento.TabIndex = 119;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(134, 333);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 123;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(351, 333);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(405, 59);
            this.txtDescripcion.TabIndex = 124;
            // 
            // cbPickPack
            // 
            this.cbPickPack.AutoSize = true;
            this.cbPickPack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbPickPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPickPack.Location = new System.Drawing.Point(106, 408);
            this.cbPickPack.Name = "cbPickPack";
            this.cbPickPack.Size = new System.Drawing.Size(227, 24);
            this.cbPickPack.TabIndex = 128;
            this.cbPickPack.Text = "Espacio Picking y Packing";
            this.cbPickPack.UseVisualStyleBackColor = false;
            // 
            // cbEstanterias
            // 
            this.cbEstanterias.AutoSize = true;
            this.cbEstanterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstanterias.Location = new System.Drawing.Point(399, 408);
            this.cbEstanterias.Name = "cbEstanterias";
            this.cbEstanterias.Size = new System.Drawing.Size(197, 24);
            this.cbEstanterias.TabIndex = 129;
            this.cbEstanterias.Text = "Estanterías ajustables";
            this.cbEstanterias.UseVisualStyleBackColor = true;
            // 
            // cbCalidad
            // 
            this.cbCalidad.AutoSize = true;
            this.cbCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalidad.Location = new System.Drawing.Point(669, 408);
            this.cbCalidad.Name = "cbCalidad";
            this.cbCalidad.Size = new System.Drawing.Size(169, 24);
            this.cbCalidad.TabIndex = 131;
            this.cbCalidad.Text = "Control de Calidad";
            this.cbCalidad.UseVisualStyleBackColor = true;
            // 
            // cbIluminacion
            // 
            this.cbIluminacion.AutoSize = true;
            this.cbIluminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIluminacion.Location = new System.Drawing.Point(877, 408);
            this.cbIluminacion.Name = "cbIluminacion";
            this.cbIluminacion.Size = new System.Drawing.Size(204, 24);
            this.cbIluminacion.TabIndex = 132;
            this.cbIluminacion.Text = "Sistema de Iluminación";
            this.cbIluminacion.UseVisualStyleBackColor = true;
            // 
            // lblVehiAlmacen
            // 
            this.lblVehiAlmacen.AutoSize = true;
            this.lblVehiAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiAlmacen.Location = new System.Drawing.Point(134, 448);
            this.lblVehiAlmacen.Name = "lblVehiAlmacen";
            this.lblVehiAlmacen.Size = new System.Drawing.Size(243, 25);
            this.lblVehiAlmacen.TabIndex = 133;
            this.lblVehiAlmacen.Text = "Vehículos Seleccionados: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(530, 506);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 33);
            this.btnAgregar.TabIndex = 134;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(530, 558);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(117, 33);
            this.btnQuitar.TabIndex = 135;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvTodosVehiculos
            // 
            this.dgvTodosVehiculos.AllowUserToAddRows = false;
            this.dgvTodosVehiculos.AllowUserToDeleteRows = false;
            this.dgvTodosVehiculos.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvTodosVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvTodosVehiculos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTodosVehiculos.Location = new System.Drawing.Point(675, 488);
            this.dgvTodosVehiculos.Name = "dgvTodosVehiculos";
            this.dgvTodosVehiculos.ReadOnly = true;
            this.dgvTodosVehiculos.RowHeadersWidth = 51;
            this.dgvTodosVehiculos.RowTemplate.Height = 24;
            this.dgvTodosVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosVehiculos.Size = new System.Drawing.Size(470, 147);
            this.dgvTodosVehiculos.TabIndex = 136;
            this.dgvTodosVehiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTodosVehiculos_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idVehiculo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PLACA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // lblListadoVehi
            // 
            this.lblListadoVehi.AutoSize = true;
            this.lblListadoVehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoVehi.Location = new System.Drawing.Point(771, 448);
            this.lblListadoVehi.Name = "lblListadoVehi";
            this.lblListadoVehi.Size = new System.Drawing.Size(278, 25);
            this.lblListadoVehi.TabIndex = 137;
            this.lblListadoVehi.Text = "Listado General de Vehículos: ";
            // 
            // lblDistritos
            // 
            this.lblDistritos.AutoSize = true;
            this.lblDistritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistritos.Location = new System.Drawing.Point(779, 210);
            this.lblDistritos.Name = "lblDistritos";
            this.lblDistritos.Size = new System.Drawing.Size(92, 25);
            this.lblDistritos.TabIndex = 138;
            this.lblDistritos.Text = "Distritos: ";
            // 
            // cboDistritos
            // 
            this.cboDistritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistritos.FormattingEnabled = true;
            this.cboDistritos.Location = new System.Drawing.Point(877, 211);
            this.cboDistritos.Name = "cboDistritos";
            this.cboDistritos.Size = new System.Drawing.Size(175, 28);
            this.cboDistritos.TabIndex = 139;
            this.cboDistritos.SelectedIndexChanged += new System.EventHandler(this.cboDistritos_SelectedIndexChanged);
            // 
            // panelTransportista
            // 
            this.panelTransportista.BackColor = System.Drawing.Color.Beige;
            this.panelTransportista.Controls.Add(this.pictureBox2);
            this.panelTransportista.Controls.Add(this.txtTipoBreve);
            this.panelTransportista.Controls.Add(this.txtnumBreve);
            this.panelTransportista.Controls.Add(this.txtIdTransportista);
            this.panelTransportista.Controls.Add(this.label3);
            this.panelTransportista.Controls.Add(this.label2);
            this.panelTransportista.Controls.Add(this.label1);
            this.panelTransportista.Controls.Add(this.lblIdTransport);
            this.panelTransportista.Location = new System.Drawing.Point(776, 245);
            this.panelTransportista.Name = "panelTransportista";
            this.panelTransportista.Size = new System.Drawing.Size(374, 147);
            this.panelTransportista.TabIndex = 140;
            // 
            // lblIdTransport
            // 
            this.lblIdTransport.AutoSize = true;
            this.lblIdTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTransport.Location = new System.Drawing.Point(9, 45);
            this.lblIdTransport.Name = "lblIdTransport";
            this.lblIdTransport.Size = new System.Drawing.Size(36, 20);
            this.lblIdTransport.TabIndex = 69;
            this.lblIdTransport.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Brevete: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tipo Brevete: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Datos Transportista";
            // 
            // txtIdTransportista
            // 
            this.txtIdTransportista.Location = new System.Drawing.Point(125, 43);
            this.txtIdTransportista.Name = "txtIdTransportista";
            this.txtIdTransportista.Size = new System.Drawing.Size(48, 22);
            this.txtIdTransportista.TabIndex = 73;
            // 
            // txtnumBreve
            // 
            this.txtnumBreve.Location = new System.Drawing.Point(125, 71);
            this.txtnumBreve.Name = "txtnumBreve";
            this.txtnumBreve.Size = new System.Drawing.Size(119, 22);
            this.txtnumBreve.TabIndex = 74;
            // 
            // txtTipoBreve
            // 
            this.txtTipoBreve.Location = new System.Drawing.Point(125, 105);
            this.txtTipoBreve.Name = "txtTipoBreve";
            this.txtTipoBreve.Size = new System.Drawing.Size(119, 22);
            this.txtTipoBreve.TabIndex = 75;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RetailSoft.Properties.Resources.Transportista;
            this.pictureBox2.Location = new System.Drawing.Point(259, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // frmInformacionAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 724);
            this.Controls.Add(this.panelTransportista);
            this.Controls.Add(this.cboDistritos);
            this.Controls.Add(this.lblDistritos);
            this.Controls.Add(this.lblListadoVehi);
            this.Controls.Add(this.dgvTodosVehiculos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblVehiAlmacen);
            this.Controls.Add(this.cbIluminacion);
            this.Controls.Add(this.cbCalidad);
            this.Controls.Add(this.cbEstanterias);
            this.Controls.Add(this.cbPickPack);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dtpMantenimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpActualizacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Name = "frmInformacionAlmacen";
            this.Text = "1";
            this.Load += new System.EventHandler(this.frmInformacionAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosVehiculos)).EndInit();
            this.panelTransportista.ResumeLayout(false);
            this.panelTransportista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpActualizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMantenimiento;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbPickPack;
        private System.Windows.Forms.CheckBox cbEstanterias;
        private System.Windows.Forms.CheckBox cbCalidad;
        private System.Windows.Forms.CheckBox cbIluminacion;
        private System.Windows.Forms.Label lblVehiAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plac;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvTodosVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblListadoVehi;
        private System.Windows.Forms.Label lblDistritos;
        private System.Windows.Forms.ComboBox cboDistritos;
        private System.Windows.Forms.Panel panelTransportista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdTransport;
        private System.Windows.Forms.TextBox txtTipoBreve;
        private System.Windows.Forms.TextBox txtnumBreve;
        private System.Windows.Forms.TextBox txtIdTransportista;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}