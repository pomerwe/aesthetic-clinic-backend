using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaBackend.Models
{
    public class Procedimento
    {
        public int ProcedimentoId { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public int Duração { get; set; }
    }
}
