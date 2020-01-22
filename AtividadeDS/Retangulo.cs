using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeDS
{
    class Retangulo :  Forma
    {
       public double lado;
       public double altura;

        public override double CalculaerArea()
        {
            return lado * altura;
        }
    }
}
