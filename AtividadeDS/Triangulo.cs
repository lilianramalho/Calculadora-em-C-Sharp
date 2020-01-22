using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeDS
{
    class Triangulo : Forma
    {
        public double altura;
        public double lado;

        public override double CalculaerArea()
        {
            return ((altura * lado) / 2);
        }

        public static int SelectedIndex { get; set; }

        
    }
}
