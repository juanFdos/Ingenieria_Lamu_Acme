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

        public List<InformacionCliente> ObtenerClientes()
        {
            try
            {
                List<InformacionCliente> clientes = new List<InformacionCliente>();
                clientes = BaseDeDatos.ConsultarTodosLosClientes();
                clientes.Insert(0, new InformacionCliente(0,"Seleccione una opción", ""));
                return clientes;
            }
            catch (Excepciones.ProblemasConLaConexion)
            {
                throw new Excepciones.ProblemasConLaConexion("Problemas con la conexión a la base de datos.") ;
            }
            
            
        }
        

    }
}
