using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    public abstract class Desconto : ICalculadorINSS
    {

        protected Desconto desconto;
        public void SetDesconto(Desconto desconto)
        {
            this.desconto = desconto;
        }

        public abstract void CalcularDesconto(DateTime data, decimal salario);


    }
}
