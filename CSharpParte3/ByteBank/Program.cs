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

            Diretor roberta = new Diretor();
            roberta.Nome = "Diego";
            roberta.CPF = "000.000.000-01";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionário: " + robertaTeste.GetBonificacao());

            Console.WriteLine("");

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("");

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
