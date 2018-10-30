using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    class Funcionario
    {
        private string Nome;
        protected string Matricula;
        protected int cpf;
        protected int idade;
        protected string email;
        public Funcionario() {}

        public Funcionario(int ctrl)
        {
            Console.Write("Informe o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Informe a matrícula do funcionário: ");
            Matricula = Console.ReadLine();

            Console.Write("Informe o cpf do funcionário: ");
            cpf = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a idade do funcionário: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o email do funcionário: ");
            email = Console.ReadLine();


        }

        public void ImprimirNome()
        {
            Console.WriteLine("Nome: " + Nome);
        }

        protected string GetNome()
        {
            return Nome;
        }

        public virtual void DisplayDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Cpf: " + cpf);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Email: " + email);
            

        }

        public virtual double calcularRendimento() {
            return (0);
        }
    }
}
