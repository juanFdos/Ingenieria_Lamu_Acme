using Lamu.BD;
using Lamu.Entidades;
using Lamu.Negocio;
using Lamu.Soporte;
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
        private UsuarioRegistrado usuarioRegistrado;
        private BaseDeDatosSQL baseDeDatosSQL;
        public AutenticarUsuario()
        {
            InitializeComponent();
            LabContrasenia.Text = "Ingrese su\ncontraseña: ";
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionUsuario informacionUsuario =
                new InformacionUsuario(TxtBoxUsuario.Text, TxtBoxContrasenia.Text);
                usuarioRegistrado.ValidarUnUsuario(informacionUsuario);
                if (baseDeDatosSQL.datosUsuario[0]==informacionUsuario.Identificacion && baseDeDatosSQL.datosUsuario[1] == informacionUsuario.Contrasenia)
                {
                    MessageBox.Show(this, "Bienvenido", "Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Error al ingresar al sistema, verifica tu identifucacion y contraseña", "Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
