using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            
            contaDaGabriela.tirular = "Gabriela";
            contaDaGabriela.agencia = 0123;
            contaDaGabriela.numero = 028821;
            contaDaGabriela.saldo = 1200.00;

            Console.WriteLine("Titular: " + contaDaGabriela.tirular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Conta: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: R$ " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200.00;
            Console.WriteLine("Saldo Novo: R$ " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
