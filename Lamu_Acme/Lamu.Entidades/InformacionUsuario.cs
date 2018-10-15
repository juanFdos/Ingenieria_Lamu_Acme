using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Entidades
{
    public class InformacionUsuario 
    {
       
        private string Nombre { get; set; }
        private string Correo { get; set; }
        private string Contrasenia { get; set; }
        
        public InformacionUsuario(string nombre, string correo, string contraenia) 
        {
            Nombre = nombre;
            Correo = correo;
            Contrasenia = contraenia;
        }
    }
}
