using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenarvetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int aux=0;

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("digite o " + (i + 1) + "º valor");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i < 9; i++)
            {
                for(int j=i+1; j < 10; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            Console.Clear();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }
    }
}
