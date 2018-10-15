using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Entidades
{
    public class InformacionUsuario 
    {
       
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        
        public InformacionUsuario(string nombre, string correo, string contraenia) 
        {
            Nombre = nombre;
            Correo = correo;
            Contrasenia = contraenia;
        }
    }
}
