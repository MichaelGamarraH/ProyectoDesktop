namespace RetailSoft.RetailSoftRRHH
{
    partial class frmMaestroCandidato
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tcColaborador = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.btnDescargarCV = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbDocumento = new System.Windows.Forms.PictureBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.btnCargarCV = new System.Windows.Forms.Button();
            this.txtIDCandidato = new System.Windows.Forms.TextBox();
            this.lblIdCandidato = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbBeneficios = new System.Windows.Forms.TabPage();
            this.lblTrazabilidad = new System.Windows.Forms.Label();
            this.dgvTrazabilidad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.pbIconoColaborador = new System.Windows.Forms.PictureBox();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            this.panelContenedor.SuspendLayout();
            this.tcColaborador.SuspendLayout();
            this.tbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).BeginInit();
            this.tbBeneficios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrazabilidad)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.tcColaborador);
            this.panelContenedor.Controls.Add(this.panelSuperior);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1005, 865);
            this.panelContenedor.TabIndex = 2;
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
            this.tcColaborador.Size = new System.Drawing.Size(1005, 754);
            this.tcColaborador.TabIndex = 89;
            // 
            // tbDatos
            // 
            this.tbDatos.AutoScroll = true;
            this.tbDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDatos.Controls.Add(this.btnDescargarCV);
            this.tbDatos.Controls.Add(this.txtCorreo);
            this.tbDatos.Controls.Add(this.lblCorreo);
            this.tbDatos.Controls.Add(this.txtApellidoMaterno);
            this.tbDatos.Controls.Add(this.lblApellidoMaterno);
            this.tbDatos.Controls.Add(this.btnCancelar);
            this.tbDatos.Controls.Add(this.pbDocumento);
            this.tbDatos.Controls.Add(this.cboEstado);
            this.tbDatos.Controls.Add(this.txtTelefono);
            this.tbDatos.Controls.Add(this.dtpFechaNacimiento);
            this.tbDatos.Controls.Add(this.rbFemenino);
            this.tbDatos.Controls.Add(this.rbMasculino);
            this.tbDatos.Controls.Add(this.txtApellidoPaterno);
            this.tbDatos.Controls.Add(this.txtNombre);
            this.tbDatos.Controls.Add(this.lblEstado);
            this.tbDatos.Controls.Add(this.lblTelefono);
            this.tbDatos.Controls.Add(this.lblGenero);
            this.tbDatos.Controls.Add(this.lblFechaNacimiento);
            this.tbDatos.Controls.Add(this.lblApellidoPaterno);
            this.tbDatos.Controls.Add(this.lblNombre);
            this.tbDatos.Controls.Add(this.txtDNI);
            this.tbDatos.Controls.Add(this.lblDNI);
            this.tbDatos.Controls.Add(this.txtObservacion);
            this.tbDatos.Controls.Add(this.lblObservacion);
            this.tbDatos.Controls.Add(this.btnCargarCV);
            this.tbDatos.Controls.Add(this.txtIDCandidato);
            this.tbDatos.Controls.Add(this.lblIdCandidato);
            this.tbDatos.Controls.Add(this.btnGuardar);
            this.tbDatos.Location = new System.Drawing.Point(4, 34);
            this.tbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDatos.Size = new System.Drawing.Size(997, 716);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos Generales";
            // 
            // btnDescargarCV
            // 
            this.btnDescargarCV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDescargarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarCV.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarCV.Location = new System.Drawing.Point(723, 336);
            this.btnDescargarCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescargarCV.Name = "btnDescargarCV";
            this.btnDescargarCV.Size = new System.Drawing.Size(236, 39);
            this.btnDescargarCV.TabIndex = 116;
            this.btnDescargarCV.Text = "Descargar CV";
            this.btnDescargarCV.UseVisualStyleBackColor = false;
            this.btnDescargarCV.Click += new System.EventHandler(this.btnDescargarCV_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(253, 377);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(279, 30);
            this.txtCorreo.TabIndex = 115;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(144, 380);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(78, 25);
            this.lblCorreo.TabIndex = 114;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(253, 213);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(291, 30);
            this.txtApellidoMaterno.TabIndex = 113;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(49, 217);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(165, 25);
            this.lblApellidoMaterno.TabIndex = 112;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(532, 608);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 43);
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbDocumento
            // 
            this.pbDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDocumento.Location = new System.Drawing.Point(723, 28);
            this.pbDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDocumento.Name = "pbDocumento";
            this.pbDocumento.Size = new System.Drawing.Size(237, 212);
            this.pbDocumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDocumento.TabIndex = 110;
            this.pbDocumento.TabStop = false;
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(253, 428);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(279, 33);
            this.cboEstado.TabIndex = 109;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(253, 332);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(279, 30);
            this.txtTelefono.TabIndex = 108;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(253, 290);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(425, 30);
            this.dtpFechaNacimiento.TabIndex = 107;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(403, 252);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(120, 29);
            this.rbFemenino.TabIndex = 106;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(253, 252);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(122, 29);
            this.rbMasculino.TabIndex = 105;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(253, 169);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(291, 30);
            this.txtApellidoPaterno.TabIndex = 104;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(253, 127);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 30);
            this.txtNombre.TabIndex = 103;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(140, 432);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 102;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(129, 336);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 25);
            this.lblTelefono.TabIndex = 101;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(141, 255);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(83, 25);
            this.lblGenero.TabIndex = 100;
            this.lblGenero.Text = "Genero:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(21, 295);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(202, 25);
            this.lblFechaNacimiento.TabIndex = 99;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(53, 172);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(161, 25);
            this.lblApellidoPaterno.TabIndex = 98;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(135, 130);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 97;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(253, 85);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(244, 30);
            this.txtDNI.TabIndex = 96;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(171, 89);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(51, 25);
            this.lblDNI.TabIndex = 95;
            this.lblDNI.Text = "DNI:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(253, 475);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(425, 107);
            this.txtObservacion.TabIndex = 94;
            this.txtObservacion.Text = "";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(99, 478);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(129, 25);
            this.lblObservacion.TabIndex = 93;
            this.lblObservacion.Text = "Observación:";
            // 
            // btnCargarCV
            // 
            this.btnCargarCV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCV.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCV.Location = new System.Drawing.Point(723, 281);
            this.btnCargarCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarCV.Name = "btnCargarCV";
            this.btnCargarCV.Size = new System.Drawing.Size(236, 39);
            this.btnCargarCV.TabIndex = 92;
            this.btnCargarCV.Text = "Subir CV";
            this.btnCargarCV.UseVisualStyleBackColor = false;
            this.btnCargarCV.Click += new System.EventHandler(this.btnCargarCV_Click);
            // 
            // txtIDCandidato
            // 
            this.txtIDCandidato.Enabled = false;
            this.txtIDCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCandidato.Location = new System.Drawing.Point(253, 43);
            this.txtIDCandidato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDCandidato.Name = "txtIDCandidato";
            this.txtIDCandidato.Size = new System.Drawing.Size(96, 30);
            this.txtIDCandidato.TabIndex = 91;
            // 
            // lblIdCandidato
            // 
            this.lblIdCandidato.AutoSize = true;
            this.lblIdCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCandidato.Location = new System.Drawing.Point(93, 43);
            this.lblIdCandidato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCandidato.Name = "lblIdCandidato";
            this.lblIdCandidato.Size = new System.Drawing.Size(129, 25);
            this.lblIdCandidato.TabIndex = 90;
            this.lblIdCandidato.Text = "Id Candidato:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(178)))), ((int)(((byte)(250)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::RetailSoft.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(291, 608);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 43);
            this.btnGuardar.TabIndex = 89;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbBeneficios
            // 
            this.tbBeneficios.AutoScroll = true;
            this.tbBeneficios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbBeneficios.Controls.Add(this.lblTrazabilidad);
            this.tbBeneficios.Controls.Add(this.dgvTrazabilidad);
            this.tbBeneficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeneficios.Location = new System.Drawing.Point(4, 34);
            this.tbBeneficios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBeneficios.Name = "tbBeneficios";
            this.tbBeneficios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBeneficios.Size = new System.Drawing.Size(997, 716);
            this.tbBeneficios.TabIndex = 1;
            this.tbBeneficios.Text = "Trazabilidad";
            // 
            // lblTrazabilidad
            // 
            this.lblTrazabilidad.AutoSize = true;
            this.lblTrazabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrazabilidad.Location = new System.Drawing.Point(20, 26);
            this.lblTrazabilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrazabilidad.Name = "lblTrazabilidad";
            this.lblTrazabilidad.Size = new System.Drawing.Size(309, 31);
            this.lblTrazabilidad.TabIndex = 91;
            this.lblTrazabilidad.Text = "Tracking del candidato";
            // 
            // dgvTrazabilidad
            // 
            this.dgvTrazabilidad.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvTrazabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrazabilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Fecha,
            this.Observacion});
            this.dgvTrazabilidad.Location = new System.Drawing.Point(27, 75);
            this.dgvTrazabilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrazabilidad.Name = "dgvTrazabilidad";
            this.dgvTrazabilidad.RowHeadersWidth = 51;
            this.dgvTrazabilidad.RowTemplate.Height = 24;
            this.dgvTrazabilidad.Size = new System.Drawing.Size(945, 505);
            this.dgvTrazabilidad.TabIndex = 4;
            this.dgvTrazabilidad.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTrazabilidad_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // Fecha
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 120;
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observación";
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 350;
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
            this.panelSuperior.Size = new System.Drawing.Size(1005, 111);
            this.panelSuperior.TabIndex = 65;
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColaborador.Location = new System.Drawing.Point(136, 32);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(381, 50);
            this.lblColaborador.TabIndex = 1;
            this.lblColaborador.Text = "Formato Candidato";
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
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "archivoCV";
            // 
            // sfdArchivo
            // 
            this.sfdArchivo.FileName = "archivoCV";
            // 
            // frmMaestroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 865);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMaestroCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Formato Candidato";
            this.panelContenedor.ResumeLayout(false);
            this.tcColaborador.ResumeLayout(false);
            this.tbDatos.ResumeLayout(false);
            this.tbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).EndInit();
            this.tbBeneficios.ResumeLayout(false);
            this.tbBeneficios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrazabilidad)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoColaborador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.PictureBox pbIconoColaborador;
        private System.Windows.Forms.TabControl tcColaborador;
        private System.Windows.Forms.TabPage tbDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbDocumento;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnCargarCV;
        private System.Windows.Forms.TextBox txtIDCandidato;
        private System.Windows.Forms.Label lblIdCandidato;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tbBeneficios;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.Button btnDescargarCV;
        private System.Windows.Forms.DataGridView dgvTrazabilidad;
        private System.Windows.Forms.Label lblTrazabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
    }
}