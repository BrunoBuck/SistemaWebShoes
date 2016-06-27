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
    public class CalcadoRepositorio : ICalcadoRepositorio
    {
            private CalcadoContexto _contexto;

            public CalcadoRepositorio()
            {
                _contexto = new CalcadoContexto();
            }

            public Calcado Adicionar(Calcado calcado)
            {
                var resultado = _contexto.Calcados.Add(calcado);
                _contexto.SaveChanges();
                return resultado;
            }

            public Calcado Atualizar(Calcado calcado)
            {
                var entry = _contexto.Entry<Calcado>(calcado);
                entry.State = System.Data.Entity.EntityState.Modified;
                _contexto.SaveChanges();

                return calcado;
            }

            public Calcado Buscar(int id)
            {
                return _contexto.Calcados.Find(id);
            }

        public Calcado BuscarCalcado(int id)
        {
            return _contexto.Calcados.Find(id);
        }

        public List<Calcado> BuscarTodos()
           {
               return _contexto.Calcados.ToList();
           }

           public void Deletar(Calcado calcado)
           {
               var entry = _contexto.Entry<Calcado>(calcado);
               entry.State = System.Data.Entity.EntityState.Deleted;
               _contexto.SaveChanges();
           }
    }
}
