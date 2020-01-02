using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaBackend.Models
{
    public abstract class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }
        public List<Telefone> Telefones { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
