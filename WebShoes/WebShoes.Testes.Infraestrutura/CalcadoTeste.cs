using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShoes.Dados.Contexto;
using System.Data.Entity;
using WebShoes.Testes.Infraestrutura.Base;
using WebShoes.Dados.Repositorios;

namespace WebShoes.Testes.Dados
{
    [TestClass]
    public class CalcadoTeste
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
        public void CriarProdutoRepositorioTeste()
        {
            Produto produto = new Produto("Tenis", 100, 10, "", new CategoriaProduto("Calcado"));

            _repositorio.Adicionar(produto);

            Produto novoProduto = _contexto.Produtos.Find(produto.Id);

            Assert.IsTrue(novoProduto.Id > 0);
            Assert.AreEqual(produto.Valor, novoProduto.Valor);
            Assert.AreEqual(produto.Nome, novoProduto.Nome);
        }

        [TestMethod]
        public void RetornarProdutoRepositorioTest()
        {
            Produto produto = _repositorio.Buscar(1);

            Assert.IsNotNull(produto);
        }

        [TestMethod]
        public void RetornaTodosOsProdutosRepositorioTest()
        {
            List<Produto> produtos = _repositorio.BuscarTodos();

            Assert.AreEqual(10, produtos.Count);
        }

        [TestMethod]
        public void AtualizaProdutoRepositorioTeste()
        {
            Produto produto = _contexto.Produtos.Find(1);

            produto.Nome = "Sapato";
            produto.Valor = 200;
            produto.Quantidade = 15;

            _repositorio.Atualizar(produto);

            Produto produtoAtualizado = _contexto.Produtos.Find(1);
            Assert.AreEqual("Sapato", produtoAtualizado.Nome);
            Assert.AreEqual(200, produtoAtualizado.Valor);
            Assert.AreEqual(15, produtoAtualizado.Quantidade);
        }

        [TestMethod]
        public void DeletarProdutoRepositorioTeste()
        {
            Produto produto = _repositorio.Buscar(1);

            _repositorio.Deletar(produto);

            Produto produtoDeletado = _contexto.Produtos.Find(1);
            Assert.IsNull(produtoDeletado);
        }
    }
}
