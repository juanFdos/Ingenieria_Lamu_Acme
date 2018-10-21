using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;
using Lamu.BD.Interfaces;
using Lamu.Soporte;

namespace Lamu.Negocio
{
    public class Usuario
    {
        public IBaseDeDatos BaseDeDatos;
        public ILog Log;

        public Usuario(IBaseDeDatos baseDeDatos, ILog log)
        {
            BaseDeDatos = baseDeDatos;
            Log = log;
        }

        public void ValidarUnUsuario(InformacionUsuario informacionUsuario)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
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
            catch (Excepciones.ProblemasConLaConexion ex)
            {
                Log.GuardarAccion(ex);
                throw ex;
            }

        }
        

    }
}
