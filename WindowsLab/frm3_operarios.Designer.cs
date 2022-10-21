namespace WindowsLab
{
    partial class frm3_operarios
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
            this.btnDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(324, 135);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(111, 37);
            this.btnDatos.TabIndex = 0;
            this.btnDatos.Text = "Ingresar Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // frm3_operarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDatos);
            this.Name = "frm3_operarios";
            this.Text = "frm3_operarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatos;
    }
}