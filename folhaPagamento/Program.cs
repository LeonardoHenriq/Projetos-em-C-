using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa E = new Empresa();
            Funcionario f;

            int op = 0;
            do
            {
                Console.WriteLine("Escolha uma opção...");
                Console.WriteLine("[1] Cadastrar Mensalista");
                Console.WriteLine("[2] Cadastrar Comissionado");
                Console.WriteLine("[3] Cadastrar Horista");
                Console.WriteLine("[4] Calcular Rendimento Total");
                Console.WriteLine("[5] Imprimir Dados ");
                Console.WriteLine("[0] Encerrar ");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                switch (op)
                {
                    case 1:
                        Console.WriteLine("Cadastro Mensalista: ");
                        f = new Mensalista();
                        E.CadastrarFuncionario(f);

                        break;

                    case 2:
                        Console.WriteLine("Cadastro Comissionado: ");
                        f = new Comissionado();
                        E.CadastrarFuncionario(f);

                        Console.Clear();

                        break;

                    case 3:
                        Console.WriteLine("Cadastro Horista ");
                        f = new Horista();
                        E.CadastrarFuncionario(f);

                        Console.Clear();

                        break;

                    case 4:
                        Console.WriteLine("Calculando Rendimento Total");
                        f = new Funcionario();
                        E.MostrarRendimento();

                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        break;


                 
                    case 5:
                        Console.WriteLine("Impimindo Dados ");

                       
                        E.MostrarInformacoes();

                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    default:
                        Console.WriteLine("Opção Invalida ");

                        Console.Clear();

                        break;

                }
            } while (op != 0);


            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        }
    }
}
