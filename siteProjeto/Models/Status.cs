using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siteProjeto.Models
{
    public class Status
    {
        public string Descricao { get; set; }
        public bool FinalizaCliente { get; set; }
        public bool ContabilizaCliente { get; set; }
        public int CodigoStatus { get; set; }

    }
}
