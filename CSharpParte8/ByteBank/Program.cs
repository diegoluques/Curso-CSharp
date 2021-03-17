using ByteBank.Extensoes;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;

namespace ByteBank
{
	partial class Program
	{
		static void Main(string[] args)
		{
			ListaDeInteiros();
			Console.WriteLine("");
			ListaDeStrings();
			Console.WriteLine("");
			DeclararVariavelComVar();
			Console.WriteLine("");
			CriarListaDeContaCorrente();
			Console.WriteLine("");

			Console.ReadLine();
		}

		private static void DeclararVariavelComVar()
		{
			//var conta = new ContaCorrente(2525, 448898);
			//var diretor = new GerenteDeConta("000.000.00-00");
		}

		private static void CriarListaDeContaCorrente()
		{
			List<ContaCorrente> contaCorrentes = new List<ContaCorrente>();
			
			foreach (var conta in contaCorrentes)
			{
				Console.WriteLine($"Conta Número {conta.Numero}, Ag. {conta.Agencia}");
			}
		}

		private static void ListaDeInteiros()
		{
			List<int> idades = new List<int>();

			ListExtensoes.AdicionarVarios(idades, 1, 5, 14, 25, 38, 61);

			idades.AdicionarVarios(1, 5, 14, 25, 38, 61);
			idades.Remove(5);

			for (int i = 0; i < idades.Count; i++)
			{
				Console.WriteLine(idades[i]);
			}
		}

		private static void ListaDeStrings()
		{
			List<string> nome = new List<string>();

			//ListExtensoes.AdicionarVarios(idades, "A", "B", "C", "D", "E");
			nome.AdicionarVarios("A", "B", "C", "D", "E", "Z", "P");
			nome.Sort();
			for (int i = 0; i < nome.Count; i++)
			{
				Console.WriteLine(nome[i]);
			}
		}
	}
}