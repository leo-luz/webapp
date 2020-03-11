using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Marca : Entity
    {
        public string Nome { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
