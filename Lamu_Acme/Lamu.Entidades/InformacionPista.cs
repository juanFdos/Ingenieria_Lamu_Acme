using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Entidades
{
    public class InformacionPista
    {
        private string Titulo { get; set; }
        private string Subtitulo { get; set; }
        private string Interprete { get; set; }
        private string Genero { get; set; }
        private int Duracion { get; set; }

        public InformacionPista(string titulo, string subtitulo, string interprete, string genero, int duracion)
        {
            Titulo = titulo;
            Subtitulo = subtitulo;
            Interprete = interprete;
            Genero = genero;
            Duracion = duracion;
        }
    }
}
