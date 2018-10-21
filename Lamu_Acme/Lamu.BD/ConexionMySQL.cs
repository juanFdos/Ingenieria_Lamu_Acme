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

        private MySqlDataReader EjecutarUnaConsulta(string consulta)
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
                throw new Excepciones.ProblemasConLaConexion();
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
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion();
            }
        }

       private void EjecutarUnProcedimientoAlmacenado(string procedimiento,string[] nombreParametro, string[] parametro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = Conexion;
                comando.CommandText = procedimiento;
                if (EstaCerradaLaConexion())
                    Conexion.Open();

                for (int i = 0; i < parametro.Length; i++)
                {
                    comando.Parameters.AddWithValue(nombreParametro[i], parametro[i]);
                }
                
                
                comando.ExecuteNonQuery();
              
            }
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion();
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
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion();
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
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion();
            }
        }

        public void ValidarQueUnaPistaNoExista(string titulo, string interprete)
        {
            try
            {
                string[] parametros = new string[1];
                parametros[0] = titulo;
                parametros[1] = interprete;
                string[] nombreParametros = new string[1];
                nombreParametros[0] = "nombre";
                nombreParametros[1] = "autor";
                EjecutarUnProcedimientoAlmacenado("procedure_consultar_si_existe_una_pista", nombreParametros, parametros);
            }
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion();
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
                return clientes;
            }
            catch (MySqlException)
            {
                throw new Excepciones.ProblemasConLaConexion();
            }
        }
    }
}
