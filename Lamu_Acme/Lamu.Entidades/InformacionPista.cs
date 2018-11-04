using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Entidades
{
    public class InformacionPista
    {
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Interprete { get; set; }
        public string Genero { get; set; }
        

        public InformacionPista(string titulo, string subtitulo, string interprete, string genero)
        {
            Titulo = titulo;
            Subtitulo = subtitulo;
            Interprete = interprete;
            Genero = genero;
        }

        public override string ToString()
        {
            return "'"+Titulo+"','"+Subtitulo + "','" +Interprete + "','" +Genero+"'";
        }
    }
}
