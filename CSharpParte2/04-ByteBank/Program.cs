using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.tirular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);

            Console.ReadLine();
        }
    }
}
