using System;
using System.Collections.Generic;

namespace ByteBank
{
	partial class Program
	{
		static void Main(string[] args)
		{
			List<int> idades = new List<int>();

			//ListExtensoes.AdicionarVarios(idades, 1, 5, 14, 25, 38, 61);

			idades.AdicionarVarios(1, 5, 14, 25, 38, 61);

			idades.Add(1);
			idades.Add(5);
			idades.Add(14);
			idades.Add(25);
			idades.Add(38);
			idades.Add(61);

			idades.Remove(5);

			for (int i = 0; i < idades.Count; i++)
			{
				Console.WriteLine(idades[i]);
			}

			Console.ReadLine();
		}
	}
}