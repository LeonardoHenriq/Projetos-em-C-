using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    class Mensalista : Funcionario
    {
        protected double Salario;

        public Mensalista():base(0)
        {
            Console.Write("Informe o salário: ");
            Salario = Convert.ToDouble(Console.ReadLine());
        }

        public override void DisplayDados()
        {
            base.DisplayDados();
            Console.WriteLine("Matricula: "+Matricula);
            Console.WriteLine("Salário: " + Salario);
        }

        public override double calcularRendimento()
        {
            return(Salario);
        }

        
    }
}
