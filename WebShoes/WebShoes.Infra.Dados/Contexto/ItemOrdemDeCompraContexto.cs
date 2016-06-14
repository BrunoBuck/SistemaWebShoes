using System.Data.Entity;
using WebShoes.Dominio;

namespace WebShoes.Infra.Dados.Contexto
{
    public class ItemOrdemDeCompraContexto : DbContext
    {
        public ItemOrdemDeCompraContexto() : base("CalcadoDB")
        {
        }

        public DbSet<ItemOrdemDeCompra> Itens { get; set; }
    }
}