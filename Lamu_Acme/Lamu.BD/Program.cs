using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;

namespace Lamu.BD
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionMySQL conexion = new ConexionMySQL();
            BaseDeDatosSQL baseDeDatos = new BaseDeDatosSQL(conexion);
            try
            {
                List<InformacionCliente> clientes = baseDeDatos.ConsultarTodosLosClientes();

                foreach (var cliente in clientes)
                {
                    Console.WriteLine(cliente);
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
            Console.Read();
        }
    }
}
