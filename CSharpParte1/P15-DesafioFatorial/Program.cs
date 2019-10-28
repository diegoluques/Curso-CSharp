using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_DesafioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto P15 - Fatorial");

            int fatorial1 = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial1 *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial1);
            }

            Console.WriteLine("");

            Console.WriteLine("Utilizando while");
            int fatorial = 1;
            int contador = 1;
            while (contador < 11)
            {
                fatorial *= contador;
                Console.WriteLine("Fatorial de " + contador + " = " + fatorial);
                contador++;
            }

            Console.ReadLine();
        }
    }
}
