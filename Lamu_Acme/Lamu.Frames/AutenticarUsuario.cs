using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lamu.Frames
{
    public partial class AutenticarUsuario : Form
    {
        public AutenticarUsuario()
        {
            InitializeComponent();
            LabContrasenia.Text = "Ingrese su\ncontraseña: ";
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
