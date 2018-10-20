using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Lamu.BD.Interfaces;

namespace Lamu.BD
{
    public class ConexionMySQL : IConexion
    {
        private MySqlConnection Conexion;
        private string Servidor = "localhost";
        private uint Puerto = 3306;
        private string Usuario = "root";
        private string Password = "";
        private string Database = "lamu";

        public ConexionMySQL()
        {
          
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Servidor;
            builder.Port = Puerto;
            builder.UserID = Usuario;
            builder.Password = Password;
            builder.Database = Database;
            
            Conexion = new MySqlConnection(builder.ToString());
            Conexion.Open();
        }

        public bool EstadoConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                return true;
            
            else
                return false;
        }

        public MySqlConnection getConexion() { return Conexion; }

    }
}
