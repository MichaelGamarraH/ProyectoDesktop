namespace RetailSoft.RetailSoftLogistica
{
    partial class frmLogisticaPrincipal
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
            this.button3 = new System.Windows.Forms.Button();
            this.lblLogistica = new System.Windows.Forms.Label();
            this.pbLogistica = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnMaestroAlmacen = new System.Windows.Forms.Button();
            this.btnMaestroProveedor = new System.Windows.Forms.Button();
            this.btnGestionLotes = new System.Windows.Forms.Button();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogistica)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.button3);
            this.panelSuperior.Controls.Add(this.lblLogistica);
            this.panelSuperior.Controls.Add(this.pbLogistica);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(878, 90);
            this.panelSuperior.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.button3.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(791, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblLogistica
            // 
            this.lblLogistica.AutoSize = true;
            this.lblLogistica.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogistica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogistica.Location = new System.Drawing.Point(94, 25);
            this.lblLogistica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogistica.Name = "lblLogistica";
            this.lblLogistica.Size = new System.Drawing.Size(321, 40);
            this.lblLogistica.TabIndex = 1;
            this.lblLogistica.Text = "Gestión de Logística";
            // 
            // pbLogistica
            // 
            this.pbLogistica.Image = global::RetailSoft.Properties.Resources.icono_logistica;
            this.pbLogistica.Location = new System.Drawing.Point(9, 10);
            this.pbLogistica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogistica.Name = "pbLogistica";
            this.pbLogistica.Size = new System.Drawing.Size(80, 72);
            this.pbLogistica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogistica.TabIndex = 0;
            this.pbLogistica.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(2, 102);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(185, 40);
            this.lblBienvenida.TabIndex = 7;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(5, 151);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(165, 22);
            this.lblPregunta.TabIndex = 8;
            this.lblPregunta.Text = "¿Qué deseas hacer?";
            // 
            // btnMaestroAlmacen
            // 
            this.btnMaestroAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnMaestroAlmacen.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaestroAlmacen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaestroAlmacen.Image = global::RetailSoft.Properties.Resources.IconoAlmacen;
            this.btnMaestroAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaestroAlmacen.Location = new System.Drawing.Point(456, 368);
            this.btnMaestroAlmacen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaestroAlmacen.Name = "btnMaestroAlmacen";
            this.btnMaestroAlmacen.Size = new System.Drawing.Size(263, 149);
            this.btnMaestroAlmacen.TabIndex = 6;
            this.btnMaestroAlmacen.Text = "Gestión de almacenes";
            this.btnMaestroAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaestroAlmacen.UseVisualStyleBackColor = false;
            this.btnMaestroAlmacen.Click += new System.EventHandler(this.btnMaestroAlmacen_Click);
            // 
            // btnMaestroProveedor
            // 
            this.btnMaestroProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnMaestroProveedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaestroProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaestroProveedor.Image = global::RetailSoft.Properties.Resources.GestionProveedor;
            this.btnMaestroProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaestroProveedor.Location = new System.Drawing.Point(103, 368);
            this.btnMaestroProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaestroProveedor.Name = "btnMaestroProveedor";
            this.btnMaestroProveedor.Size = new System.Drawing.Size(263, 149);
            this.btnMaestroProveedor.TabIndex = 5;
            this.btnMaestroProveedor.Text = "Gestión de proveedores";
            this.btnMaestroProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaestroProveedor.UseVisualStyleBackColor = false;
            this.btnMaestroProveedor.Click += new System.EventHandler(this.btnMaestroProveedor_Click);
            // 
            // btnGestionLotes
            // 
            this.btnGestionLotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGestionLotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionLotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionLotes.Image = global::RetailSoft.Properties.Resources.GestionLotes;
            this.btnGestionLotes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestionLotes.Location = new System.Drawing.Point(456, 201);
            this.btnGestionLotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionLotes.Name = "btnGestionLotes";
            this.btnGestionLotes.Size = new System.Drawing.Size(263, 149);
            this.btnGestionLotes.TabIndex = 3;
            this.btnGestionLotes.Text = "Gestión de lotes";
            this.btnGestionLotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestionLotes.UseVisualStyleBackColor = false;
            this.btnGestionLotes.Click += new System.EventHandler(this.btnGestionLotes_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGestionProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProductos.Image = global::RetailSoft.Properties.Resources.Productos;
            this.btnGestionProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestionProductos.Location = new System.Drawing.Point(103, 201);
            this.btnGestionProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(263, 149);
            this.btnGestionProductos.TabIndex = 2;
            this.btnGestionProductos.Text = "Gestión de productos";
            this.btnGestionProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestionProductos.UseVisualStyleBackColor = false;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // frmLogisticaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 568);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnMaestroAlmacen);
            this.Controls.Add(this.btnMaestroProveedor);
            this.Controls.Add(this.btnGestionLotes);
            this.Controls.Add(this.btnGestionProductos);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogisticaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Logística";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pbLogistica;
        private System.Windows.Forms.Label lblLogistica;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Button btnGestionLotes;
        private System.Windows.Forms.Button btnMaestroProveedor;
        private System.Windows.Forms.Button btnMaestroAlmacen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblPregunta;
    }
}