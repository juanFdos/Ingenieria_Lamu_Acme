using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Excepciones
{
    public class ConsultaNoTraeResultados: Exception
    {
        public ConsultaNoTraeResultados()
        {
        }

        public ConsultaNoTraeResultados(string message)
            : base(message)
        {
        }

        public ConsultaNoTraeResultados(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
