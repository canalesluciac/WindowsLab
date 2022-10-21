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
    public partial class frmMultiplicar : Form
    {
        public frmMultiplicar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string tabla = "";

            for (int i = 0; i <= 12; i++)
            {
                tabla = (tabla + numero + " x " + i + " = " + numero * i + "\n");
            }

            MessageBox.Show(tabla, "Tabla de multiplicacion");
        }
    }
}
