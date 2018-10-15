using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;
using System.IO;
using Lamu.Negocio.Interfaces;

namespace Lamu.Negocio
{
    public class BaseDeDatosArchivoPlano : IBaseDeDatos
    {
        private string Ruta;

        public BaseDeDatosArchivoPlano()
        {
            string rutacompleta = Directory.GetCurrentDirectory();
            Ruta = Path.Combine(rutacompleta, "LOGS", "log.txt");
        }

        public void AgregarCliente(InformacionCliente informacionCliente)
        {
            throw new NotImplementedException();
        }

        public void AgregarPista(InformacionPista informacionPista)
        {
            throw new NotImplementedException();
        }

        public void AgregarUsuario(InformacionUsuario informacionUsuario)
        {
            
        }
    }
}
