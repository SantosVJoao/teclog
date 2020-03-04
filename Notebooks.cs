using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Nb : ClasseBase
    {
        public string Marca { get; protected set; }
        public int QtdRam { get; protected set; }
        public string placadevideo { get; protected set; }

        public Nb(int quantidade , string marca, int QuantidadeRam, string PlacaDeVideo) : base (quantidade)
        {
            Marca = marca;
            QtdRam = QuantidadeRam;
            placadevideo = PlacaDeVideo;
        }
        
    }
}

