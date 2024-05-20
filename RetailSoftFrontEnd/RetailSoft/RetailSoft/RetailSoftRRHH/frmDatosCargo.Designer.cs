namespace RetailSoft.RetailSoftRRHH
{
    partial class frmDatosCargo
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
            this.btnCargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargo
            // 
            this.btnCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCargo.FlatAppearance.BorderSize = 0;
            this.btnCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargo.Location = new System.Drawing.Point(0, 0);
            this.btnCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(136, 43);
            this.btnCargo.TabIndex = 0;
            this.btnCargo.Text = "Cargo";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // frmDatosCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(136, 43);
            this.Controls.Add(this.btnCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDatosCargo";
            this.Text = "frmDatosCargo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargo;
    }
}