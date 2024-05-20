namespace RetailSoft.RetailSoftLogistica
{
    partial class frmGestionProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblGestionProducto = new System.Windows.Forms.Label();
            this.pbGestionProductos = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.panelBotoneria = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.panelMarcas = new System.Windows.Forms.Panel();
            this.lblTituloDgv = new System.Windows.Forms.Label();
            this.TimerProductos = new System.Windows.Forms.Timer(this.components);
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestionProductos)).BeginInit();
            this.panelBotoneria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Nombre,
            this.Marca,
            this.Categoria,
            this.Subcategoria,
            this.Precio,
            this.Stock});
            this.dgvProductos.Location = new System.Drawing.Point(175, 208);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 30;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(850, 380);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblGestionProducto);
            this.panelSuperior.Controls.Add(this.pbGestionProductos);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1032, 90);
            this.panelSuperior.TabIndex = 14;
            // 
            // lblGestionProducto
            // 
            this.lblGestionProducto.AutoSize = true;
            this.lblGestionProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGestionProducto.Location = new System.Drawing.Point(95, 25);
            this.lblGestionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionProducto.Name = "lblGestionProducto";
            this.lblGestionProducto.Size = new System.Drawing.Size(342, 40);
            this.lblGestionProducto.TabIndex = 1;
            this.lblGestionProducto.Text = "Gestión de productos";
            // 
            // pbGestionProductos
            // 
            this.pbGestionProductos.Image = global::RetailSoft.Properties.Resources.icono_producto;
            this.pbGestionProductos.Location = new System.Drawing.Point(11, 10);
            this.pbGestionProductos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbGestionProductos.Name = "pbGestionProductos";
            this.pbGestionProductos.Size = new System.Drawing.Size(79, 72);
            this.pbGestionProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGestionProductos.TabIndex = 0;
            this.pbGestionProductos.TabStop = false;
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
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarProducto.Location = new System.Drawing.Point(302, 23);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(448, 28);
            this.txtBuscarProducto.TabIndex = 29;
            this.txtBuscarProducto.Text = "Buscar por ID o nombre del producto...";
            this.txtBuscarProducto.Enter += new System.EventHandler(this.txtBuscarProducto_Enter);
            this.txtBuscarProducto.Leave += new System.EventHandler(this.txtBuscarProducto_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::RetailSoft.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(754, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 36);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(9, 378);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 21);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Marcas";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(9, 192);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(91, 21);
            this.lblCategorias.TabIndex = 33;
            this.lblCategorias.Text = "Categorías";
            // 
            // panelBotoneria
            // 
            this.panelBotoneria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoneria.Controls.Add(this.btnSeleccionar);
            this.panelBotoneria.Controls.Add(this.btnNuevo);
            this.panelBotoneria.Controls.Add(this.txtBuscarProducto);
            this.panelBotoneria.Controls.Add(this.btnBuscar);
            this.panelBotoneria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoneria.Location = new System.Drawing.Point(0, 90);
            this.panelBotoneria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBotoneria.Name = "panelBotoneria";
            this.panelBotoneria.Size = new System.Drawing.Size(1032, 68);
            this.panelBotoneria.TabIndex = 38;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(863, 21);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 29);
            this.btnSeleccionar.TabIndex = 31;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // panelCategorias
            // 
            this.panelCategorias.AutoScroll = true;
            this.panelCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCategorias.Location = new System.Drawing.Point(11, 231);
            this.panelCategorias.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(151, 120);
            this.panelCategorias.TabIndex = 39;
            // 
            // panelMarcas
            // 
            this.panelMarcas.AutoScroll = true;
            this.panelMarcas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMarcas.Location = new System.Drawing.Point(11, 426);
            this.panelMarcas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMarcas.Name = "panelMarcas";
            this.panelMarcas.Size = new System.Drawing.Size(151, 162);
            this.panelMarcas.TabIndex = 40;
            // 
            // lblTituloDgv
            // 
            this.lblTituloDgv.AutoSize = true;
            this.lblTituloDgv.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDgv.Location = new System.Drawing.Point(171, 177);
            this.lblTituloDgv.Name = "lblTituloDgv";
            this.lblTituloDgv.Size = new System.Drawing.Size(193, 22);
            this.lblTituloDgv.TabIndex = 50;
            this.lblTituloDgv.Text = "Productos disponibles";
            // 
            // TimerProductos
            // 
            this.TimerProductos.Tick += new System.EventHandler(this.TimerProductos_Tick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 220;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Subcategoria
            // 
            this.Subcategoria.HeaderText = "Subcategoría";
            this.Subcategoria.MinimumWidth = 6;
            this.Subcategoria.Name = "Subcategoria";
            this.Subcategoria.ReadOnly = true;
            this.Subcategoria.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio (S./)";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 85;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // frmGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 612);
            this.Controls.Add(this.lblTituloDgv);
            this.Controls.Add(this.panelMarcas);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.panelCategorias);
            this.Controls.Add(this.panelBotoneria);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.dgvProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmGestionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestionProductos)).EndInit();
            this.panelBotoneria.ResumeLayout(false);
            this.panelBotoneria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblGestionProducto;
        private System.Windows.Forms.PictureBox pbGestionProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Panel panelBotoneria;
        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.Panel panelMarcas;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblTituloDgv;
        private System.Windows.Forms.Timer TimerProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}