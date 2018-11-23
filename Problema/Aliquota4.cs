using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    public class Aliquota4:Desconto
    {
        private decimal valor;
        public override void CalcularDesconto(DateTime data, decimal salario)
        {
            if (data.Year.Equals(2012) && salario <= 1000.00M )
            {
                Console.WriteLine(valor = salario * 0.07M);
            }
            else if (desconto != null)
            {
                desconto.CalcularDesconto(data, salario);
            }
        }
    }
}
