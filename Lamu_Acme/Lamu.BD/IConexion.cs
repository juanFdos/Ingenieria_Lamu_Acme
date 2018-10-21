using MySql.Data.MySqlClient;
using Lamu.Entidades;
using System.Collections.Generic;

namespace Lamu.BD.Interfaces

{
    public interface IConexion
    {
        bool EstaCerradaLaConexion();

        void EjecutarUnaOperacionInsertUpdateDelete(string operacion);

        void ValidarQueUnUsuarioNoExiste(string identificacion);

        void ValidarQueUnClienteNoExiste(string identificacion);

        void ValidarQueUnaPistaNoExista(string titulo, string interprete);

        List<InformacionCliente> ConsultarTodosLosClientes();
    }
}