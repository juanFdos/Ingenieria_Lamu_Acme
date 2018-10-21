using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Excepciones
{
    public class ProblemasConLaConexion: Exception
    {
        public ProblemasConLaConexion()
        {
        }

        public ProblemasConLaConexion(string message)
            : base(message)
        {

        }

        public ProblemasConLaConexion(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
