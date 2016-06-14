using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Infra.Dados.Contexto;
using WebShoes.Dominio.Contratos;
using System.Data.Entity;
using WebShoes.Testes.Dados.Base;
using WebShoes.Infra.Dados.Repositorio;

namespace WebShoes.Testes.Dados
{
    /// <summary>
    /// Summary description for ItemOrdemDeCompraTesteDados
    /// </summary>
    [TestClass]
    public class ItemOrdemDeCompraTesteDados
    {
        private ItemOrdemDeCompraContexto _contexto;
        private IItemOrdemDeCompraRepositorio _repositorio;

        [TestInitialize]
        public void Initialize()
        {
            Database.SetInitializer(new CriarNovoBancoCalcado<ItemOrdemDeCompraContexto>());

            _contexto = new ItemOrdemDeCompraContexto();
            _repositorio = new ItemOrdemDeCompraRepositorio();

            _contexto.Database.Initialize(true);

            _contexto.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        [TestMethod]
        public void CriarItemOrdemDeCompraRepositorioTeste()
        {
        }

        [TestMethod]
        public void RetornarItemOrdemDeCompraRepositorioTest()
        {

        }

        [TestMethod]
        public void RetornaTodosOsItemOrdemDeCompraRepositorioTest()
        {

        }

        [TestMethod]
        public void AtualizaItemOrdemDeCompraRepositorioTeste()
        {
            

        }

        [TestMethod]
        public void DeletarItemOrdemDeCompraRepositorioTeste()
        {
            
        }
    }
}
