using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoChama
{
    public class Chamado
    {
        public Cliente Cliente { get; set; }
        public Atendente Atendente { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        public Chamado(Cliente cliente, Atendente atendente, string descricao)
        {
            Cliente = cliente;
            Atendente = atendente;
            Descricao = descricao;
            Status = "Aberto";
        }

        public override string ToString()
        {
            return $"[{Status}] {Cliente.Nome} → {Atendente.Nome}: {Descricao}";
        }
    }
}