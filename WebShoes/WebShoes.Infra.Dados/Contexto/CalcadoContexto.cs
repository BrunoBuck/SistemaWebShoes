using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio;

namespace WebShoes.Infra.Dados.Contexto
{
    public class CalcadoContexto : DbContext
    {
        public CalcadoContexto() : base("CalcadoDB")
        {
        }

        public DbSet<Calcado> Calcados { get; set; }
    }
}
