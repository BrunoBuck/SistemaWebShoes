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

            ICalcadoAplicacao servico = new CalcadoAplicacao(repositoriofake.Object);

            Calcado novoCalcado = servico.CriarCalcado(calcado);
            repositoriofake.Verify(x => x.Adicionar(calcado));
            
        }

        [TestMethod]
        public void RetornarCalcadoAplicacao()
        {
            var repositorioFake = new Mock<ICalcadoAplicacao>();
            repositorioFake.Setup(x => x.BuscarCalcado(1)).Returns(new Calcado());

            ICalcadoAplicacao servico = new CalcadoAplicacao(repositorioFake.Object);
            Calcado calcado = servico.BuscarCalcado(1);
        }

        public void AtualizarCalcado()
        {
            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW",
                                            "Nike",
                                            "Vermelho",
                                            41, 300);

            var repositorioFake = new Mock<ICalcadoRepositorio>();
            repositorioFake.Setup(x => x.Atualizar(calcado)).Returns(new Calcado());
            repositorioFake.Setup(x => x.BuscarTodos()).Returns(new List<Calcado>());

            ICalcadoAplicacao servico = new CalcadoAplicacao(repositorioFake.Object);
            Calcado novoCalcado = servico.AtualizarCalcado(calcado);
        }
    }
}
