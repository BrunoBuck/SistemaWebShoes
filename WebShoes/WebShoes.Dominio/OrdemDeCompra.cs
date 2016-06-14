using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio
{
    public class OrdemDeCompra
    {
        public OrdemDeCompra(string _status, DateTime _data, List<ItemOrdemDeCompra> _lista)
        {
            Status = _status;
            Data = _data;
            Lista = _lista;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<ItemOrdemDeCompra> Lista { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Status, Data);
        }
    }
}
