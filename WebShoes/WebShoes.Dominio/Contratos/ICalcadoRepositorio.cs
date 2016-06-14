using System.Collections.Generic;

namespace WebShoes.Dominio.Contratos
{
    public interface ICalcadoRepositorio
    {
        Calcado Adicionar(Calcado calcado);
        Calcado Buscar(int id);
        List<Calcado> BuscarTodos();
        Calcado Atualizar(Calcado calcado);
        void DeletarCalcado(Calcado calcado);
    }
}