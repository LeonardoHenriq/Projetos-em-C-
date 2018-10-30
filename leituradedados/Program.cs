using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace leituradedados
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha,comparar;
            bool achou = false;

            StreamReader ler = new StreamReader(@"C:\Users\leonardo\Desktop\teste.txt");
            Console.WriteLine("digite por quem deseja procurar: ");
            comparar = Console.ReadLine();


            while((linha=ler.ReadLine())!= null)
            {
                if (linha == comparar)
                {
                    Console.WriteLine("Nome: " + linha);
                    Console.WriteLine("rg: " + ler.ReadLine());
                    Console.WriteLine("cpf: " + ler.ReadLine());
                    Console.WriteLine("endereço: " + ler.ReadLine());
                    Console.WriteLine("telefone: "  + ler.ReadLine());
                    Console.WriteLine("email: " + ler.ReadLine());

                    achou = true;
                    break;
                }
                

            }

            if (achou == false)
            {
                Console.WriteLine("contato nao encontrado");

            }

            ler.Close();
            ler.Dispose();

            Console.ReadKey();
        }
    }
}
