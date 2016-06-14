using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;
using WebShoes.Infra.Dados.Contexto;

namespace WebShoes.Testes.Dados.Base
{
    public class CriarNovoBancoCalcado<T> : DropCreateDatabaseAlways<CalcadoContexto>
    {
        protected override void Seed(CalcadoContexto context)
        {
            for (int i = 0; i< 10; i++)
            {
                Calcado produto = new Calcado("Modelo " + i, "Marca" + i, "Cor " + i, 30 + i);
                context.Calcados.Add(produto);
            }

            context.SaveChanges();

            base.Seed(context);
        }
}
