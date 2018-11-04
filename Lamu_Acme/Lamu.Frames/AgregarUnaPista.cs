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
    public partial class AgregarUnaPista : Form
    {
        private Pista pista;
        public AgregarUnaPista()
        {
            InitializeComponent();
        }


        private void AgregarPista_Click_1(object sender, EventArgs e)
        {
            try
            {
                BaseDeDatosSQL baseDeDatos = new BaseDeDatosSQL(new ConexionMySQL());

                pista = new Pista(baseDeDatos, new LogMySQL(baseDeDatos));

                InformacionPista informacionPista =
                 new InformacionPista(TxtBoxTitulo.Text, TxtBoxSubtitulo.Text, TxtBoxInterprete.Text, TxtBoxGenero.Text);
                pista.ValidarUnaPista(informacionPista);
                switch (MessageBox.Show(this, "Pista agregada satisfactoriamente\n ¿Desea ingresar otra pista?", "Exito!",
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
            TxtBoxTitulo.Clear();
            TxtBoxSubtitulo.Clear();
            TxtBoxInterprete.Clear();
            TxtBoxGenero.Clear();
        }
    }
}
