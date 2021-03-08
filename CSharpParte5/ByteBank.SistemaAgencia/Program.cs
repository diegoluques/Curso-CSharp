using ByteBank.Modelos;
using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
	class Program
	{
		static void Main(string[] args)
		{
			//DateTime dataFimPagamento = new DateTime(2021, 3, 3);
			//DateTime dataCorrente = DateTime.Now;

			//TimeSpan diferenca = dataFimPagamento - dataCorrente;

			//String msg = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

			//Console.WriteLine("Hoje é: " + dataCorrente);
			//Console.WriteLine("Pagamento em: " + dataFimPagamento);
			//Console.WriteLine(msg);

			//TrocarValoresDeDuasVariaveis(5, 7);
			//LerUmNumeroInteiroERetornarNotasPossiveis(576);

			//string urlParametros = "https://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar";
			//string urlTeste = "https://www.bytebank.com.br/cambio";
			//ExtratorValorDeArgumentosUrl extratorValorDeArgumentosUrl = new ExtratorValorDeArgumentosUrl(urlParametros);

			//string valor2 = extratorValorDeArgumentosUrl.ObterValoresDosAgumentos("moedaOrigem");
			//Console.WriteLine("Valor de moedaOrigem: " + valor2);

			//string valor = extratorValorDeArgumentosUrl.ObterValoresDosAgumentos("moedaDestino");
			//Console.WriteLine("Valor de moedaDestino: " + valor);

			//Console.WriteLine("");

			//Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
			//Console.WriteLine(urlTeste.EndsWith("cambio"));
			//Console.WriteLine(urlTeste.Contains("bytebank"));

			//ContaCorrente contaCorrente = new ContaCorrente(2525, 3669);
			//Console.WriteLine(contaCorrente);

			Cliente cliente1 = new Cliente
			{
				Nome = "Diego Luques"
			};

			Cliente cliente2 = new Cliente
			{
				Nome = "Diego Luques"
			};

			if (cliente1.Equals(cliente2))
			{
				Console.WriteLine("São iguais");
			}

			Console.WriteLine("");
			Console.ReadLine();
		}

		private static void TrocarValoresDeDuasVariaveis(int n, int p)
		{
			p = n + p;
			n = p - n;
			p -= n;

			Console.WriteLine("n = " + n + "| p = " + p);
		}

		private static void LerUmNumeroInteiroERetornarNotasPossiveis(int numero)
		{
			Console.WriteLine(numero);
			Console.WriteLine((numero / 100) + " nota(s) de R$ 100, 00");
			Console.WriteLine((numero / 50) + " nota(s) de R$ 50, 00");
			Console.WriteLine((numero / 20) + " nota(s) de R$ 20, 00");
			Console.WriteLine((numero / 10) + " nota(s) de R$ 10, 00");
			Console.WriteLine((numero / 5) + " nota(s) de R$ 5 ,00");
			Console.WriteLine((numero / 2) + " nota(s) de R$ 2, 00");
			Console.WriteLine((numero / 1) + " nota(s) de R$ 1, 00");
		}
	}
}