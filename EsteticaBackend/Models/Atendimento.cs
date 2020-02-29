using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaBackend.Models
{
    public class Atendimento
    {
        public int AtendimentoId { get; set; }
        [ForeignKey("ProcedimentoId")]
        public Procedimento Procedimento { get; set; }
        public DateTime DataMarcada { get; set; }
        public Cliente Cliente { get; set; }
        public Profissional Profissional { get; set; }
        public bool Cancelado { get; set; }
        public bool Finalizado { get; set; }
        public bool EmAndamento { get; set; }

        public Atendimento()
        {
            EmAndamento = false;
            Cancelado = false;
            Finalizado = false;
        }

        public Atendimento(Procedimento procedimento, Cliente cliente, Profissional profissional, DateTime dataMarcada)
        {
            Procedimento = procedimento;
            Cliente = cliente;
            Profissional = profissional;
            DataMarcada = dataMarcada;
            EmAndamento = false;
            Cancelado = false;
            Finalizado = false;
        }

        public Atendimento ReMarcar(DateTime dataRemarcada)
        {
            Cancelado = true;
            return new Atendimento(Procedimento, Cliente, Profissional, dataRemarcada);
        }
    }
}
