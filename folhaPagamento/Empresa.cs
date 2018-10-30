using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaPagamento
{
    class Empresa
    {
        private string RazaoSocial;
        private string CNPJ;
        private List<Funcionario> LFuncionario;

        public Empresa()
        {
            LFuncionario = new List<Funcionario>();

        }

        public void CadastrarFuncionario(Funcionario F)
        {
            LFuncionario.Add(F);

        }
        public void MostrarRendimento()
        {
            double Total = 0;

            foreach (Funcionario x in LFuncionario)
            {
                Total = Total + x.calcularRendimento();
            }
            Console.WriteLine("Rendimento Total: " + Total);

        }
       

        public  void MostrarInformacoes()
        {
            foreach(Funcionario x in LFuncionario)
            {
                x.DisplayDados();
            }
        }


        public Empresa(Funcionario F1, Funcionario F2, Funcionario F3)
        {
            Console.WriteLine("Empresa");
            Console.Write("Informe a Razão Social: ");
            RazaoSocial = Console.ReadLine();
            Console.Write("Informe o CNPJ: ");
            CNPJ = Console.ReadLine();

        }

        
    }
}
