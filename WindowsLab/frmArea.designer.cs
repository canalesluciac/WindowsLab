namespace PracticaDeMetodos
{
    partial class frmArea
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
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnTrapecio = new System.Windows.Forms.Button();
            this.lblFigura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(384, 134);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 0;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(384, 172);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 1;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnTrapecio
            // 
            this.btnTrapecio.Location = new System.Drawing.Point(384, 210);
            this.btnTrapecio.Name = "btnTrapecio";
            this.btnTrapecio.Size = new System.Drawing.Size(75, 23);
            this.btnTrapecio.TabIndex = 2;
            this.btnTrapecio.Text = "Trapecio";
            this.btnTrapecio.UseVisualStyleBackColor = true;
            this.btnTrapecio.Click += new System.EventHandler(this.btnTrapecio_Click);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(261, 160);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(106, 13);
            this.lblFigura.TabIndex = 3;
            this.lblFigura.Text = "Seleccione la figura: ";
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.btnTrapecio);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnRectangulo);
            this.Name = "frmArea";
            this.Text = "frmArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnTrapecio;
        private System.Windows.Forms.Label lblFigura;
    }
}