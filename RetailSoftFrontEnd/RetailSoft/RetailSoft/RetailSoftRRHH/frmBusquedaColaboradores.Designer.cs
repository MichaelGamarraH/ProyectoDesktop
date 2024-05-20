namespace RetailSoft.RetailSoftRRHH
{
    partial class frmBusquedaColaboradores
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbIconoEvento = new System.Windows.Forms.PictureBox();
            this.lblModuloActual = new System.Windows.Forms.Label();
            this.panelColaboradores = new System.Windows.Forms.Panel();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.btnPorDNI = new System.Windows.Forms.Button();
            this.panelBotoneria = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoEvento)).BeginInit();
            this.panelBotoneria.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.pbIconoEvento);
            this.panelSuperior.Controls.Add(this.lblModuloActual);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(952, 90);
            this.panelSuperior.TabIndex = 3;
            // 
            // pbIconoEvento
            // 
            this.pbIconoEvento.Image = global::RetailSoft.Properties.Resources.PerfilHombre;
            this.pbIconoEvento.Location = new System.Drawing.Point(13, 11);
            this.pbIconoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.pbIconoEvento.Name = "pbIconoEvento";
            this.pbIconoEvento.Size = new System.Drawing.Size(78, 67);
            this.pbIconoEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconoEvento.TabIndex = 1;
            this.pbIconoEvento.TabStop = false;
            // 
            // lblModuloActual
            // 
            this.lblModuloActual.AutoSize = true;
            this.lblModuloActual.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModuloActual.Location = new System.Drawing.Point(94, 22);
            this.lblModuloActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuloActual.Name = "lblModuloActual";
            this.lblModuloActual.Size = new System.Drawing.Size(398, 41);
            this.lblModuloActual.TabIndex = 0;
            this.lblModuloActual.Text = "Búsqueda de empleados";
            // 
            // panelColaboradores
            // 
            this.panelColaboradores.AutoScroll = true;
            this.panelColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColaboradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColaboradores.Location = new System.Drawing.Point(172, 211);
            this.panelColaboradores.Name = "panelColaboradores";
            this.panelColaboradores.Size = new System.Drawing.Size(780, 239);
            this.panelColaboradores.TabIndex = 4;
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnMarcarTodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcarTodos.FlatAppearance.BorderSize = 0;
            this.btnMarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMarcarTodos.Location = new System.Drawing.Point(0, 0);
            this.btnMarcarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(172, 43);
            this.btnMarcarTodos.TabIndex = 8;
            this.btnMarcarTodos.Text = "Marcar Todos";
            this.btnMarcarTodos.UseVisualStyleBackColor = false;
            this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
            // 
            // btnPorDNI
            // 
            this.btnPorDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnPorDNI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorDNI.FlatAppearance.BorderSize = 0;
            this.btnPorDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorDNI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPorDNI.Location = new System.Drawing.Point(0, 43);
            this.btnPorDNI.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorDNI.Name = "btnPorDNI";
            this.btnPorDNI.Size = new System.Drawing.Size(172, 43);
            this.btnPorDNI.TabIndex = 9;
            this.btnPorDNI.Text = "Por DNI";
            this.btnPorDNI.UseVisualStyleBackColor = false;
            this.btnPorDNI.Click += new System.EventHandler(this.btnPorDNI_Click);
            // 
            // panelBotoneria
            // 
            this.panelBotoneria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoneria.Controls.Add(this.btnCancelar);
            this.panelBotoneria.Controls.Add(this.lblCargo);
            this.panelBotoneria.Controls.Add(this.lblOpciones);
            this.panelBotoneria.Controls.Add(this.lblDNI);
            this.panelBotoneria.Controls.Add(this.lblApellido);
            this.panelBotoneria.Controls.Add(this.lblNombre);
            this.panelBotoneria.Controls.Add(this.btnSeleccionar);
            this.panelBotoneria.Controls.Add(this.lblIndicacion);
            this.panelBotoneria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoneria.Location = new System.Drawing.Point(0, 90);
            this.panelBotoneria.Name = "panelBotoneria";
            this.panelBotoneria.Size = new System.Drawing.Size(952, 121);
            this.panelBotoneria.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(624, 21);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(694, 85);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(57, 20);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(44, 85);
            this.lblOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(84, 20);
            this.lblOpciones.TabIndex = 7;
            this.lblOpciones.Text = "Opciones";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(548, 85);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 20);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(189, 85);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 20);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(377, 85);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombres";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(792, 21);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(127, 34);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(23, 21);
            this.lblIndicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(288, 25);
            this.lblIndicacion.TabIndex = 3;
            this.lblIndicacion.Text = "Seleccione a los invitados";
            // 
            // panelFiltros
            // 
            this.panelFiltros.AutoScroll = true;
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.btnAlfabetico);
            this.panelFiltros.Controls.Add(this.btnPorDNI);
            this.panelFiltros.Controls.Add(this.btnMarcarTodos);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFiltros.Location = new System.Drawing.Point(0, 211);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(172, 239);
            this.panelFiltros.TabIndex = 5;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnLimpiarFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(0, 136);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(172, 50);
            this.btnLimpiarFiltros.TabIndex = 10;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnAlfabetico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlfabetico.FlatAppearance.BorderSize = 0;
            this.btnAlfabetico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabetico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlfabetico.Location = new System.Drawing.Point(0, 86);
            this.btnAlfabetico.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(172, 50);
            this.btnAlfabetico.TabIndex = 7;
            this.btnAlfabetico.Text = "Alfabéticamente";
            this.btnAlfabetico.UseVisualStyleBackColor = false;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // frmBusquedaColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.panelColaboradores);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelBotoneria);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmBusquedaColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaEmpleados";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoEvento)).EndInit();
            this.panelBotoneria.ResumeLayout(false);
            this.panelBotoneria.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pbIconoEvento;
        private System.Windows.Forms.Label lblModuloActual;
        private System.Windows.Forms.Panel panelColaboradores;
        private System.Windows.Forms.Panel panelBotoneria;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Button btnPorDNI;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnCancelar;
    }
}