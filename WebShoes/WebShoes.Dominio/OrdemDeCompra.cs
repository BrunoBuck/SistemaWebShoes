using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio
{
    public class OrdemDeCompra
    {
        public OrdemDeCompra()
        {

        }
        public OrdemDeCompra(string _status, DateTime _data, List<ItemOrdemDeCompra> _lista)
        {
            Status = _status;
            Data = _data;
            Itens = _lista;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<ItemOrdemDeCompra> Itens { get; set; }
        public string Status { get; set; }
        public double ValorTotal()
        {
            double valorTotal = 0;
            foreach (var item in Itens)
            {
                valorTotal += item.Valor;
            }
            return valorTotal;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}: R$ {2}", Status, Data, ValorTotal());
        }

        public void AdicionarItens(ItemOrdemDeCompra item)
        {
            Itens.Add(item);
        }
    }
}
