namespace RetailSoft
{
    partial class frmGestionarVenta
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
            this.btnFlechaIzquierda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEjecutarVenta = new System.Windows.Forms.Button();
            this.gbDatosPedido = new System.Windows.Forms.GroupBox();
            this.lblPromotor = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.txtIDPedido = new System.Windows.Forms.TextBox();
            this.lblIDPedido = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboPromotor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gbDatosPedido.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.gbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btnFlechaIzquierda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 72);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnFlechaIzquierda
            // 
            this.btnFlechaIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.btnFlechaIzquierda.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlechaIzquierda.ForeColor = System.Drawing.Color.White;
            this.btnFlechaIzquierda.Location = new System.Drawing.Point(2, 8);
            this.btnFlechaIzquierda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFlechaIzquierda.Name = "btnFlechaIzquierda";
            this.btnFlechaIzquierda.Size = new System.Drawing.Size(53, 57);
            this.btnFlechaIzquierda.TabIndex = 11;
            this.btnFlechaIzquierda.Text = "<";
            this.btnFlechaIzquierda.UseVisualStyleBackColor = false;
            this.btnFlechaIzquierda.Click += new System.EventHandler(this.btnFlechaIzquierda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "GIT";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(70, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 42);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "REST";
            // 
            // btnEjecutarVenta
            // 
            this.btnEjecutarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.btnEjecutarVenta.Location = new System.Drawing.Point(11, 268);
            this.btnEjecutarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEjecutarVenta.Name = "btnEjecutarVenta";
            this.btnEjecutarVenta.Size = new System.Drawing.Size(377, 31);
            this.btnEjecutarVenta.TabIndex = 4;
            this.btnEjecutarVenta.Text = "Ir a pagar";
            this.btnEjecutarVenta.UseVisualStyleBackColor = true;
            this.btnEjecutarVenta.Click += new System.EventHandler(this.btnEjecutarVenta_Click);
            // 
            // gbDatosPedido
            // 
            this.gbDatosPedido.Controls.Add(this.cboPromotor);
            this.gbDatosPedido.Controls.Add(this.lblPromotor);
            this.gbDatosPedido.Controls.Add(this.dtpFechaPedido);
            this.gbDatosPedido.Controls.Add(this.lblFechaPedido);
            this.gbDatosPedido.Controls.Add(this.txtIDPedido);
            this.gbDatosPedido.Controls.Add(this.lblIDPedido);
            this.gbDatosPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.gbDatosPedido.Location = new System.Drawing.Point(8, 76);
            this.gbDatosPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosPedido.Name = "gbDatosPedido";
            this.gbDatosPedido.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosPedido.Size = new System.Drawing.Size(272, 153);
            this.gbDatosPedido.TabIndex = 5;
            this.gbDatosPedido.TabStop = false;
            this.gbDatosPedido.Text = "Datos del pedido";
            // 
            // lblPromotor
            // 
            this.lblPromotor.AutoSize = true;
            this.lblPromotor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.lblPromotor.Location = new System.Drawing.Point(4, 82);
            this.lblPromotor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromotor.Name = "lblPromotor";
            this.lblPromotor.Size = new System.Drawing.Size(72, 16);
            this.lblPromotor.TabIndex = 4;
            this.lblPromotor.Text = "Promotor";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.dtpFechaPedido.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPedido.Location = new System.Drawing.Point(116, 53);
            this.dtpFechaPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(155, 20);
            this.dtpFechaPedido.TabIndex = 3;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.lblFechaPedido.Location = new System.Drawing.Point(26, 56);
            this.lblFechaPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(50, 16);
            this.lblFechaPedido.TabIndex = 2;
            this.lblFechaPedido.Text = "Fecha";
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.Enabled = false;
            this.txtIDPedido.Location = new System.Drawing.Point(116, 26);
            this.txtIDPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(58, 26);
            this.txtIDPedido.TabIndex = 1;
            // 
            // lblIDPedido
            // 
            this.lblIDPedido.AutoSize = true;
            this.lblIDPedido.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.lblIDPedido.Location = new System.Drawing.Point(4, 26);
            this.lblIDPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDPedido.Name = "lblIDPedido";
            this.lblIDPedido.Size = new System.Drawing.Size(74, 16);
            this.lblIDPedido.TabIndex = 0;
            this.lblIDPedido.Text = "ID Pedido";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.txtDNICliente);
            this.gbDatosCliente.Controls.Add(this.lblDNICliente);
            this.gbDatosCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.gbDatosCliente.Location = new System.Drawing.Point(9, 242);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosCliente.Size = new System.Drawing.Size(272, 141);
            this.gbDatosCliente.TabIndex = 6;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(68, 78);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(203, 26);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.lblNombre.Location = new System.Drawing.Point(4, 80);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre ";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(68, 26);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(88, 26);
            this.txtDNICliente.TabIndex = 1;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.lblDNICliente.Location = new System.Drawing.Point(4, 26);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(35, 16);
            this.lblDNICliente.TabIndex = 0;
            this.lblDNICliente.Text = "DNI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(7, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total a pagar ";
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.label1);
            this.gbResumen.Controls.Add(this.btnEliminar);
            this.gbResumen.Controls.Add(this.dataGridView1);
            this.gbResumen.Controls.Add(this.txtTotal);
            this.gbResumen.Controls.Add(this.label2);
            this.gbResumen.Controls.Add(this.btnEjecutarVenta);
            this.gbResumen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.gbResumen.Location = new System.Drawing.Point(285, 76);
            this.gbResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbResumen.Size = new System.Drawing.Size(393, 307);
            this.gbResumen.TabIndex = 6;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(213, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quitar producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(347, 237);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(41, 25);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(382, 211);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(117, 239);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(69, 26);
            this.txtTotal.TabIndex = 6;
            // 
            // cboPromotor
            // 
            this.cboPromotor.FormattingEnabled = true;
            this.cboPromotor.Location = new System.Drawing.Point(111, 82);
            this.cboPromotor.Name = "cboPromotor";
            this.cboPromotor.Size = new System.Drawing.Size(156, 27);
            this.cboPromotor.TabIndex = 6;
            // 
            // frmGestionarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 389);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbDatosPedido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionarVenta";
            this.Text = "frmGestionarVenta";
            this.Load += new System.EventHandler(this.frmGestionarVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDatosPedido.ResumeLayout(false);
            this.gbDatosPedido.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbResumen.ResumeLayout(false);
            this.gbResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEjecutarVenta;
        private System.Windows.Forms.GroupBox gbDatosPedido;
        private System.Windows.Forms.Label lblPromotor;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.TextBox txtIDPedido;
        private System.Windows.Forms.Label lblIDPedido;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFlechaIzquierda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPromotor;
    }
}