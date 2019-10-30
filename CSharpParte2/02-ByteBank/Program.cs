using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.tirular = "Gabriela";
            conta.saldo = 2000.00;

            Console.WriteLine(conta.tirular);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
