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
        public string Identificacion { get; set; }
        public string Contrasenia { get; set; }
        public int IdCliente { get; set; }
        
        public InformacionUsuario(string nombre, string identificacion, string contraenia,int idcliente) 
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Contrasenia = contraenia;
            IdCliente = idcliente;
        }

        public override string ToString()
        {
            return "'"+Nombre +"','"+ Identificacion + "','"
                + Contrasenia + "','" + IdCliente.ToString()+"'";
        }
    }
}
