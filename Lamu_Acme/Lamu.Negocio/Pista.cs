using Lamu.BD.Interfaces;
using Lamu.Soporte;
using Lamu.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Negocio
{
    public class Pista
    {
        public IBaseDeDatos BaseDeDatos;
        public ILog Log;
        private string mensajeDeError;

        public Pista(IBaseDeDatos baseDeDatos, ILog log)
        {
            BaseDeDatos = baseDeDatos;
            Log = log;
        }

        public void ValidarUnaPista(InformacionPista informacionPista)
        {

            if (ValidarCampos(informacionPista))
                throw new Excepciones.ParametrosIncorrectos(mensajeDeError);
            try
            {
                BaseDeDatos.AgregarPista(informacionPista);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public bool ValidarCampos(InformacionPista informacionPista)
        {
            mensajeDeError = "Se presentaron los siguiente errores: \n";
            int contador = 0;
            if (String.IsNullOrEmpty(informacionPista.Titulo))
            {
                mensajeDeError += "--> Titulo esta vacio \n";
                contador++;
            }

            if (String.IsNullOrEmpty(informacionPista.Subtitulo))
            {
                mensajeDeError += "--> Subtitulo esta vacio \n";
                contador++;
            }
            if (String.IsNullOrEmpty(informacionPista.Interprete))
            {
                mensajeDeError += "--> Interprete esta vacio \n";
                contador++;
            }
            if (String.IsNullOrEmpty(informacionPista.Genero))
            {
                mensajeDeError += "--> Genero esta vacio \n";
                contador++;
            }

            return contador > 0;


        }
    }
}
