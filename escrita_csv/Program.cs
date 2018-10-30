using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace escrita_csv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, end, mail,cpf, comparar, rg;
            int  fone=0;
            int op = 0;
            bool achou = false;

            Console.WriteLine("[1] Cadastrar Cliente:");
            Console.WriteLine("[2] Buscar Cliente:");
            Console.WriteLine("[3] Sair:");
            op = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

                switch (op)
                {


                case 1:

                StreamWriter arq = new StreamWriter(@"C:\Users\leonardo\Desktop\cadastro.txt", true);

                Console.WriteLine("Informe nome!!!");
                nome = Console.ReadLine().ToUpper();

                Console.WriteLine("Informe rg!!!");
                rg = Console.ReadLine();

                Console.WriteLine("Informe cpf!!!");
                cpf = Console.ReadLine();

                    Console.WriteLine("Informe endereço!!!");
                end = Console.ReadLine().ToUpper();

                Console.WriteLine("Informe fone!!!");
                fone = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe e-mail!!!");
                mail = Console.ReadLine().ToUpper();



                arq.WriteLine(nome+" ; "+rg+" ; "+cpf+" ; "+end+" ; "+" ; "+fone+" ; "+mail);
              

                    Console.Clear();

                    arq.Close();
                    arq.Dispose();

                    break;

                case 2:
                    string linha= " ";

                    StreamReader ler = new StreamReader(@"C:\Users\leonardo\Desktop\cadastro.txt");

                    Console.WriteLine("Informe o CPF de quem deseja procurar:");
                    comparar= Console.ReadLine();

                  while ((linha= ler.ReadLine()) != null)
                    {

                        int pos =0;
                        nome = linha.Substring(pos, linha.IndexOf(';'));
                        pos 

                    }
                  if (achou == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Cliente nao encontrado!!!");
                    }


                    ler.Close();
                    ler.Dispose();

                    break;

                case 3:
                    Console.WriteLine("Saindo , Pressione qualquer tecla para encerrar...");
                    Console.ReadKey();

                break;

                default:
                    Console.WriteLine("Opção invalida...");
                break;


             }


            Console.ReadKey();
        }
    }
}
