using System;
using System.IO;

namespace CSharpParte9
{
	partial class Program
	{
		static void Main(string[] args)
		{
			//LidandoComStreamDiretamente();

			var enderecoDoArquivo = "contas.txt";
			using (var fluxoDoArquivo = new FileStream(path: enderecoDoArquivo, mode: FileMode.Open))
			using (var leitor = new StreamReader(fluxoDoArquivo))
			{
				while (!leitor.EndOfStream)
				{
					var linha = leitor.ReadLine();
					Console.WriteLine(linha);
				}
			}
			Console.Write("");
			Console.ReadLine();
		}
	}
}