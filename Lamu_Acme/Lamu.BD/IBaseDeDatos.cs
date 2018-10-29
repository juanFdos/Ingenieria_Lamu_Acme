using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;
using MySql.Data.MySqlClient;

namespace Lamu.BD.Interfaces
{
    public interface IBaseDeDatos
    {
        void AgregarUsuario(InformacionUsuario informacionUsuario);

        void AgregarPista(InformacionPista informacionPista);

        void AgregarCliente(InformacionCliente informacionCliente);

        List<InformacionCliente> ConsultarTodosLosClientes();

        void AgregarUnLog(string accion);

        void AutenticarUnUsuario(InformacionUsuario informacionUsuario);

        List<string> ObtenerDatosDeUsuario(MySqlDataReader myreader);

    }
}
