using CSharpParte9.Modelos;
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

					var contaCorrente = ConverterStringParaContaCorrente(linha);
					var msg = $"Titutal: {contaCorrente.Titular.Nome}, Conta número: {contaCorrente.Numero}, Ag: {contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo}";
					Console.WriteLine(msg);
					//Console.WriteLine(linha);
				}
			}
			Console.Write("");
			Console.ReadLine();
		}

		static ContaCorrente ConverterStringParaContaCorrente(string linha)
		{
			string[] campos = linha.Split(' ');

			var agencia = campos[0];
			var numero = campos[1];
			var saldo = campos[2].Replace(".", ",");
			var nomeTitular = campos[3];

			var titular = new Cliente();
			titular.Nome = nomeTitular;

			var resultado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
			resultado.Depositar(double.Parse(saldo));
			resultado.Titular = titular;

			return resultado;
		}
	}
}