﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShoes.Dominio
{
    public class ItemOrdemDeCompra
    {
        public int Id { get; set; }
        public Calcado Calcado { get; set; }
        public ItemOrdemDeCompra()
        {

        }
    }
}
