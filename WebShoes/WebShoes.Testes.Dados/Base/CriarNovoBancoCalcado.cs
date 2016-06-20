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
            for (int i = 0; i < 10; i++)
            {
                Calcado produto = new Calcado("Modelo " + i, "Marca" + i, "Cor " + i, 30 + i, 300 + i);
                ItemOrdemDeCompra item = new ItemOrdemDeCompra(produto, 0, 1);
                OrdemDeCompra ordem = new OrdemDeCompra("Aguardando Pagamento", new DateTime(2016, 6, 13, 10, 55, 31), new List<ItemOrdemDeCompra>());
                ordem.AdicionarItens(item);
                context.Calcados.Add(produto);
                context.Ordens.Add(ordem);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
