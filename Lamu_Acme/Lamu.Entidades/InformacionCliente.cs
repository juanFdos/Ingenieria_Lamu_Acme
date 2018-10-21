using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Entidades
{
   public class InformacionCliente
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
       

        public InformacionCliente(string nombre, string identificacion)
        {
            Nombre = nombre;
            Identificacion = identificacion;
        }


        public override string ToString()
        {
            return "'"+Nombre+"','"+Identificacion+"'" ;
        }
    }
}
