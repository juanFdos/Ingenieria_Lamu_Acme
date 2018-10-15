using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


using Lamu.Entidades;
using Lamu.Negocio.Interfaces;


namespace Lamu.Negocio
{
    public class BaseDeDatosArchivoPlano : IBaseDeDatos
    {
        private string Ruta;
        private static string Clientes = "clientes.txt";
        private static string Usuarios = "usuarios.txt";

        public BaseDeDatosArchivoPlano()
        {
            string rutacompleta = Directory.GetCurrentDirectory();
            Ruta = Path.Combine(rutacompleta, "BD");
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
            string InformacionJSON = JsonConvert.SerializeObject(informacionUsuario);
        }

        public void ConsultarUsuario(InformacionUsuario informacionUsuario)
        {
          
            string datos =  File.ReadAllText(Path.Combine(Ruta,Usuarios));
          
            List <InformacionUsuario> listaUsuarios = JsonConvert.DeserializeObject<List<InformacionUsuario>>(datos);

            foreach (var usuario in listaUsuarios)
            {
                if (informacionUsuario.Equals(usuario))
                    break;
            }
        }
    }
}
