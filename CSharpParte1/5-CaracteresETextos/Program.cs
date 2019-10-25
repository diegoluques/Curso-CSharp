using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //Character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia ";
            string cursosProgramacao =
@"- .NET
- JAVA 
- JAVASCRIPT";
            Console.WriteLine(titulo + 2020);
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Fim da execução");
            Console.ReadLine();
        }
    }
}
