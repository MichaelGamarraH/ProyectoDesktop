namespace RetailSoft.RetailSoftRRHH
{
    partial class frmGestionReclutamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbGestColaboradores = new System.Windows.Forms.PictureBox();
            this.lblModuloActual = new System.Windows.Forms.Label();
            this.panelBotoneria = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInvitados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.rbFechaLimite = new System.Windows.Forms.RadioButton();
            this.rbFechaPublicacion = new System.Windows.Forms.RadioButton();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnAplicarFiltroFecha = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestColaboradores)).BeginInit();
            this.panelBotoneria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.pbGestColaboradores);
            this.panelSuperior.Controls.Add(this.lblModuloActual);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1219, 111);
            this.panelSuperior.TabIndex = 2;
            // 
            // pbGestColaboradores
            // 
            this.pbGestColaboradores.Image = global::RetailSoft.Properties.Resources.RRHH;
            this.pbGestColaboradores.Location = new System.Drawing.Point(12, 12);
            this.pbGestColaboradores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbGestColaboradores.Name = "pbGestColaboradores";
            this.pbGestColaboradores.Size = new System.Drawing.Size(107, 89);
            this.pbGestColaboradores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGestColaboradores.TabIndex = 1;
            this.pbGestColaboradores.TabStop = false;
            // 
            // lblModuloActual
            // 
            this.lblModuloActual.AutoSize = true;
            this.lblModuloActual.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModuloActual.Location = new System.Drawing.Point(125, 27);
            this.lblModuloActual.Name = "lblModuloActual";
            this.lblModuloActual.Size = new System.Drawing.Size(521, 50);
            this.lblModuloActual.TabIndex = 0;
            this.lblModuloActual.Text = "Gestión de Reclutamiento";
            // 
            // panelBotoneria
            // 
            this.panelBotoneria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoneria.Controls.Add(this.txtBuscar);
            this.panelBotoneria.Controls.Add(this.btnSeleccionar);
            this.panelBotoneria.Controls.Add(this.btnBuscar);
            this.panelBotoneria.Controls.Add(this.btnNuevo);
            this.panelBotoneria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoneria.Location = new System.Drawing.Point(0, 111);
            this.panelBotoneria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotoneria.Name = "panelBotoneria";
            this.panelBotoneria.Size = new System.Drawing.Size(1219, 84);
            this.panelBotoneria.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(332, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(467, 30);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.Text = "Buscar Puesto de Trabajo por nombre...";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(1001, 22);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(171, 42);
            this.btnSeleccionar.TabIndex = 7;
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
            this.btnBuscar.Location = new System.Drawing.Point(805, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(55, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(128, 37);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvPuestos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPuestos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.FechaLimite,
            this.TotalInvitados});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuestos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuestos.Location = new System.Drawing.Point(257, 195);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPuestos.Name = "dgvPuestos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.Size = new System.Drawing.Size(962, 510);
            this.dgvPuestos.TabIndex = 5;
            this.dgvPuestos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPuestos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 280;
            // 
            // Fecha
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "Fecha Publicación";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 130;
            // 
            // FechaLimite
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaLimite.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaLimite.HeaderText = "Fecha Limite";
            this.FechaLimite.MinimumWidth = 6;
            this.FechaLimite.Name = "FechaLimite";
            this.FechaLimite.Width = 130;
            // 
            // TotalInvitados
            // 
            this.TotalInvitados.HeaderText = "Correo Responsable";
            this.TotalInvitados.MinimumWidth = 6;
            this.TotalInvitados.Name = "TotalInvitados";
            this.TotalInvitados.Width = 280;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.rbFechaLimite);
            this.panelFiltros.Controls.Add(this.rbFechaPublicacion);
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltro);
            this.panelFiltros.Controls.Add(this.lblBusqueda);
            this.panelFiltros.Controls.Add(this.btnAplicarFiltroFecha);
            this.panelFiltros.Controls.Add(this.dtpDesde);
            this.panelFiltros.Controls.Add(this.dtpHasta);
            this.panelFiltros.Controls.Add(this.lblDesde);
            this.panelFiltros.Controls.Add(this.lblHasta);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFiltros.Location = new System.Drawing.Point(0, 195);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(257, 510);
            this.panelFiltros.TabIndex = 6;
            // 
            // rbFechaLimite
            // 
            this.rbFechaLimite.AutoSize = true;
            this.rbFechaLimite.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaLimite.Location = new System.Drawing.Point(68, 276);
            this.rbFechaLimite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFechaLimite.Name = "rbFechaLimite";
            this.rbFechaLimite.Size = new System.Drawing.Size(71, 24);
            this.rbFechaLimite.TabIndex = 55;
            this.rbFechaLimite.TabStop = true;
            this.rbFechaLimite.Text = "Límite";
            this.rbFechaLimite.UseVisualStyleBackColor = true;
            // 
            // rbFechaPublicacion
            // 
            this.rbFechaPublicacion.AutoSize = true;
            this.rbFechaPublicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaPublicacion.Location = new System.Drawing.Point(68, 246);
            this.rbFechaPublicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFechaPublicacion.Name = "rbFechaPublicacion";
            this.rbFechaPublicacion.Size = new System.Drawing.Size(109, 24);
            this.rbFechaPublicacion.TabIndex = 54;
            this.rbFechaPublicacion.TabStop = true;
            this.rbFechaPublicacion.Text = "Publicación";
            this.rbFechaPublicacion.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(43, 411);
            this.btnLimpiarFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(167, 81);
            this.btnLimpiarFiltro.TabIndex = 53;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(12, 18);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(217, 27);
            this.lblBusqueda.TabIndex = 52;
            this.lblBusqueda.Text = "BUSCAR POR FECHA";
            // 
            // btnAplicarFiltroFecha
            // 
            this.btnAplicarFiltroFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnAplicarFiltroFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltroFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltroFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAplicarFiltroFecha.Location = new System.Drawing.Point(43, 319);
            this.btnAplicarFiltroFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAplicarFiltroFecha.Name = "btnAplicarFiltroFecha";
            this.btnAplicarFiltroFecha.Size = new System.Drawing.Size(167, 81);
            this.btnAplicarFiltroFecha.TabIndex = 51;
            this.btnAplicarFiltroFecha.Text = "Aplicar Filtro";
            this.btnAplicarFiltroFecha.UseVisualStyleBackColor = false;
            this.btnAplicarFiltroFecha.Click += new System.EventHandler(this.btnAplicarFiltroFecha_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(33, 108);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(187, 29);
            this.dtpDesde.TabIndex = 48;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(33, 193);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(184, 29);
            this.dtpHasta.TabIndex = 50;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(27, 68);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(76, 27);
            this.lblDesde.TabIndex = 47;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(27, 153);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(70, 27);
            this.lblHasta.TabIndex = 49;
            this.lblHasta.Text = "Hasta:";
            // 
            // frmGestionReclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 705);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelBotoneria);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionReclutamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Gestión de Reclutamiento";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestColaboradores)).EndInit();
            this.panelBotoneria.ResumeLayout(false);
            this.panelBotoneria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pbGestColaboradores;
        private System.Windows.Forms.Label lblModuloActual;
        private System.Windows.Forms.Panel panelBotoneria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnAplicarFiltroFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInvitados;
        private System.Windows.Forms.RadioButton rbFechaLimite;
        private System.Windows.Forms.RadioButton rbFechaPublicacion;
    }
}