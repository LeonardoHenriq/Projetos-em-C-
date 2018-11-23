using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    public interface ICalculadorINSS
    {
        void CalcularDesconto(DateTime data, decimal salario);
    }
}
