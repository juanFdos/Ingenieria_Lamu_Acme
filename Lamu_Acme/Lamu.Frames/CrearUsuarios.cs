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
    public partial class CrearUsuarios : Form
    {
        public CrearUsuarios()
        {
            InitializeComponent();
            LabNombre.Text = "Ingrese el nombre: ";
            LabCorreo.Text = "Ingrese un correo\nelectronico: ";
            LabContrasenia.Text = "Ingrese una \ncontraseña: ";
            LabConfirmacionContrasenia.Text = "Ingrese de nuevo la \ncontraseña: ";
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
