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
            builder.SslMode = MySqlSslMode.None;

            Conexion = new MySqlConnection(builder.ToString());
            
        }

        public void EjecutarUnaConsulta(string consulta)
        {
            throw new NotImplementedException();
        }

        public void EjecutarUnaOperacion(string operacion)
        {
           
            MySqlCommand commandDatabase = new MySqlCommand(operacion, Conexion);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                
                reader = commandDatabase.ExecuteReader();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public void EjecutarUnProcedimientoAlmacenado(string procedimiento,string[] nombreParametro, string[] parametro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = Conexion;
                comando.CommandText = procedimiento;
                Conexion.Open();
                for (int i = 0; i < parametro.Length; i++)
                {
                    comando.Parameters.AddWithValue(nombreParametro[i], parametro[i]);
                }
                
                
                comando.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        public bool EstadoConexion()
        {
            Conexion.Open();
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
                return true;
            }
            else
            {
                Conexion.Close();
                return false;
            }
               
        }

        public void ValidarQueUnUsuarioNoExiste(string identificacion)
        {
            try
            {
                string[] parametros = new string[1];
                parametros[0] = identificacion;
                string[] nombreParametros = new string[1];
                nombreParametros[0] = "nit";
                EjecutarUnProcedimientoAlmacenado("procedure_consultar_si_existe_un_usuario", nombreParametros, parametros);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public void ValidarQueUnClienteNoExiste(string identificacion)
        {
            try
            {
                string[] parametros = new string[1];
                parametros[0] = identificacion;
                string[] nombreParametros = new string[1];
                nombreParametros[0] = "nit";
                EjecutarUnProcedimientoAlmacenado("procedure_consultar_si_existe_un_cliente",nombreParametros, parametros);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

    }
}
