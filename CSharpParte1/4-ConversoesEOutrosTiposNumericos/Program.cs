using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            
            double salario;
            salario = 1200.50;

            // O int é um tipo de variável que suporte valores até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; 
            Console.WriteLine("Salário é: " + salarioEmInteiro);

            //O long é uma varoiável de 64 bits
            long idade;
            idade = 2600000000000000;
            Console.WriteLine("Idade é: " + idade);

            //O short é um tipo de variável que suporta até 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 12000;
            Console.WriteLine("Quantidade de produto é: " + quantidadeProdutos);

            float altura = 1.59f;
            Console.WriteLine("Altura é: " + altura);

            Console.WriteLine("Fim da execução");
            Console.ReadLine();
        }
    }
}
