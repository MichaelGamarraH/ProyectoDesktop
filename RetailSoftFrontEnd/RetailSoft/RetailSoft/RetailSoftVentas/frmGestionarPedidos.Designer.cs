using System.Windows.Forms;

namespace RetailSoft
{
    partial class frmGestionarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPedidos));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.panelPromociones = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFlechaDerecha = new System.Windows.Forms.Button();
            this.btnFlechaIzquierda = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llPromocion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelPromociones.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelSuperior.Controls.Add(this.lblContador);
            this.panelSuperior.Controls.Add(this.button3);
            this.panelSuperior.Controls.Add(this.label7);
            this.panelSuperior.Controls.Add(this.label8);
            this.panelSuperior.Controls.Add(this.label9);
            this.panelSuperior.Controls.Add(this.button2);
            this.panelSuperior.Controls.Add(this.label6);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(724, 74);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.White;
            this.lblContador.Location = new System.Drawing.Point(584, 14);
            this.lblContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(19, 20);
            this.lblContador.TabIndex = 14;
            this.lblContador.Text = "0";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(669, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "IN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "GIT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 42);
            this.label9.TabIndex = 11;
            this.label9.Text = "REST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(219, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "¡Bienvenido a nuestro sistema!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Location = new System.Drawing.Point(2, -15);
            this.lblPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(68, 13);
            this.lblPromocion.TabIndex = 5;
            this.lblPromocion.Text = "Promociones";
            // 
            // panelCategorias
            // 
            this.panelCategorias.AutoScroll = true;
            this.panelCategorias.BackColor = System.Drawing.Color.White;
            this.panelCategorias.Location = new System.Drawing.Point(0, 102);
            this.panelCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(1268, 43);
            this.panelCategorias.TabIndex = 1;
            // 
            // panelPromociones
            // 
            this.panelPromociones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelPromociones.Controls.Add(this.label5);
            this.panelPromociones.Controls.Add(this.btnFlechaDerecha);
            this.panelPromociones.Controls.Add(this.lblPromocion);
            this.panelPromociones.Controls.Add(this.btnFlechaIzquierda);
            this.panelPromociones.Location = new System.Drawing.Point(0, 210);
            this.panelPromociones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPromociones.Name = "panelPromociones";
            this.panelPromociones.Size = new System.Drawing.Size(1268, 193);
            this.panelPromociones.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(5, -10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(808, 13);
            this.label5.TabIndex = 8;
            this.label5.Tag = "";
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnFlechaDerecha
            // 
            this.btnFlechaDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.btnFlechaDerecha.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlechaDerecha.ForeColor = System.Drawing.Color.White;
            this.btnFlechaDerecha.Location = new System.Drawing.Point(657, 68);
            this.btnFlechaDerecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFlechaDerecha.Name = "btnFlechaDerecha";
            this.btnFlechaDerecha.Size = new System.Drawing.Size(53, 53);
            this.btnFlechaDerecha.TabIndex = 7;
            this.btnFlechaDerecha.Text = ">";
            this.btnFlechaDerecha.UseVisualStyleBackColor = false;
            this.btnFlechaDerecha.Click += new System.EventHandler(this.btnFlechaDerecha_Click);
            // 
            // btnFlechaIzquierda
            // 
            this.btnFlechaIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.btnFlechaIzquierda.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlechaIzquierda.ForeColor = System.Drawing.Color.White;
            this.btnFlechaIzquierda.Location = new System.Drawing.Point(9, 68);
            this.btnFlechaIzquierda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFlechaIzquierda.Name = "btnFlechaIzquierda";
            this.btnFlechaIzquierda.Size = new System.Drawing.Size(53, 53);
            this.btnFlechaIzquierda.TabIndex = 6;
            this.btnFlechaIzquierda.Text = "<";
            this.btnFlechaIzquierda.UseVisualStyleBackColor = false;
            this.btnFlechaIzquierda.Click += new System.EventHandler(this.btnFlechaIzquierda_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCentro.Controls.Add(this.label3);
            this.panelCentro.Controls.Add(this.label1);
            this.panelCentro.Controls.Add(this.llPromocion);
            this.panelCentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.panelCentro.Location = new System.Drawing.Point(0, 151);
            this.panelCentro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(729, 60);
            this.panelCentro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(4, -11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(808, 13);
            this.label3.TabIndex = 7;
            this.label3.Tag = "";
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Aprovecha nuestras promociones! Exclusivas solo en nuestra aplicación!";
            // 
            // llPromocion
            // 
            this.llPromocion.AutoSize = true;
            this.llPromocion.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPromocion.Location = new System.Drawing.Point(297, 0);
            this.llPromocion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llPromocion.Name = "llPromocion";
            this.llPromocion.Size = new System.Drawing.Size(105, 31);
            this.llPromocion.TabIndex = 5;
            this.llPromocion.Text = "Promos";
            this.llPromocion.Click += new System.EventHandler(this.llPromocion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(279, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categorías";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImage = global::RetailSoft.Properties.Resources.carrito;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.button2.Location = new System.Drawing.Point(563, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 53);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGestionarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelPromociones);
            this.Controls.Add(this.panelCategorias);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionarPedidos";
            this.Text = "frmGestionarPedidos";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelPromociones.ResumeLayout(false);
            this.panelPromociones.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.Panel panelPromociones;
        private Button btnFlechaDerecha;
        private Button btnFlechaIzquierda;
        private Panel panelCentro;
        private Label llPromocion;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button3;
        private Label label3;
        private Label label5;
        private Label lblContador;

        public Panel PanelCategorias { get => panelCategorias; set => panelCategorias = value; }
        public Panel PanelPromociones { get => panelPromociones; set => panelPromociones = value; }
        public Button BtnFlechaDerecha { get => btnFlechaDerecha; set => btnFlechaDerecha = value; }
        public Button BtnFlechaIzquierda { get => btnFlechaIzquierda; set => btnFlechaIzquierda = value; }
    }
}