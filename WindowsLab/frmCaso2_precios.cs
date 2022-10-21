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
    public partial class frmCaso2_precios : Form

    {
        public frmCaso2_precios()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            string[] productos = new string[5];
            double[] precios = new double[5];
            double suma = 0;

            for (int i = 0; i < 5; i++)
            {
                productos[i] = nombreProducto(productos[i], i);
                precios[i] = precioProducto(precios[i], productos[i]);
                suma = sumaPrecios(suma, precios[i]);
            }
            MessageBox.Show("Suma total: $" + suma);
            
        }

        #region Mis Métodos
        string nombreProducto (string producto, int numero)
        {
            return Interaction.InputBox("Ingrese el NOMBRE del producto", "Nombre del producto");
        }

        double precioProducto (double precio, string producto)
        {
            return Convert.ToDouble(Interaction.InputBox("Ingrese el PRECIO de " + producto + " ($)", "Precio del producto"));
        }

        double sumaPrecios (double suma, double precio)
        {
            return suma + precio;
        }
        #endregion
    }
}
