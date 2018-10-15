using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Soporte
{
     public interface ILog
    {
        void GuardarError(Exception ex);

        void GuardarAccion(string msg);
    }
}
