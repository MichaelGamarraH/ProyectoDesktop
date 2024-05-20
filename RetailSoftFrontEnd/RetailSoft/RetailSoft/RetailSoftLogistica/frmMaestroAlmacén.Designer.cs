namespace RetailSoft.RetailSoftLogistica
{
    partial class frmMaestroAlmacén
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGestionProveedores = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombreAlmacen = new System.Windows.Forms.TextBox();
            this.btnBuscarAlmacen = new System.Windows.Forms.Button();
            this.panelAlmacen = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAlmacen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblGestionProveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 81);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetailSoft.Properties.Resources.almacen;
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblGestionProveedores
            // 
            this.lblGestionProveedores.AutoSize = true;
            this.lblGestionProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGestionProveedores.Location = new System.Drawing.Point(115, 16);
            this.lblGestionProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionProveedores.Name = "lblGestionProveedores";
            this.lblGestionProveedores.Size = new System.Drawing.Size(317, 40);
            this.lblGestionProveedores.TabIndex = 3;
            this.lblGestionProveedores.Text = "Gestión de Almacén";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Location = new System.Drawing.Point(8, 86);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 39);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNombreAlmacen
            // 
            this.txtNombreAlmacen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlmacen.Location = new System.Drawing.Point(427, 94);
            this.txtNombreAlmacen.Name = "txtNombreAlmacen";
            this.txtNombreAlmacen.Size = new System.Drawing.Size(92, 26);
            this.txtNombreAlmacen.TabIndex = 5;
            // 
            // btnBuscarAlmacen
            // 
            this.btnBuscarAlmacen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAlmacen.Location = new System.Drawing.Point(542, 96);
            this.btnBuscarAlmacen.Name = "btnBuscarAlmacen";
            this.btnBuscarAlmacen.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarAlmacen.TabIndex = 6;
            this.btnBuscarAlmacen.Text = "...";
            this.btnBuscarAlmacen.UseVisualStyleBackColor = true;
            this.btnBuscarAlmacen.Click += new System.EventHandler(this.btnBuscarAlmacen_Click);
            // 
            // panelAlmacen
            // 
            this.panelAlmacen.AutoScroll = true;
            this.panelAlmacen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAlmacen.Controls.Add(this.vScrollBar2);
            this.panelAlmacen.Location = new System.Drawing.Point(101, 138);
            this.panelAlmacen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAlmacen.Name = "panelAlmacen";
            this.panelAlmacen.Size = new System.Drawing.Size(705, 326);
            this.panelAlmacen.TabIndex = 7;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar2.Location = new System.Drawing.Point(684, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 326);
            this.vScrollBar2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el ID del Almacén: ";
            // 
            // frmMaestroAlmacén
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAlmacen);
            this.Controls.Add(this.btnBuscarAlmacen);
            this.Controls.Add(this.txtNombreAlmacen);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMaestroAlmacén";
            this.Text = "frmMaestroAlmacén";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAlmacen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGestionProveedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombreAlmacen;
        private System.Windows.Forms.Button btnBuscarAlmacen;
        private System.Windows.Forms.Panel panelAlmacen;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label1;
    }
}