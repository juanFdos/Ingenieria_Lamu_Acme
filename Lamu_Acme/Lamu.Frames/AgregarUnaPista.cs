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
    public partial class AgregarUnaPista : Form
    {
        public AgregarUnaPista()
        {
            InitializeComponent();
            LabTitulo.Text = "Ingrese un titulo:";
            LabSubtitulo.Text = "Ingrese un subtitulo:";
            LabInterprete.Text = "Ingrese un interprete:";
            LabGenero.Text = "Ingrese el genero: ";
        }

     
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
