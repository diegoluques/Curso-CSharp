using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int qtdPessoas = 2;
            bool acompanhado = qtdPessoas >= 2;
            string mensagemAdiconal;

            if (acompanhado == true)
            {
                mensagemAdiconal = "João está acompanhado!";
            }
            else
            {
                mensagemAdiconal = "João bão está acaompanhado!";
            }

            if (idadeJoao > 18 || acompanhado == true)
            {
                Console.WriteLine("Pode liberar a entrada");
                Console.WriteLine(mensagemAdiconal);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdiconal);
            }

            Console.WriteLine("Fim da execução");
            Console.ReadLine();
        }
    }
}
