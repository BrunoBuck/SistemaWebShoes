using System;

namespace WebShoes.Dominio.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string msg) : base(msg)
        {

        }
    }
}