using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio
{
    public class Calcado
    {
        public Calcado(string _nome, string _marca, string _cor, int _tamanho)
        {
            Modelo = _nome;
            Marca = _marca;
            Cor = _cor;
            Tamanho = _tamanho;
        }

        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public object Tamanho { get; set; }
    }
}
