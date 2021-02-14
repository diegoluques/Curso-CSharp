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
			Console.WriteLine("-");

			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

			Funcionario carlos = new Funcionario("000.000.000-00")
			{
				Nome = "Carlos",
				Salario = 2000.00
			};

			Console.WriteLine("-");
			Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);
			Console.WriteLine("-");

			gerenciador.Registrar(carlos);

			Console.WriteLine(carlos.Nome);
			Console.WriteLine(carlos.GetBonificacao());

			Console.WriteLine("-");

			Diretor roberta = new Diretor("000.000.000 - 02")
			{
				Nome = "Roberta",
				Salario = 5000
			};

			Console.WriteLine("-");
			Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);
			Console.WriteLine("-");

			Funcionario robertaTeste = roberta;

			Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
			Console.WriteLine("Bonificação de uma referência de Funcionário: " + robertaTeste.GetBonificacao());

			Console.WriteLine("-");

			gerenciador.Registrar(roberta);

			Console.WriteLine(roberta.Nome);
			Console.WriteLine(roberta.GetBonificacao());

			Console.WriteLine("-");
			Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());
			Console.WriteLine("-");
			Console.WriteLine(RetornarString());
			Console.ReadLine();
		}

		private static string RetornarString()
		{
			return string.Concat(Enumerable.Repeat("#", 70));
		}
	}
}