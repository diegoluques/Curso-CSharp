using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Metodo();
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Não é possível divisão por zero!");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
				Console.WriteLine("Aconteceu um erro!");
			}

			Console.ReadLine();
		}

		private static void Metodo()
		{
			TestaDivisao(0);
		}

		private static void TestaDivisao(int divisor)
		{
			try
			{
				int resultado = Dividir(10, divisor);
				Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
			}
			catch (DivideByZeroException erro)
			{
				Console.WriteLine(erro.Message);
				Console.WriteLine(erro.StackTrace);
				Console.WriteLine("Não é possível fazer uma divisão por 0!");
			}
		}

		private static int Dividir(int numero, int divisor)
		{
			try
			{
				return numero / divisor;
			}
			catch (DivideByZeroException)
			{
				throw;
			}
		}

	}
}