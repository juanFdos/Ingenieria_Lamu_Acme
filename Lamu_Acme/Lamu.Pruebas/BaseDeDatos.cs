using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamu.BD;

namespace Lamu.Pruebas
{
    [TestClass]
    public class BaseDeDatos
    {
        [TestMethod]
        public void ComprobarCuandoElEstadoDeLaConexionEstaAbierta()
        {
            try
            {
                ConexionMySQL conexion = new ConexionMySQL();
                Assert.Equals(conexion.EstadoConexion(), true);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Data);
            }
        }

        
    }
}
