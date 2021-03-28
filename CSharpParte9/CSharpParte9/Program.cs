using System;
using System.IO;
using System.Text;

namespace CSharpParte9
{
	class Program
	{
		static void Main(string[] args)
		{
			var enderecoDoArquivo = "contas.txt";

			using (var fluxoDoArquivo = new FileStream(path: enderecoDoArquivo, mode: FileMode.Open))
			{
				var buffer = new byte[1024]; //1kb
				var numeroDeBytesLidos = -1;
				while (numeroDeBytesLidos != 0)
				{
					numeroDeBytesLidos = fluxoDoArquivo.Read(array: buffer, offset: 0, count: 1024);
					EscreverBuffer(buffer);
				}
			}

			Console.Write("");
			Console.ReadLine();
		}

		static void EscreverBuffer(byte[] buffer)
		{
			var utf8 = Encoding.Default;
			var texto = utf8.GetString(buffer);
			Console.WriteLine(texto);

			//foreach (var meuByte in buffer)
			//{
			//	Console.Write(meuByte);
			//	Console.Write("-");
			//}
		}
	}
}