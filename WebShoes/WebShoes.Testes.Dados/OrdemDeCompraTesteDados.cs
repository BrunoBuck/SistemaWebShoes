using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Infra.Dados.Contexto;
using WebShoes.Dominio.Contratos;
using System.Data.Entity;
using WebShoes.Testes.Dados.Base;
using WebShoes.Infra.Dados.Repositorio;
using WebShoes.Dominio;

namespace WebShoes.Testes.Dados
{
    /// <summary>
    /// Summary description for ItemOrdemDeCompraTesteDados
    /// </summary>
    [TestClass]
    public class OrdemDeCompraTesteDados
    {
        private CalcadoContexto _contexto;
        private IOrdemDeCompraRepositorio _repositorio;

        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new CriarNovoBancoCalcado<CalcadoContexto>());

            _contexto = new CalcadoContexto();
            _repositorio = new OrdemDeCompraRepositorio();

            _contexto.Database.Initialize(true);

            _contexto.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        [TestMethod]
        public void CriarOrdemDeCompraRepositorioTeste()
        {
            Calcado calcado = new Calcado("TÊNIS NIKE AIR JORDAN 1 LOW", "Nike", "Vermelho", 41, 300);

            ItemOrdemDeCompra item = new ItemOrdemDeCompra(calcado, 10, 2);

            OrdemDeCompra ordem = new OrdemDeCompra("Saiu para Entrega", new DateTime(2016, 6, 13, 10, 55, 31), new List<ItemOrdemDeCompra>());

            ordem.AdicionarItens(item);

            _repositorio.Adicionar(ordem);

            OrdemDeCompra ordemCriada = _repositorio.Buscar(ordem.Id);

            Assert.IsTrue(ordemCriada.Id > 0);
            Assert.AreEqual(ordemCriada.ValorTotal(), 540);
            Assert.AreEqual(ordemCriada.Status, "Saiu para Entrega");
        }

        [TestMethod]
        public void RetornarOrdemDeCompraRepositorioTest()
        {
            OrdemDeCompra ordem = _repositorio.Buscar(1);

            Assert.IsNotNull(ordem);
        }

        [TestMethod]
        public void RetornaTodasAsOrdemDeCompraRepositorioTest()
        {
            List<OrdemDeCompra> ordens = _repositorio.BuscarTodos();

            Assert.AreEqual(10, ordens.Count);
        }

        [TestMethod]
        public void AtualizaOrdemDeCompraRepositorioTeste()
        {
            OrdemDeCompra ordem = _repositorio.Buscar(1); //_contexto.Ordens.Find(1);

            ordem.Status = "Entregue";
            ordem.Data = new DateTime(2016, 6, 20, 12, 55, 31);

            OrdemDeCompra ordemCriad = _repositorio.Atualizar(ordem);

            OrdemDeCompra ordemAtualizada = _repositorio.Buscar(1);
            Assert.AreEqual("Entregue", ordemAtualizada.Status);
            Assert.AreEqual(new DateTime(2016, 6, 20, 12, 55, 31), ordemAtualizada.Data);

        }

        [TestMethod]
        public void DeletarOrdemDeCompraRepositorioTeste()
        {
            OrdemDeCompra ordem = _repositorio.Buscar(1);            

            _repositorio.Deletar(ordem);
            
            OrdemDeCompra ordemDeletada = _contexto.Ordens.Find(1);
            Assert.IsNull(ordemDeletada);
        }
    }
}
