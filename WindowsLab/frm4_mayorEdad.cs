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
    public partial class frm4_mayorEdad : Form
    {
        public frm4_mayorEdad()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            const int cantidad = 5;
            string[] nombres = new string[cantidad];
            int[] edades = new int[cantidad];

            cargaNombres(cantidad, ref nombres);
            cargaEdades(ref edades, nombres, cantidad);
            imprimir(nombres, edades, cantidad);
        }

    #region mis metodos
        void cargaNombres(int j, ref string[] nombres)
        {
            for (int i = 0; i < j; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese NOMBRE");       
            }
        }

        void cargaEdades(ref int[] edades, string[] nombres, int j)
        {
            for (int i = 0; i < j; i++)
            {
                string aux = "Ingrese EDAD de " + nombres[i];
                edades[i] = Convert.ToInt32(Interaction.InputBox(aux));
            }
        }

        void imprimir(string[] nombres, int[] edades, int cantidad)
        {
            string mayoresEdad = "";
            for (int i=0; i<cantidad; i++)
            {
                if (edades[i] >= 18)
                {
                    mayoresEdad += " " + nombres[i];
                }
            }
            MessageBox.Show("Personas mayores de edad:" + mayoresEdad);
        }

        #endregion

    }
}
