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
        private IConexion Conexion;

        public BaseDeDatosSQL(IConexion conexion)
        {
            Conexion = conexion;
        }

        public void AgregarCliente(InformacionCliente informacionCliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            try
            {
                Conexion.ValidarQueUnClienteNoExiste(informacionCliente.Identificacion);
                Conexion.EjecutarUnaOperacionInsertUpdateDelete(clienteDTO.AgregarCliente(informacionCliente));
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
                Conexion.ValidarQueUnaPistaNoExista(informacionPista.Titulo,informacionPista.Interprete);
                Conexion.EjecutarUnaOperacionInsertUpdateDelete(pistaDTO.AgregarPista(informacionPista));
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
                Conexion.ValidarQueUnUsuarioNoExiste(informacionUsuario.Identificacion);
                Conexion.EjecutarUnaOperacionInsertUpdateDelete(usuarioDTO.AgregarUsuario(informacionUsuario));
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

        public List<InformacionCliente> ConsultarTodosLosClientes()
        {
            List<InformacionCliente> clientes = new List<InformacionCliente>();
            try
            {
                return Conexion.ConsultarTodosLosClientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarUnLog(string accion)
        {
            try
            {
                Conexion.InsertarUnLog(accion);
            }
            catch (Exception)
            {

                throw;
            }
        }
<<<<<<< HEAD
=======

        public void AutenticarUnUsuario(string identificacion, string contrasenia)
        {
            throw new NotImplementedException();
        }
>>>>>>> 05b69be37cd44a4ea3092eb2e70b25ad59ea9656
    }
}
