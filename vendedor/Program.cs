using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] produtos =new char[5];
            double[] vun =new double[5];
            int[] qnt =new int[5];
            int i = 0;

            for (i = 0; i < 5; i++) {
                Console.WriteLine("digite o produto: ");
                produtos[i] =Convert.ToChar( Console.ReadLine());

                Console.WriteLine("informe o valor unitario produto: ");
                vun[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("iforme a quantidade de produtos vendidos: ");
                qnt[i] = Convert.ToInt32(Console.ReadLine());
            }
            double stotal=0 , sproduto=0;
            for (i = 0; i < 5; i++){
                sproduto = vun[i] * qnt[i];
                stotal += sproduto;
                Console.WriteLine(produtos[i] + "valor das vendas: " + sproduto + "valor total: " + stotal);
                

            }
            Console.ReadKey();
        }
    }
}
