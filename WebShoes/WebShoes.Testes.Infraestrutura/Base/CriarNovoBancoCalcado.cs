using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dados.Contexto;

namespace WebShoes.Testes.Infraestrutura.Base
{
    public class CriarNovoBancoCalcado<T> : DropCreateDatabaseAlways<CalcadoContexto>
    {
        protected override void Seed(CalcadoContexto context)
        {
            for (int i = 0; i < 10; i++)
            {
                Calcado produto = new Calcado("Modelo " + 1, "Marca" + 1, "Cor " + 1, "Tamanho " + 1);
                context.Calcados.Add(produto);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    {
    }
}
