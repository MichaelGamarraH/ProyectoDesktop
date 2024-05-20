namespace RetailSoft
{
    partial class frmDatosPromocion
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
            this.btnPromocion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPromocion
            // 
            this.btnPromocion.BackColor = System.Drawing.Color.White;
            this.btnPromocion.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromocion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.btnPromocion.Location = new System.Drawing.Point(-1, -1);
            this.btnPromocion.Name = "btnPromocion";
            this.btnPromocion.Size = new System.Drawing.Size(221, 303);
            this.btnPromocion.TabIndex = 0;
            this.btnPromocion.UseVisualStyleBackColor = false;
            this.btnPromocion.Click += new System.EventHandler(this.btnPromocion_Click);
            // 
            // frmDatosPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(220, 300);
            this.Controls.Add(this.btnPromocion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosPromocion";
            this.Text = "frmDatosPromocion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPromocion;
    }
}