using MySql.Data.MySqlClient;

namespace Lamu.BD.Interfaces

{
    public interface IConexion
    {
        bool EstadoConexion();

        void EjecutarUnaOperacion(string operacion);

        void EjecutarUnaConsulta(string consulta);

        void ValidarQueUnUsuarioNoExiste(string identificacion);

        void ValidarQueUnClienteNoExiste(string identificacion);
    }
}