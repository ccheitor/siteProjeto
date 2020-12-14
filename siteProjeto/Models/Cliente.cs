using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siteProjeto.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Credito { get; set; }
        public int Telefone { get; set; }
        public Status Status { get; set; }
    }
}
