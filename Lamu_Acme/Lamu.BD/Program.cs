using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                baseDeDatos.AgregarCliente(new Entidades.InformacionCliente("Adidas", "1234"));
                Console.WriteLine("melo");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
            Console.Read();
        }
    }
}
