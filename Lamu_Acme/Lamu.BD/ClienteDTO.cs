using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;

namespace Lamu.BD
{
    class ClienteDTO
    {

        public string AgregarCliente(InformacionCliente informacionCliente)
        {
            return "INSERT INTO CLIENTE(nombre,identificion)" +
                " VALUES(" + informacionCliente.ToString() + "); ";
        }

        public string ConsultarTodosLosClientes()
        {
            return "SELECT * FROM CLIENTE";
        }
    }
}
