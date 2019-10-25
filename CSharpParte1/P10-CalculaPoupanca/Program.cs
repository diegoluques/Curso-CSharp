using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto P10 - Calcula Poupança");

            double valorInvestido = 1000;
            int mes = 1;

            while (mes <= 12)
            {
                // 0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + mes + " mês, você terá R$ " + valorInvestido);
                mes++;
            }

            Console.WriteLine("Fim da execução");
            Console.ReadLine();
        }
    }
}
