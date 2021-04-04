using System;
using System.IO;

namespace CSharpParte9
{
	partial class Program
	{
		static void Main(string[] args)
		{
			//CriarArquivo();
			//CriarArquivoComWriter();
			//TestarEscrita();
			//StreamBinario();
			//LeituraBinaria();
			//UsandoStreamDeEntradaDaConsole();

			var linhas = File.ReadAllLines("contas.txt");
			var bytesDoArquivo = File.ReadAllBytes("contas.txt");

			File.WriteAllText("nomeArquivo.txt", "Deu certo");

			Console.Write("");
			Console.ReadLine();
		}
	}
}