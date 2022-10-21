namespace WindowsLab
{
    partial class frmNotasVectores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblAlumno1 = new System.Windows.Forms.Label();
            this.lblAlumno2 = new System.Windows.Forms.Label();
            this.lblAlumno4 = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtAlumno1 = new System.Windows.Forms.TextBox();
            this.txtAlumno2 = new System.Windows.Forms.TextBox();
            this.txtAlumno3 = new System.Windows.Forms.TextBox();
            this.txtAlumno4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(380, 253);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblAlumno1
            // 
            this.lblAlumno1.AutoSize = true;
            this.lblAlumno1.Location = new System.Drawing.Point(276, 98);
            this.lblAlumno1.Name = "lblAlumno1";
            this.lblAlumno1.Size = new System.Drawing.Size(54, 13);
            this.lblAlumno1.TabIndex = 1;
            this.lblAlumno1.Text = "Alumno 1:";
            // 
            // lblAlumno2
            // 
            this.lblAlumno2.AutoSize = true;
            this.lblAlumno2.Location = new System.Drawing.Point(276, 135);
            this.lblAlumno2.Name = "lblAlumno2";
            this.lblAlumno2.Size = new System.Drawing.Size(54, 13);
            this.lblAlumno2.TabIndex = 2;
            this.lblAlumno2.Text = "Alumno 2:";
            // 
            // lblAlumno4
            // 
            this.lblAlumno4.AutoSize = true;
            this.lblAlumno4.Location = new System.Drawing.Point(276, 206);
            this.lblAlumno4.Name = "lblAlumno4";
            this.lblAlumno4.Size = new System.Drawing.Size(54, 13);
            this.lblAlumno4.TabIndex = 4;
            this.lblAlumno4.Text = "Alumno 4:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(276, 169);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(54, 13);
            this.lblAlumno.TabIndex = 3;
            this.lblAlumno.Text = "Alumno 3:";
            // 
            // txtAlumno1
            // 
            this.txtAlumno1.Location = new System.Drawing.Point(380, 95);
            this.txtAlumno1.Name = "txtAlumno1";
            this.txtAlumno1.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno1.TabIndex = 5;
            // 
            // txtAlumno2
            // 
            this.txtAlumno2.Location = new System.Drawing.Point(380, 132);
            this.txtAlumno2.Name = "txtAlumno2";
            this.txtAlumno2.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno2.TabIndex = 6;
            // 
            // txtAlumno3
            // 
            this.txtAlumno3.Location = new System.Drawing.Point(380, 166);
            this.txtAlumno3.Name = "txtAlumno3";
            this.txtAlumno3.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno3.TabIndex = 7;
            // 
            // txtAlumno4
            // 
            this.txtAlumno4.Location = new System.Drawing.Point(380, 199);
            this.txtAlumno4.Name = "txtAlumno4";
            this.txtAlumno4.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAlumno4);
            this.Controls.Add(this.txtAlumno3);
            this.Controls.Add(this.txtAlumno2);
            this.Controls.Add(this.txtAlumno1);
            this.Controls.Add(this.lblAlumno4);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblAlumno2);
            this.Controls.Add(this.lblAlumno1);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblAlumno1;
        private System.Windows.Forms.Label lblAlumno2;
        private System.Windows.Forms.Label lblAlumno4;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtAlumno1;
        private System.Windows.Forms.TextBox txtAlumno2;
        private System.Windows.Forms.TextBox txtAlumno3;
        private System.Windows.Forms.TextBox txtAlumno4;
    }
}

