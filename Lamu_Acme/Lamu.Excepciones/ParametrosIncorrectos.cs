using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Excepciones
{
    public class ParametrosIncorrectos : Exception
    {

        public ParametrosIncorrectos()
        {
        }

        public ParametrosIncorrectos(string message)
            : base(message)
        {
        }

        public ParametrosIncorrectos(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
