using WebShoes.Dominio;

namespace WebShoes.Aplicacao
{
    public interface ICalcadoAplicacao
    {
        bool ExisteCalcado(int id);
        Calcado CriarCalcado(Calcado cliente);
        Calcado AtualizarCalcado(Calcado cliente);
        void DeletarCalcado(Calcado cliente);
        Calcado BuscarCalcado(Calcado cliente);

    }
}