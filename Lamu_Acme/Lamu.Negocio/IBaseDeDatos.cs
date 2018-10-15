using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;

namespace Lamu.Negocio.Interfaces
{
    public interface IBaseDeDatos
    {
        void AgregarUsuario(InformacionUsuario informacionUsuario);

        void AgregarPista(InformacionPista informacionPista);
    }
}
