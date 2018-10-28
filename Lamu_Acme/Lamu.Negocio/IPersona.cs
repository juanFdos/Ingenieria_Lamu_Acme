using Lamu.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamu.Negocio
{
    public interface IPersona
    {
        void ValidarUnUsuario(InformacionUsuario informacionUsuario);
        bool ValidarCampos(InformacionUsuario informacionUsuario);
    }
}
