using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;

namespace Lamu.BD
{
    public class PistaDTO
    {
        public string AgregarPista(InformacionPista informacionPista)
        {
            return "INSERT INTO PISTA(titulo,subtitulo,interprete,genero)" +
                " VALUES(" + informacionPista.ToString() + "); ";
        }

        public string ConsultarTodasLasPistas()
        {
            return "SELECT * FROM pista;";
        }
    }
}
