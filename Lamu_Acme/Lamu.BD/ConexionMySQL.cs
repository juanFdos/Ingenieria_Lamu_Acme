using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Lamu.BD.Interfaces;
using Lamu.Entidades;
using Lamu.Excepciones;

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

        internal IBaseDeDatos BaseDeDatos;
       

        public ConexionMySQL(IBaseDeDatos baseDeDatos)
        {
          
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Servidor;
            builder.Port = Puerto;
            builder.UserID = Usuario;
            builder.Password = Password;
            builder.Database = Database;
            builder.SslMode = MySqlSslMode.None;
            BaseDeDatos = baseDeDatos;

            Conexion = new MySqlConnection(builder.ToString());
            
        }

        public MySqlDataReader EjecutarUnaConsulta(string consulta)
        {
            MySqlCommand commandDatabase = new MySqlCommand(consulta, Conexion);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                if (EstaCerradaLaConexion())
                    Conexion.Open();

                reader = commandDatabase.ExecuteReader();
                
                if (!reader.Read())
                    throw new Excepciones.ConsultaNoTraeResultados("La consulta no obtuvo datos");
               
                return reader;
            }
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion("Problemas con la conexión a la base de datos.");
            }

        }

        public void EjecutarUnaOperacionInsertUpdateDelete(string operacion)
        {
           
            MySqlCommand commandDatabase = new MySqlCommand(operacion, Conexion);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                if (EstaCerradaLaConexion())
                    Conexion.Open();

                reader = commandDatabase.ExecuteReader();
                Conexion.Close();
            }
            catch (MySqlException ex)
            {
                throw ex;
                //throw new Excepciones.ProblemasConLaConexion("Problemas con la conexión a la base de datos.");
            }
        }

       private void EjecutarUnProcedimientoAlmacenado(string procedimiento,string[] nombreParametro, string[] parametro)
        {
            try
            {
                Conexion.Open();
                MySqlCommand comando = new MySqlCommand
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

               
                comando.Connection = Conexion;
                comando.CommandText = procedimiento;
              

                for (int i = 0; i < parametro.Length; i++)
                {
                    comando.Parameters.AddWithValue(nombreParametro[i], parametro[i]);
                }
                comando.ExecuteNonQuery();

                Conexion.Close();
              
            }
            catch (MySqlException ex)
            {
                Conexion.Close();
                throw ex;
               
            }

        }


        public bool EstaCerradaLaConexion()
        {
           return Conexion.State == System.Data.ConnectionState.Closed;
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
            catch (MySqlException ex)
            {
                throw ex;
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
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void ValidarQueUnaPistaNoExista(string titulo, string interprete)
        {
            try
            {
                string[] parametros = new string[2];
                parametros[0] = titulo;
                parametros[1] = interprete;
                string[] nombreParametros = new string[2];
                nombreParametros[0] = "nombre";
                nombreParametros[1] = "autor";
                EjecutarUnProcedimientoAlmacenado("procedure_consultar_si_existe_una_pista", nombreParametros, parametros);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarUnLog(string msg)
        {
            try
            {
                string[] parametros = new string[1];
                parametros[0] = msg;                
                string[] nombreParametros = new string[1];
                nombreParametros[0] = "VSACCION";
                
                EjecutarUnProcedimientoAlmacenado("procedure_crear_un_log", nombreParametros, parametros);
            }
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion("Problemas con la conexión a la base de datos.");
            }
        }

        public List<InformacionCliente> ConsultarTodosLosClientes()
        {
            List<InformacionCliente> clientes = new List<InformacionCliente>();
            try
            {
                MySqlDataReader reader = this.EjecutarUnaConsulta(new ClienteDTO().ConsultarTodosLosClientes());
                clientes.Add(new InformacionCliente(reader.GetInt32("idCliente"), reader.GetString("nombre"), reader.GetString("identificacion")));
                while (reader.Read())
                {
                    clientes.Add(new InformacionCliente(reader.GetInt32("idCliente"), reader.GetString("nombre"), reader.GetString("identificacion")));
                    
                }
                Conexion.Close();
                return clientes;
            }
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion("Problemas con la conexión a la base de datos.");
            }
        }

        public void AutenticarUsuario(string identificacionUsuario, string contraseniaUsuario, string query)
        {
            

          
            MySqlConnection conn = new MySqlConnection(Conexion.ToString());
            conn.Open();


            MySqlCommand mycomand = new MySqlCommand(query, conn);
            mycomand.Parameters.AddWithValue("?identificacionUsuario", identificacionUsuario);

            mycomand.Parameters.AddWithValue("?contraseniaUsuario", contraseniaUsuario);


            MySqlDataReader myreader = mycomand.ExecuteReader();
            BaseDeDatos.ObtenerDatosDeUsuario(myreader);
            

            /*
            try
            {
                string[] parametros = new string[2];
                parametros[0] = identificacion;
                parametros[1] = contrasenia;
                string[] nombreParametros = new string[2];
                nombreParametros[0] = "VCIDENTIFICACION";
                nombreParametros[1] = "VCCONTRASENIA";
                EjecutarUnProcedimientoAlmacenado("procedure_autenticar_Un_usuario", nombreParametros, parametros);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            */
            
        }

    }
}
