using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.BD.Interfaces;
using Lamu.Entidades;

namespace Lamu.BD
{
    public class BaseDeDatosSQL : IBaseDeDatos
    {
        private IConexion BaseDeDatos;

        public BaseDeDatosSQL(IConexion conexion)
        {
            BaseDeDatos = conexion;
        }

        public void AgregarCliente(InformacionCliente informacionCliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            try
            {
                BaseDeDatos.ValidarQueUnClienteNoExiste(informacionCliente.Identificacion);
                BaseDeDatos.EjecutarUnaOperacion(clienteDTO.AgregarCliente(informacionCliente));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarPista(InformacionPista informacionPista)
        {
            PistaDTO pistaDTO = new PistaDTO();
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarUsuario(InformacionUsuario informacionUsuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            try
            {
                BaseDeDatos.ValidarQueUnUsuarioNoExiste(informacionUsuario.Identificacion);
                BaseDeDatos.EjecutarUnaOperacion(usuarioDTO.AgregarUsuario(informacionUsuario));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ConsultarUsuario(InformacionUsuario informacionUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
