using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int qtdPessoas = 2;
            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode liberar a entrada");
            }
            else
            {
                if (qtdPessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos e não está acompanhado. Não pode entrar");
                }
                Console.WriteLine("João tem a idade menor que 18 anos. Não pode entrar");
            }

            Console.WriteLine("Fim da execução");
            Console.ReadLine();
        }
    }
}
