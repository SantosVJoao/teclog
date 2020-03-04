using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class ClasseBase
    {
        public int Codigo { get; protected set;}

        protected ClasseBase(int quantidade)
        {
            Codigo = quantidade + 1;
        }
    }
}
