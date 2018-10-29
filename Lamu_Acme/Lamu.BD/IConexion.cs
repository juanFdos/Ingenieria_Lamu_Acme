using MySql.Data.MySqlClient;
using Lamu.Entidades;
using System.Collections.Generic;
using System;

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

        void InsertarUnLog(string msg);

        void AutenticarUsuario(string identificacion, string contrasenia, string query);
        
    }
}