using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto
{
    class Program
    {
        static void Main(string[] args)
        {


            Companhia n1 = Companhia.GetCompanhia();
            Companhia n2 = Companhia.GetCompanhia();

            if(n1 == n2)
            {
                Console.WriteLine("Alguma Companhia?\n");
            }

            Companhia nome = Companhia.GetCompanhia();

            for(int i = 0; i < 5; i++)
            {
                string companhia = nome.NomesDeCompanhias;
                Console.WriteLine("Nome da " + (i + 1) + "° companhia: " + companhia);
            }

            Console.ReadKey();
        }
    }
}
