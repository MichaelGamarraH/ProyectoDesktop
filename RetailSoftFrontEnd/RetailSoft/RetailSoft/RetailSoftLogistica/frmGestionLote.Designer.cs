namespace RetailSoft.RetailSoftLogistica
{
    partial class frmGestionLote
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
            this.components = new System.ComponentModel.Container();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblGestionLotes = new System.Windows.Forms.Label();
            this.pbGestionLotes = new System.Windows.Forms.PictureBox();
            this.panelBotoneria = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscarLote = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.rbFechaLlegada = new System.Windows.Forms.RadioButton();
            this.rbFechaCompra = new System.Windows.Forms.RadioButton();
            this.btnAplicarFiltroFecha = new System.Windows.Forms.Button();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.lblTituloDgv = new System.Windows.Forms.Label();
            this.TimerLotes = new System.Windows.Forms.Timer(this.components);
            this.idLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestionLotes)).BeginInit();
            this.panelBotoneria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblGestionLotes);
            this.panelSuperior.Controls.Add(this.pbGestionLotes);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1120, 90);
            this.panelSuperior.TabIndex = 15;
            // 
            // lblGestionLotes
            // 
            this.lblGestionLotes.AutoSize = true;
            this.lblGestionLotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGestionLotes.Location = new System.Drawing.Point(95, 25);
            this.lblGestionLotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionLotes.Name = "lblGestionLotes";
            this.lblGestionLotes.Size = new System.Drawing.Size(260, 40);
            this.lblGestionLotes.TabIndex = 1;
            this.lblGestionLotes.Text = "Gestión de lotes\r\n";
            // 
            // pbGestionLotes
            // 
            this.pbGestionLotes.Image = global::RetailSoft.Properties.Resources.icono_lote;
            this.pbGestionLotes.Location = new System.Drawing.Point(11, 10);
            this.pbGestionLotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbGestionLotes.Name = "pbGestionLotes";
            this.pbGestionLotes.Size = new System.Drawing.Size(79, 72);
            this.pbGestionLotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGestionLotes.TabIndex = 0;
            this.pbGestionLotes.TabStop = false;
            // 
            // panelBotoneria
            // 
            this.panelBotoneria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoneria.Controls.Add(this.btnSeleccionar);
            this.panelBotoneria.Controls.Add(this.btnNuevo);
            this.panelBotoneria.Controls.Add(this.txtBuscarLote);
            this.panelBotoneria.Controls.Add(this.btnBuscar);
            this.panelBotoneria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoneria.Location = new System.Drawing.Point(0, 90);
            this.panelBotoneria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBotoneria.Name = "panelBotoneria";
            this.panelBotoneria.Size = new System.Drawing.Size(1120, 68);
            this.panelBotoneria.TabIndex = 39;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(985, 22);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 29);
            this.btnSeleccionar.TabIndex = 49;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(33, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(79, 29);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscarLote
            // 
            this.txtBuscarLote.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLote.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarLote.Location = new System.Drawing.Point(391, 22);
            this.txtBuscarLote.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuscarLote.Name = "txtBuscarLote";
            this.txtBuscarLote.Size = new System.Drawing.Size(448, 28);
            this.txtBuscarLote.TabIndex = 29;
            this.txtBuscarLote.Text = "Buscar por ID del lote, proveedor o almacén...";
            this.txtBuscarLote.Enter += new System.EventHandler(this.txtBuscarLote_Enter);
            this.txtBuscarLote.Leave += new System.EventHandler(this.txtBuscarLote_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::RetailSoft.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(865, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 36);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvLotes
            // 
            this.dgvLotes.AllowUserToAddRows = false;
            this.dgvLotes.AllowUserToDeleteRows = false;
            this.dgvLotes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLote,
            this.Producto,
            this.Proveedor,
            this.Almacen,
            this.FechaCompra,
            this.FechaLlegada,
            this.CostoTotal,
            this.EstadoLote});
            this.dgvLotes.Location = new System.Drawing.Point(190, 204);
            this.dgvLotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.RowHeadersWidth = 51;
            this.dgvLotes.RowTemplate.Height = 24;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(919, 401);
            this.dgvLotes.TabIndex = 40;
            this.dgvLotes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLotes_CellFormatting);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(21, 34);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(61, 21);
            this.lblDesde.TabIndex = 42;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(25, 67);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(114, 28);
            this.dtpDesde.TabIndex = 43;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(21, 103);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(57, 21);
            this.lblHasta.TabIndex = 44;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(25, 136);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(116, 28);
            this.dtpHasta.TabIndex = 45;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.rbFechaLlegada);
            this.gbFecha.Controls.Add(this.rbFechaCompra);
            this.gbFecha.Controls.Add(this.btnAplicarFiltroFecha);
            this.gbFecha.Controls.Add(this.dtpDesde);
            this.gbFecha.Controls.Add(this.dtpHasta);
            this.gbFecha.Controls.Add(this.lblDesde);
            this.gbFecha.Controls.Add(this.lblHasta);
            this.gbFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(9, 170);
            this.gbFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFecha.Size = new System.Drawing.Size(160, 272);
            this.gbFecha.TabIndex = 46;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // rbFechaLlegada
            // 
            this.rbFechaLlegada.AutoSize = true;
            this.rbFechaLlegada.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaLlegada.Location = new System.Drawing.Point(85, 185);
            this.rbFechaLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.rbFechaLlegada.Name = "rbFechaLlegada";
            this.rbFechaLlegada.Size = new System.Drawing.Size(66, 20);
            this.rbFechaLlegada.TabIndex = 48;
            this.rbFechaLlegada.TabStop = true;
            this.rbFechaLlegada.Text = "Llegada";
            this.rbFechaLlegada.UseVisualStyleBackColor = true;
            // 
            // rbFechaCompra
            // 
            this.rbFechaCompra.AutoSize = true;
            this.rbFechaCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechaCompra.Location = new System.Drawing.Point(8, 185);
            this.rbFechaCompra.Margin = new System.Windows.Forms.Padding(2);
            this.rbFechaCompra.Name = "rbFechaCompra";
            this.rbFechaCompra.Size = new System.Drawing.Size(66, 20);
            this.rbFechaCompra.TabIndex = 47;
            this.rbFechaCompra.TabStop = true;
            this.rbFechaCompra.Text = "Compra";
            this.rbFechaCompra.UseVisualStyleBackColor = true;
            // 
            // btnAplicarFiltroFecha
            // 
            this.btnAplicarFiltroFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnAplicarFiltroFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltroFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAplicarFiltroFecha.Location = new System.Drawing.Point(42, 214);
            this.btnAplicarFiltroFecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAplicarFiltroFecha.Name = "btnAplicarFiltroFecha";
            this.btnAplicarFiltroFecha.Size = new System.Drawing.Size(79, 52);
            this.btnAplicarFiltroFecha.TabIndex = 46;
            this.btnAplicarFiltroFecha.Text = "Aplicar Filtro";
            this.btnAplicarFiltroFecha.UseVisualStyleBackColor = false;
            this.btnAplicarFiltroFecha.Click += new System.EventHandler(this.btnAplicarFiltroFecha_Click);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(8, 445);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(104, 21);
            this.lblProveedores.TabIndex = 47;
            this.lblProveedores.Text = "Proveedores";
            // 
            // panelProveedores
            // 
            this.panelProveedores.AutoScroll = true;
            this.panelProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProveedores.Location = new System.Drawing.Point(11, 473);
            this.panelProveedores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(159, 133);
            this.panelProveedores.TabIndex = 48;
            // 
            // lblTituloDgv
            // 
            this.lblTituloDgv.AutoSize = true;
            this.lblTituloDgv.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDgv.Location = new System.Drawing.Point(186, 170);
            this.lblTituloDgv.Name = "lblTituloDgv";
            this.lblTituloDgv.Size = new System.Drawing.Size(153, 22);
            this.lblTituloDgv.TabIndex = 49;
            this.lblTituloDgv.Text = "Lotes disponibles";
            // 
            // TimerLotes
            // 
            this.TimerLotes.Tick += new System.EventHandler(this.TimerLotes_Tick);
            // 
            // idLote
            // 
            this.idLote.HeaderText = "ID";
            this.idLote.MinimumWidth = 6;
            this.idLote.Name = "idLote";
            this.idLote.ReadOnly = true;
            this.idLote.Width = 60;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 130;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 125;
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "Almacén";
            this.Almacen.MinimumWidth = 6;
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            this.Almacen.Width = 125;
            // 
            // FechaCompra
            // 
            this.FechaCompra.HeaderText = "Fecha de Compra";
            this.FechaCompra.MinimumWidth = 6;
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            this.FechaCompra.Width = 120;
            // 
            // FechaLlegada
            // 
            this.FechaLlegada.HeaderText = "Fecha de Llegada";
            this.FechaLlegada.MinimumWidth = 6;
            this.FechaLlegada.Name = "FechaLlegada";
            this.FechaLlegada.ReadOnly = true;
            this.FechaLlegada.Width = 120;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total (S./)";
            this.CostoTotal.MinimumWidth = 6;
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            this.CostoTotal.Width = 90;
            // 
            // EstadoLote
            // 
            this.EstadoLote.HeaderText = "Estado del lote";
            this.EstadoLote.MinimumWidth = 6;
            this.EstadoLote.Name = "EstadoLote";
            this.EstadoLote.Width = 80;
            // 
            // frmGestionLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1120, 621);
            this.Controls.Add(this.lblTituloDgv);
            this.Controls.Add(this.panelProveedores);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.dgvLotes);
            this.Controls.Add(this.panelBotoneria);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmGestionLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de lotes";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestionLotes)).EndInit();
            this.panelBotoneria.ResumeLayout(false);
            this.panelBotoneria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGestionLotes;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblGestionLotes;
        private System.Windows.Forms.Panel panelBotoneria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscarLote;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Button btnAplicarFiltroFecha;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.RadioButton rbFechaLlegada;
        private System.Windows.Forms.RadioButton rbFechaCompra;
        private System.Windows.Forms.Label lblTituloDgv;
        private System.Windows.Forms.Timer TimerLotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoLote;
    }
}