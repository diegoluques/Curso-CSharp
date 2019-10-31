using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "434.562.878-20";
            //gabriela.profissao = "Desenvolvedora";

            ContaCorrente conta = new ContaCorrente();
            
            //conta.titular = new Cliente();
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 123456;

            //conta.titular.nome = "Gabriela Costa";

            if (conta.titular == null)
                Console.WriteLine("Titular é nulo");

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);

            Console.ReadLine();
        }
    }
}
