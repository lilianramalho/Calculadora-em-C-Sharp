﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeDS
{
    class Quadrado : Forma
    {
       public double lado;

        public override double CalculaerArea()
        {
            return lado * lado;
        }

    }
}
