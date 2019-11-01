using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(756, 012345);
              
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(856, 56321); 

            Console.WriteLine("Total de conta corrente: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
