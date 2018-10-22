using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;
using Lamu.BD;
using Lamu.BD.Interfaces;
using Lamu.Soporte;
using System.Text.RegularExpressions;

namespace Lamu.Negocio
{
    public class Usuario
    {
        public IBaseDeDatos BaseDeDatos;
        public ILog Log;
        private string mensajeDeError;

        public Usuario(IBaseDeDatos baseDeDatos, ILog log)
        {
            BaseDeDatos = baseDeDatos;
            Log = log;
        }

        public void ValidarUnUsuario(InformacionUsuario informacionUsuario)
        {
            
            if (ValidarCampos(informacionUsuario))
                throw new Excepciones.ParametrosIncorrectos(mensajeDeError);
            try
            {
                BaseDeDatos.AgregarUsuario(informacionUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            
        }
        private bool ValidarCampos(InformacionUsuario informacionUsuario)
        {
            mensajeDeError = "Se presentaron los siguiente errores: \n";
            int contador = 0;
            if (String.IsNullOrEmpty(informacionUsuario.Nombre)) 
            {
                mensajeDeError += "--> Nombre esta vacio \n";
                contador++;
            }

            if (String.IsNullOrEmpty(informacionUsuario.Identificacion))
            {
                mensajeDeError += "--> Identifiacion esta vacio \n";
                contador++;
            }
            if (String.IsNullOrEmpty(informacionUsuario.Contrasenia))
            {
                mensajeDeError += "--> Contraseña esta vacio \n";
                contador++;
            }
            if (String.IsNullOrEmpty(informacionUsuario.ConfirmacionContrasenia))
            {
                mensajeDeError += "--> Confirmación de la contraseña esta vacio \n";
                contador++;
            }
            if (!informacionUsuario.ConfirmacionContrasenia.Equals(informacionUsuario.Contrasenia))
            {
                mensajeDeError += "--> Las Contraseñas no coinciden \n";
                contador++;
            }
            if (informacionUsuario.IdCliente == 0)
            {
                mensajeDeError += "--> No se selecciona una empresa \n";
                contador++;
            }
        
            return contador > 0;
         

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
