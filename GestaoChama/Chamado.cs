using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GestaoChama
{
    public class Chamado
    {
        public Cliente Cliente { get; set; }
        public Atendente Atendente { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        public string Prioridade { get; set; }

        public Chamado(Cliente cliente, Atendente atendente, string descricao, string prioridade)
        {
            Cliente = cliente;
            Atendente = atendente;
            Descricao = descricao;
            Status = "Aberto";
            Prioridade = prioridade;
        }



        public override string ToString()
        {
            return $"[{Status}] [({Prioridade})] {Cliente.Nome} → {Atendente.Nome}: {Descricao}";
        }
    }
}