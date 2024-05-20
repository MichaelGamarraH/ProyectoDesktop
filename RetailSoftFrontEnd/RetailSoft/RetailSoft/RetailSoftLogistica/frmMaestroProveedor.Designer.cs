namespace RetailSoft.RetailSoftLogistica
{
    partial class frmMaestroProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGestionProveedores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnEntreFechas = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelProveedores.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.lblGestionProveedores);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblGestionProveedores
            // 
            this.lblGestionProveedores.AutoSize = true;
            this.lblGestionProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGestionProveedores.Location = new System.Drawing.Point(115, 16);
            this.lblGestionProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionProveedores.Name = "lblGestionProveedores";
            this.lblGestionProveedores.Size = new System.Drawing.Size(376, 40);
            this.lblGestionProveedores.TabIndex = 3;
            this.lblGestionProveedores.Text = "Gestión de Proveedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetailSoft.Properties.Resources.repartidor;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelProveedores
            // 
            this.panelProveedores.AutoScroll = true;
            this.panelProveedores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelProveedores.Controls.Add(this.btnReporte);
            this.panelProveedores.Controls.Add(this.panelFiltros);
            this.panelProveedores.Controls.Add(this.btnFiltros);
            this.panelProveedores.Controls.Add(this.btnBusqueda);
            this.panelProveedores.Controls.Add(this.label1);
            this.panelProveedores.Controls.Add(this.btnNuevo);
            this.panelProveedores.Controls.Add(this.vScrollBar1);
            this.panelProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProveedores.Location = new System.Drawing.Point(0, 81);
            this.panelProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(891, 388);
            this.panelProveedores.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporte.Location = new System.Drawing.Point(9, 229);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(105, 48);
            this.btnReporte.TabIndex = 51;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.btnEntreFechas);
            this.panelFiltros.Controls.Add(this.btnDescendente);
            this.panelFiltros.Controls.Add(this.btnAscendente);
            this.panelFiltros.Location = new System.Drawing.Point(9, 87);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(105, 92);
            this.panelFiltros.TabIndex = 16;
            // 
            // btnEntreFechas
            // 
            this.btnEntreFechas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEntreFechas.FlatAppearance.BorderSize = 0;
            this.btnEntreFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnEntreFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntreFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntreFechas.Location = new System.Drawing.Point(0, 60);
            this.btnEntreFechas.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntreFechas.Name = "btnEntreFechas";
            this.btnEntreFechas.Size = new System.Drawing.Size(105, 32);
            this.btnEntreFechas.TabIndex = 19;
            this.btnEntreFechas.Text = "Entre Fechas";
            this.btnEntreFechas.UseVisualStyleBackColor = false;
            this.btnEntreFechas.Click += new System.EventHandler(this.btnEntreFechas_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDescendente.FlatAppearance.BorderSize = 0;
            this.btnDescendente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnDescendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescendente.Location = new System.Drawing.Point(0, 30);
            this.btnDescendente.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(105, 32);
            this.btnDescendente.TabIndex = 18;
            this.btnDescendente.Text = "Antiguos";
            this.btnDescendente.UseVisualStyleBackColor = false;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // btnAscendente
            // 
            this.btnAscendente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAscendente.FlatAppearance.BorderSize = 0;
            this.btnAscendente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnAscendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscendente.Location = new System.Drawing.Point(0, 0);
            this.btnAscendente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(105, 32);
            this.btnAscendente.TabIndex = 17;
            this.btnAscendente.Text = "Recientes";
            this.btnAscendente.UseVisualStyleBackColor = false;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
            // 
            // btnFiltros
            // 
            this.btnFiltros.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFiltros.FlatAppearance.BorderSize = 0;
            this.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.Location = new System.Drawing.Point(9, 58);
            this.btnFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(105, 32);
            this.btnFiltros.TabIndex = 15;
            this.btnFiltros.Text = "FILTROS";
            this.btnFiltros.UseVisualStyleBackColor = false;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(566, 8);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(50, 23);
            this.btnBusqueda.TabIndex = 13;
            this.btnBusqueda.Text = "...";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.MouseHover += new System.EventHandler(this.btnBusqueda_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione método de búsqueda Proveedor: ";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(9, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 39);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(870, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 388);
            this.vScrollBar1.TabIndex = 0;
            // 
            // frmMaestroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 469);
            this.Controls.Add(this.panelProveedores);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaestroProveedor";
            this.Text = "MaestroProveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGestionProveedores;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnEntreFechas;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.Button btnReporte;
    }
}