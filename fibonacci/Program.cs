using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int fib = 0;
            int Natual = 1;
            int Nanterior = 0;

            Console.WriteLine("Digite o numero para fazer a sequencia: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for(int i=0; i < num; i++)
            {
                if (Nanterior == 0)
                {
                    Console.WriteLine(Nanterior);
                }
                if (fib == 1)
                {
                    Console.WriteLine(fib);
                }
                fib = Natual + Nanterior;
                Console.WriteLine(fib);

                Nanterior = Natual;
                 Natual= fib;

            }

            Console.ReadKey();
        }
    }
}
