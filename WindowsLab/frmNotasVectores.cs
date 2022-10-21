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
    public partial class frmNotasVectores : Form
    {
        public frmNotasVectores()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string alumno1 = txtAlumno1.Text, alumno2 = txtAlumno2.Text, alumno3 = txtAlumno3.Text, alumno4 = txtAlumno4.Text;
            string[] alumnos = {alumno1 , alumno2, alumno3, alumno4};
            int[] notas = new int[3];
            float maximo, suma;

            foreach(string alumno in alumnos)
            {
                maximo = -1;
                suma = 0;
                for(int i = 0; i < 3; i++)
                {
                    notas[i] = Convert.ToInt32(Interaction.InputBox("Ingrese la " + (i+1) + "a nota de " + alumno));
                    if (notas[i] > maximo)
                        maximo = notas[i];
                    suma += notas[i];
                }
                MessageBox.Show("Alumno " + alumno + "\nMaxima nota: " + maximo + "\nPromedio: " + promedio(suma));
            }

            
        }

        string promedio (float suma)
        {
            float aux = suma / 3;
            string texto;
            if (aux < 4)
                texto = aux + ". Debe ir a recuperatorio";
            else if (aux > 4 && aux < 6)
                texto = aux + ". Bien";
            else
                texto = aux + ". Muy bien";
            return texto;
        }
    }
}
