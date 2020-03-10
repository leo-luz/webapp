using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public Guid MarcaId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Marca Marca { get; set; }
    }
}
