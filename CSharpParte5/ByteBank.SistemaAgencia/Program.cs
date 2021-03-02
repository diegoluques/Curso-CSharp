using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dataFimPagamento = new DateTime(2021, 3, 3);
			DateTime dataCorrente = DateTime.Now;

			TimeSpan diferenca = dataFimPagamento - dataCorrente;

			String msg = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

			Console.WriteLine("Hoje é: " + dataCorrente);
			Console.WriteLine("Pagamento em: " + dataFimPagamento);
			Console.WriteLine(msg);


			Console.WriteLine("");
			Console.ReadLine();
		}

	}
}