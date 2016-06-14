using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Dominio;
using WebShoes.Dominio.Exceptions;

namespace WebShoes.Testes.Dominio
{
    [TestClass]
    public class CalcadoTeste
    {
        [TestMethod]
        public void CriarCalcadoTeste()
        {
            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW", "Nike", "Vermelho", 41);
            Assert.AreEqual("TÊNIS NIKE AIR JORDAN 1 LOW - Nike - Vermelho - 41", calcado.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void CriarCalcadoModeloEmBrancoTeste()
        {
            Calcado calcado = new Calcado("", "Nike", "Vermelho", 41);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void CriarCalcadoMarcaEmBrancoTeste()
        {
            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW", "", "Vermelho", 41);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void CriarCalcadoCorEmBrancoTeste()
        {
            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW", "Nike", "", 41);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void CriarCalcadoTamanhoInvalidoTeste()
        {
            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW", "Nike", "Vermelho", 215);
        }
    }
}
