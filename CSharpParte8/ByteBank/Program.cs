using ByteBank.Extensoes;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

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
			Console.WriteLine("Lista ordenada: ");
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
			var contaCorrentes = new List<ContaCorrente>() {
				new ContaCorrente(1,9871),
				new ContaCorrente(5,3855),
				new ContaCorrente(6,1513),
				new ContaCorrente(2,9996),
				new ContaCorrente(4,1111),
				new ContaCorrente(3,3159),
				new ContaCorrente(0,1561),
				null
			};

			IOrderedEnumerable<ContaCorrente> contasOrdenadas = contaCorrentes.OrderBy(conta =>
			{
				if (conta == null)
					return int.MaxValue;

				return conta.Agencia;
			});

			foreach (var conta in contasOrdenadas)
			{
				if (conta != null)
					Console.WriteLine($"Conta Número {conta.Agencia}, Ag. {conta.Numero}");
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