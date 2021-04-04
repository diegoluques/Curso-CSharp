using System;
using System.IO;

namespace CSharpParte9
{
	partial class Program
	{
		static void StreamBinario()
		{
			using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
			{
				using (var escritor = new BinaryWriter(fs))
				{
					escritor.Write(456);
					escritor.Write(5566);
					escritor.Write(4000.50);
					escritor.Write("Diego");
				}
			}
		}

		static void LeituraBinaria()
		{
			using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
			{
				using (var leitor = new BinaryReader(fs))
				{
					var agencia = leitor.ReadInt32();
					var conta = leitor.ReadInt32();
					var saldo = leitor.ReadDouble();
					var titular = leitor.ReadString();

					Console.WriteLine($"{agencia}, {conta}, {saldo}, {titular}");
				}
			}
		}
	}
}