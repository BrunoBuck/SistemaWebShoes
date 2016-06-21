using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;
using WebShoes.Dominio.Contratos;

namespace WebShoes.Aplicacao
{ 
    
    public class CalcadoAplicacao : ICalcadoAplicacao
    {

        private ICalcadoRepositorio _repositorio;
        

        public CalcadoAplicacao (ICalcadoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public CalcadoAplicacao(ICalcadoAplicacao calcado)
        {
            
        }

        public Calcado CriarCalcado(Calcado calcado)
        {
            bool existe = ExisteCalcado(calcado.Id);

            if (!existe)
            {
                Calcado novoCalcado = _repositorio.Adicionar(calcado);
                return novoCalcado;
            }
            return null;
        }

        public bool ExisteCalcado(int id)
        {
            return false;
        }

        public Calcado AtualizarCalcado (Calcado calcado)
        {
            bool existe = ExisteCalcado(calcado.Id);

            if (!existe)
            {
                Calcado atualizarcalcado = _repositorio.Atualizar(calcado);
                return atualizarcalcado;
            }
            return null;
        }

        public Calcado BuscarCalcado(Calcado calcado)
        {
            bool existe = ExisteCalcado(calcado.Id);

            if (!existe)
            {
                Calcado buscaCalcado = _repositorio.Buscar(calcado.Id);
                return buscaCalcado;
            }
            return null;
        }

        public void DeletarCalcado (Calcado calcado)
        {
           
            if (ExisteCalcado(calcado.Id))            
                _repositorio.Deletar(calcado);
                
            
           
        }

        
    }
}
