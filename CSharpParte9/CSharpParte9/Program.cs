using System;
using System.IO;

namespace CSharpParte9
{
	class Program
	{
		static void Main(string[] args)
		{
			var enderecoDoArquivo = "contas.txt";

			var fluxoDoArquivo = new FileStream(path: enderecoDoArquivo, mode: FileMode.Open);

			var buffer = new byte[1024]; //1kb
			var numeroDeBytesLidos = -1;

			while (numeroDeBytesLidos != 0)
			{
				numeroDeBytesLidos = fluxoDoArquivo.Read(array: buffer, offset: 0, count: 1024);
				EscreverBuffer(buffer);
			}

			Console.Write("");
			Console.ReadLine();
		}

		static void EscreverBuffer(byte[] buffer)
		{
			foreach (var meuByte in buffer)
			{
				Console.Write(meuByte);
				Console.Write("-");
			}
		}
	}
}