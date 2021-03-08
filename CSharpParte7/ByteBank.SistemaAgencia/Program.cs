using System;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] idades = new int[5];

			idades[0] = 15;
			idades[1] = 25;
			idades[2] = 35;
			idades[3] = 50;
			idades[4] = 28;

			int acumulador = 0;
			for (int indice = 0; indice <= idades.Length; indice++)
			{
				int idade = idades[indice];
				Console.WriteLine($"Acessando o array idades no índice {indice}");
				Console.WriteLine($"Valor de idades [{indice}] = {idade}");
				acumulador++;
			}

			int media = (acumulador / idades.Length);

			Console.WriteLine(idades[4]);

			Console.ReadLine();
		}
	}
}