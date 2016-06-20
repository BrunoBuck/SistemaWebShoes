using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio
{
    public class ItemOrdemDeCompra
    {
        public int Id { get; set; }
        public double Desconto { get; set; }
        public Calcado Calcado { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double CalcularValor()
        {
            double valorDescontado = Calcado.Valor - (Calcado.Valor * (Desconto / 100));
            return valorDescontado * Quantidade;
        }
        public ItemOrdemDeCompra()
        {

        }

        public ItemOrdemDeCompra(Calcado calcado, double desconto, int quantidade)
        {
            Calcado = calcado;
            Desconto = desconto;
            Quantidade = quantidade;
            Valor = CalcularValor();
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}: R$ {2}", Quantidade, Calcado, Valor);
        }
    }
}
