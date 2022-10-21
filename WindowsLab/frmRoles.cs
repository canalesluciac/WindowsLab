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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtNombre.Text;
            string sex = txtSexo.Text;
            string role = txtRol.Text;

            if (validateSex(sex) && validateRole(role))
                MessageBox.Show("Nombre de usuario: " + username + "\nSexo: " + sex + "\nRol: " + role, "Datos Validos. Bienvenido");
        }

        private bool validateRole (string role)
        {
            if (role.ToUpper().Equals("ADMINISTRADOR") || role.ToUpper().Equals("ESTANDAR") || role.ToUpper().Equals("INVITADO"))
                return true;
            else
            {
                MessageBox.Show("Datos ingresados inválidos. \nIngrese un rol valido (administrador, estandar o invitado)", "Error");
                return false;
            }
                
        }

        private bool validateSex (string sex)
        {
            if (sex.ToUpper().Equals("FEMENINO") || sex.ToUpper().Equals("MASCULINO") || sex.ToUpper().Equals("OTRO")) 
                return true;
            else
                MessageBox.Show("Datos ingresados inválidos. \nIngrese un sexo/genero valido (femenino, masculino u otro)", "Error");
            return false;
        }
    }
}
