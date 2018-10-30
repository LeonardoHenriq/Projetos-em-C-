using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imobiliaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa c1 = new Casa();
            c1.display();
            c1.qntcomodos();
            c1.imprimirdados();
            c1.imprimirqntdcomodos();

            Apartamento A = new Apartamento();
            A.obterdados();

            Lote L = new Lote();
            L.obterdados();

            Comercial C = new Comercial();
            C.obterdados();


            Console.WriteLine("Pressione qualuquer tecla para continuar: ");
            Console.ReadKey();
        }
    }
}
