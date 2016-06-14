using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio.Contratos
{
    public interface ICalcadoRepositorio
    {
        Calcado Adicionar(Calcado calcado);
        Calcado Buscar(int id);
        List<Calcado> BuscarTodos();
        Calcado Atualizar(Calcado calcado);
        void Deletar(Calcado calcado);
    }
}
