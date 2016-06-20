using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Dominio;
using WebShoes.Aplicacao;
using Moq;
using WebShoes.Dominio.Contratos;
using System.Collections.Generic;

namespace WebShoes.Testes.Aplicacao
{
    [TestClass]
    public class CalcadoTesteAplicacao
    {
        [TestMethod]
        public void CriarCalcadoAplicacaoTeste()
        {

            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW", 
                                            "Nike", 
                                            "Vermelho", 
                                            41, 300);

            // ARRANGE - CONFIGURAR OBJETO MENTIRA
            var repositoriofake = new Mock<ICalcadoRepositorio>();
            repositoriofake.Setup(x => x.Adicionar(calcado)).Returns(new Calcado());
            repositoriofake.Setup(x => x.BuscarTodos()).Returns(new List<Calcado>());
        }
    }
}
