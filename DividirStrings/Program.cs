using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividirStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados, nome , end, fone, email;
            int pos = 0;

            Console.WriteLine("Informe Nome, Endereço, Telefone e E-mail: ");
            dados = Console.ReadLine();

            for (int i = 0; i < dados.Length; i++)
            {
                int index = dados.IndexOf(';');

                nome =dados.Substring(dados[i], index);
                
            }
            


        }
    }
}
