using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lamu.Entidades;
using Lamu.Negocio;

namespace Lamu.Pruebas
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        public void validarCamposDeClientesVacios()
        {
            //Arrange
            Cliente cliente = new Cliente();
            InformacionCliente infoCliente = new InformacionCliente("", "123");

            //Act
            bool resultado = cliente.ValidarCampos(infoCliente);

            //Assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void validarCamposDePistasVacios()
        {
            //Arrange
            Pista pista = new Pista();
            InformacionPista infoPista = new InformacionPista("", "", "Maluma", "Indefinido");

            //Act
            bool resultado = pista.ValidarCampos(infoPista);

            //Assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void validarCamposDeUsuariosVacios()
        {
            //Arrange
            Usuario usuario = new Usuario();
            InformacionUsuario infoUsuario = new InformacionUsuario("", "123","","",2);

            //Act
            bool resultado = usuario.ValidarCampos(infoUsuario);

            //Assert
            Assert.IsTrue(resultado);

        }
    }
}
