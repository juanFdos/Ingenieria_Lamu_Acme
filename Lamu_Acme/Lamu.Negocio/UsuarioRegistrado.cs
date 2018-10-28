using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.BD.Interfaces;
using Lamu.Entidades;
using Lamu.Soporte;

namespace Lamu.Negocio
{
    public class UsuarioRegistrado : IPersona
    {
        public IBaseDeDatos BaseDeDatos;
        public ILog Log;
        private string mensajeDeError;

        public UsuarioRegistrado(IBaseDeDatos baseDeDatos, ILog log)
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
                BaseDeDatos.AutenticarUnUsuario(informacionUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool ValidarCampos(InformacionUsuario informacionUsuario)
        {
            mensajeDeError = "Se presentaron los siguiente errores: \n";
            int contador = 0;

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
            
            return contador > 0;
        }

    }
}
