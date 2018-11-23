using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salario");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a data DD/MM/AAAA");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Desconto D = new Aliquota1();
            Desconto D1 = new Aliquota2();
            Desconto D2 = new Aliquota3();
            Desconto D3 = new Aliquota4();
            Desconto D4 = new Aliquota5();
            Desconto D5 = new Aliquota6();
            Desconto D6 = new Aliquota7();
            Desconto D7 = new Teto1();
            Desconto D8 = new Teto2();

            D.CalcularDesconto(data, salario);
            D1.CalcularDesconto(data, salario);
            D2.CalcularDesconto(data, salario);
            D3.CalcularDesconto(data, salario);
            D4.CalcularDesconto(data, salario);
            D5.CalcularDesconto(data, salario);
            D6.CalcularDesconto(data, salario);
            D7.CalcularDesconto(data, salario);
            D8.CalcularDesconto(data, salario);

            Console.ReadKey(); 
        }
    }
}
