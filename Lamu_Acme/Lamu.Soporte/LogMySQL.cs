using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Soporte;
using Lamu.BD.Interfaces;

namespace Lamu.Soporte
{
    public class LogMySQL : ILog
    {
        private IBaseDeDatos BaseDeDatos;

        public LogMySQL(IBaseDeDatos baseDeDatos)
        {
            BaseDeDatos = baseDeDatos;
        }

        public void GuardarAccion(Exception ex)
        {
            BaseDeDatos.AgregarUnLog(ex.Message);
        }
    }
}
