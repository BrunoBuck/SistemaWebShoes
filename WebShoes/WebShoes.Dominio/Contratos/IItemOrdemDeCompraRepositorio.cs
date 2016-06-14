using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio.Contratos
{
    public interface IItemOrdemDeCompraRepositorio
    {
        ItemOrdemDeCompra Adicionar(ItemOrdemDeCompra item);
        ItemOrdemDeCompra Buscar(int id);
        List<ItemOrdemDeCompra> BuscarTodos();
        ItemOrdemDeCompra Atualizar(ItemOrdemDeCompra item);
        void Deletar(ItemOrdemDeCompra item);
    }
}
