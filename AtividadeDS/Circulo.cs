using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeDS
{
    class Circulo : Forma
    {
       public double pi = 3.14;
        public double raio;

        public override double CalculaerArea()
        {
            return ((raio * raio) * pi);
        }
    }
}
