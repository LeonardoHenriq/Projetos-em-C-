using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto
{
    public class Companhia
    {
        private static Companhia _instancia;
        private List<string> nomes = new List<string>();
        private Random _random = new Random();

        private static object syncLock = new object();
        protected Companhia()
        {
            nomes.Add("Gol");
            nomes.Add("Tam");
            nomes.Add("Airline");
            nomes.Add("Latam");

        }

        public static Companhia GetCompanhia()
        {
            if (_instancia == null)
            {
                lock (syncLock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new Companhia();

                    }
                }
            }
            return _instancia;
        }

        public string NomesDeCompanhias
        {
            get
            {
                int r = _random.Next(nomes.Count);
                return nomes[r].ToString();
            }
        }
    }
}
