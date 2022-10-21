using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PracticaDeMetodos
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            double bases = Convert.ToDouble(Interaction.InputBox("Ingrese base del rectangulo (cm): "));
            double altura = Convert.ToDouble(Interaction.InputBox("Ingrese altura del rectangulo (cm): ", "Area"));

            MessageBox.Show("Area del rectangulo: " + bases * altura + " cm2");
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(Interaction.InputBox("Ingrese diametro del circulo (cm): "));
            MessageBox.Show("Area del circulo: " + Math.PI * Math.Pow(radio/2, 2)+ " cm2", "Area");
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            double baseMenor = Convert.ToDouble(Interaction.InputBox("Ingrese base menor del trapecio (cm): "));
            double baseMayor = Convert.ToDouble(Interaction.InputBox("Ingrese base mayor del trapecio (cm)"));
            double altura = Convert.ToDouble(Interaction.InputBox("Ingrese altura del trapecio (cm): "));

            MessageBox.Show("Area del trapecio: " + (baseMayor + baseMenor)/2*altura+" cm2", "Area");
        }
    }
}
