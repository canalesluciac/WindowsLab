using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class frm5_temperaturaMedia : Form
    {
        public frm5_temperaturaMedia()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] provincias = new string[4];
            double[] temperatura = new double[12];
            double mediaTrimestral, mediaHistorica = -99.9;
            int maxTempIndice = 0;
            string maxMedia = "", mediaProvincias = "";

            cargaPcias(ref provincias, 4);
            cargaTemperatura(ref temperatura, provincias, 12);
            imprimir(provincias, temperatura);

            for (int i = 0; i < 4; i++)
            {
                mediaTrimestral = tempMediaTrimestral(temperatura, i);
                maxMedia = mediaTrimestralMayor(provincias, ref maxTempIndice, i, mediaTrimestral, ref mediaHistorica);
                mediaProvincias += provincias[i] + ": " + mediaTrimestral + "°\n";
            }
            MessageBox.Show(mediaProvincias + "\nMaxima temperatura media: " + maxMedia + " (" + mediaHistorica + "°)", "Media Provincias e Historica");
        }

        #region metodos
        void cargaPcias(ref string[] provincias, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                provincias[i] = Interaction.InputBox("Ingrese PROVINCIA");
            }
        }

        void cargaTemperatura(ref double[] temperatura, string[] provincias, int cantidad)
        {
            int cont = 0, cont2 = 1;
            for (int i = 0; i < cantidad; i++, cont2++)
            {
                if (cont2 == 5)
                    cont2 = 1;
                string aux = "Ingrese TEMPERATURA MENSUAL " + cont2 + " de " + provincias[cont];
                temperatura[i] = Convert.ToDouble(Interaction.InputBox(aux));
                if ((i + 1) % 4 == 0)
                    cont++;

            }
        }

        void imprimir(string[] provincias, double[] temperaturas)
        {
            string aux = "";
            int cont = 0;
            foreach (string provincia in provincias)
            {
                aux += "\n" + provincia + " ";
                for (int i = 0; i < 3; i++, cont++)
                {
                    aux += temperaturas[cont] + "°  ";

                }

            }
            MessageBox.Show(aux, "Temperaturas");
        }

        double tempMediaTrimestral(double[] temperaturas, int cantidad)
        {
            double suma = 0, promedio;
            int start;

            if (cantidad == 0)
                start = 0;
            else
                start = cantidad * 3;

            for(int i = start; i<(start+3); i++)
                suma += temperaturas[i];

            promedio = suma / 3;
            return promedio;
        }

        string mediaTrimestralMayor(string[] provincias, ref int maxTempIndice,  int i, double mediaAct, ref double mediaHistorica)
        {
            string mayor = provincias[maxTempIndice];
            if (mediaAct > mediaHistorica)
            {
                mediaHistorica = mediaAct;
                mayor = provincias[i];
                maxTempIndice = i;
            }
            return mayor;
        }
        #endregion

    }


}
