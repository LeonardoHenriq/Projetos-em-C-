using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    class Horista : Funcionario
    {
        protected float ValorHora;

        public Horista() : base(0)
        {
            Console.Write("Informe o valor da hora: ");
            ValorHora = float.Parse(Console.ReadLine());

        }

        public override void DisplayDados()
        {
            base.DisplayDados();
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Valor da Hora: " + ValorHora);
        }

        public override double calcularRendimento()
        {
            Console.Write("Informe a quantidade de horas: ");
            int QtdHoras = Convert.ToInt32(Console.ReadLine());
            float rendimento = QtdHoras * ValorHora;
            return (rendimento);
        }
    }
}
