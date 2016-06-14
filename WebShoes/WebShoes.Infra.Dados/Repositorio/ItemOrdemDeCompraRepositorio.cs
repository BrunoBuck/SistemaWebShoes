using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;
using WebShoes.Dominio.Contratos;
using WebShoes.Infra.Dados.Contexto;

namespace WebShoes.Infra.Dados.Repositorio
{
    public class ItemOrdemDeCompraRepositorio : IItemOrdemDeCompraRepositorio
    {
        private ItemOrdemDeCompraContexto _contexto;

        public ItemOrdemDeCompraRepositorio()
        {
            _contexto = new ItemOrdemDeCompraContexto();
        }

        public ItemOrdemDeCompra Adicionar(ItemOrdemDeCompra item)
        {
            var resultado = _contexto.Itens.Add(item);
            _contexto.SaveChanges();
            return resultado;
        }

        public ItemOrdemDeCompra Atualizar(ItemOrdemDeCompra item)
        {
            var entry = _contexto.Entry<ItemOrdemDeCompra>(item);
            entry.State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();

            return item;
        }

        public ItemOrdemDeCompra Buscar(int id)
        {
            return _contexto.Itens.Find(id);
        }

        public List<ItemOrdemDeCompra> BuscarTodos()
        {
            return _contexto.Itens.ToList();
        }

        public void Deletar(ItemOrdemDeCompra item)
        {
            var entry = _contexto.Entry<ItemOrdemDeCompra>(item);
            entry.State = System.Data.Entity.EntityState.Deleted;
            _contexto.SaveChanges();
        }
    }
}
