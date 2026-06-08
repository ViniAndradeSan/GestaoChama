using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace GestaoChama
{
    public class Atendente
    {
        public string Nome { get; set; }
        public string Setor { get; set; }

        public Atendente(string nome, string setor)
        {
          Nome = nome;
          Setor = setor;
        }

        public override string ToString()
        {
            return $"{Nome} - ({Setor})";
        }
    }
}
