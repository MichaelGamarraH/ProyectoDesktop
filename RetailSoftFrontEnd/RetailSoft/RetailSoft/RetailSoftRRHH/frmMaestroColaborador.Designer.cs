namespace RetailSoft.RetailSoftRRHH
{
    partial class frmMaestroColaborador
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
            this.lblColaborador = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbIconoColaborador = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tcColaborador = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtIdColaborador = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblIdColaborador = new System.Windows.Forms.Label();
            this.tbBeneficios = new System.Windows.Forms.TabPage();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBeneficiosSeleccionados = new System.Windows.Forms.Label();
            this.dgvBeneficiosColab = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.dgvBeneficiosTodos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoColaborador)).BeginInit();
            this.tcColaborador.SuspendLayout();
            this.tbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tbBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiosColab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiosTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaborador.Location = new System.Drawing.Point(136, 32);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(480, 50);
            this.lblColaborador.TabIndex = 1;
            this.lblColaborador.Text = "Formato de Colaborador";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblColaborador);
            this.panelSuperior.Controls.Add(this.pbIconoColaborador);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(872, 111);
            this.panelSuperior.TabIndex = 1;
            // 
            // pbIconoColaborador
            // 
            this.pbIconoColaborador.Image = global::RetailSoft.Properties.Resources.PerfilHombre;
            this.pbIconoColaborador.Location = new System.Drawing.Point(12, 12);
            this.pbIconoColaborador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIconoColaborador.Name = "pbIconoColaborador";
            this.pbIconoColaborador.Size = new System.Drawing.Size(107, 89);
            this.pbIconoColaborador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconoColaborador.TabIndex = 0;
            this.pbIconoColaborador.TabStop = false;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // tcColaborador
            // 
            this.tcColaborador.Controls.Add(this.tbDatos);
            this.tcColaborador.Controls.Add(this.tbBeneficios);
            this.tcColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcColaborador.Location = new System.Drawing.Point(0, 111);
            this.tcColaborador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcColaborador.Name = "tcColaborador";
            this.tcColaborador.SelectedIndex = 0;
            this.tcColaborador.Size = new System.Drawing.Size(872, 726);
            this.tcColaborador.TabIndex = 38;
            // 
            // tbDatos
            // 
            this.tbDatos.AutoScroll = true;
            this.tbDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDatos.Controls.Add(this.btnEliminar);
            this.tbDatos.Controls.Add(this.dtpHoraSalida);
            this.tbDatos.Controls.Add(this.dtpHoraIngreso);
            this.tbDatos.Controls.Add(this.btnSubirFoto);
            this.tbDatos.Controls.Add(this.btnCancelar);
            this.tbDatos.Controls.Add(this.btnGuardar);
            this.tbDatos.Controls.Add(this.pbFoto);
            this.tbDatos.Controls.Add(this.cboCargo);
            this.tbDatos.Controls.Add(this.dtpFechaNacimiento);
            this.tbDatos.Controls.Add(this.rbFemenino);
            this.tbDatos.Controls.Add(this.rbMasculino);
            this.tbDatos.Controls.Add(this.txtCorreo);
            this.tbDatos.Controls.Add(this.txtTelefono);
            this.tbDatos.Controls.Add(this.txtSalario);
            this.tbDatos.Controls.Add(this.txtApellidoPaterno);
            this.tbDatos.Controls.Add(this.txtApellidoMaterno);
            this.tbDatos.Controls.Add(this.txtNombres);
            this.tbDatos.Controls.Add(this.txtDNI);
            this.tbDatos.Controls.Add(this.txtIdColaborador);
            this.tbDatos.Controls.Add(this.lblFechaNacimiento);
            this.tbDatos.Controls.Add(this.lblGenero);
            this.tbDatos.Controls.Add(this.lblCorreo);
            this.tbDatos.Controls.Add(this.lblTelefono);
            this.tbDatos.Controls.Add(this.lblApellidoMaterno);
            this.tbDatos.Controls.Add(this.lblDni);
            this.tbDatos.Controls.Add(this.lblApellidoPaterno);
            this.tbDatos.Controls.Add(this.lblNombre);
            this.tbDatos.Controls.Add(this.lblHoraSalida);
            this.tbDatos.Controls.Add(this.lblHoraIngreso);
            this.tbDatos.Controls.Add(this.lblCargo);
            this.tbDatos.Controls.Add(this.lblSueldo);
            this.tbDatos.Controls.Add(this.lblIdColaborador);
            this.tbDatos.Location = new System.Drawing.Point(4, 34);
            this.tbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatos.Size = new System.Drawing.Size(864, 688);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos Generales";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(717, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "HH:mm";
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHoraSalida.Location = new System.Drawing.Point(234, 527);
            this.dtpHoraSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(200, 28);
            this.dtpHoraSalida.TabIndex = 69;
            // 
            // dtpHoraIngreso
            // 
            this.dtpHoraIngreso.CustomFormat = "HH:mm";
            this.dtpHoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraIngreso.Location = new System.Drawing.Point(234, 483);
            this.dtpHoraIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraIngreso.Name = "dtpHoraIngreso";
            this.dtpHoraIngreso.ShowUpDown = true;
            this.dtpHoraIngreso.Size = new System.Drawing.Size(200, 28);
            this.dtpHoraIngreso.TabIndex = 68;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirFoto.Image = global::RetailSoft.Properties.Resources.subir;
            this.btnSubirFoto.Location = new System.Drawing.Point(750, 187);
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
            this.btnCancelar.Location = new System.Drawing.Point(473, 605);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 50);
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
            this.btnGuardar.Location = new System.Drawing.Point(250, 607);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 46);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(612, 44);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(222, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 63;
            this.pbFoto.TabStop = false;
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(233, 437);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(227, 30);
            this.cboCargo.TabIndex = 62;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(233, 261);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(338, 28);
            this.dtpFechaNacimiento.TabIndex = 61;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(350, 223);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(110, 26);
            this.rbFemenino.TabIndex = 60;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(233, 223);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(111, 26);
            this.rbMasculino.TabIndex = 59;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(233, 356);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(279, 28);
            this.txtCorreo.TabIndex = 58;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(233, 312);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 28);
            this.txtTelefono.TabIndex = 57;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(233, 398);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(145, 28);
            this.txtSalario.TabIndex = 56;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(233, 135);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(279, 28);
            this.txtApellidoPaterno.TabIndex = 55;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(233, 177);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(279, 28);
            this.txtApellidoMaterno.TabIndex = 54;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(233, 92);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(279, 28);
            this.txtNombres.TabIndex = 53;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(233, 53);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 28);
            this.txtDNI.TabIndex = 52;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtIdColaborador
            // 
            this.txtIdColaborador.Enabled = false;
            this.txtIdColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdColaborador.Location = new System.Drawing.Point(233, 15);
            this.txtIdColaborador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdColaborador.Name = "txtIdColaborador";
            this.txtIdColaborador.Size = new System.Drawing.Size(100, 28);
            this.txtIdColaborador.TabIndex = 51;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(31, 259);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(175, 25);
            this.lblFechaNacimiento.TabIndex = 50;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(121, 221);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(83, 25);
            this.lblGenero.TabIndex = 49;
            this.lblGenero.Text = "Genero:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(128, 357);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(78, 25);
            this.lblCorreo.TabIndex = 48;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(112, 312);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 25);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(41, 177);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(165, 25);
            this.lblApellidoMaterno.TabIndex = 46;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(155, 53);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(51, 25);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(45, 131);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(161, 25);
            this.lblApellidoPaterno.TabIndex = 44;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(109, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 25);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(80, 532);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(120, 25);
            this.lblHoraSalida.TabIndex = 42;
            this.lblHoraSalida.Text = "Hora Salida:";
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIngreso.Location = new System.Drawing.Point(70, 488);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(130, 25);
            this.lblHoraIngreso.TabIndex = 41;
            this.lblHoraIngreso.Text = "Hora Ingreso:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(135, 441);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(72, 25);
            this.lblCargo.TabIndex = 40;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(127, 399);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(79, 25);
            this.lblSueldo.TabIndex = 39;
            this.lblSueldo.Text = "Salario:";
            // 
            // lblIdColaborador
            // 
            this.lblIdColaborador.AutoSize = true;
            this.lblIdColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdColaborador.Location = new System.Drawing.Point(59, 15);
            this.lblIdColaborador.Name = "lblIdColaborador";
            this.lblIdColaborador.Size = new System.Drawing.Size(149, 25);
            this.lblIdColaborador.TabIndex = 38;
            this.lblIdColaborador.Text = "lD Colaborador:";
            // 
            // tbBeneficios
            // 
            this.tbBeneficios.AutoScroll = true;
            this.tbBeneficios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbBeneficios.Controls.Add(this.btnQuitar);
            this.tbBeneficios.Controls.Add(this.btnAgregar);
            this.tbBeneficios.Controls.Add(this.lblBeneficiosSeleccionados);
            this.tbBeneficios.Controls.Add(this.dgvBeneficiosColab);
            this.tbBeneficios.Controls.Add(this.lblIndicacion);
            this.tbBeneficios.Controls.Add(this.dgvBeneficiosTodos);
            this.tbBeneficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeneficios.Location = new System.Drawing.Point(4, 34);
            this.tbBeneficios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBeneficios.Name = "tbBeneficios";
            this.tbBeneficios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBeneficios.Size = new System.Drawing.Size(864, 688);
            this.tbBeneficios.TabIndex = 1;
            this.tbBeneficios.Text = "Beneficios";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(713, 65);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(99, 41);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(595, 65);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBeneficiosSeleccionados
            // 
            this.lblBeneficiosSeleccionados.AutoSize = true;
            this.lblBeneficiosSeleccionados.Location = new System.Drawing.Point(32, 363);
            this.lblBeneficiosSeleccionados.Name = "lblBeneficiosSeleccionados";
            this.lblBeneficiosSeleccionados.Size = new System.Drawing.Size(316, 29);
            this.lblBeneficiosSeleccionados.TabIndex = 4;
            this.lblBeneficiosSeleccionados.Text = "Beneficios Seleccionados";
            // 
            // dgvBeneficiosColab
            // 
            this.dgvBeneficiosColab.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBeneficiosColab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiosColab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvBeneficiosColab.Location = new System.Drawing.Point(37, 423);
            this.dgvBeneficiosColab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBeneficiosColab.Name = "dgvBeneficiosColab";
            this.dgvBeneficiosColab.RowHeadersWidth = 51;
            this.dgvBeneficiosColab.RowTemplate.Height = 24;
            this.dgvBeneficiosColab.Size = new System.Drawing.Size(775, 193);
            this.dgvBeneficiosColab.TabIndex = 3;
            this.dgvBeneficiosColab.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBeneficiosColab_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 185;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 540;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(32, 65);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(506, 29);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "Seleccione los beneficios del colaborador";
            // 
            // dgvBeneficiosTodos
            // 
            this.dgvBeneficiosTodos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvBeneficiosTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiosTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion});
            this.dgvBeneficiosTodos.Location = new System.Drawing.Point(37, 128);
            this.dgvBeneficiosTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBeneficiosTodos.Name = "dgvBeneficiosTodos";
            this.dgvBeneficiosTodos.RowHeadersWidth = 51;
            this.dgvBeneficiosTodos.RowTemplate.Height = 24;
            this.dgvBeneficiosTodos.Size = new System.Drawing.Size(775, 193);
            this.dgvBeneficiosTodos.TabIndex = 0;
            this.dgvBeneficiosTodos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBeneficiosTodos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 185;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 540;
            // 
            // frmMaestroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 837);
            this.Controls.Add(this.tcColaborador);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMaestroColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Formulario Formato de Colaborador";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoColaborador)).EndInit();
            this.tcColaborador.ResumeLayout(false);
            this.tbDatos.ResumeLayout(false);
            this.tbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tbBeneficios.ResumeLayout(false);
            this.tbBeneficios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiosColab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiosTodos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pbIconoColaborador;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.TabControl tcColaborador;
        private System.Windows.Forms.TabPage tbDatos;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraIngreso;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtIdColaborador;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblIdColaborador;
        private System.Windows.Forms.TabPage tbBeneficios;
        private System.Windows.Forms.DataGridView dgvBeneficiosTodos;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.DataGridView dgvBeneficiosColab;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblBeneficiosSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnEliminar;
    }
}