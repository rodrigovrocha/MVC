﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplLojaVirtualNew.Dominio.Entidade
{
    public class Produto
    {
        public int produtoId { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public string categoria { get; set; }
    }
}
