using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;
using WebShoes.Dominio.Contratos;
using WebShoes.Infra.Dados.Contexto;
using System.Data.Entity;

namespace WebShoes.Infra.Dados.Repositorio
{
    public class OrdemDeCompraRepositorio : IOrdemDeCompraRepositorio
    {
        private CalcadoContexto _contexto;

        public OrdemDeCompraRepositorio()
        {
            _contexto = new CalcadoContexto();

        }

        public OrdemDeCompra Adicionar(OrdemDeCompra ordem)
        {
            var resultado = _contexto.Ordens.Add(ordem);

            _contexto.SaveChanges();
            return resultado;
        }

        public OrdemDeCompra Atualizar(OrdemDeCompra ordem)
        {
            var entry = _contexto.Entry<OrdemDeCompra>(ordem);
            entry.State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();

            return ordem;
        }

        public OrdemDeCompra Buscar(int id)
        {
            OrdemDeCompra ordem = _contexto.Ordens.Find(id);
            _contexto.Entry(ordem).Collection(i => i.Itens).Load();
            return ordem;
        }

        public List<OrdemDeCompra> BuscarTodos()
        {
            return _contexto.Ordens.ToList();
        }

        public void Deletar(OrdemDeCompra ordem)
        {
            for (int i = 0; i < ordem.Itens.Count; i++)
            {
                var ent = _contexto.Entry<ItemOrdemDeCompra>(ordem.Itens[i]);
                ent.State = System.Data.Entity.EntityState.Deleted;
                _contexto.SaveChanges();
            }
            var entry = _contexto.Entry<OrdemDeCompra>(ordem);
            entry.State = System.Data.Entity.EntityState.Deleted;
            _contexto.SaveChanges();
        }
    }
}
