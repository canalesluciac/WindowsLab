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
    public partial class frm3_operarios : Form
    {
        public frm3_operarios()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            string[] nombres = new string[3];
            double[] sueldo = new double[3];
            double totalPagado = 0, suma, acumOperario = 0;
            string nombreOperario = "nombre";


            for (int i = 0; i < nombres.Length; i++)    // operario
            {
                nombres[i] = cargaNombre(nombres, i);
                suma = 0;
                for (int j=0; j<sueldo.Length; j++)     // sueldo mensual
                {
                    sueldo[j] = cargaSueldo(sueldo, j, nombres[i]);
                    suma += sueldo[j];
                }
                acumOperario = maximoOperario(suma, acumOperario, i);
                nombreOperario = maximoOperario(nombres, i, suma, acumOperario);

                totalPagado += suma;
            }
            MessageBox.Show("Total pagado: $" + totalPagado + "\n" + nombreOperario + " tuvo el mayor ingreso acumulado ($" + acumOperario + ")", "Resultados");
        }

        #region mis métodos
        string cargaNombre (string[] nombres, int i)
        {
            return Interaction.InputBox("Nombre del operario: ", "Ingrese nombre");
        }

        double cargaSueldo(double[] sueldo, int mes, string nombre)
        {
            string texto = "";
            texto = "Sueldo de ultimo " + (mes + 1) + "° mes de " + nombre +": ";
            return Convert.ToDouble(Interaction.InputBox(texto, "Ingrese sueldo"));
        }

        string maximoOperario(string[] nombres, int i, double suma, double maximo)
        {
            if (i == 0 || suma > maximo)
                return nombres[0];
            else
                return nombres[i];
        }

        double maximoOperario(double suma, double maximo, int i)
        {
            if (i == 0 || suma > maximo)
                return suma;
            else
                return -1;
        }

       
        #endregion
    }
}
