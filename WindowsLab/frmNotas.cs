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

namespace WindowsLab
{
    public partial class frmNotas : Form
    {
        //private string[] nombresAlumnos; //List<string> Namelist = new List<string>();
        private int[] notasAlumno;

        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            double maximoDeAlumno, sumaDeAlumno, promedioAlumno;
            string alumno1 = txtNombre1.Text, alumno2 = txtNombre2.Text, alumno3 = txtNombre3.Text, alumno4 = txtNombre4.Text;
            string[] nombresAlumnos = { alumno1, alumno2, alumno3, alumno4 };
            //nombresAlumnos = new string[4];                             //nombresAlumnos = new string[nombresAlumnos.Length];
            notasAlumno = new int[3];

            foreach(string alumno in nombresAlumnos)
            {
                // alumno = Interaction.InputBox("Ingrese el nombre del alumno: "); //string nombre = Interaction.InputBox("Ingrese el nombre del alumno: "); Namelist.Add(nombre);

                maximoDeAlumno = -1;
                sumaDeAlumno = 0;
                
                foreach(int nota in notasAlumno)
                {
                    if (nota > maximoDeAlumno)
                        maximoDeAlumno = nota;
                    sumaDeAlumno += nota;
                }
                promedioAlumno = sumaDeAlumno / 3;
                Interaction.InputBox(alumno + ": " + notasAlumno[0] + ", " + notasAlumno[1] + ", " + notasAlumno[2] + "\nMaxima nota: " + maximoDeAlumno + "\nPromedio: " + promedioAlumno) ;

                if (promedioAlumno < 4)
                    MessageBox.Show("Debe ir a recuperatorio", "Nota " + promedioAlumno);
                else if (promedioAlumno > 4 && promedioAlumno < 7)
                    MessageBox.Show("Bien", "Nota " + promedioAlumno);
                else
                    MessageBox.Show("Muy bien", "Nota " + promedioAlumno);
            }

            /*for (int i= 0; i < 4; i++) // recorre alumno
            {
                                                                        
                nombresAlumnos[i] = Interaction.InputBox("Ingrese el nombre del alumno: "); //string nombre = Interaction.InputBox("Ingrese el nombre del alumno: "); Namelist.Add(nombre);

                maximoDeAlumno = -1;
                sumaDeAlumno = 0;

                for (int j=0; j<3; j++) // recorre notas 
                {
                    notasAlumno[i] = Convert.ToInt32(Interaction.InputBox("Ingrese la nota " + (j + 1) + " de " + nombresAlumnos[i]));

                    if (notasAlumno[i] > maximoDeAlumno)
                        maximoDeAlumno = notasAlumno[i];
                    sumaDeAlumno += notasAlumno[i];
                
                }
                promedioAlumno = sumaDeAlumno / 3;
                if (promedioAlumno < 4)
                    MessageBox.Show("Debe ir a recuperatorio", "Nota " + promedioAlumno);
                else if (promedioAlumno > 4 && promedioAlumno < 7)
                    MessageBox.Show("Bien", "Nota " + promedioAlumno);
                else
                    MessageBox.Show("Muy bien", "Nota " + promedioAlumno);
            } 
            */

            /*foreach(string alumno in nombresAlumnos)
            {
                for(int k=0; k<8; k++)
                {
                    Interaction.InputBox(alumno);
                    if (k<3)
                    {
                        Interaction.InputBox(notasAlumno[k] + " - ");
                    }
                }
            }*/
        }

   
    }
}
