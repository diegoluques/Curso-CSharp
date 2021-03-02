using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dataFimPagamento = new DateTime(2021, 4, 17);
			DateTime dataCorrente = DateTime.Now;

			TimeSpan diferenca = dataFimPagamento - dataCorrente;

			String msg = "Vencimento em " + RetornarIntervaloDeDatas(diferenca);

			Console.WriteLine("Hoje é: " + dataCorrente);
			Console.WriteLine("Pagamento em: " + dataFimPagamento);
			Console.WriteLine(msg);

			Console.WriteLine("");
			Console.ReadLine();
		}

		private static string RetornarIntervaloDeDatas(TimeSpan timeSpan)
		{
			if(timeSpan.Days > 30)
			{
				int quantidadeDeMeses = timeSpan.Days / 30;
				if (quantidadeDeMeses == 1) 
					return quantidadeDeMeses + " mês";

				return quantidadeDeMeses + " meses";
			}

			return timeSpan.Days + " dias";
		}
	}
}