using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDeMetodos
{
    public partial class frmNacimiento : Form
    {
        public frmNacimiento()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime nacimiento = dateTimePicker1.Value;
            
            Imprimir(nombre, apellido);
            Imprimir(nombre, apellido, nacimiento);
            MessageBox.Show("Hoy es " + DateTime.Today, "Fecha actual");
        }

        #region mis metodos
        private void Imprimir (string nombre, string apellido)
        {
            MessageBox.Show("Nombre completo: " + nombre + ", " + apellido, "Nombre completo");
        }

        private void Imprimir (string nombre, string apellido, DateTime nacimiento)
        {
            int edad = DateTime.Now.Year - nacimiento.Year;
            MessageBox.Show(nombre + " " + apellido + " tiene " + edad + " anios", "Edad");
        }
        #endregion
    }
}
