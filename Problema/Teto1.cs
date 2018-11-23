using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    public class Teto1:Desconto
    {
        private decimal valor;
        public override void CalcularDesconto(DateTime data, decimal salario)
        {
            if (data.Year.Equals(2011) && salario > 3689.66M)
            {
                Console.WriteLine(valor = 405.86M);
            }
            else if (desconto != null)
            {
                desconto.CalcularDesconto(data, salario);
            }
        }
    }
}
