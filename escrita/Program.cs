using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace escrita
{
    class Program
    {
        static void Main(string[] args)
        {
            int cliente = 0;
            Console.WriteLine("Digite 1 para enserir cliente e -1 para sair");
            cliente = Convert.ToInt32(Console.ReadLine());

            while (cliente != -1)
            {
                Console.WriteLine("informe seu nome:");
                string palavra = Console.ReadLine();
                Console.WriteLine("informe seu rg:");
                string rg = Console.ReadLine();
                Console.WriteLine("informe seu endereço:");
                string end = Console.ReadLine();
                Console.WriteLine("informe seu telefone:");
                string fone = Console.ReadLine();

                Console.WriteLine("Digite 1 para enserir cliente e -1 para sair");
                cliente = Convert.ToInt32(Console.ReadLine());

                StreamWriter arq = new StreamWriter(@"C:\Users\leonardo\Desktop\teste.txt", true);
                arq.WriteLine(palavra);
                arq.WriteLine(end);
                arq.WriteLine(rg);
                arq.WriteLine(fone);
                arq.Close();
                arq.Dispose();
            }

        }
    }
}
