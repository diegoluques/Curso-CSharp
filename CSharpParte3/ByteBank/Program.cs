using ByteBank.Funcionarios;
using System;
using System.Linq;

namespace ByteBank
{
	class Program
	{
		private static void Main()
		{
			Console.WriteLine(RetornarString());

			CalcularBonificacao();

			Console.WriteLine(RetornarString());
			Console.ReadLine();
		}

		public static void CalcularBonificacao()
		{
			GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

			Designer pedro = new Designer("000.000.001-11")
			{
				Nome = "Pedro"
			};

			Diretor roberta = new Diretor("000.000.002-22")
			{
				Nome = "Roberta"
			};

			Auxiliar igor = new Auxiliar("000.000.003-33")
			{
				Nome = "Igor"
			};

			GerenteDeConta camila = new GerenteDeConta("000.000.004-44")
			{
				Nome = "Camila"
			};

			gerenciadorBonificacao.Registrar(pedro);
			gerenciadorBonificacao.Registrar(roberta);
			gerenciadorBonificacao.Registrar(igor);
			gerenciadorBonificacao.Registrar(camila);

			Console.WriteLine("Total de bonificação do mês: " +gerenciadorBonificacao.GetTotalBonificacao());
		}

		private static string RetornarString()
		{
			return string.Concat(Enumerable.Repeat("#", 70));
		}
	}
}