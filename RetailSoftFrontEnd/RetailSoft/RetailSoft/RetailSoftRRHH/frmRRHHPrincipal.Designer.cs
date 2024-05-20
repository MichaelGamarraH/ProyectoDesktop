namespace RetailSoft.RetailSoftRRHH
{
    partial class frmRRHHPrincipal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblModuloActual = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnGestAsistencias = new System.Windows.Forms.Button();
            this.btnGestEventos = new System.Windows.Forms.Button();
            this.btnGestReclutamiento = new System.Windows.Forms.Button();
            this.btnGestColaboradores = new System.Windows.Forms.Button();
            this.pbIconorrhh = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconorrhh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.btnSalir);
            this.panelSuperior.Controls.Add(this.pbIconorrhh);
            this.panelSuperior.Controls.Add(this.lblModuloActual);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1303, 111);
            this.panelSuperior.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1196, 27);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 64);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblModuloActual
            // 
            this.lblModuloActual.AutoSize = true;
            this.lblModuloActual.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModuloActual.Location = new System.Drawing.Point(152, 27);
            this.lblModuloActual.Name = "lblModuloActual";
            this.lblModuloActual.Size = new System.Drawing.Size(637, 52);
            this.lblModuloActual.TabIndex = 0;
            this.lblModuloActual.Text = "Gestión de Recursos Humanos";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(4, 114);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(231, 50);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(7, 172);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(207, 27);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "¿Qué deseas hacer?";
            // 
            // btnGestAsistencias
            // 
            this.btnGestAsistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGestAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestAsistencias.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestAsistencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestAsistencias.Image = global::RetailSoft.Properties.Resources.asistencias;
            this.btnGestAsistencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestAsistencias.Location = new System.Drawing.Point(716, 485);
            this.btnGestAsistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestAsistencias.Name = "btnGestAsistencias";
            this.btnGestAsistencias.Size = new System.Drawing.Size(427, 197);
            this.btnGestAsistencias.TabIndex = 6;
            this.btnGestAsistencias.Text = "Gestión de Asistencias";
            this.btnGestAsistencias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestAsistencias.UseVisualStyleBackColor = false;
            this.btnGestAsistencias.Click += new System.EventHandler(this.btnGestAsistencias_Click);
            // 
            // btnGestEventos
            // 
            this.btnGestEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGestEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestEventos.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEventos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestEventos.Image = global::RetailSoft.Properties.Resources.eventos;
            this.btnGestEventos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestEventos.Location = new System.Drawing.Point(109, 485);
            this.btnGestEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestEventos.Name = "btnGestEventos";
            this.btnGestEventos.Size = new System.Drawing.Size(427, 197);
            this.btnGestEventos.TabIndex = 5;
            this.btnGestEventos.Text = "Gestión de Eventos";
            this.btnGestEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestEventos.UseVisualStyleBackColor = false;
            this.btnGestEventos.Click += new System.EventHandler(this.btnGestEventos_Click);
            // 
            // btnGestReclutamiento
            // 
            this.btnGestReclutamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGestReclutamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestReclutamiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestReclutamiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestReclutamiento.Image = global::RetailSoft.Properties.Resources.reclutamiento;
            this.btnGestReclutamiento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestReclutamiento.Location = new System.Drawing.Point(716, 248);
            this.btnGestReclutamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestReclutamiento.Name = "btnGestReclutamiento";
            this.btnGestReclutamiento.Size = new System.Drawing.Size(427, 197);
            this.btnGestReclutamiento.TabIndex = 4;
            this.btnGestReclutamiento.Text = "Gestión de Reclutamiento";
            this.btnGestReclutamiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestReclutamiento.UseVisualStyleBackColor = false;
            this.btnGestReclutamiento.Click += new System.EventHandler(this.btnGestReclutamiento_Click);
            // 
            // btnGestColaboradores
            // 
            this.btnGestColaboradores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnGestColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestColaboradores.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestColaboradores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestColaboradores.Image = global::RetailSoft.Properties.Resources.Colaboradores;
            this.btnGestColaboradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestColaboradores.Location = new System.Drawing.Point(109, 248);
            this.btnGestColaboradores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestColaboradores.Name = "btnGestColaboradores";
            this.btnGestColaboradores.Size = new System.Drawing.Size(427, 197);
            this.btnGestColaboradores.TabIndex = 3;
            this.btnGestColaboradores.Text = "Gestión de Colaboradores";
            this.btnGestColaboradores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestColaboradores.UseVisualStyleBackColor = false;
            this.btnGestColaboradores.Click += new System.EventHandler(this.btnGestColaboradores_Click);
            // 
            // pbIconorrhh
            // 
            this.pbIconorrhh.Image = global::RetailSoft.Properties.Resources.RRHH;
            this.pbIconorrhh.Location = new System.Drawing.Point(12, 12);
            this.pbIconorrhh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIconorrhh.Name = "pbIconorrhh";
            this.pbIconorrhh.Size = new System.Drawing.Size(107, 89);
            this.pbIconorrhh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconorrhh.TabIndex = 1;
            this.pbIconorrhh.TabStop = false;
            // 
            // frmRRHHPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 734);
            this.Controls.Add(this.btnGestAsistencias);
            this.Controls.Add(this.btnGestEventos);
            this.Controls.Add(this.btnGestReclutamiento);
            this.Controls.Add(this.btnGestColaboradores);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRRHHPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRRHHPrincipal";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconorrhh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblModuloActual;
        private System.Windows.Forms.PictureBox pbIconorrhh;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnGestColaboradores;
        private System.Windows.Forms.Button btnGestReclutamiento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnGestEventos;
        private System.Windows.Forms.Button btnGestAsistencias;
    }
}