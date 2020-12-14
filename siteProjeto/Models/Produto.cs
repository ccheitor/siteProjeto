using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siteProjeto.Models
{
    public class Produto
    {
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public int CodigoProduto { get; set; }
        public double Preco { get; set; }
    }
}
