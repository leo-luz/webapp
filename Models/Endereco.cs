using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }

        /*EF Relação*/
        public Fornecedor Fornecedor { get; set; }
    }
}
