using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Infra.Dados.Contexto;
using WebShoes.Testes.Dados.Base;
using System.Data.Entity;
using WebShoes.Infra.Dados.Repositorio;
using WebShoes.Dominio;
using System.Collections.Generic;
using WebShoes.Dominio.Contratos;
using WebShoes.Dominio.Exceptions;

namespace WebShoes.Testes.Dados
{
    [TestClass]
    public class CalcadoTesteDados
    {
        private CalcadoContexto _contexto;
        private ICalcadoRepositorio _repositorio;

        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new CriarNovoBancoCalcado<CalcadoContexto>());

            _contexto = new CalcadoContexto();
            _repositorio = new CalcadoRepositorio();

            _contexto.Database.Initialize(true);

            _contexto.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        [TestMethod]
        public void CriarCalcadoRepositorioTeste()
        {
            Calcado calcado = new Calcado("Tenis Air", "Nike", "Azul", 40, 300);

            _repositorio.Adicionar(calcado);

            Calcado novoCalcado = _contexto.Calcados.Find(calcado.Id);

            Assert.IsTrue(calcado.Id > 0);
            Assert.AreEqual(calcado.Cor, "Azul");
            Assert.AreEqual(calcado.Marca, "Nike");
            Assert.AreEqual(calcado.Valor, 300);
        }

        [TestMethod]
        public void RetornarCalcadoRepositorioTest()
        {
            Calcado calcado = _repositorio.Buscar(1);

            Assert.IsNotNull(calcado);
        }

        [TestMethod]
        public void RetornaTodosOsCalcadosRepositorioTest()
        {
            List<Calcado> calcados = _repositorio.BuscarTodos();

            Assert.AreEqual(10, calcados.Count);
        }

        [TestMethod]
        public void AtualizaProdutoRepositorioTeste()
        {
            Calcado calcado = _contexto.Calcados.Find(1);

            calcado.Modelo = "Tenis Mercurial";
            calcado.Cor = "Roxo";
            calcado.Tamanho = 39;

            _repositorio.Atualizar(calcado);

            Calcado calcadoAtualizado = _contexto.Calcados.Find(1);
            Assert.AreEqual("Tenis Mercurial", calcadoAtualizado.Modelo);
            Assert.AreEqual("Roxo", calcadoAtualizado.Cor);
            Assert.AreEqual(39, calcadoAtualizado.Tamanho);
        }

        [TestMethod]
        public void DeletarCalcadoRepositorioTeste()
        {
            Calcado calcado = new Calcado("Tenis Air", "Nike", "Azul", 40, 300);

            Calcado calcadoCriado = _repositorio.Adicionar(calcado);

            _repositorio.Deletar(calcadoCriado);

            Calcado calcadoDeletado = _contexto.Calcados.Find(calcadoCriado.Id);
            Assert.IsNull(calcadoDeletado);
        }
    }
}
