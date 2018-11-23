using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    public class Aliquota2:Desconto
    {
        private decimal valor;
        public override void CalcularDesconto(DateTime data, decimal salario)
        {
            if(data.Year.Equals(2011)&& salario>= 1106.91M && salario <= 1844.83M)
            {
                Console.WriteLine(valor = salario * 0.09M);
            }else if (desconto != null)
            {
                desconto.CalcularDesconto(data, salario);
            }
        }
    }
}
