using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;

namespace WebShoes.Aplicacao
{
    public interface IOrdemDeCompraAplicacao
    {
        OrdemDeCompra Adicionar(OrdemDeCompra ordem);
        OrdemDeCompra Atualizar(OrdemDeCompra ordem);
        OrdemDeCompra Buscar(int id);
        void Deletar(Calcado calcado);
    }
}
