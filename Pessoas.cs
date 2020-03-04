using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Pessoas : ClasseBase
    {
        
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }
        public Pessoas(int quantidade, string nome, int idade) : base (quantidade)
        {
            
            Nome = nome;
            Idade = idade;
        }
        public void AlteraPessoa(string nome, int idade)
        {
            
        }

    }
}
