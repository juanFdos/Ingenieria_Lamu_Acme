using MySql.Data.MySqlClient;

namespace Lamu.BD.Interfaces

{
    public interface IConexion
    {
        bool EstadoConexion();
        MySqlConnection getConexion();
    }
}