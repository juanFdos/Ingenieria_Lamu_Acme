using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.BD.Interfaces;
using Lamu.Entidades;
using MySql.Data.MySqlClient;

namespace Lamu.BD
{
    public class BaseDeDatosSQL : IBaseDeDatos
    {
        private IConexion Conexion;
        public static InformacionUsuario datosDeUsuario { get; set; }

        public BaseDeDatosSQL(IConexion conexion)
        {
            Conexion = conexion;
        }

        public BaseDeDatosSQL()
        {
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
                Conexion.EjecutarUnaOperacionInsertUpdateDelete(operacion: usuarioDTO.AgregarUsuario(informacionUsuario));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ConsultarUsuario(InformacionUsuario informacionUsuario)
        {
            
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

        public void AutenticarUnUsuario(InformacionUsuario informacionUsuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            try
            {
                Conexion.AutenticarUsuario(informacionUsuario.Identificacion, informacionUsuario.Contrasenia, usuarioDTO.BuscarUsuario(informacionUsuario.Identificacion,informacionUsuario.Contrasenia));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ObtenerDatosDeUsuario(MySqlDataReader myreader)
        {

            if (myreader.Read())
            {
                datosDeUsuario = new InformacionUsuario(myreader["identificacion"].ToString(), myreader["contrasenia"].ToString());
            }

        }
    }
}
