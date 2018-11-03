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
        BaseDeDatosSQL baseDeDatos = new BaseDeDatosSQL(new ConexionMySQL());
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
                new InformacionUsuario(TxtBoxUsuario.Text.ToString(), TxtBoxContrasenia.Text.ToString());
                Login_usuario();
                usuarioRegistrado.ValidarUnUsuario(informacionUsuario);

                if (BaseDeDatosSQL.datosDeUsuario.Identificacion == informacionUsuario.Identificacion && BaseDeDatosSQL.datosDeUsuario.Contrasenia == informacionUsuario.Contrasenia)
                {
                    MessageBox.Show(this, "Bienvenido", "¡Éxito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    this.Close();

                }
                else
                {
                    MessageBox.Show(this, "Error al ingresar al sistema, verifica tu identificacion y contraseña", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al ingresar al sistema, verifica tu identificacion y contraseña", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }

        }

        private void LimpiarCampos()
        {
            TxtBoxUsuario.Clear();
            TxtBoxContrasenia.Clear();
        }

        private void Login_usuario()
        {
            try
            {

                usuarioRegistrado = new UsuarioRegistrado(baseDeDatos, new LogMySQL(baseDeDatos));


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
