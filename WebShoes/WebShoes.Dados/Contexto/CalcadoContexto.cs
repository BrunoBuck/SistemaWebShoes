using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dados.Contexto
{
    public class CalcadoContexto : DbContext
    {
        public CalcadoContexto(): base("CalcadoDB")
        {
        }

        public DbSet<Calcado> Calcados { get; set; }
    }
}
