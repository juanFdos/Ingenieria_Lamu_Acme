
using Lamu.Entidades;
using Lamu.Negocio;
using Lamu.BD;
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
    public partial class CrearUsuarios : Form
    {
        private Usuario usuario;
        private string IdCliente;
        

        public CrearUsuarios()
        {
            InitializeComponent();
            LabNombre.Text = "Ingrese el nombre: ";
            LabIdentificacion.Text = "Ingrese la \nidentificación: ";
            LabContrasenia.Text = "Ingrese una \ncontraseña: ";
            LabConfirmacionContrasenia.Text = "Ingrese de nuevo la \ncontraseña: ";
            LabIdCliente.Text = "Seleccione la empresa \nA cual pertenece: ";
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionUsuario informacionUsuario =
      new InformacionUsuario(TxtBoxNombre.Text, TxtBoxIdentifiacion.Text, TxtBoxContrasenia.Text,
      TxtBoxConfirmacionContrasenia.Text, int.Parse(IdCliente));
                usuario.ValidarUnUsuario(informacionUsuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                BaseDeDatosSQL baseDeDatos = new BaseDeDatosSQL(new ConexionMySQL());
                
                usuario = new Usuario(baseDeDatos, new LogMySQL(baseDeDatos));
                CBoxIdCliente.DataSource = usuario.ObtenerClientes();
                CBoxIdCliente.DisplayMember = "Nombre";
                CBoxIdCliente.ValueMember = "IdCliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
        }

        private void CBoxIdCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.IdCliente = CBoxIdCliente.SelectedValue.ToString();
            this.BtnGuardar.Focus();
        }
    }
}
