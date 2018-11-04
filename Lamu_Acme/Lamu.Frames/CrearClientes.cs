using System;
using Lamu.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lamu.Entidades;
using Lamu.BD;
using Lamu.Soporte;

namespace Lamu.Frames
{
    public partial class CrearClientes : Form
    {
        private Cliente cliente;

        public CrearClientes()
        {
            InitializeComponent();
            LabNombre.Text = "Ingrese el \nNombre";
            LabIdentificacion.Text = "Ingrese un \nidentificación: ";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDatosSQL baseDeDatos = new BaseDeDatosSQL(new ConexionMySQL());

                cliente = new Cliente(baseDeDatos, new LogMySQL(baseDeDatos));

                InformacionCliente informacionCliente =
      new InformacionCliente(TxtBoxNombre.Text, TxtBoxIdentificacion.Text);
                cliente.ValidarUnCliente(informacionCliente);
                switch (MessageBox.Show(this, "Cliente creado satisfactoriamente\n ¿Desea ingresar otro cliente?", "Exito!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        LimpiarCampos();
                        break;

                    case DialogResult.No:
                        this.Close();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarCampos()
        {
            TxtBoxIdentificacion.Clear();
            TxtBoxNombre.Clear();
        }

    }
}
