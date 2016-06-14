using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShoes.Dominio.Exceptions;

namespace WebShoes.Dominio
{
    public class Calcado
    {
        public Calcado(string _modelo, string _marca, string _cor, int _tamanho)
        {
            if (String.IsNullOrEmpty(_modelo))       
                throw new BusinessException("O modelo não pode estar em branco.");        
            if (String.IsNullOrEmpty(_marca))            
                throw new BusinessException("A marca não pode estar em branco.");
            if (String.IsNullOrEmpty(_cor))
                throw new BusinessException("A cor não pode estar em branco.");
            if (!(_tamanho > 0 && _tamanho < 70))
                throw new BusinessException("O tamanho não é válido");

            Modelo = _modelo;
            Marca = _marca;
            Cor = _cor;
            Tamanho = _tamanho;
        }

        public Calcado()
        {

        }

        public int Id { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public object Tamanho { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", Modelo, Marca, Cor, Tamanho);
        }
    }
}
