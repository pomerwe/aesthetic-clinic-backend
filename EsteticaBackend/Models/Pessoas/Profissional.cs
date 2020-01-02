using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaBackend.Models
{
    public class Profissional : Pessoa
    {
        public int ProfissionalId { get; set; }
        public string Funcao { get; set; }
    }
}
