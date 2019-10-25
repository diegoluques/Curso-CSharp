using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto P11 - Calcula Poupança");

            double valorInvestido = 1000;
            for (int mes = 1; mes <= 12; mes ++)
            {
                valorInvestido *= 1.0030;
                Console.WriteLine("Após " + mes + ", você terá R$ " + valorInvestido);
            }

            Console.WriteLine("Fim da execução");
            Console.ReadLine();
        }
    }
}
