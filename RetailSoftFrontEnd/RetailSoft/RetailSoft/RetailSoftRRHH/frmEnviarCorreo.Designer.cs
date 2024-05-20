namespace RetailSoft.RetailSoftLogistica
{
    partial class frmEnviarCorreo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblModuloActual = new System.Windows.Forms.Label();
            this.pbIconoEvento = new System.Windows.Forms.PictureBox();
            this.panelInfoEvento = new System.Windows.Forms.Panel();
            this.lblInvitados = new System.Windows.Forms.Label();
            this.lblTotalInvitados = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelInvitados = new System.Windows.Forms.Panel();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelBotoneria = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoEvento)).BeginInit();
            this.panelInfoEvento.SuspendLayout();
            this.panelInvitados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.panelBotoneria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblModuloActual);
            this.panelSuperior.Controls.Add(this.pbIconoEvento);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(762, 90);
            this.panelSuperior.TabIndex = 3;
            // 
            // lblModuloActual
            // 
            this.lblModuloActual.AutoSize = true;
            this.lblModuloActual.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloActual.ForeColor = System.Drawing.Color.White;
            this.lblModuloActual.Location = new System.Drawing.Point(101, 25);
            this.lblModuloActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuloActual.Name = "lblModuloActual";
            this.lblModuloActual.Size = new System.Drawing.Size(472, 40);
            this.lblModuloActual.TabIndex = 1;
            this.lblModuloActual.Text = "Enviar Invitaciones por Correo";
            // 
            // pbIconoEvento
            // 
            this.pbIconoEvento.Image = global::RetailSoft.Properties.Resources.correo1;
            this.pbIconoEvento.Location = new System.Drawing.Point(11, 13);
            this.pbIconoEvento.Margin = new System.Windows.Forms.Padding(2);
            this.pbIconoEvento.Name = "pbIconoEvento";
            this.pbIconoEvento.Size = new System.Drawing.Size(78, 67);
            this.pbIconoEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconoEvento.TabIndex = 0;
            this.pbIconoEvento.TabStop = false;
            // 
            // panelInfoEvento
            // 
            this.panelInfoEvento.Controls.Add(this.lblInvitados);
            this.panelInfoEvento.Controls.Add(this.lblTotalInvitados);
            this.panelInfoEvento.Controls.Add(this.lblFecha);
            this.panelInfoEvento.Controls.Add(this.lblNombre);
            this.panelInfoEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoEvento.Location = new System.Drawing.Point(0, 90);
            this.panelInfoEvento.Name = "panelInfoEvento";
            this.panelInfoEvento.Size = new System.Drawing.Size(762, 142);
            this.panelInfoEvento.TabIndex = 4;
            // 
            // lblInvitados
            // 
            this.lblInvitados.AutoSize = true;
            this.lblInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvitados.Location = new System.Drawing.Point(29, 104);
            this.lblInvitados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvitados.Name = "lblInvitados";
            this.lblInvitados.Size = new System.Drawing.Size(119, 24);
            this.lblInvitados.TabIndex = 8;
            this.lblInvitados.Text = "INVITADOS";
            // 
            // lblTotalInvitados
            // 
            this.lblTotalInvitados.AutoSize = true;
            this.lblTotalInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvitados.Location = new System.Drawing.Point(29, 72);
            this.lblTotalInvitados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalInvitados.Name = "lblTotalInvitados";
            this.lblTotalInvitados.Size = new System.Drawing.Size(130, 20);
            this.lblTotalInvitados.TabIndex = 7;
            this.lblTotalInvitados.Text = "Total invitados:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 43);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 13);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(169, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre del evento: ";
            // 
            // panelInvitados
            // 
            this.panelInvitados.Controls.Add(this.dgvColaboradores);
            this.panelInvitados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvitados.Location = new System.Drawing.Point(0, 232);
            this.panelInvitados.Name = "panelInvitados";
            this.panelInvitados.Size = new System.Drawing.Size(762, 299);
            this.panelInvitados.TabIndex = 5;
            // 
            // dgvColaboradores
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaboradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.DNI,
            this.Correo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColaboradores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColaboradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColaboradores.Location = new System.Drawing.Point(0, 0);
            this.dgvColaboradores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.RowHeadersWidth = 51;
            this.dgvColaboradores.RowTemplate.Height = 24;
            this.dgvColaboradores.Size = new System.Drawing.Size(762, 299);
            this.dgvColaboradores.TabIndex = 4;
            this.dgvColaboradores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvColaboradores_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.Width = 120;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 185;
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(225, 5);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(142, 46);
            this.btnEnviarCorreo.TabIndex = 73;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(417, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 46);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelBotoneria
            // 
            this.panelBotoneria.Controls.Add(this.btnEnviarCorreo);
            this.panelBotoneria.Controls.Add(this.btnCancelar);
            this.panelBotoneria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoneria.Location = new System.Drawing.Point(0, 531);
            this.panelBotoneria.Name = "panelBotoneria";
            this.panelBotoneria.Size = new System.Drawing.Size(762, 60);
            this.panelBotoneria.TabIndex = 6;
            // 
            // frmEnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 591);
            this.Controls.Add(this.panelInvitados);
            this.Controls.Add(this.panelBotoneria);
            this.Controls.Add(this.panelInfoEvento);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmEnviarCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoEvento)).EndInit();
            this.panelInfoEvento.ResumeLayout(false);
            this.panelInfoEvento.PerformLayout();
            this.panelInvitados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.panelBotoneria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblModuloActual;
        private System.Windows.Forms.PictureBox pbIconoEvento;
        private System.Windows.Forms.Panel panelInfoEvento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInvitados;
        private System.Windows.Forms.Label lblTotalInvitados;
        private System.Windows.Forms.Panel panelInvitados;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelBotoneria;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}