using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemAerea
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            string[,] CompaniaeVoo = new string[2,2];
            int p1h1 = 0, p1h2 = 0, p2h1 = 0, p2h2 = 0;
            

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++) {
                    Console.WriteLine("Informe a " + (i + 1) + " compania e o seu  "+(j+1)+" voo, com saida e destino: ");
                    CompaniaeVoo[i, j] = Console.ReadLine();
                }
            }

            Console.Clear();
            

            Console.WriteLine("[1] para: "+ CompaniaeVoo[0, 0]);
            Console.WriteLine("[2] para: "+ CompaniaeVoo[0, 1]);
            Console.WriteLine("[3] para: "+ CompaniaeVoo[1, 0]);
            Console.WriteLine("[4] para: "+ CompaniaeVoo[1, 1]);
            Console.WriteLine("[-1] PARA ENCERRAR: ");
            Console.WriteLine("\n");
            Console.WriteLine("Informe a companhia desejada e o horario do voo: ");
            op = Convert.ToInt32(Console.ReadLine());

            while (op != -1) {
                    switch (op)
                    {
                        //1ºCOMPANHIA 1ºVOO
                        case 1:
                       
                        Console.WriteLine("voo: "+CompaniaeVoo[0,0]);
                        p1h1++;

                        if (p1h1 < 5)
                        {
                            Console.WriteLine("Ainda restam"+(5-p1h1)+" passagens para este voo:");
                            
                        }
                        else
                        {
                            Console.WriteLine("Passagens esgotadas para este voo!!! ");
                        }

                        Console.WriteLine("DIGITE -1 PARA ENCERRAR");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        break;

                        //1º COMPANHIA 2ºVOO
                        case 2:
                      

                        Console.WriteLine("voo: "+ CompaniaeVoo[0, 1]);

                        p1h2++;

                        if (p1h2 < 5)
                        {
                            Console.WriteLine("Ainda restam" + (5-p1h2) + " passagens para este voo:");

                        }
                        else
                        {
                            Console.WriteLine("Passagens esgotadas para este voo!!! ");
                        }

                        Console.WriteLine("DIGITE -1 PARA ENCERRAR");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        break;

                        //2ºCOMPANHIA 1ºVOO
                        case 3:
                       

                        Console.WriteLine("voo: "+ CompaniaeVoo[1, 0]);

                        p2h1++;

                        if (p2h1 < 5)
                        {
                            Console.WriteLine("Ainda restam" + (5-p2h1) + " passagens para este voo:");

                        }
                        else
                        {
                            Console.WriteLine("Passagens esgotadas para este voo!!! ");
                        }

                        Console.WriteLine("DIGITE -1 PARA ENCERRAR");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        break;


                        //2º COMPANHIA 2ºVOO
                        case 4:


                        Console.WriteLine("voo: "+ CompaniaeVoo[1, 1]);
                        p2h2++;

                        if (p2h2 < 5)
                        {
                            Console.WriteLine("Ainda restam" + (p2h2 - 5) + " passagens para este voo:");

                        }
                        else
                        {
                            Console.WriteLine("Passagens esgotadas para este voo!!! ");
                        }

                        Console.WriteLine("DIGITE -1 PARA ENCERRAR");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        break;

                        default:

                            Console.WriteLine("Opção invalida !!!");

                        Console.WriteLine("DIGITE -1 PARA ENCERRAR");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        break;


                    }
                }
            }
        }
    }

