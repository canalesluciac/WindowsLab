using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class frm1_NotasVectores : Form
    {
        public frm1_NotasVectores()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string alumno1 = txtAlumno1.Text, alumno2 = txtAlumno2.Text, alumno3 = txtAlumno3.Text, alumno4 = txtAlumno4.Text, texto = "";
            string[] alumnos = {alumno1 , alumno2, alumno3, alumno4};
            double[] notas = new double[3];
            double maximo, suma;

            foreach(string alumno in alumnos)
            {
                maximo = -1;
                suma = 0;
                texto += alumno;
                for(int i = 0; i < 3; i++)
                {
                    notas[i] = cargarNota(i, alumno);
                    maximo = maximaNota(notas[i], maximo);
                    suma += notas[i];
                    texto += "\t" + Math.Round(notas[i],2);
                }
                texto += "\n";
                MessageBox.Show("Alumno " + alumno + "\nMaxima nota: " + maximo + "\nPromedio: " + promedio(suma));
            }
            MessageBox.Show(texto, "Resultados");

            
        }
        #region mis métodos

        double cargarNota(int nroNota, string alumno)
        {
            return Convert.ToDouble(Interaction.InputBox("Ingrese la " + (nroNota + 1) + "a nota de " + alumno));
        }

        double maximaNota(double nota, double maximo)
        {
            if (nota > maximo)
                return nota;
            else
                return maximo;
        }

        string promedio (double suma)
        {
            double aux = Math.Round(suma / 3 , 2);
            string texto;
            if (aux < 4)
                texto = aux + ". Debe ir a recuperatorio";
            else if (aux > 4 && aux < 6)
                texto = aux + ". Bien";
            else
                texto = aux + ". Muy bien";
            return texto;
        }
        #endregion
    }
}
