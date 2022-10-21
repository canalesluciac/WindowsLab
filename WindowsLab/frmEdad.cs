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
    public partial class frmEdad : Form
    {
        public frmEdad()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtEdad.Text);

            if (age == 0)
                MessageBox.Show("ERROR");
            else if (age < 18)
                MessageBox.Show("Menor de edad");
            else if (age < 60)
                MessageBox.Show("Mayor de edad");
            else
                MessageBox.Show("Persona adulta mayor");
        }
    }
}
