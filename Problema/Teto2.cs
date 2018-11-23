using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    public class Teto2:Desconto
    {
        private decimal valor;

        public override void CalcularDesconto(DateTime data, decimal salario)
        {
            if (data.Year.Equals(2012) && salario >4000.00M)
            {
                Console.WriteLine(valor = 500.00M);
            }
            else if (desconto != null)
            {
                desconto.CalcularDesconto(data, salario);
            }
        }
    }
}
