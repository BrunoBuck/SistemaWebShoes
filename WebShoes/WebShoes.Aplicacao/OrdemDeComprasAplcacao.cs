using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;

namespace WebShoes.Aplicacao
{
    public class OrdemDeComprasAplcacao : IOrdemDeCompraAplicacao
    {
        private IOrdemDeCompraAplicacao _repositorio;

        public OrdemDeComprasAplcacao(IOrdemDeCompraAplicacao repositorio)
        {
            _repositorio = repositorio;
        }

        public OrdemDeCompra Adicionar(OrdemDeCompra ordem)
        {
            bool existe = ExisteCalcado(ordem.Id);

            if (!existe)
            {
                OrdemDeCompra novaOrdem = _repositorio.Adicionar(ordem);
                return novaOrdem;
            }
            return null;
        }

        private bool ExisteCalcado(int id)
        {
            return false;
        }

        public OrdemDeCompra Atualizar(OrdemDeCompra ordem)
        {
            bool existe = ExisteCalcado(ordem.Id);

            if (!existe)
            {
                OrdemDeCompra atualizarordem = _repositorio.Atualizar(ordem);
                return atualizarordem;
            }
            return null;
        }

        public OrdemDeCompra Buscar(OrdemDeCompra ordem)
        {
            bool existe = ExisteCalcado(ordem.Id);

            if (!existe)
            {
                OrdemDeCompra buscarOrdem = _repositorio.Buscar(ordem.Id);
                return buscarOrdem;
            }
            return null;
        }

        public void Deletar(Calcado calcado)
        {

            if (ExisteCalcado(calcado.Id))
                _repositorio.Deletar(calcado);



        }

        public OrdemDeCompra Buscar(int id)
        {
            return _repositorio.Buscar(id);
        }
    }
}
