﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imobiliaria
{
    class Apartamento:Casa
    {
        public void obterdados()
        {
            display();
            qntcomodos();
            imprimirdados();
            imprimirqntdcomodos();
        }
    }
}
