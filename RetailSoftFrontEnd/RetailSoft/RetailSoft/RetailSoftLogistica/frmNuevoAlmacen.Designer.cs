namespace RetailSoft.RetailSoftLogistica
{
    partial class frmNuevoAlmacen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbCalidad = new System.Windows.Forms.CheckBox();
            this.cbIluminacion = new System.Windows.Forms.CheckBox();
            this.cbEstanterias = new System.Windows.Forms.CheckBox();
            this.cbPickPack = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.dtpMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpActualizacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblRegistroAlmacen = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblVehiculosSelect = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvVehiculosSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTodosVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDistritos = new System.Windows.Forms.Label();
            this.cboDistritos = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.cboDistritos);
            this.tabPage1.Controls.Add(this.lblDistritos);
            this.tabPage1.Controls.Add(this.cbCalidad);
            this.tabPage1.Controls.Add(this.cbIluminacion);
            this.tabPage1.Controls.Add(this.cbEstanterias);
            this.tabPage1.Controls.Add(this.cbPickPack);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.lblDatos);
            this.tabPage1.Controls.Add(this.dtpMantenimiento);
            this.tabPage1.Controls.Add(this.dtpActualizacion);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtResponsable);
            this.tabPage1.Controls.Add(this.lblResponsable);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnRetroceder);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.lblRegistroAlmacen);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.txtCapacidad);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.lblDireccion);
            this.tabPage1.Controls.Add(this.lblPlaca);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1026, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // cbCalidad
            // 
            this.cbCalidad.AutoSize = true;
            this.cbCalidad.Location = new System.Drawing.Point(301, 603);
            this.cbCalidad.Name = "cbCalidad";
            this.cbCalidad.Size = new System.Drawing.Size(189, 28);
            this.cbCalidad.TabIndex = 130;
            this.cbCalidad.Text = "Control de Calidad";
            this.cbCalidad.UseVisualStyleBackColor = true;
            // 
            // cbIluminacion
            // 
            this.cbIluminacion.AutoSize = true;
            this.cbIluminacion.Location = new System.Drawing.Point(598, 603);
            this.cbIluminacion.Name = "cbIluminacion";
            this.cbIluminacion.Size = new System.Drawing.Size(231, 28);
            this.cbIluminacion.TabIndex = 129;
            this.cbIluminacion.Text = "Sistema de Iluminación";
            this.cbIluminacion.UseVisualStyleBackColor = true;
            // 
            // cbEstanterias
            // 
            this.cbEstanterias.AutoSize = true;
            this.cbEstanterias.Location = new System.Drawing.Point(598, 552);
            this.cbEstanterias.Name = "cbEstanterias";
            this.cbEstanterias.Size = new System.Drawing.Size(215, 28);
            this.cbEstanterias.TabIndex = 128;
            this.cbEstanterias.Text = "Estanterías ajustables";
            this.cbEstanterias.UseVisualStyleBackColor = true;
            // 
            // cbPickPack
            // 
            this.cbPickPack.AutoSize = true;
            this.cbPickPack.Location = new System.Drawing.Point(301, 552);
            this.cbPickPack.Name = "cbPickPack";
            this.cbPickPack.Size = new System.Drawing.Size(250, 28);
            this.cbPickPack.TabIndex = 127;
            this.cbPickPack.Text = "Espacio Picking y Packing";
            this.cbPickPack.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(301, 429);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(405, 86);
            this.txtDescripcion.TabIndex = 123;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(84, 438);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 122;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(84, 524);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(177, 25);
            this.lblDatos.TabIndex = 118;
            this.lblDatos.Text = "Datos adicionales: ";
            // 
            // dtpMantenimiento
            // 
            this.dtpMantenimiento.Location = new System.Drawing.Point(301, 389);
            this.dtpMantenimiento.Name = "dtpMantenimiento";
            this.dtpMantenimiento.Size = new System.Drawing.Size(405, 29);
            this.dtpMantenimiento.TabIndex = 117;
            // 
            // dtpActualizacion
            // 
            this.dtpActualizacion.Location = new System.Drawing.Point(301, 343);
            this.dtpActualizacion.Name = "dtpActualizacion";
            this.dtpActualizacion.Size = new System.Drawing.Size(405, 29);
            this.dtpActualizacion.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 115;
            this.label5.Text = "Fecha Mantenimiento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 114;
            this.label4.Text = "Fecha Actualización: ";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(301, 199);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(305, 27);
            this.txtResponsable.TabIndex = 113;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(84, 198);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(137, 25);
            this.lblResponsable.TabIndex = 112;
            this.lblResponsable.Text = "Responsable: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetailSoft.Properties.Resources.almacenes;
            this.pictureBox1.Location = new System.Drawing.Point(766, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(328, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 36);
            this.btnCancelar.TabIndex = 101;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(12, 12);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(124, 36);
            this.btnRetroceder.TabIndex = 100;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(215, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 36);
            this.btnGuardar.TabIndex = 99;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // lblRegistroAlmacen
            // 
            this.lblRegistroAlmacen.AutoSize = true;
            this.lblRegistroAlmacen.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroAlmacen.Location = new System.Drawing.Point(68, 64);
            this.lblRegistroAlmacen.Name = "lblRegistroAlmacen";
            this.lblRegistroAlmacen.Size = new System.Drawing.Size(376, 37);
            this.lblRegistroAlmacen.TabIndex = 98;
            this.lblRegistroAlmacen.Text = "REGISTRO DE ALMACÉN: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(301, 288);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(405, 27);
            this.txtDireccion.TabIndex = 97;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(301, 241);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(63, 27);
            this.txtCapacidad.TabIndex = 96;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(301, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 27);
            this.txtNombre.TabIndex = 95;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(301, 114);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 27);
            this.txtID.TabIndex = 94;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(84, 288);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(104, 25);
            this.lblDireccion.TabIndex = 93;
            this.lblDireccion.Text = "Dirección: ";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(84, 240);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(113, 25);
            this.lblPlaca.TabIndex = 92;
            this.lblPlaca.Text = "Capacidad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(84, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 25);
            this.lblNombre.TabIndex = 91;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(84, 113);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 25);
            this.lblID.TabIndex = 90;
            this.lblID.Text = "ID: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.lblVehiculosSelect);
            this.tabPage2.Controls.Add(this.lblVehiculos);
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Controls.Add(this.dgvVehiculosSelect);
            this.tabPage2.Controls.Add(this.dgvTodosVehiculos);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblVehiculosSelect
            // 
            this.lblVehiculosSelect.AutoSize = true;
            this.lblVehiculosSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculosSelect.Location = new System.Drawing.Point(373, 296);
            this.lblVehiculosSelect.Name = "lblVehiculosSelect";
            this.lblVehiculosSelect.Size = new System.Drawing.Size(294, 31);
            this.lblVehiculosSelect.TabIndex = 109;
            this.lblVehiculosSelect.Text = "Vehículos Seleccionados";
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.Location = new System.Drawing.Point(52, 15);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(263, 31);
            this.lblVehiculos.TabIndex = 108;
            this.lblVehiculos.Text = "Vehículos disponibles";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(808, 179);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(117, 33);
            this.btnQuitar.TabIndex = 107;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(808, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 33);
            this.btnAgregar.TabIndex = 106;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvVehiculosSelect
            // 
            this.dgvVehiculosSelect.AllowUserToAddRows = false;
            this.dgvVehiculosSelect.AllowUserToDeleteRows = false;
            this.dgvVehiculosSelect.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvVehiculosSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvVehiculosSelect.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVehiculosSelect.Location = new System.Drawing.Point(193, 340);
            this.dgvVehiculosSelect.Name = "dgvVehiculosSelect";
            this.dgvVehiculosSelect.ReadOnly = true;
            this.dgvVehiculosSelect.RowHeadersWidth = 51;
            this.dgvVehiculosSelect.RowTemplate.Height = 24;
            this.dgvVehiculosSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculosSelect.Size = new System.Drawing.Size(663, 234);
            this.dgvVehiculosSelect.TabIndex = 105;
            this.dgvVehiculosSelect.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVehiculosSelect_CellFormatting);
            this.dgvVehiculosSelect.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvVehiculosSelect_CellPainting);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "idVehiculo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "PLACA";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 160;
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
            this.dgvTodosVehiculos.Location = new System.Drawing.Point(58, 65);
            this.dgvTodosVehiculos.Name = "dgvTodosVehiculos";
            this.dgvTodosVehiculos.ReadOnly = true;
            this.dgvTodosVehiculos.RowHeadersWidth = 51;
            this.dgvTodosVehiculos.RowTemplate.Height = 24;
            this.dgvTodosVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosVehiculos.Size = new System.Drawing.Size(663, 200);
            this.dgvTodosVehiculos.TabIndex = 104;
            this.dgvTodosVehiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTodosVehiculos_CellFormatting);
            this.dgvTodosVehiculos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTodosVehiculos_CellPainting);
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
            // lblDistritos
            // 
            this.lblDistritos.AutoSize = true;
            this.lblDistritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistritos.Location = new System.Drawing.Point(748, 290);
            this.lblDistritos.Name = "lblDistritos";
            this.lblDistritos.Size = new System.Drawing.Size(92, 25);
            this.lblDistritos.TabIndex = 131;
            this.lblDistritos.Text = "Distritos: ";
            // 
            // cboDistritos
            // 
            this.cboDistritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistritos.FormattingEnabled = true;
            this.cboDistritos.Location = new System.Drawing.Point(834, 289);
            this.cboDistritos.Name = "cboDistritos";
            this.cboDistritos.Size = new System.Drawing.Size(175, 28);
            this.cboDistritos.TabIndex = 132;
            // 
            // frmNuevoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 708);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmNuevoAlmacen";
            this.Text = "frmNuevoAlmacen";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblRegistroAlmacen;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvVehiculosSelect;
        private System.Windows.Forms.DataGridView dgvTodosVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Label lblVehiculosSelect;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DateTimePicker dtpMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpActualizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbIluminacion;
        private System.Windows.Forms.CheckBox cbEstanterias;
        private System.Windows.Forms.CheckBox cbPickPack;
        private System.Windows.Forms.CheckBox cbCalidad;
        private System.Windows.Forms.Label lblDistritos;
        private System.Windows.Forms.ComboBox cboDistritos;
    }
}