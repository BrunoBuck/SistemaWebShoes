using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Dominio;

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
    }
}
