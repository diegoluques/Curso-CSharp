using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//Metodo();
				CriarContaCorrente();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
			}
			//catch (DivideByZeroException)
			//{
			//	Console.WriteLine("Não é possível divisão por zero!");
			//}
			//catch (ArgumentException ex)
			//{
			//	Console.WriteLine("Argumento com problema: " + ex.ParamName);
			//	Console.WriteLine(ex.Message);
			//}
			//catch (SaldoInsuficienteException ex)
			//{
			//	Console.WriteLine(ex.Message);
			//	Console.WriteLine("");
			//	Console.WriteLine(ex.StackTrace);
			//	Console.WriteLine("");
			//	Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e.Message);
			//	Console.WriteLine(e.StackTrace);
			//	Console.WriteLine("Aconteceu um erro!");
			//}

			Console.ReadLine();
		}

		private static void CriarContaCorrente()
		{
			ContaCorrente conta1 = new ContaCorrente(4055, 478663);
			ContaCorrente conta2 = new ContaCorrente(5566, 256698);

			//conta1.Transferir(5000, conta2);
			conta1.Sacar(500);

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