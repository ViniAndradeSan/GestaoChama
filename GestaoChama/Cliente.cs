using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoChama
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Contato { get; set; }

        public Cliente(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }

        public override string ToString()
        {
            return $"{Nome} ({Contato})";
        }
    }
}
