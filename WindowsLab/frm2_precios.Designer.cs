namespace WindowsLab
{
    partial class frm2_precios
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
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(290, 189);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(208, 13);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingrese precios de productos en pesos AR";
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(327, 219);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(143, 23);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Ingresar";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // frmCaso2_precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.lblIngresar);
            this.Name = "frmCaso2_precios";
            this.Text = "frmCaso2_precios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnProductos;
    }
}