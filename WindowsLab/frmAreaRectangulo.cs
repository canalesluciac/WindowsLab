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
    public partial class frmAreaRectangulo : Form
    {
        public frmAreaRectangulo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int largo = Convert.ToInt32(txtLargo.Text);
            int ancho = Convert.ToInt32(txtAncho.Text);

            MessageBox.Show("Area del rectangulo: " + largo * ancho, "Area del rectangulo");
        }
    }
}
