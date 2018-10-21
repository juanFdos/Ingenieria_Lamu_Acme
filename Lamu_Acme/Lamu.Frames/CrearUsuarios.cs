using Lamu.BD;
using Lamu.Entidades;
using Lamu.Negocio;
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
            LabCorreo.Text = "Ingrese un correo\nelectronico: ";
            LabContrasenia.Text = "Ingrese una \ncontraseña: ";
            LabConfirmacionContrasenia.Text = "Ingrese de nuevo la \ncontraseña: ";
            LabIdCliente.Text = "Seleccione la empresa \nA cual pertenece: ";
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // usuario.validar();

        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {

            usuario = new Usuario(new BaseDeDatosSQL(new ConexionMySQL()));
            CBoxIdCliente.Items.Add("Seleccione una opción");
            List<InformacionCliente> clientes = usuario.BaseDeDatos.ConsultarTodosLosClientes();
            clientes.Insert(0, new InformacionCliente("Seleccione una opción", "-1"));
            CBoxIdCliente.DataSource = clientes;
            CBoxIdCliente.DisplayMember = "Nombre";
            CBoxIdCliente.ValueMember = "Identificacion";



        }

        private void CBoxIdCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.IdCliente = CBoxIdCliente.SelectedValue.ToString();
            MessageBox.Show(IdCliente);
            this.LabCorreo.Focus();
        }
    }
}
