using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio.Contratos
{
    public interface IOrdemDeCompraRepositorio
    {
        OrdemDeCompra Adicionar(OrdemDeCompra ordem);
        OrdemDeCompra Buscar(int id);
        List<OrdemDeCompra> BuscarTodos();
        OrdemDeCompra Atualizar(OrdemDeCompra ordem);
        void Deletar(OrdemDeCompra ordem);
    }
}
