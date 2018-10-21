using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;
using Lamu.BD;
using Lamu.BD.Interfaces;

namespace Lamu.Negocio
{
    public class Usuario
    {
         public IBaseDeDatos BaseDeDatos { get; set; }

        public Usuario(IBaseDeDatos baseDeDatos)
        {
            BaseDeDatos = baseDeDatos;
        }

     
        

    }
}
