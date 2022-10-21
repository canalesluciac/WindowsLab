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
            double totalPagado = 0, suma, maximo = 0;
            string nombreOperario = "nombre";

            for (int i = 0; i < 3; i++)
            {
                nombres[i] = Interaction.InputBox("Nombre del operario: ");
                suma = sumaTrimestral();
                maximo = mayorIngreso(suma, maximo, ref nombreOperario, nombres[i]);
                totalPagado += suma;
            }
            MessageBox.Show("Total pagado: $" + totalPagado + "\n" + nombreOperario + " tuvo el mayor ingreso acumulado ($" + maximo + ")");
        }

        #region mis métodos
        double sumaTrimestral ()
        {
            double[] sueldo = new double[3];
            double suma = 0;
            string texto = "";
            for (int j = 0; j<3; j++)
            {
                texto = "Sueldo de ultimo " + (j+1) + " meses: ";
                sueldo[j] = Convert.ToDouble(Interaction.InputBox(texto));
                suma += sueldo[j];
            }
            return suma;

        }

        double mayorIngreso(double suma, double maximo, ref string nombreMayor, string nombreAct)
        {
            double aux;
            if (suma > maximo)
            {
                aux = suma;
                nombreMayor = nombreAct;
            }
            else
                aux = maximo;
            return aux;
        }
        #endregion
    }
}
