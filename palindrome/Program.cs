using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int tamanho = 0;
            bool palindromo = true;

            Console.WriteLine("digite uma palavra para ver se é palindrome: ");
            palavra = Console.ReadLine();
            tamanho = palavra.Length;
            for (int i = 0; i < tamanho; i++)
            {
                if (palavra[i] != palavra[tamanho - 1 - i])
                {
                    palindromo = false;
                    break;
                }
               
            }
            if (palindromo == true)
            {
                Console.WriteLine(" é palindromo!");
            }
            else
            {
                Console.WriteLine(" não é palindromo!");
            }
            Console.ReadKey();

        }
    }
}
