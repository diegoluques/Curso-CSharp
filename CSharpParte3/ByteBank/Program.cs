using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "000.000.000-00";
            carlos.Salario = 2000.00;

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            
            Console.WriteLine("");

            Diretor diego = new Diretor();
            diego.Nome = "Diego";
            diego.CPF = "000.000.000-01";
            diego.Salario = 5000;

            gerenciador.Registrar(diego);

            Console.WriteLine(diego.Nome);
            Console.WriteLine(diego.GetBonificacao());

            Console.WriteLine("");

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
