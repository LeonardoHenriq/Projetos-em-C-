using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imobiliaria
{
    class Casa
    {
        protected string End;
        protected string Qntcomodos;
        protected double valor;

        public void display()
        {
            Console.WriteLine("Informe o endereço do lugar: ");
            End = Console.ReadLine();

            Console.WriteLine("Informe o valor do lugar: ");
            valor = Convert.ToDouble(Console.ReadLine());

        }
        public void qntcomodos()
        {
            Console.WriteLine("Informe a quantidade de comodos do imovel: ");
            Qntcomodos = Console.ReadLine();
        }
        public void imprimirdados()
        {
            Console.WriteLine("O endereço do lugar é: " + End);
            Console.WriteLine("O Valor do lugar é: " + valor);
            
        }
        public void imprimirqntdcomodos()
        {
            Console.WriteLine("A quantidade de comodos do lugar é: " + Qntcomodos);
        }

    }
}
