using Lamu.BD.Interfaces;
using Lamu.Entidades;
using Lamu.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Negocio
{
   public class Cliente   
    {

        public IBaseDeDatos BaseDeDatos;
        public ILog Log;
        private string mensajeDeError;

        public Cliente(IBaseDeDatos baseDeDatos, ILog log)
        {
            BaseDeDatos = baseDeDatos;
            Log = log;
        }

        public void ValidarUnCliente(InformacionCliente informacionCliente)
        {

            if (ValidarCampos(informacionCliente))
                throw new Excepciones.ParametrosIncorrectos(mensajeDeError);
            try
            {
                BaseDeDatos.AgregarCliente(informacionCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private bool ValidarCampos(InformacionCliente informacionCliente)
        {
            mensajeDeError = "Se presentaron los siguiente errores: \n";
            int contador = 0;
            if (String.IsNullOrEmpty(informacionCliente.Nombre))
            {
                mensajeDeError += "--> Nombre esta vacio \n";
                contador++;
            }

            if (String.IsNullOrEmpty(informacionCliente.Identificacion))
            {
                mensajeDeError += "--> Identifiacion esta vacio \n";
                contador++;
            }

            return contador > 0;


        }

    }
}
