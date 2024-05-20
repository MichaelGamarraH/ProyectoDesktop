namespace RetailSoft.RetailSoftRRHH
{
    partial class frmGestionColaboradores
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
            this.pbGestColaboradores = new System.Windows.Forms.PictureBox();
            this.lblModuloActual = new System.Windows.Forms.Label();
            this.panelBotoneria = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelCargos = new System.Windows.Forms.Panel();
            this.panelColaboradores = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestColaboradores)).BeginInit();
            this.panelBotoneria.SuspendLayout();
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
            this.panelSuperior.Size = new System.Drawing.Size(1523, 111);
            this.panelSuperior.TabIndex = 1;
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
            this.lblModuloActual.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModuloActual.Location = new System.Drawing.Point(125, 27);
            this.lblModuloActual.Name = "lblModuloActual";
            this.lblModuloActual.Size = new System.Drawing.Size(545, 52);
            this.lblModuloActual.TabIndex = 0;
            this.lblModuloActual.Text = "Gestión de Colaboradores";
            // 
            // panelBotoneria
            // 
            this.panelBotoneria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoneria.Controls.Add(this.btnBuscar);
            this.panelBotoneria.Controls.Add(this.txtBuscar);
            this.panelBotoneria.Controls.Add(this.btnNuevo);
            this.panelBotoneria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoneria.Location = new System.Drawing.Point(0, 111);
            this.panelBotoneria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotoneria.Name = "panelBotoneria";
            this.panelBotoneria.Size = new System.Drawing.Size(1523, 84);
            this.panelBotoneria.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::RetailSoft.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(1032, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(572, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(453, 30);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar por nombre o DNI...";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(37, 20);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelCargos
            // 
            this.panelCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCargos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCargos.Location = new System.Drawing.Point(0, 195);
            this.panelCargos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCargos.Name = "panelCargos";
            this.panelCargos.Size = new System.Drawing.Size(199, 532);
            this.panelCargos.TabIndex = 3;
            // 
            // panelColaboradores
            // 
            this.panelColaboradores.AutoScroll = true;
            this.panelColaboradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColaboradores.Location = new System.Drawing.Point(199, 195);
            this.panelColaboradores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelColaboradores.Name = "panelColaboradores";
            this.panelColaboradores.Size = new System.Drawing.Size(1324, 532);
            this.panelColaboradores.TabIndex = 4;
            // 
            // frmGestionColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1523, 727);
            this.Controls.Add(this.panelColaboradores);
            this.Controls.Add(this.panelCargos);
            this.Controls.Add(this.panelBotoneria);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Gestión de Colaboradores";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestColaboradores)).EndInit();
            this.panelBotoneria.ResumeLayout(false);
            this.panelBotoneria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGestColaboradores;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblModuloActual;
        private System.Windows.Forms.Panel panelBotoneria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panelCargos;
        private System.Windows.Forms.Panel panelColaboradores;
    }
}