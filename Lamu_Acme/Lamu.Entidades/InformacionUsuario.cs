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
        public string ConfirmacionContrasenia { get; set; }
        public int IdCliente { get; set; }
        
        public InformacionUsuario(string nombre, string identificacion, string contrasenia,int idcliente) 
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Contrasenia = contrasenia;
            IdCliente = idcliente;
        }

        public InformacionUsuario(string nombre, string identificacion, string contrasenia,string confContrasenia, int idcliente)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Contrasenia = contrasenia;
            ConfirmacionContrasenia = confContrasenia;
            IdCliente = idcliente;
        }

        public InformacionUsuario(string identificacion, string contrasenia)
        {
            Identificacion = identificacion;
            Contrasenia = contrasenia;
        }

        public override string ToString()
        {
            return "'"+Nombre +"','"+ Identificacion + "','"
                + Contrasenia + "','" + IdCliente.ToString()+"'";
        }
    }
}
