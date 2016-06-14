using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Dominio;

namespace WebShoes.Testes.Dominio
{
    [TestClass]
    public class OrdemDeCompraTeste
    {
        [TestMethod]
        public void CriarOrdemDeCompraTeste()
        {
            OrdemDeCompra ordem = new OrdemDeCompra("Aguardando Pagamento", new DateTime(2016, 6, 13, 10, 55, 31), new List<ItemOrdemDeCompra>());
            Assert.AreEqual("Aguardando Pagamento - 13/06/2016 10:55:31", ordem.ToString());
        }
    }
}
