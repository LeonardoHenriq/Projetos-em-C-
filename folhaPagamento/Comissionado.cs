using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    class Comissionado:Funcionario
    {
        protected double comissao;
        protected double salarioBase;
        protected double totalSalario;
        public Comissionado() : base(0)
        {
            Console.WriteLine("Informe o salario base: ");
            salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a comissão: ");
            comissao = Convert.ToDouble(Console.ReadLine());
        }

        public override void DisplayDados()
        {
            base.DisplayDados();
            Console.WriteLine("Matricula: "+Matricula);
            Console.WriteLine("Salario base: "+salarioBase);
            Console.WriteLine("Comissão: "+comissao);
            
        }

        public override double calcularRendimento()
        {
            return(totalSalario= salarioBase + comissao);
        }

    }
}
