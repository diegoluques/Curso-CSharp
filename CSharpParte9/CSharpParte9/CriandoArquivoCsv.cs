using System;
using System.IO;
using System.Text;

namespace CSharpParte9
{
	partial class Program
	{
		static void CriarArquivo()
		{
			var caminhoNovoArquivo = "contasExportadas.csv";

			using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
			{
				var contaComoString = "00001;0001;1999.99;Diego Luques";
				var encoding = Encoding.UTF8;

				var bytes = encoding.GetBytes(contaComoString);

				fluxoDeArquivo.Write(bytes, 0, bytes.Length);
			}
		}

		static void CriarArquivoComWriter()
		{
			var caminhoNovoArquivo = "contasExportadas.csv";

			using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
			{
				var contaComoString = "00001;0001;1999.99;Diego Luques";
				var encoding = Encoding.UTF8;

				using (var escritor = new StreamWriter(fluxoDeArquivo))
				{
					escritor.WriteLine(contaComoString);
				}
			}
		}

		static void TestarEscrita()
		{
			var caminhoDoArquivo = "teste.txt";

			using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
			{
				using (var escritor = new StreamWriter(fluxoDeArquivo))
				{
					for (int i = 0; i < 100000; i++)
					{
						escritor.WriteLine($"Linha {i}");

						escritor.Flush(); //Despeja o byffer para o Stream

						Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma");
						Console.ReadLine();
					}
				}
			}
		}
	}
}