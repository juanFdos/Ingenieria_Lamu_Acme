using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamu.Entidades;

namespace Lamu.BD
{
    public class UsuarioDTO
    {

        InformacionUsuario informacionUsuario;
       
        public string AgregarUsuario(InformacionUsuario informacionUsuario)
        {
            return "INSERT INTO USUARIO(nombre,identificacion,contrasenia,idCliente)" +
                " VALUES("+informacionUsuario.ToString() +"); ";
        }

        public string BuscarUsuario(string identificacionUsuario, string contraseniaUsuario)
        {
            return "Select * From usuario Where identificacion =" + identificacionUsuario + " AND contrasenia =" + contraseniaUsuario + ";";
        }

    }
}
