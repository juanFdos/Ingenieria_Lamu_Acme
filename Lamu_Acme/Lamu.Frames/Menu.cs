using System;
using System.Windows.Forms;

namespace Lamu.Frames
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnHU1_Click(object sender, EventArgs e)
        {
            Form Autenticacion = new AutenticarUsuario();
            Autenticacion.Show();
        }

        private void BtnHU4_Click(object sender, EventArgs e)
        {
            Form CreacionDeUsuarios = new CrearUsuarios();
            CreacionDeUsuarios.Show();
        }

        private void BtnHU5_Click(object sender, EventArgs e)
        {
            Form CreacionDeClientes = new CrearClientes();
            CreacionDeClientes.Show();
        }

        private void BtnHU6_Click(object sender, EventArgs e)
        {
            Form AgregarUnaPista = new AgregarUnaPista();
            AgregarUnaPista.Show();
        }
    }
}
