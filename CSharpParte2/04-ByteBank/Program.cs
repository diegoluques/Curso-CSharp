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
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Sacar(500);

            Console.WriteLine("Saldo do Bruno R$ " + contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("");
            Console.WriteLine("Saldo do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaDaGabriela.saldo);
            Console.WriteLine("Tranferência realizada com sucesso? " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("");
            Console.WriteLine("Saldo do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
