using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaProdutos
{
    class categoria
    {
        private string InformarCategoria;
        private double Precopromocional;
        private Produtos Produtos;

        public  categoria(Produtos Produtos)
        {
            this.Produtos = Produtos;
            Console.WriteLine("Informe a categoria do produto: ");
            InformarCategoria = Console.ReadLine();
            Console.WriteLine("Informe o preço Promocional do produto: ");
            Precopromocional = Convert.ToDouble(Console.ReadLine());
        }

        public string getCproduto()
        {
            return InformarCategoria.ToUpper();
        }
        public double getPrecopromocional()
        {
            return Precopromocional;
        }
        public void setPrecopromocional(double Precopromocional)
        {
            
            this.Precopromocional = Precopromocional;
        }

        public void display()
        {
            Console.WriteLine("Categoria do produto: "+InformarCategoria);
            
            Console.WriteLine("Preço promocional produto: "+Precopromocional);

       
         

        }

        
        
       
    }
}
